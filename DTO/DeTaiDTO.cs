using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DeTaiDTO
    {
        public string MaDeTai { get; set; }
        public string TenDeTai { get; set; }
        public string MoTa { get; set; }
        public string TrangThai { get; set; }
        public DateTime NgayDeXuat { get; set; }
        public DateTime? NgayDuyet { get; set; }
        public string MaGVHD { get; set; }
        public string MaGVPB { get; set; }
        public string MaBoMon { get; set; }
        public bool? DaChinhSua { get; set; }
        public DateTime? CapNhatLanCuoi { get; set; }
        public DeTaiDTO(string maDeTai, string tenDeTai, string moTa, string trangThai, DateTime ngayDeXuat, DateTime? ngayDuyet, string maGVHD, string maGVPB)
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
        public DeTaiDTO(string maDeTai, string tenDeTai, string moTa, string trangThai, DateTime ngayDeXuat, DateTime? ngayDuyet, string maGVHD, string maGVPB, string maBoMon)
        {
            MaDeTai = maDeTai;
            TenDeTai = tenDeTai;
            MoTa = moTa;
            TrangThai = trangThai;
            NgayDeXuat = ngayDeXuat;
            NgayDuyet = ngayDuyet;
            MaGVHD = maGVHD;
            MaGVPB = maGVPB;
            MaBoMon = maBoMon;
        }
        public DeTaiDTO() { }
    }
}
