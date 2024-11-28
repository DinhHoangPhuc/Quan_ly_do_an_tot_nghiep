using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiangVienHuongDanDTO
    {
        public string MaGVHD { get; set; }
        public string TenGVHD { get; set; }

        public GiangVienHuongDanDTO(string maGVHD, string tenGVHD)
        {
            MaGVHD = maGVHD;
            TenGVHD = tenGVHD;
        }

        public GiangVienHuongDanDTO() { }
    }
}
