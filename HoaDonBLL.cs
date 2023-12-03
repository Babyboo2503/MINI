using MINI.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MINI.DTO;

namespace MINI.BLL
{
    internal class HoaDonBLL
    {
        
        Database db;
        public HoaDonBLL()
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
            try { 
            string sql = string.Format("Insert Into HoaDon " +
                "Values({0}, {1}, '{2}',{3},{4})", hd.idNhanVien,hd.idKhachHang,hd.ngayLap,hd.idKhuyenMai,hd.tongHoaDon); db.ExecuteNonQuery(sql);
            }
            catch (Exception) { }
        }


        public void CapNhatHoaDon(HoaDonDTO hd)
        {
            try
            {
                //Chuẩn bị câu lẹnh truy vấn
                string str = string.Format("Update HoaDon set idNhanVien = {0}, idKhachHang = {1}, ngayLap = '{2}', idKhuyenMai = {3}, tongHoaDon = {4} where idHoaDon = {5}", 
                    hd.idNhanVien, hd.idKhachHang, hd.ngayLap, hd.idKhuyenMai, hd.tongHoaDon, hd.idHoaDon); 
                db.ExecuteNonQuery(str);
            }
            catch (Exception) { }
        }
    }
}
