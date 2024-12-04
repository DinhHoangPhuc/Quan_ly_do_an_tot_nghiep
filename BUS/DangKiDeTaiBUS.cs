using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BUS
{
    public class DangKiDeTaiBUS
    {

        private readonly DangKiDeTaiDAL _dangKiDeTaiDAL = new DangKiDeTaiDAL();

        public bool DangKiDeTai(string maNhom, string maDeTai, string maHocKy)
        {
            bool nhomSinhVienDaDangKyDeTai = _dangKiDeTaiDAL.KiemTraDeDeTaiDaDangKyChua(maDeTai);
            if (nhomSinhVienDaDangKyDeTai)
            {
                MessageBox.Show($"Có nhóm sinh viên đã đăng ký đề tài {maDeTai}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return _dangKiDeTaiDAL.DangKyDeTai(maNhom, maDeTai, maHocKy);
        }

        public List<NhomSinhVien> LayDanhSachNhomSinhVienChuaDangKiDeTai()
        {
            return _dangKiDeTaiDAL.LayDanhSachNhomSinhVienChuaDangKiDeTai();
        }

        public List<DeTai> LayDanhSachDeTaiKhaDung()
        {
            return _dangKiDeTaiDAL.LayDanhSachDeTaiKhaDung();
        }
        public List<HocKy> LayDanhSachHocKy()
        {
            return _dangKiDeTaiDAL.LayDanhSachHocKy();
        }

        public NhomSinhVien LayThongTinNhomBangMaNhom(string maNhom)
        {
            return _dangKiDeTaiDAL.LayThongTinNhomBangMaNhom(maNhom);
        }

        public DeTai LayDeTaiBangMaDeTai(string maDeTai)
        {
            return _dangKiDeTaiDAL.LayDeTaiBangMaDeTai(maDeTai);
        }

        public DangKyDeTai CapNhatTrangThaiDangKyDeTai(string maDKDT, string trangThai)
        {
            return _dangKiDeTaiDAL.CapNhatTrangThaiDangKyDeTai(maDKDT, trangThai);
        }

    }
}
