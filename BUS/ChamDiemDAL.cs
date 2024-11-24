using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class ChamDiemDAL
    {
        private QLDADataContext db;

        public ChamDiemDAL()
        {
            db = new QLDADataContext();
        }
        public List<DoAnVaDiem> GetAllDoAnVaDiem()
        {
            return db.DoAnVaDiems.ToList();
        }
        public List<dynamic> GetAllDoAn()
        {

            var result = db.DoAnVaDiems
                          .Select(da => new
                          {
                              da.MaDeTai,
                              da.MaNhom,
                              da.NgayNopDoAn,
                              da.Id
                          })
                          .ToList();

            return result.Cast<dynamic>().ToList();
        }

        public bool AddData(string id, string noiDungDoAn, string nhanXet, float? diemGVHuongDan, float? diemGVPhanBien, DateTime? ngayCham)
        {
            try
            {

                var recordToUpdate = db.DoAnVaDiems.FirstOrDefault(d => d.Id == id);
                if (recordToUpdate != null)
                {
                    if (!string.IsNullOrEmpty(noiDungDoAn))
                        recordToUpdate.NoiDungDoAn = noiDungDoAn;
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

                    MessageBox.Show("Không tìm thấy bản ghi với ID: " + id);
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
