using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class DoAnDAL
    {
        private QLDADataContext db;

        public DoAnDAL()
        {
            db = new QLDADataContext();
        }
        public List<DeTai> GetDeTaiList()
        {

            var dt = db.DeTais.ToList();
            return dt;
        }
        public List<NhomSinhVien> GetNhomList()
        {
            var nhom = db.NhomSinhViens.ToList();
            return nhom;
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
        public bool AddData(string maDeTai, string maNhom, DateTime ngayNop, string ID)
        {
            try
            {
                // Kiểm tra trùng lặp trước khi thêm dữ liệu
                if (CheckForDuplicate(maDeTai, maNhom, ID))
                {
                    MessageBox.Show("Dữ liệu đã tồn tại.");
                    return false; // Nếu trùng lặp, không thêm dữ liệu
                }
                var newRecord = new DoAnVaDiem()
                {
                    MaDeTai = maDeTai,
                    MaNhom = maNhom,
                    NgayNopDoAn = ngayNop,
                    Id = ID
                };

                // Thêm bản ghi vào cơ sở dữ liệu
                db.DoAnVaDiems.InsertOnSubmit(newRecord);
                db.SubmitChanges();

                return true; // Thêm thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                return false; // Thêm thất bại
            }
        }
        public bool CheckForDuplicate(string maDeTai, string maNhom, string ID)
        {

            var duplicateRecord = db.DoAnVaDiems
                .Where(x => x.MaDeTai == maDeTai && x.MaNhom == maNhom && x.Id == ID)
                .FirstOrDefault();

            return duplicateRecord != null;
        }
    }
}
