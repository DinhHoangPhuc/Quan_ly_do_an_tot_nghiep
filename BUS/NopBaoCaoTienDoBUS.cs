using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NopBaoCaoTienDoBUS
    {
        public bool ThemBaoCao(string maBaoCao, int tuanThu, DateTime ngayBaoCao, string noiDung, bool coMat, string maNhom, string maGiangVien)
        {
            try
            {
                string connectionString = "Data Source=ADMIN;Initial Catalog=QL_DOAN;User ID=sa;Password=123;TrustServerCertificate=True";
                // Khởi tạo context LINQ (DataContext hoặc DbContext đã setup)
                using (var context = new QLDADataContext(connectionString))
                {
                    // Tạo báo cáo mới
                    var baoCao = new BaoCaoTienDo
                    {
                        MaBaoCao = maBaoCao,
                        TuanThu = tuanThu,
                        NgayBaoCao = ngayBaoCao,
                        NoiDung = noiDung,
                        CoMat = coMat,
                        MaNhom = maNhom,
                        MaGiangVien = maGiangVien
                    };

                    // Thêm vào database
                    context.BaoCaoTienDos.InsertOnSubmit(baoCao);
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

