using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DeXuatDetai
    {
        public string MaDeTai { get; set; }
        public string TenDeTai { get; set; }
        public string MoTa { get; set; }
        public string TrangThai { get; set; }
        public DateTime NgayDeXuat { get; set; }
        public DateTime? NgayDuyet { get; set; }
        public string MaGVHD { get; set; }
        public string MaGVPB { get; set; }

        public DeXuatDetai(string maDeTai, string tenDeTai, string moTa, string trangThai, DateTime ngayDeXuat, DateTime? ngayDuyet, string maGVHD)
        {
            MaDeTai = maDeTai;
            TenDeTai = tenDeTai;
            MoTa = moTa;
            TrangThai = trangThai;
            NgayDeXuat = ngayDeXuat;
            NgayDuyet = ngayDuyet;
            MaGVHD = maGVHD;
        }

        public DeXuatDetai(string maDeTai, string tenDeTai, string moTa, string trangThai, DateTime ngayDeXuat, DateTime? ngayDuyet, string maGVHD, string maGVPB)
        {
            MaDeTai = maDeTai;
            TenDeTai = tenDeTai;
            MoTa = moTa;
            TrangThai = trangThai;
            NgayDeXuat = ngayDeXuat;
            NgayDuyet = ngayDuyet;
            MaGVHD = maGVHD;
            MaGVPB = maGVPB;
        }

        public DeXuatDetai() { }
    }
}
