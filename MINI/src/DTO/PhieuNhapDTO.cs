using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINI.src.DTO
{
    public class PhieuNhapDTO
    {
        public int idPhieuNhap { get; set; }
        public int idNhanVien { get; set; }
        public int idNhaCungCap { get; set; }
        public float tongTien { get; set; }
        public DateTime ngayNhap { get; set; }
    }
}
