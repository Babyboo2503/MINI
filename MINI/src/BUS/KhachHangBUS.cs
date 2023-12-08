using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MINI.src.DAO;

namespace MINI.BUS
{
    public class KhachHangBUS
    {
        Database db;
        public KhachHangBUS()
        {
            db = new Database();
        }
        public DataTable LayDSKhachHang()
        {
            string strSQL = "Select * from KhachHang";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable TimKiemKhachHang(string condition, string value)
        {
            string strSQL = "";
            if (condition.Equals("theo tên"))
            {
                strSQL = "Select * from KhachHang where hoVaTen like " + value;
            }
            else
            {
                strSQL = "Select * from KhachHang where soDienThoai like " + value;
            }
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public void XoaKhachHang(string index)
        {
            string sql = "Delete from KhachHang where idKhachHang = " +index;
            db.ExecuteNonQuery(sql);
        }
        public void ThemKhachHang(string hovaten, string diachi, string sdt, string gioitinh, string email, string ngaysinh)
        {
            string sql = string.Format("Insert Into KhachHang " +
                "Values(N'{0}', '{1}', N'{2}', '{3}', '{4}', {5}, N'{6}')",
                hovaten, sdt, gioitinh, email, ngaysinh, 0, diachi);
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatKhachHang(string hovaten, string diachi, string sdt, string gioitinh, string email, string ngaysinh, string diem, string id)
        {
            string str = string.Format("Update KhachHang set hoVaTen = N'{0}', diaChi = N'{1}', soDienThoai = '{2}', gioiTinh = N'{3}', email = '{4}', ngaySinh = '{5}', diem = {6}  where idKhachHang = '{7}'",
            hovaten, diachi, sdt, gioitinh, email, ngaysinh, diem, id);
            db.ExecuteNonQuery(str);
        }

        public string checkValue(string id, string hoten, string sdt, string email, string diem)
        {
            Regex regexName = new Regex("^[A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*(?:[ ][A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*)*$");
            Regex regexPhone = new Regex("^0\\d{9}$");
            Regex regexEmail = new Regex("^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$");
            int valueDiem;
            if (id == "")
            {

                MessageBox.Show("Hãy chọn khách hàng ở danh sách khách hàng", "Báo lỗi");
                return "id";
            }
            else if (hoten == "")
            {
                MessageBox.Show("Hãy nhập tên khách hàng", "Báo lỗi");
                return "hoten";
            }
            else if (!regexName.IsMatch(hoten))
            {
                MessageBox.Show("Tên chỉ chứa kí tự chữ và phải in hoa chữ cái đầu", "Báo lỗi");
                return "hoten";
            }
            else if (sdt == "")
            {
                MessageBox.Show("Hãy nhập số điện thoại", "Báo lỗi");
                return "sdt";
            }
            else if (!regexPhone.IsMatch(sdt))
            {
                MessageBox.Show("Số điện thoại phải có 10 số và bắt đầu bằng số 0", "Báo lỗi");
                return "sdt";
            }
            else if (email != "")
            {
                if (!regexEmail.IsMatch(email))
                {
                    MessageBox.Show("Email không đúng định dạng", "Báo lỗi");
                    return "email";
                }
            }
            else if (diem == "")
            {
                MessageBox.Show("Hãy nhập điểm", "Báo lỗi");
                return "diem";
            }
            else if (!int.TryParse(diem, out valueDiem))
            {
                MessageBox.Show("Điểm phải là số", "Báo lỗi");
                return "diem";
            }
            else if (valueDiem < 0)
            {
                MessageBox.Show("Điểm phải lớn hơn hoặc bằng 0", "Báo lỗi");
                return "diem";
            }
            return "true";
        }
    }
}
