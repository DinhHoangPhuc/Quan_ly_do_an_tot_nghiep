using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BUS
{

    public class DoAnBus
    {
        private DoAnDAL dal;

        public DoAnBus()
        {
            dal = new DoAnDAL();

        }

        public List<DeTai> GetDeTaiList()
        {
            return dal.GetDeTaiList();
        }
        public List<NhomSinhVien> GetNhomList()
        {
            return dal.GetNhomList();
        }
        //public bool AddData(string maDeTai, string maNhom, DateTime ngayNop, string ID)
        //{
        //    return dal.AddData(maDeTai, maNhom, ngayNop, ID);
        //}

        public List<dynamic> LoadDoAn()
        {
            try
            {
                return dal.GetAllDoAn();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi lấy danh sách đồ án: " + ex.Message);
            }

        }
    }
}




