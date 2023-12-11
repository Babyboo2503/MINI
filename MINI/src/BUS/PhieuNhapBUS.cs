using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MINI.src.DAO;
using MINI.src.GUI;

namespace MINI.src.BUS
{
     class PhieuNhapBUS
    {
        Database db;

        public PhieuNhapBUS()
        {
            db = new Database();
        }

       public DataTable LayDSPN()
        {
            string strSQL = "Select * from PhieuNhap";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDSCTPN()
        {
            string strSQL = "Select * from ChiTietPhieuNhap";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDSNCC()
        {
            string strSQL = "Select * from NhaCungCap";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDSCTPNTheoMaPhieuNhap(string maPhieuNhap)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection("Data Source=.; Database=MiniMarket;Integrated Security = True"))
            {
                string query = "SELECT * FROM ChiTietPhieuNhap WHERE idPhieuNhap = @maPhieuNhap";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@maPhieuNhap", maPhieuNhap);
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                    connection.Close();
                }
            }
            return dt;
        }

        public DataTable LayDSNCCTheoTenNCC(string tenNCC)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection("Data Source=.; Database=MiniMarket;Integrated Security = True"))
            {
                string query = "SELECT * FROM NhaCungCap WHERE tenNhaCungCap LIKE '%' + @tenNCC + '%'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tenNCC", tenNCC);
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                    connection.Close();
                }
            }
            return dt;
        }



    }
}
