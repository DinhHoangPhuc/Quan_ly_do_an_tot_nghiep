
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BUS
{
    public class ChamDiemBUS
    {
        private ChamDiemDAL dal;

        public ChamDiemBUS()
        {
            dal = new ChamDiemDAL();

        }
        public List<DoAnVaDiem> GetAllDoAnVaDiem()
        {
            return dal.GetAllDoAnVaDiem();
        }
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

        public bool AddData(string id, string noiDungDoAn, string nhanXet, float? diemGVHuongDan, float? diemGVPhanBien, DateTime? ngayCham)
        {

            return dal.AddData(id, noiDungDoAn, nhanXet, diemGVHuongDan, diemGVPhanBien, ngayCham);

        }

    }
}

