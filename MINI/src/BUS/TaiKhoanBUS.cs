using MINI.src.DAO;
using MINI.src.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        
        public int KTAdmin(string txtUsername, string txtPassword)
        {
            string id = $"Select idNhanVien from TaiKhoan where username='{txtUsername}' and password='{txtPassword}'";
            return db.ExecuteNonQuery(id);
        }
        public void UploadTK(string idtk, string idnv, string username, string password, CheckedListBox quyen)
        {
            string quyenTK = null;
            for (int i = 1; i < 13; i++)
            {
                if (quyen.GetItemChecked(i-1) == true)
                {
                    quyenTK += i + ","; 
                }
            }
            string newString = quyenTK.TrimEnd(',');
            string acc = $"Update TaiKhoan set idNhanVien='{idnv}', username='{username}',password='{password}',quyen='{newString}' where idTaiKhoan='{idtk}'";
            db.ExecuteNonQuery(acc);
        }
        public void InsertTK(string idtk, string idnv, string username, string password, CheckedListBox quyen)
        {
            string quyenTK = null;
            for (int i = 1; i < 13; i++)
            {
                if (quyen.GetItemChecked(i - 1) == true)
                {
                    quyenTK += i + ",";
                }
            }
            string newString = quyenTK.TrimEnd(',');
            string acc = $"Insert into TaiKhoan (idNhanVien, username, password, quyen) values ('{idnv}','{username}','{password}','{newString}')";
            db.ExecuteNonQuery(acc);
        }

    }
}
