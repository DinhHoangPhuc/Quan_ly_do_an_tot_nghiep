using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DanhGiaBCTDBUS
    {
        public bool ThemDanhGia(string maDanhGia, string maBaoCao, DateTime ngayDanhGia, string maNhom, string maGiangVien, string noiDung)
        {
            try
            {
                string connectionString = "Data Source=ADMIN;Initial Catalog=QL_DOAN;User ID=sa;Password=123;TrustServerCertificate=True";
                // Khởi tạo context LINQ (DataContext hoặc DbContext đã setup)
                using (var context = new QLDADataContext(connectionString))
                {
                    // Tạo đánh giá mới
                    var danhGia = new DanhGiaBaoCaoTienDo
                    {
                        MaDanhGia = maDanhGia,
                        MaBaoCao = maBaoCao,
                        NgayDanhGia = ngayDanhGia,
                        MaNhom = maNhom,
                        MaGiangVien = maGiangVien,
                        NoiDung = noiDung               
                    };

                    // Thêm vào database
                    context.DanhGiaBaoCaoTienDos.InsertOnSubmit(danhGia);
                    context.SubmitChanges();
                }

                return true; // Thành công
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false; // Thất bại
            }
        }
    }
}
