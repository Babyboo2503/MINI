using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINI.src.DTO
{
    public class NhanVienDTO
    {
        public int idNhanVien { get; set; } 
        public string hoTenNhanVien { get; set; }
        public string soDienThoai { get; set; }
        public string diaChi { get; set; }
        public DateTime ngaySinh { get; set; }
        public DateTime ngayNghi { get; set; }
        public string gioiTinh { get; set; }
        public float luong { get; set; }
        public string trangThai { get; set; }
        public int idChucVu { get; set; }
    }
}
