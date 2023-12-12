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
        public DataTable LayDSNhanVien()
        {
            string strSQL = "Select * From NhanVien";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public void UpdateNV(string id, string ht, string dc,string sdt, string gt, string idcv, string luong, string tt, string nsinh, string nnghi )
        {
            if(tt=="Thôi Việc)")
            {
                string str = $"Update NhanVien set hoVaTen=N'{ht}',diaChi=N'{dc}',soDienThoai='{sdt}',gioiTinh='{gt}',idChucVu={idcv},luong={luong},trangThai=N'{tt}',ngaySinh='{nnghi}',ngayNghi='{nsinh}' where idNhanVien={id}";
                db.ExecuteNonQuery(str);
            }
            else
            {
                string str = $"Update NhanVien set hoVaTen=N'{ht}',diaChi=N'{dc}',soDienThoai='{sdt}',gioiTinh='{gt}',idChucVu={idcv},luong={luong},trangThai=N'{tt}',ngaySinh='{nsinh}' where idNhanVien={id}";
                db.ExecuteNonQuery(str);
            }
        }
        public void InsertNV(string ht, string dc, string sdt, string gt, string idcv, string luong, string tt, string nsinh)
        {
            string str = $"Insert into NhanVien (hoVaTen,diaChi,soDienThoai,gioiTinh,idChucVu,luong,trangThai,ngaySinh) values (N'{ht}',N'{dc}','{sdt}',N'{gt}','{idcv}','{luong}',N'{tt}','{nsinh}')";
            db.ExecuteReader(str);
        }
        public bool checkButtonSave(string idnv)
        {
            string test = $"Select * from NhanVien where idNhanVien='{idnv}'";
            int row= db.ExecuteNonQuery(test);
            return row > 0;
        }
    }
}
