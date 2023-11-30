using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINI.src.DTO
{
    public class KhuyenMai
    {
        public int idKhuyenMai { get; set; }
        public string tenKhuyenMai { set; get; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }
        public string noiDung { get; set; }
        public float phanTram { get; set; }
        public string dieuKien { get; set; }
    }
}
