using MINI.src.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MINI.src.BUS
{
    internal class PhanQuyenBUS
    {
        static Database db= new Database();
        public static bool[] DangNhap(string username, string password)
        {
            string dsQuyen = "";
            string query = $"select quyen from TaiKhoan where username='{username}' and password='{password}'";
            DataTable dataTable = db.Execute(query);
            dsQuyen = dataTable.Rows[0]["quyen"].ToString();

            if (string.IsNullOrEmpty(dsQuyen)) return new bool[0];

            bool[] result = new bool[12];
            foreach (string quyen in dsQuyen.Split(','))
            {
                if (int.TryParse(quyen, out int parsedQuyen) && parsedQuyen >= 1 && parsedQuyen <= 12)
                {
                    result[parsedQuyen - 1] = true;
                }
            }

            return result;
        }

    }
}

