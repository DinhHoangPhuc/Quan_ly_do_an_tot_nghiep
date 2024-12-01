
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace BUS
{
    public class ChamDiemBUS
    {
        
        private QLDADataContext db = new QLDADataContext();

        public ChamDiemBUS()
        {
            
        }
        public List<dynamic> GetAllDoAn()
        {
            try
            {
                var result = db.DoAnVaDiems
                    .Select(da => new
                    {
                        da.MaDeTai,
                        da.MaNhom,
                        da.NgayNopDoAn,
                        da.DiemGVHuongDan,
                        da.DiemGVPhanBien,
                        da.DiemCuoiCung,
                        da.NhanXet,
                        da.NgayCham,
                        da.NoiDungDoAn
                    })
                    .ToList();

                return result.Cast<dynamic>().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<dynamic>();
            }
        }
        public bool AddData(string maDeTai,string maNhom,string nhanXet,float? diemGVHuongDan,float? diemGVPhanBien,DateTime? ngayCham)
        {
            try
            {
                var recordToUpdate = db.DoAnVaDiems.FirstOrDefault(da => da.MaDeTai == maDeTai && da.MaNhom == maNhom);

                if (recordToUpdate != null)
                {
                    if (!string.IsNullOrEmpty(nhanXet))
                        recordToUpdate.NhanXet = nhanXet;

                    if (diemGVHuongDan.HasValue)
                        recordToUpdate.DiemGVHuongDan = diemGVHuongDan.Value;

                    if (diemGVPhanBien.HasValue)
                        recordToUpdate.DiemGVPhanBien = diemGVPhanBien.Value;

                    if (ngayCham.HasValue)
                        recordToUpdate.NgayCham = ngayCham.Value;
                    if (diemGVHuongDan > 0 && diemGVPhanBien > 0)
                    {
                        recordToUpdate.DiemCuoiCung = (diemGVHuongDan + diemGVPhanBien) / 2;
                    }
                    db.SubmitChanges();

                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bản ghi với mã đề tài và mã nhóm.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }

      
    }
}

