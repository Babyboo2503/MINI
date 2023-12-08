using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MINI.DAO;

namespace MINI.BUS
{
    public class SanPhamBUS
    {
        Database db;
        public SanPhamBUS()
        {
            db = new Database();
        }
        public DataTable LayDSSanPham()
        {
            string strSQL = "Select * from SanPham";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public void XoaSanPham(string index)
        {
            string sql = "Delete from SanPham where idSanPham = " + index;
            db.ExecuteNonQuery(sql);
        }
        public void ThemSanPham(string loaisanpham, string ten, string dongia, string soluong, string hinhanh, string trangthai)
        {
            string sql = string.Format("Insert Into SanPham " +
                "Values('{0}', '{1}', '{2}', N'{3}', {4}, N'{5}', '{6}')",
                loaisanpham, dongia, soluong, trangthai, 0, ten, hinhanh);
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatSanPham(string loaisanpham, string ten, string dongia, string soluong, string hinhanh, string trangthai, string id)
        {
            string str = string.Format("Update SanPham set idLoaiSanPham = '{0}', tenSanPham = N'{1}', donGia = '{2}', soLuong = '{3}', hinhAnh = '{4}', trangThai = N'{5}' where idSanPham = '{6}'",
            loaisanpham, ten, dongia, soluong, hinhanh, trangthai, id);
            db.ExecuteNonQuery(str);
        }
        public DataTable LayDSLoaiSanPham()
        {
            string strSQL = "Select * from LoaiSanPham";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public void XoaLoaiSanPham(string index)
        {
            string sql = "Delete from LoaiSanPham where idLoaiSanPham = " + index;
            db.ExecuteNonQuery(sql);
        }
        public void ThemLoaiSanPham(string tenloaisanpham)
        {
            string sql = string.Format("Insert Into LoaiSanPham " +
                "Values(N'{0}')", tenloaisanpham);
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatLoaiSanPham(string tenloaisanpham, string id)
        {
            string str = string.Format("Update LoaiSanPham set tenLoaiSanPham = N'{0}' where idLoaiSanPham = '{1}'",
            tenloaisanpham, id);
            db.ExecuteNonQuery(str);
        }
        public bool checkValue_LoaiSanPham(string id, string ten)
        {
            if (id == "")
            {
                MessageBox.Show("Hãy chọn loại sản phẩm", "Báo lỗi");
                return false;
            }
            else if (ten == "")
            {
                MessageBox.Show("Hãy nhập tên loại sản phẩm", "Báo lỗi");
                return false;
            }
            else
            {
                bool flag = true;
                DataTable dttk = LayDSLoaiSanPham();
                for (int i = 0; i < dttk.Rows.Count; i++)
                {
                    if(id == "id")
                    {
                        if (dttk.Rows[i][1].ToString().ToLower().Equals(ten.ToLower()))
                        {
                            flag = false;
                        }
                    } 
                    else
                    {
                        if (dttk.Rows[i][0].ToString().Equals(id) && dttk.Rows[i][1].ToString().ToLower().Equals(ten.ToLower()))
                        {
                            flag = true;
                            break;
                        }
                        else if (!dttk.Rows[i][0].ToString().Equals(id) && dttk.Rows[i][1].ToString().ToLower().Equals(ten.ToLower()))
                        {
                            flag = false;
                        }
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("Tên loại sản phẩm đã tồn tại", "Báo lỗi");
                    return false;
                }
            }
            return true;
        }
        public string checkValue_SanPham(string id, string loaisp, string ten, string dongia, string soluong, string hinhanh, string trangthai)
        {
            double valueDongia;
            int valueSoluong;
            if (id == "")
            {
                MessageBox.Show("Hãy chọn sản phẩm", "Báo lỗi");
                return "id";
            }
            else if (loaisp == "")
            {
                MessageBox.Show("Hãy chọn loại sản phẩm", "Báo lỗi");
                return "loaisp";
            }
            else if (ten == "")
            {
                MessageBox.Show("Hãy nhập tên sản phẩm", "Báo lỗi");
                return "ten";
            }
            else
            {
                bool flag = true;
                DataTable dttk = LayDSSanPham();
                for (int i = 0; i < dttk.Rows.Count; i++)
                {
                    if (id == "id")
                    {
                        if (dttk.Rows[i][6].ToString().ToLower().Equals(ten.ToLower()))
                        {
                            flag = false;
                        }
                    }
                    else
                    {
                        if (dttk.Rows[i][6].ToString().ToLower().Equals(ten.ToLower()) && dttk.Rows[i][0].ToString().Equals(id))
                        {
                            flag = true;
                            break;
                        }
                        else if (dttk.Rows[i][6].ToString().ToLower().Equals(ten.ToLower()) && !dttk.Rows[i][0].ToString().Equals(id))
                        {
                            flag = false;
                        }
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("Tên sản phẩm đã tồn tại", "Báo lỗi");
                    return "ten";
                }
            }
            if (dongia == "")
            {
                MessageBox.Show("Hãy nhập đơn giá", "Báo lỗi");
                return "dongia";
            }
            else if (!double.TryParse(dongia, out valueDongia))
            {
                MessageBox.Show("Đơn giá phải là số", "Báo lỗi");
                return "dongia";
            }
            else if (soluong == "")
            {
                MessageBox.Show("Hãy nhập số lượng", "Báo lỗi");
                return "soluong";
            }
            else if (!int.TryParse(soluong, out valueSoluong))
            {
                MessageBox.Show("Số lượng phải là số", "Báo lỗi");
                return "soluong";
            }
            else if(hinhanh == "")
            {
                MessageBox.Show("Hãy chọn hình ảnh", "Báo lỗi");
                return "hinhanh";
            }
            return "true";
        }
    }
}
