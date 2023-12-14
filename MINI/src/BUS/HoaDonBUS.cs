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
    internal class HoaDonBUS
    {
        Database db;
        public HoaDonBUS()
        {
            db = new Database();
            //hd = new HoaDonDTO(); 
        }
        public DataTable LayDSHoaDon()
        {
            string strSQL = "Select hd.idHoaDon,hd.ngayLap,hd.tongHoaDon,hd.idNhanVien,nv.hoVaTen,hd.idKhachHang,kh.hoVaTen,hd.idKhuyenMai,km.tenKhuyenMai" +
                " from HoaDon hd inner join NhanVien nv on hd.idNhanVien = nv.idNhanVien" +
                " inner join KhachHang kh on hd.idKhachHang = kh.idKhachHang" +
                " inner join KhuyenMai km on hd.idKhuyenMai = km.idKhuyenMai";
            DataTable dt = db.Execute(strSQL); //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public void XoaHoaDon(string idHoaDon)
        {
            string sql = "Delete from HoaDon where idHoaDon = " + idHoaDon;
            db.ExecuteNonQuery(sql);
        }

        public void ThemHoaDon(HoaDonDTO hd)
        {
            try
            {
                string sql = string.Format("Insert Into HoaDon " +
                    "Values({0}, {1}, '{2}',{3},{4})", hd.idNhanVien.ToString(), hd.idKhachHang.ToString(), hd.ngayLap.ToString(), hd.idKhuyenMai.ToString(), hd.tongHoaDon.ToString());
                db.ExecuteNonQuery(sql);
            }
            catch (Exception) { }
        }


        public void CapNhatHoaDon(HoaDonDTO hd)
        {
            try
            {
                //Chuẩn bị câu lẹnh truy vấn
                string str = string.Format("Update HoaDon set idNhanVien = {0}, idKhachHang = {1}, ngayLap = '{2}', idKhuyenMai = {3}, tongHoaDon = {4} where idHoaDon = {5}",
                    hd.idNhanVien.ToString(), hd.idKhachHang.ToString(), hd.ngayLap.ToString(), hd.idKhuyenMai.ToString(), hd.tongHoaDon.ToString(), hd.idHoaDon.ToString());
                db.ExecuteNonQuery(str);
            }
            catch (Exception) { }
        }
        public DataTable LayDSSanPham()
        {
            string strSQL = "Select idSanPham,idLoaiSanPham, donGia, soLuong, trangThai, tenSanPham from SanPham where trangThai = 'Còn bán'";
            DataTable dt = db.Execute(strSQL); //Goi phuong thuc truy xuat du lieu
            return dt;
        }

        public DataTable LayMaHDMoi()
        {
            string strSQL = "Select Max(idHoaDon) from HoaDon;";
            DataTable dt = db.Execute(strSQL); //Goi phuong thuc truy xuat du lieu
            return dt;
        }

        public DataTable LayphanTramKM(string a)
        {
            string strSQL = "Select phanTram from KhuyenMai where idKhuyenMai = " + a;
            DataTable dt = db.Execute(strSQL); //Goi phuong thuc truy xuat du lieu
            return dt;
        }

        public DataTable LayDiemKH(string a)
        {
            string strSQL = "Select diem from KhachHang Where idKhachHang = " + a;
            DataTable dt = db.Execute(strSQL); //Goi phuong thuc truy xuat du lieu
            return dt;
        }

        public DataTable LayDSNhanVien()
        {
            string strSQL = "Select * from NhanVien";
            DataTable dt = db.Execute(strSQL); //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public DataTable LayDSKhachHang()
        {
            string strSQL = "Select * from KhachHang";
            DataTable dt = db.Execute(strSQL); //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public DataTable LayDSKhuyenMai()
        {
            string strSQL = "Select * from KhuyenMai";
            DataTable dt = db.Execute(strSQL); //Goi phuong thuc truy xuat du lieu
            return dt;
        }
    }
}
