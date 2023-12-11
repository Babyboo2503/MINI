using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINI.src.DTO
{
    public class HoaDonDTO
    {
        public int idHoaDon { get; set; }
        public int idNhanVien { get; set; }
        public int idKhachHang { get; set; }
        public DateTime ngayLap { get; set; }
        public int idKhuyenMai { get; set; }
        public decimal tongHoaDon { get; set; }
    }
}
