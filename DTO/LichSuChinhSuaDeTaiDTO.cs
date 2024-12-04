using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichSuChinhSuaDeTaiDTO
    {
        public int MaLichSu { get; set; }
        public string MaDeTai { get; set; }
        public string TruongChinhSua { get; set; }
        public string GiaTriCu { get; set; }
        public string GiaTriMoi { get; set; }
        public DateTime? ThoiGianChinhSua { get; set; }
        public string NguoiChinhSua { get; set; }

        public LichSuChinhSuaDeTaiDTO()
        {
        }

        public LichSuChinhSuaDeTaiDTO(int maLichSu, string maDeTai, string truongChinhSua, string giaTriCu, string giaTriMoi, DateTime? thoiGianChinhSua, string nguoiChinhSua)
        {
            MaLichSu = maLichSu;
            MaDeTai = maDeTai;
            TruongChinhSua = truongChinhSua;
            GiaTriCu = giaTriCu;
            GiaTriMoi = giaTriMoi;
            ThoiGianChinhSua = thoiGianChinhSua;
            NguoiChinhSua = nguoiChinhSua;
        }
    }
}
