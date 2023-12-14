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
            DataTable dt = new DataTable();
            string test = $"Select * from NhanVien where idNhanVien='{idnv}'";
            dt = db.Execute(test);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
        public DataTable layDSIDNhanVienChuaCoTK()
        {
            string nv = $"Select * from NhanVien where idNhanVien not in (Select idNhanVien from TaiKhoan)";
            return db.Execute(nv);
        }
        public DataTable layNhanVienDuaVaoID(string idnv)
        {
            string nv = $"Select * from NhanVien where idNhanVien='{idnv}'";
            return db.Execute(nv);
        }
        public DataTable locNVTheoGioiTinh(string gt)
        {
            string nv = $"Select * from NhanVien where gioiTinh=N'{gt}'";
            return db.Execute(nv);
        }
        public DataTable locNVTheoChucVu(string cv)
        {
            string nv = null; 
            if (cv == "Admin")
            {
                nv = $"Select * from NhanVien where idChucVu=1";
            }
            if(cv=="Quản lí")
            {
                nv = $"Select * from NhanVien where idChucVu=2";
            }
            if (cv == "Bán hàng")
            {
                nv = $"Select * from NhanVien where idChucVu=3";
            }
            if (cv == "Thủ kho")
            {
                nv = $"Select * from NhanVien where idChucVu=4";
            }
            return db.Execute(nv);
        }
        public DataTable locNVTheoTrangThai(string tt)
        {
            string nv = $"Select * from NhanVien where trangThai=N'{tt}'";
            return db.Execute(nv);
        }
        public DataTable timKiemNV(string x)
        {
            string query = "SELECT * FROM NhanVien WHERE hoVaTen LIKE '%' + @x + '%'";
            return db.Execute(query);
        }

    }
}
