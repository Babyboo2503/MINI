using MINI.src.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINI.src.DTO
{
    internal class BaoCaoDTO
    {
        public int idBaoCao {  get; set; }
        public int idNhanVien { get; set;}
        public DateTime ngayLap { get; set; }
        public int idSanPham { get; set; }
        public int soLuong { get; set; }
        public string lyDo {  get; set; }

        
    }
}
