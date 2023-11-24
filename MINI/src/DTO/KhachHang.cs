using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINI.src.DTO
{
    internal class KhachHang
    {
        public int idKhachHang { get; set; }
        public string hoTenKhachHang { get; set; }
        public string diaChi { get; set; }
        public string soDienThoai { get; set; }
        public string gioiTinh { get; set; }
        public string email { get; set; }
        public DateTime ngaySinh { get; set; }
    }
}
