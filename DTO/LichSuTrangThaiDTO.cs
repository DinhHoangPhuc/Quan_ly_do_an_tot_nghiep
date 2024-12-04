using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichSuTrangThaiDTO
    {
        public int MaTrangThai { get; set; }
        public string MaDeTai { get; set; }
        public string TrangThai { get; set; }
        public DateTime ThoiGianThayDoi { get; set; }
        public string NguoiThayDoi { get; set; }

        public LichSuTrangThaiDTO()
        {
        }

        public LichSuTrangThaiDTO(int maTrangThai, string maDeTai, string trangThai, DateTime thoiGianThayDoi, string nguoiThayDoi)
        {
            MaTrangThai = maTrangThai;
            MaDeTai = maDeTai;
            TrangThai = trangThai;
            ThoiGianThayDoi = thoiGianThayDoi;
            NguoiThayDoi = nguoiThayDoi;
        }
    }
}
