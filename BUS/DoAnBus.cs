using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DTO;
using System.Runtime.Remoting.Contexts;
namespace BUS
{

    public class DoAnBus
    {
        private QLDADataContext db = new QLDADataContext();

        public DoAnBus()
        {
           
        }
        public List<string> GetMaDeTaiByMaNhom(string maNhom)
        {
            var maDeTaiList = db.DangKyDeTais
                                .Where(dt => dt.MaNhom == maNhom) 
                                .Select(dt => dt.MaDeTai)          
                                .Distinct()                         
                                .ToList();                         
            return maDeTaiList;
        }

        public List<string> GetMaNhomList()
        {
            var maNhomList = db.DangKyDeTais
                               .Select(dt => dt.MaNhom)
                               .Distinct()  
                               .ToList();   
            return maNhomList;
        }
        public bool CheckDangKyDeTai(string maNhom)
        {
            var query = db.DangKyDeTais
                                 .Where(d => d.MaNhom == maNhom && d.TrangThai == "Đã đăng ký")
                                 .FirstOrDefault();

            return query != null;
        }
        public IQueryable<dynamic> GetDoAnVaDiems()
        {
            var result = db.DoAnVaDiems.Select(da => new
            {
                da.MaDeTai,
                da.MaNhom,
                da.NgayNopDoAn,
                da.NoiDungDoAn 
            });

            return result;
        }
        public bool UploadFileToDatabase(string maNhom,string maDeTai,DateTime NgayNopDoAn, byte[] fileData)
        {
            try
            {
              
                var dkDeTai = db.DangKyDeTais.FirstOrDefault(dt => dt.MaDeTai == maDeTai);
                if (dkDeTai == null)
                {
                    MessageBox.Show("Mã đề tài không tồn tại.");
                    return false;
                }
                var doAnVaChamDiem = db.DoAnVaDiems.FirstOrDefault(d => d.MaDeTai == maDeTai && d.MaNhom == maNhom);
                if (doAnVaChamDiem == null)
                {
                    doAnVaChamDiem = new DoAnVaDiem
                    {
                        MaDeTai = maDeTai,
                        MaNhom = maNhom,
                        NgayNopDoAn = NgayNopDoAn,
                        NoiDungDoAn = fileData
                    };
                    db.DoAnVaDiems.InsertOnSubmit(doAnVaChamDiem);
                }
                else
                {
                    doAnVaChamDiem.NgayNopDoAn = NgayNopDoAn;
                    doAnVaChamDiem.NoiDungDoAn = fileData;
                }
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi nộp đồ án: {ex.Message}");
                return false;
            }
        }



    }
}




