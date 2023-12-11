using MINI.src.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MINI.src.BUS
{
    internal class NhanVienBUS
    {
        private Database db = new Database();
        public string findChucVu(int ID)
        {
            string chucVu = $"Select tenChucVu from ChucVu where ChucVu.idChucVu='{ID}'";
            return db.Execute(chucVu).Rows[0]["tenChucVu"].ToString();
        }

        public DataTable LayDSNhanVien()
        {
            string strSQL = "Select * From NhanVien";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayDSChucVu()
        {
            string id = $"Select * from ChucVu";
            DataTable dt = db.Execute(id);
            return dt;
        }
        public void UpdateNV(string id, string ht, string dc, string gt, string idcv, string luong, string tt, string nsinh, string nnghi )
        {
            if(tt=="Thôi Việc)")
            {
                string str = $"Update NhanVien set hoVaTen=N'{1}',diaChi=N'{2},soDienThoai='{3}',gioiTinh='{4}',idChucVu={5},luong={6},trangThai=N'{7},ngaySinh='{8}',ngayNghi='{9}' where idNhanVien={0}";
                db.ExecuteNonQuery(str);
            }
            else
            {
                string str = $"Update NhanVien set hoVaTen=N'{1}',diaChi=N'{2},soDienThoai='{3}',gioiTinh='{4}',idChucVu={5},luong={6},trangThai=N'{7},ngaySinh='{8}' where idNhanVien={0}";
                db.ExecuteNonQuery(str);
            }
           
            

        }
    }
}
