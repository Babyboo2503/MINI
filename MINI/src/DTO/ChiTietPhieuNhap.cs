using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINI.src.DTO
{
    internal class ChiTietPhieuNhap
    {
        public int idPhieuNhap { get; set; }
        public int idSanPham { get; set; }
        public int soLuong { get; set; }
        public float donGia { get; set; }
        public float tongTien { get; set; }
    }
}
