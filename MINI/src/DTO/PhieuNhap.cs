using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINI.src.DTO
{
    internal class PhieuNhap
    {
        public int idPhieuNhap { get; set; }
        public int idNhanVien { get; set; }
        public int idNhaCungCap { get; set; }
        public float tongTien { get; set; }
    }
}
