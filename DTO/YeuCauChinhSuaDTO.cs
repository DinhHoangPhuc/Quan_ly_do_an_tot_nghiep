using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class YeuCauChinhSuaDTO
    {
        public int MaYeuCau { get; set; }
        public string MaDeTai { get; set; }
        public string TruongCanChinhSua { get; set; }
        public string YeuCau { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiYeuCau { get; set; }

        public YeuCauChinhSuaDTO(int maYeuCau, string maDeTai, string truongCanChinhSua, string yeuCau, DateTime ngayTao, string nguoiYeuCau)
        {
            MaYeuCau = maYeuCau;
            MaDeTai = maDeTai;
            TruongCanChinhSua = truongCanChinhSua;
            YeuCau = yeuCau;
            NgayTao = ngayTao;
            NguoiYeuCau = nguoiYeuCau;
        }
    }
}
