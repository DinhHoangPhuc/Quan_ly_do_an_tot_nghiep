using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DangNhap
    {
        private QLDADataContext qlda;

        public DangNhap()
        {
            qlda = new QLDADataContext();
        }

        public bool Login(string taiKhoan, string matKhau)
        {
            var nguoiDungRecord = qlda.NguoiDungs.Where(nd => nd.TenDangNhap.Equals(taiKhoan) && nd.MatKhau.Equals(matKhau)).FirstOrDefault();

            if (nguoiDungRecord != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckHoatDongTaiKhoan(string taiKhoan)
        {
            var nguoiDungRecord = qlda.NguoiDungs.Where(nd => nd.TenDangNhap.Equals(taiKhoan)).FirstOrDefault();

            if (nguoiDungRecord != null && nguoiDungRecord.HoatDong == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
