using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINI.DTO
{
    internal class ChiTietHoaDonDTO
    {
        public int idHoaDon { get; set; }
        public int idSanPham {  get; set; }
        public int soLuong { get; set; }
        public decimal donGia { get; set; }
        public decimal tongTien { get; set; }
    }
}
