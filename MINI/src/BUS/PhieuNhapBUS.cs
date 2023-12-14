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
using MINI.src.DTO;
using System.Drawing;

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
        public DataTable LayDSSanPham()
        {
            string strSQL = "Select * from SanPham";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public void CapNhatGiaSanPham(string id, string value)
        {
            string str = string.Format("Update SanPham set donGia = '{0}' where idSanPham = '{1}'",
            value, id);
            db.ExecuteNonQuery(str);
        }

        public void ThemCTPhieuNhap(string id_pn, string id_sp, string soluong, string dongia, string thanhtien)
        {
            string sql = string.Format("Insert Into ChiTietPhieuNhap " +
                "Values('{0}', '{1}', '{2}', '{3}', {4})",
                id_pn, id_sp, soluong, dongia, thanhtien);
            db.ExecuteNonQuery(sql);
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

        public DataTable LayDSPNTheoMaPhieuNhap(string maPhieuNhap)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection("Data Source=.; Database=MiniMarket;Integrated Security = True"))
            {
                string query = "SELECT * FROM PhieuNhap WHERE idPhieuNhap = @maPhieuNhap";
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

        public void CapNhatSoLuongSanPhamTrongDatabase(string maSanPham, int soLuongNhap)
        {
            string connectionString = "Data Source=.; Database=MiniMarket;Integrated Security = True"; // Thay thế bằng connection string của bạn

            // Thiết lập kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn cập nhật
                string query = "UPDATE SanPham SET SoLuong = SoLuong + @SoLuongNhap WHERE idSanPham = @MaSanPham";

                // Tạo command và truyền tham số
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaSanPham", maSanPham);
                    command.Parameters.AddWithValue("@SoLuongNhap", soLuongNhap);

                    // Thực thi truy vấn cập nhật
                    int rowsAffected = command.ExecuteNonQuery();


                }
            }
        }

        public DataTable LayDSPNTheoKhoangThoiGian(DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection("Data Source=.; Database=MiniMarket;Integrated Security = True"))
            {
                string query = "SELECT * FROM PhieuNhap WHERE NgayNhap BETWEEN @StartDate AND @EndDate";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable LayDSPNTheoKhoangTongTien(decimal startTotal, decimal endTotal)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection("Data Source=.; Database=MiniMarket;Integrated Security = True"))
            {
                string query = "SELECT * FROM PhieuNhap WHERE TongTien BETWEEN @startTotal AND @endTotal";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@startTotal", startTotal);
                command.Parameters.AddWithValue("@endTotal", endTotal);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            return dt;
        }

        public bool ThemNCC(string tenNCC, string diaChi, string SDT)
        {
            string connectionString = "Data Source=.; Database=MiniMarket;Integrated Security = True"; // Thay thế bằng connection string của bạn
            bool themThanhCong = false;
            // Thiết lập kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn cập nhật
                string query = "INSERT INTO NhaCungCap (tenNhaCungCap, diaChi, soDienThoai) VALUES(@tenNCC, @diaChi, @SDT)";

                // Tạo command và truyền tham số
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tenNCC", tenNCC);
                    command.Parameters.AddWithValue("@diaChi", diaChi);
                    command.Parameters.AddWithValue("@SDT", SDT);

                    // Thực thi truy vấn cập nhật
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        themThanhCong = true;
                    }
                }
            }
            return themThanhCong;
        }

        public bool SuaNCC(string maNCC, string tenNCC, string diaChi, string SDT)
        {
            string connectionString = "Data Source=.; Database=MiniMarket;Integrated Security = True"; // Thay thế bằng connection string của bạn
            bool suaThanhCong = false;
            // Thiết lập kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn cập nhật
                string query = "UPDATE NhaCungCap SET tenNhaCungCap = @tenNCC, diaChi = @diaChi, soDienThoai = @SDT WHERE idNhaCungCap = @maNCC;";

                // Tạo command và truyền tham số
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@maNCC", maNCC);
                    command.Parameters.AddWithValue("@tenNCC", tenNCC);
                    command.Parameters.AddWithValue("@diaChi", diaChi);
                    command.Parameters.AddWithValue("@SDT", SDT);


                    // Thực thi truy vấn cập nhật
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        suaThanhCong = true;
                    }
                }
            }
            return suaThanhCong;
        }

        public void XoaNCC(string maNCC)
        {
            string connectionString = "Data Source=.; Database=MiniMarket;Integrated Security = True"; // Thay thế bằng connection string của bạn

            // Thiết lập kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn cập nhật
                string query = "DELETE FROM NhaCungCap WHERE idNhaCungCap = @maNCC;";

                // Tạo command và truyền tham số
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@maNCC", maNCC);
                    // Thực thi truy vấn cập nhật
                    int rowsAffected = command.ExecuteNonQuery();


                }
            }
        }

        public void ThemPhieuNhap(string maNCC, string maNV, DateTime ngayNhap, decimal tongTien)
        {
            string connectionString = "Data Source=.; Database=MiniMarket;Integrated Security = True"; // Thay thế bằng connection string của bạn

            // Thiết lập kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn cập nhật
                string query = " INSERT INTO PhieuNhap(idNhanVien, idNhaCungCap, ngayNhap, tongTien) VALUES(@maNV,@maNCC,@ngayNhap,@tongTien)";

                // Tạo command và truyền tham số
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@maNCC", maNCC);
                    command.Parameters.AddWithValue("@maNV", maNV);
                    command.Parameters.AddWithValue("@ngayNhap", ngayNhap);
                    command.Parameters.AddWithValue("@tongTien", tongTien);

                    // Thực thi truy vấn cập nhật
                    int rowsAffected = command.ExecuteNonQuery();


                }
            }
        }

    }
}
