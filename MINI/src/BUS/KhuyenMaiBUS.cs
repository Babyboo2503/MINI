using MINI.src.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINI.BUS
{
    public class KhuyenMaiBUS
    {
        Database db;
        public KhuyenMaiBUS()
        {
            db = new Database();
        }
        public DataTable LayDSKhuyenMai()
        {
            string strSQL = "Select * from KhuyenMai";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public void ThemKhuyenMai(string ngaybatdau, string ngayketthuc, string tenkm, string phantram, string noidung, string dieukien)
        {
            string sql = string.Format("Insert Into KhuyenMai " +
                "Values('{0}', '{1}', N'{2}', '{3}', N'{4}', '{5}')",
                ngaybatdau, ngayketthuc, tenkm, phantram, noidung, dieukien);
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatKhuyenMai(string ngaybatdau, string ngayketthuc, string tenkm, string phantram, string noidung, string dieukien, string id)
        {
            string str = string.Format("Update KhuyenMai set ngayBatDau = '{0}', ngayKetThuc = '{1}', tenKhuyenMai = N'{2}', phanTram = '{3}', noiDung = N'{4}', dieuKien = '{5}' where idKhuyenMai = '{6}'",
            ngaybatdau, ngayketthuc, tenkm, phantram, noidung, dieukien, id);
            db.ExecuteNonQuery(str);
        }
        public string checkValue(DateTime ngaybatdau, DateTime ngayketthuc, string tenkm, string phantram, string noidung, string dieukien)
        {
            int valuePhanTram;
            if (DateTime.Compare(ngaybatdau, ngayketthuc) > 0)
            {
                MessageBox.Show("Ngày bắt đầu phải sớm hơn ngày kết thúc", "Báo lỗi");
                return "ngaybatdau";
            }
            else if (DateTime.Compare(ngayketthuc, DateTime.Now) < 0)
            {
                MessageBox.Show("Ngày kết thúc phải trễ hơn hiện tại", "Báo lỗi");
                return "ngayketthuc";
            }
            else if (tenkm == "")
            {
                MessageBox.Show("Hãy nhập tên khuyến mãi", "Báo lỗi");
                return "tenkm";
            }
            else if (phantram == "")
            {
                MessageBox.Show("Hãy nhập phần trăm", "Báo lỗi");
                return "phantram";
            }
            else if (!int.TryParse(phantram, out valuePhanTram))
            {
                MessageBox.Show("Phần trăm phải là số", "Báo lỗi");
                return "phantram";
            }
            else if (valuePhanTram < 0 || valuePhanTram > 50)
            {
                MessageBox.Show("Phần trăm chỉ được nằm trong khoảng từ 0 - 50", "Báo lỗi");
                return "phantram";
            }
            else if(noidung == "")
            {
                MessageBox.Show("Hãy nhập nội dung", "Báo lỗi");
                return "noidung";
            }
            else if(dieukien == "")
            {
                MessageBox.Show("Hãy nhập điều kiện", "Báo lỗi");
                return "dieukien";
            }
            return "true";
        }
        public void ApDungKhuyenMai(string chietkhau, string id)
        {
            string str = string.Format("Update SanPham set chietKhau = '{0}' where idSanPham = '{1}'",
            chietkhau, id);
            db.ExecuteNonQuery(str);
        }
        public void HuyKhuyenMai(string id)
        {
            string str = string.Format("Update SanPham set chietKhau = 0 where idSanPham = '{0}'",
            id);
            db.ExecuteNonQuery(str);
        }
    }
}
