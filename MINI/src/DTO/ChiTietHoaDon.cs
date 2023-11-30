using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINI.src.DTO
{
    public class ChiTietHoaDon
    {
        public int idHoaDon { get; set; }
        public int idSanPham { get; set; }
        public int soLuong { get; set; }
        public float donGia { get; set; }
        public float tongTien { get; set; }
    }
}
