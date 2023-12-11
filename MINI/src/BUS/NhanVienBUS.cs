using MINI.src.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINI.src.BUS
{
    internal class NhanVienBUS
    {
        private Database db=new Database();
        public string findChucVu(int ID)
        {
            string chucVu = $"Select tenChucVu from ChucVu where ChucVu.idChucVu='{ID}'";
            return db.Execute(chucVu).Rows[0]["tenChucVu"].ToString() ;
        }
        public void UpdateToSQL (string ID, string ten, string sdt, string gt, string idcv, string luong, string trangthai, DateTime nsinh, DateTime nnghi, string dc)
        {
            string thongtin = $"UPDATE NhanVien SET hoVaTen = '{ten}', soDienThoai = '{sdt}', gioiTinh = '{gt}', idChucVu = '{idcv}'" +
                $", luong = '{luong}', trangThai = '{trangthai}', ngaySinh = '{nsinh}', ngayNghi = '{nnghi}', diaChi = '{dc}' WHERE idNhanVien = {ID}";
            db.ExecuteNonQuery(thongtin) ;
        }


    }
}
