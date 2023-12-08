using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINI.src.DTO
{
    public class SanPhamDTO
    {
        public int idSanPham { get; set; }
        public string tenSanPham { get; set; }
        public float donGia { get; set; }
        public int soLuong { get; set; }
        public string hinhAnh { get; set; }
        public string trangThai { get; set; }
        public int idLoaiSanPham { get; set; }
        public float chietKhau { get; set; }
    }
}
