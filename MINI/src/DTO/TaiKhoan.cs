using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINI.src.DTO
{
    internal class TaiKhoan
    {
        public int idTaiKhoan { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int idNhanVien { get; set; }
    }
}
