using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class DeTaiPhanHoi
    {
        private QLDADataContext qlda;
        private const string DE_XUAT = "Đề xuất";

        public DeTaiPhanHoi()
        {
            qlda = new QLDADataContext();
        }

        public List<PhanHoiDeTaiDTO> GetPhanHoiDeTaiByMaDeTai(string maDeTai)
        {
            List<PhanHoiDeTai> phanHoiDeTais = qlda.PhanHoiDeTais.Where(i => i.MaDeTai == maDeTai).ToList();

            if (phanHoiDeTais.Count > 0)
            {
                return ToListPhanHoiDTO(phanHoiDeTais);
            }
            return null;
        }

        public List<DeXuatDetai> GetDeTaiForGiangVien(string maND)
        {
            string maGV = qlda.GiangViens.Where(i => i.TenDangNhap == maND).Select(i => i.MaGiangVien).FirstOrDefault();
            List<DeTai> lstdeTai = qlda.DeTais.Where(i => i.MaGVHuongDan == maGV).ToList();

            if (lstdeTai.Count > 0)
            {
                return ToListDeXuatDeTai(lstdeTai);
            }
            return null;

        }

        public bool DeXuatDeTai(DeXuatDetai deXuatDetai)
        {
            try
            {
                DeTai deTai = new DeTai();
                deTai.MaDeTai = AutoGenerateMaDeTai();
                deTai.TenDeTai = deXuatDetai.TenDeTai;
                deTai.MoTa = deXuatDetai.MoTa;
                deTai.MaGVHuongDan = deXuatDetai.MaGVHD;
                deTai.MaBoMon = GetMaBoMonByMaGV(deXuatDetai.MaGVHD);
                deTai.NgayDeXuat = DateTime.Now;
                deTai.TrangThai = DE_XUAT;
                qlda.DeTais.InsertOnSubmit(deTai);
                qlda.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<DeTaiDTO> GetAllDeTai()
        {
            List<DeTai> lstdeTai = qlda.DeTais.ToList();
            if (lstdeTai.Count > 0)
            {
                return ToListDetaiDTO(lstdeTai);
            }
            return null;
        }

        private List<DeTaiDTO> ToListDetaiDTO(List<DeTai> lstdeTai)
        {
            List<DeTaiDTO> deTaiDTOs = new List<DeTaiDTO>();
            foreach (DeTai deTai in lstdeTai)
            {
                DeTaiDTO deTaiDTO = new DeTaiDTO(deTai.MaDeTai, deTai.TenDeTai, deTai.MoTa, deTai.TrangThai, deTai.NgayDeXuat, deTai.NgayDuyet, deTai.MaGVHuongDan, deTai.MaGVPhanBien, deTai.MaBoMon);
                deTaiDTOs.Add(deTaiDTO);
            }
            return deTaiDTOs;
        }

        private List<DeXuatDetai> ToListDeXuatDeTai(List<DeTai> lstdeTai)
        {
            List<DeXuatDetai> deXuatDetais = new List<DeXuatDetai>();
            foreach (DeTai deTai in lstdeTai)
            {
                DeXuatDetai deXuatDetai = new DeXuatDetai(deTai.MaDeTai, deTai.TenDeTai, deTai.MoTa, deTai.TrangThai, deTai.NgayDeXuat, deTai.NgayDuyet, deTai.MaGVHuongDan);
                deXuatDetais.Add(deXuatDetai);
            }
            return deXuatDetais;
        }

        private List<PhanHoiDeTaiDTO> ToListPhanHoiDTO(List<PhanHoiDeTai> phanHoiDeTais)
        {
            List<PhanHoiDeTaiDTO> phanHoiDeTaiDTOs = new List<PhanHoiDeTaiDTO>();
            foreach (PhanHoiDeTai phanHoiDeTai in phanHoiDeTais)
            {
                PhanHoiDeTaiDTO phanHoiDeTaiDTO = new PhanHoiDeTaiDTO(phanHoiDeTai.MaPhanHoi, phanHoiDeTai.MaDeTai, phanHoiDeTai.NoiDungChinhSua, phanHoiDeTai.NoiDungPhanHoi, phanHoiDeTai.NgayChinhSua, phanHoiDeTai.NgayPhanHoi);
                phanHoiDeTaiDTOs.Add(phanHoiDeTaiDTO);
            }
            return phanHoiDeTaiDTOs;
        }

        private string GetMaBoMonByMaGV(string maGV)
        {
            return qlda.GiangViens.Where(i => i.MaGiangVien == maGV).Select(i => i.MaBoMon).FirstOrDefault();
        }

        public string GetMaGVByMaND(string maND)
        {
            return qlda.GiangViens.Where(i => i.TenDangNhap == maND).Select(i => i.MaGiangVien).FirstOrDefault();
        }

        private string AutoGenerateMaDeTai()
        {
            string maDeTai = qlda.DeTais.OrderByDescending(i => i.MaDeTai).Select(i => i.MaDeTai).FirstOrDefault();
            if (maDeTai == null)
            {
                return "DT001";
            }
            int number = int.Parse(maDeTai.Substring(2)) + 1;
            return "DT" + number.ToString("000");
        }

        public List<string> GetListTrangThaiDeTai()
        {
            return new List<string> { "Đề xuất", "Cần chỉnh sửa", "Từ chối", "Chấp nhận" };
        }

        public List<GiangVienHuongDanDTO> GetAllGVHD()
        {
            List<DeTai> lstDeTai = qlda.DeTais.ToList();
            var distinctMaGVHD = lstDeTai.Select(dt => dt.MaGVHuongDan).Distinct().ToList();
            List<GiangVienHuongDanDTO> giangVienHuongDanDTOs = new List<GiangVienHuongDanDTO>();

            foreach (var maGVHD in distinctMaGVHD)
            {
                var giangVien = qlda.GiangViens.FirstOrDefault(gv => gv.MaGiangVien == maGVHD);
                if (giangVien != null)
                {
                    giangVienHuongDanDTOs.Add(new GiangVienHuongDanDTO(giangVien.MaGiangVien, giangVien.HoTen));
                }
            }

            return giangVienHuongDanDTOs;
        }

        public List<DeTaiDTO> LocDeTaiTheoMaGVHD(string maGVHD)
        {
            List<DeTai> deTais = qlda.DeTais.Where(i => i.MaGVHuongDan.Equals(maGVHD)).ToList();
            if(deTais.Count > 0)
            {
                return ToListDetaiDTO(deTais);
            }
            return null;
        }

        public List<DeTaiDTO> TimKiemDeTai(string text)
        {
            List<DeTai> deTais = qlda.DeTais.Where(i => i.TenDeTai.Contains(text)).ToList();
            if (deTais.Count > 0)
            {
                return ToListDetaiDTO(deTais);
            }
            return null;
        }

        public List<DeTaiDTO> TimKiemDeTaiTrongTatCaCot(string text)
        {
            List<DeTai> deTais = qlda.DeTais.Where(i => i.TenDeTai.Contains(text) || i.MaDeTai.Contains(text) || i.MoTa.Contains(text) || i.TrangThai.Contains(text) || i.MaGVHuongDan.Contains(text) || i.MaGVPhanBien.Contains(text)).ToList();
            if (deTais.Count > 0)
            {
                return ToListDetaiDTO(deTais);
            }
            return null;
        }
    }
}
