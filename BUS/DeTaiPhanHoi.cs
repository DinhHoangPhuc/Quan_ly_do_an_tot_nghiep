using System;
using System.CodeDom;
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
        private const string CAN_CHINH_SUA = "Cần chỉnh sửa";

        public DeTaiPhanHoi()
        {
            qlda = new QLDADataContext();
        }

        public List<PhanHoiDeTaiDTO> GetPhanHoiDeTaiByMaDeTai(string maDeTai)
        {
            //List<PhanHoiDeTai> phanHoiDeTais = qlda.PhanHoiDeTais.Where(i => i.MaDeTai == maDeTai).ToList();

            //if (phanHoiDeTais.Count > 0)
            //{
            //    return ToListPhanHoiDTO(phanHoiDeTais);
            //}
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

        public void DeXuatDeTai(DeXuatDetai deXuatDetai, string maND)
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

            LuuLichSuTrangThaiDeTai(deTai.MaDeTai, DE_XUAT, maND);

            //try
            //{
            //    DeTai deTai = new DeTai();
            //    deTai.MaDeTai = AutoGenerateMaDeTai();
            //    deTai.TenDeTai = deXuatDetai.TenDeTai;
            //    deTai.MoTa = deXuatDetai.MoTa;
            //    deTai.MaGVHuongDan = deXuatDetai.MaGVHD;
            //    deTai.MaBoMon = GetMaBoMonByMaGV(deXuatDetai.MaGVHD);
            //    deTai.NgayDeXuat = DateTime.Now;
            //    deTai.TrangThai = DE_XUAT;
            //    qlda.DeTais.InsertOnSubmit(deTai);
            //    qlda.SubmitChanges();
            //    return true;
            //}
            //catch
            //{
            //    return false;
            //}
        }

        public List<DeTaiDTO> GetAllDeTai()
        {
            List<DeTai> lstdeTai = qlda.DeTais.ToList();
            if (lstdeTai.Count > 0)
            {
                List<DeTaiDTO> deTaiDTOs = new List<DeTaiDTO>();
                foreach (DeTai deTai in lstdeTai)
                {
                    DeTaiDTO deTaiDTO = new DeTaiDTO(deTai.MaDeTai, deTai.TenDeTai, deTai.MoTa, deTai.TrangThai, deTai.NgayDeXuat, deTai.NgayDuyet, deTai.MaGVHuongDan, deTai.MaGVPhanBien, deTai.MaBoMon);
                    deTaiDTO.DaChinhSua = deTai.DaChinhSua;
                    deTaiDTO.CapNhatLanCuoi = deTai.CapNhatLanCuoi;
                    deTaiDTOs.Add(deTaiDTO);
                }
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

        //private List<PhanHoiDeTaiDTO> ToListPhanHoiDTO(List<PhanHoiDeTai> phanHoiDeTais)
        //{
        //    List<PhanHoiDeTaiDTO> phanHoiDeTaiDTOs = new List<PhanHoiDeTaiDTO>();
        //    foreach (PhanHoiDeTai phanHoiDeTai in phanHoiDeTais)
        //    {
        //        PhanHoiDeTaiDTO phanHoiDeTaiDTO = new PhanHoiDeTaiDTO(phanHoiDeTai.MaPhanHoi, phanHoiDeTai.MaDeTai, phanHoiDeTai.NoiDungChinhSua, phanHoiDeTai.NoiDungPhanHoi, phanHoiDeTai.NgayChinhSua, phanHoiDeTai.NgayPhanHoi);
        //        phanHoiDeTaiDTOs.Add(phanHoiDeTaiDTO);
        //    }
        //    return phanHoiDeTaiDTOs;
        //}

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
            if (deTais.Count > 0)
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

        public bool LuuPhanHoiDeTai(PhanHoiDeTaiDTO phanHoiDeTaiDTO)
        {
            try
            {
                //PhanHoiDeTai phanHoiDeTai = new PhanHoiDeTai();
                //phanHoiDeTai.MaDeTai = phanHoiDeTaiDTO.MaDeTai;
                //phanHoiDeTai.NoiDungPhanHoi = phanHoiDeTaiDTO.NoiDungPhanHoi;
                //phanHoiDeTai.NgayPhanHoi = DateTime.Now;

                //qlda.PhanHoiDeTais.InsertOnSubmit(phanHoiDeTai);
                //qlda.SubmitChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void CapNhatTrangThaiDeTai(string maDeTai, string trangThai)
        {
            DeTai deTai = qlda.DeTais.FirstOrDefault(i => i.MaDeTai == maDeTai);
            deTai.TrangThai = trangThai;
            qlda.SubmitChanges();

            //try
            //{
            //    DeTai deTai = qlda.DeTais.FirstOrDefault(i => i.MaDeTai == maDeTai);
            //    deTai.TrangThai = trangThai;
            //    qlda.SubmitChanges();
            //    return true;
            //}
            //catch
            //{
            //    return false;
            //}
        }

        public bool LuuChinhSuaDeTai(int maPhanHoi, string noiDungChinhSua)
        {
            try
            {
                //PhanHoiDeTai phanHoiDeTai = qlda.PhanHoiDeTais.FirstOrDefault(i => i.MaPhanHoi == maPhanHoi);
                //phanHoiDeTai.NoiDungChinhSua = noiDungChinhSua;
                //qlda.SubmitChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void LuuYeuCauChinhSuaDeTai(string maDeTai, string truongCanChinhSua, string noiDung, string nguoiTao)
        {
            YeuCauChinhSua yeuCauChinhSuaDeTai = new YeuCauChinhSua();
            yeuCauChinhSuaDeTai.MaDeTai = maDeTai;
            yeuCauChinhSuaDeTai.TruongCanChinhSua = truongCanChinhSua;
            yeuCauChinhSuaDeTai.YeuCau = noiDung;
            yeuCauChinhSuaDeTai.NgayTao = DateTime.Now;
            yeuCauChinhSuaDeTai.NguoiYeuCau = nguoiTao;

            qlda.YeuCauChinhSuas.InsertOnSubmit(yeuCauChinhSuaDeTai);
            qlda.SubmitChanges();
        }

        public void LuuLichSuTrangThaiDeTai(string maDeTai, string trangThai, string maND)
        {
            LichSuTrangThaiDeTai lichSuTrangThaiDeTai = new LichSuTrangThaiDeTai();
            lichSuTrangThaiDeTai.MaDeTai = maDeTai;
            lichSuTrangThaiDeTai.TrangThai = trangThai;
            lichSuTrangThaiDeTai.ThoiGianThayDoi = DateTime.Now;
            lichSuTrangThaiDeTai.NguoiThayDoi = GetMaGVByMaND(maND);
            qlda.LichSuTrangThaiDeTais.InsertOnSubmit(lichSuTrangThaiDeTai);
            qlda.SubmitChanges();
        }

        public List<string> GetTruongChinhSua()
        {
            return new List<string> { "Tên đề tài", "Mô tả" };
        }

        public List<YeuCauChinhSuaDTO> GetYeuCauChinhSuaDeTaiByMaDeTai(string maDeTai)
        {
            List<YeuCauChinhSua> yeuCauChinhSuas = qlda.YeuCauChinhSuas.Where(i => i.MaDeTai == maDeTai).OrderByDescending(i => i.NgayTao).ToList();

            if (yeuCauChinhSuas.Count > 0)
            {
                return ToListYeuCauChinhSuaDTO(yeuCauChinhSuas);
            }
            return null;
        }

        private List<YeuCauChinhSuaDTO> ToListYeuCauChinhSuaDTO(List<YeuCauChinhSua> yeuCauChinhSuas)
        {
            List<YeuCauChinhSuaDTO> yeuCauChinhSuaDTOs = new List<YeuCauChinhSuaDTO>();
            foreach (YeuCauChinhSua yeuCauChinhSua in yeuCauChinhSuas)
            {
                YeuCauChinhSuaDTO yeuCauChinhSuaDTO = new YeuCauChinhSuaDTO(yeuCauChinhSua.MaYeuCau, yeuCauChinhSua.MaDeTai, yeuCauChinhSua.TruongCanChinhSua, yeuCauChinhSua.YeuCau, yeuCauChinhSua.NgayTao, yeuCauChinhSua.NguoiYeuCau);
                yeuCauChinhSuaDTOs.Add(yeuCauChinhSuaDTO);
            }
            return yeuCauChinhSuaDTOs;
        }

        public List<DeTaiDTO> LocDeTaiTheoTrangThai(string trangThai, string maND)
        {
            string maGV = GetMaGVByMaND(maND);

            List<DeTai> deTais = qlda.DeTais.Where(i => i.TrangThai == trangThai && i.MaGVHuongDan == maGV).ToList();

            if (deTais.Count > 0)
            {
                return ToListDetaiDTO(deTais);
            }

            return null;
        }

        public List<LichSuTrangThaiDTO> GetLichSuTrangThaiDeTaiByMaDeTai(string maDeTai)
        {
            List<LichSuTrangThaiDeTai> lichSuTrangThaiDeTais = qlda.LichSuTrangThaiDeTais.Where(i => i.MaDeTai == maDeTai).OrderByDescending(i => i.ThoiGianThayDoi).ToList();

            if (lichSuTrangThaiDeTais.Count > 0)
            {
                return ToListLichSuTrangThaiDTO(lichSuTrangThaiDeTais);
            }
            return null;
        }

        private List<LichSuTrangThaiDTO> ToListLichSuTrangThaiDTO(List<LichSuTrangThaiDeTai> lichSuTrangThaiDeTais)
        {
            List<LichSuTrangThaiDTO> lichSuTrangThaiDTOs = new List<LichSuTrangThaiDTO>();
            foreach (LichSuTrangThaiDeTai lichSuTrangThai in lichSuTrangThaiDeTais)
            {
                LichSuTrangThaiDTO lichSuTrangThaiDTO = new LichSuTrangThaiDTO(lichSuTrangThai.MaTrangThai, lichSuTrangThai.MaDeTai, lichSuTrangThai.TrangThai, lichSuTrangThai.ThoiGianThayDoi, lichSuTrangThai.NguoiThayDoi);
                lichSuTrangThaiDTOs.Add(lichSuTrangThaiDTO);
            }

            return lichSuTrangThaiDTOs;
        }

        public void CapNhatDeTai(string maDeTai, string truongCanChinhSua, string noiDung, string maND)
        {
            if(truongCanChinhSua == "Tên đề tài")
            {
                DeTai deTai = qlda.DeTais.FirstOrDefault(i => i.MaDeTai == maDeTai);
                
                LichSuChinhSuaDeTai lichSuChinhSuaDeTai = new LichSuChinhSuaDeTai();
                lichSuChinhSuaDeTai.MaDeTai = maDeTai;
                lichSuChinhSuaDeTai.TruongChinhSua = truongCanChinhSua;
                lichSuChinhSuaDeTai.GiaTriCu = deTai.TenDeTai;
                lichSuChinhSuaDeTai.GiaTriMoi = noiDung;
                lichSuChinhSuaDeTai.ThoiGianChinhSua = DateTime.Now;
                lichSuChinhSuaDeTai.NguoiChinhSua = GetMaGVByMaND(maND);

                deTai.TenDeTai = noiDung;

                qlda.LichSuChinhSuaDeTais.InsertOnSubmit(lichSuChinhSuaDeTai);
                qlda.SubmitChanges();

            }
            else if (truongCanChinhSua == "Mô tả")
            {
                DeTai deTai = qlda.DeTais.FirstOrDefault(i => i.MaDeTai == maDeTai);

                LichSuChinhSuaDeTai lichSuChinhSuaDeTai = new LichSuChinhSuaDeTai();
                lichSuChinhSuaDeTai.MaDeTai = maDeTai;
                lichSuChinhSuaDeTai.TruongChinhSua = truongCanChinhSua;
                lichSuChinhSuaDeTai.GiaTriCu = deTai.MoTa;
                lichSuChinhSuaDeTai.GiaTriMoi = noiDung;
                lichSuChinhSuaDeTai.ThoiGianChinhSua = DateTime.Now;
                lichSuChinhSuaDeTai.NguoiChinhSua = GetMaGVByMaND(maND);

                deTai.MoTa = noiDung;

                qlda.LichSuChinhSuaDeTais.InsertOnSubmit(lichSuChinhSuaDeTai);
                qlda.SubmitChanges();
            }
        }

        public List<LichSuChinhSuaDeTaiDTO> GetLichSuChinhSuaDeTaiByMaDeTai(string maDeTai)
        {
            List<LichSuChinhSuaDeTai> lichSuChinhSuaDeTais = qlda.LichSuChinhSuaDeTais.Where(i => i.MaDeTai == maDeTai).OrderByDescending(i => i.ThoiGianChinhSua).ToList();
            if (lichSuChinhSuaDeTais.Count > 0)
            {
                return ToListLichSuChinhSuaDeTaiDTO(lichSuChinhSuaDeTais);
            }
            return null;
        }

        private List<LichSuChinhSuaDeTaiDTO> ToListLichSuChinhSuaDeTaiDTO(List<LichSuChinhSuaDeTai> lichSuChinhSuaDeTais)
        {
            List<LichSuChinhSuaDeTaiDTO> lichSuChinhSuaDeTaiDTOs = new List<LichSuChinhSuaDeTaiDTO>();
            foreach (LichSuChinhSuaDeTai lichSuChinhSua in lichSuChinhSuaDeTais)
            {
                LichSuChinhSuaDeTaiDTO lichSuChinhSuaDTO = new LichSuChinhSuaDeTaiDTO(lichSuChinhSua.MaLichSu, lichSuChinhSua.MaDeTai, lichSuChinhSua.TruongChinhSua, lichSuChinhSua.GiaTriCu, lichSuChinhSua.GiaTriMoi, lichSuChinhSua.ThoiGianChinhSua, lichSuChinhSua.NguoiChinhSua);
                lichSuChinhSuaDeTaiDTOs.Add(lichSuChinhSuaDTO);
            }
            return lichSuChinhSuaDeTaiDTOs;
        }
    }
}
