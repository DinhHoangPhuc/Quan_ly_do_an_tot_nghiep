using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class DangKiDeTaiDAL
    {

        private readonly QLDADataContext _qldatnDataContext = new QLDADataContext();

        public List <NhomSinhVien> LayDanhSachNhomSinhVienChuaDangKiDeTai()
        {
            return _qldatnDataContext.NhomSinhViens.ToList();
        }

        public NhomSinhVien LayThongTinNhomBangMaNhom(string maNhom)
        {
            return _qldatnDataContext.NhomSinhViens
                                      .FirstOrDefault(nsv => nsv.MaNhom == maNhom);
        }

        public DeTai LayDeTaiBangMaDeTai(string maDeTai)
        {
            return _qldatnDataContext.DeTais
                                      .FirstOrDefault(dt => dt.MaDeTai == maDeTai);
        }

        public List<DeTai> LayDanhSachDeTaiKhaDung()
        {
            return _qldatnDataContext.DeTais.Where(dt => dt.NgayDuyet != null).ToList();
        }

        public List<HocKy> LayDanhSachHocKy()
        {
            return _qldatnDataContext.HocKies.ToList();
        }

        public DangKyDeTai CapNhatTrangThaiDangKyDeTai(string maDKDT, string trangThai)
        {
         DangKyDeTai dkdt = _qldatnDataContext.DangKyDeTais.FirstOrDefault(dk => dk.MaDangKyDeTai == maDKDT);
            if(dkdt == null)
            {
                throw new Exception("Không tìm thấy đơm đăng ký đề tài !");
            }
            dkdt.TrangThai = trangThai;

            _qldatnDataContext.SubmitChanges();
            return dkdt;
        }

        public List<NhomSinhVien> LayDanhSachNhomSinhVienBangMaDeTai(string maNhom, string maDeTai)
        {
            return _qldatnDataContext.NhomSinhViens
                .Where(
                        nsv => nsv.MaNhom == maNhom 
                            && nsv.DangKyDeTais != null 
                            && nsv.DangKyDeTais.Any(dkdt => dkdt.MaDeTai == maDeTai))
                .ToList();
        }

        public bool KiemTraDeDeTaiDaDangKyChua(string maDeTai)
        {
           DangKyDeTai deTai = _qldatnDataContext.DangKyDeTais.FirstOrDefault(dkdt => dkdt.MaDeTai == maDeTai);
            if(deTai == null)
            {
                return false;
            }
            return true;
        
        }


        public bool DangKyDeTai(string maNhom, string maDeTai, string maHocKy)
        {
            NhomSinhVien nhomSinhVien = _qldatnDataContext.NhomSinhViens.FirstOrDefault(nsv => nsv.MaNhom == maNhom);
            if (nhomSinhVien == null)
            {
                return false;
            }

            DeTai deTai = _qldatnDataContext.DeTais.FirstOrDefault(dt => dt.MaDeTai == maDeTai);
            if (deTai == null)
            {
                return false;
            }

            string maTGDK = Guid.NewGuid().ToString().Substring(0, 10);
            string maDK = Guid.NewGuid().ToString().Substring(0, 10);

            HocKy hocKy = _qldatnDataContext.HocKies.FirstOrDefault(hk => hk.MaHocKy == maHocKy);
            
            if(hocKy == null)
            {
                return false;
            }

            ThoiGianDangKy thoiGianDangKy = new ThoiGianDangKy
            {
                MaThoiGianDangKy = maTGDK,
                TrangThai = "Đang mở",
                HocKy = hocKy,
                NgayBatDau = DateTime.Now,
                NgayKetThuc = DateTime.Now.AddDays(7 * 3)
            };

            DangKyDeTai dangKyDeTai = new DangKyDeTai
            {
                MaDangKyDeTai = maDK,
                MaNhom = maNhom,
                MaDeTai = maDeTai,
                NgayDangKy = DateTime.Now,
                TrangThai = "Đã đăng ký",
                MaThoiGianDangKy = maTGDK,
                ThoiGianDangKy = thoiGianDangKy
            };
            
            _qldatnDataContext.ThoiGianDangKies.InsertOnSubmit(thoiGianDangKy);
            _qldatnDataContext.DangKyDeTais.InsertOnSubmit(dangKyDeTai);
            _qldatnDataContext.SubmitChanges();

            return true;
        }
    }
}
