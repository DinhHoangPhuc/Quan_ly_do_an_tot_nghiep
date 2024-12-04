using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanHoiDeTaiDTO
    {
        public int MaPhanHoi { get; set; }
        public string MaDeTai { get; set; }
        public string NoiDungChinhSua { get; set; }
        public string NoiDungPhanHoi { get; set; }
        public DateTime? NgayChinhSua { get; set; }
        public DateTime NgayPhanHoi { get; set; }

        public PhanHoiDeTaiDTO(int maPhanHoi, string maDeTai, string noiDungChinhSua, string noiDungPhanHoi, DateTime? ngayChinhSua, DateTime ngayPhanHoi)
        {
            MaPhanHoi = maPhanHoi;
            MaDeTai = maDeTai;
            NoiDungChinhSua = noiDungChinhSua;
            NoiDungPhanHoi = noiDungPhanHoi;
            NgayChinhSua = ngayChinhSua;
            NgayPhanHoi = ngayPhanHoi;
        }

        public PhanHoiDeTaiDTO()
        {
        }
    }
}
