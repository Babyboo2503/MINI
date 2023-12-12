using MINI.src.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINI.src.BUS
{
    internal class ChucVuBUS
    {
        private Database db=new Database();
        public string findChucVu(string ID)
        {
            string chucVu = $"Select tenChucVu from ChucVu where ChucVu.idChucVu='{ID}'";
            return db.Execute(chucVu).Rows[0]["tenChucVu"].ToString();
        }
        public DataTable LayDSChucVu()
        {
            string id = $"Select * from ChucVu";
            DataTable dt = db.Execute(id);
            return dt;
        }
        public DataTable LayChucVuNhanVien(string idNV)
        {
            string id = $"Select hoVaTen,idChucVu from NhanVien where idNhanVien='{idNV}' ";
            DataTable dt = db.Execute(id);
            return dt;
        }
        public DataTable getChucVu(string Idcv)
        {
            string chucvu = $"Select tenChucVu from ChucVu where idChucVu='{Idcv}'";
            return db.Execute(chucvu);
        }
    }
}
