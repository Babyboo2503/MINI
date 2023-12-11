using MINI.src.DAO;
using MINI.src.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINI.src.BUS
{
    internal class TaiKhoanBUS
    {
        private Database db = new Database();
        public bool findAccount(string txtUsername, string txtPassword)
        {
            string account = $"Select username,password from TaiKhoan where username='{txtUsername}' and password='{txtPassword}'";
            int row = db.ExecuteReader(account);
            return row > 0;
        }
        public bool[] fillQuyen(string quyenTextBox)
        {
            bool[] result = new bool[12];
            foreach (string quyen in quyenTextBox.Split(','))
            {
                if (int.TryParse(quyen, out int parsedQuyen) && parsedQuyen >= 1 && parsedQuyen <= 12)
                {
                    result[parsedQuyen - 1] = true;
                }

            }
            return result;
        }
        public DataTable LayDSTaiKhoan()
        {
            string strSQL = "Select * From TaiKhoan";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayThongTinTaiKhoan(string idNhanVien)
        {
            string account = $"Select * from TaiKhoan where idNhanVien={idNhanVien}";
            DataTable dt = db.Execute(account);
            return dt;
        }


    }
}
