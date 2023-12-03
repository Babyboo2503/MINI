using MINI.DAL;
using MINI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINI.BLL
{
    internal class CTHoaDonBLL
    {
        Database db;
        public CTHoaDonBLL() 
        {
            db = new Database();
        }
        public DataTable LayDSCTHoaDon(string idHoaDon)
        {
            string strSQL = "Select cthd.idHoaDon,cthd.idSanPham,sp.tenSanPham,cthd.soLuong,cthd.donGia,cthd.tongTien" +
                " from ChiTietHoaDon cthd " +
                " inner join SanPham sp on cthd.idSanPham = sp.idSanPham  where cthd.idHoaDon ="+idHoaDon;
            DataTable dt = db.Execute(strSQL); //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public void XoaCTHoaDon(string idHoaDon)
        {
            string sql = "Delete from ChiTietHoaDon where idHoaDon = " + idHoaDon;
            db.ExecuteNonQuery(sql);
        }

        public void ThemCTHoaDon(ChiTietHoaDonDTO cthd)
        {

            string sql = string.Format("Insert Into ChiTietHoaDon " +
                "Values({0}, {1} , {2} ,{3} )", cthd.idSanPham, cthd.soLuong, cthd.donGia,cthd.tongTien); db.ExecuteNonQuery(sql);
        }


        public void CapNhatCTHoaDon(ChiTietHoaDonDTO cthd)
        {
            //Chuẩn bị câu lẹnh truy vấn
            string str = string.Format("Update ChiTietHoaDon set idSanPham = {0}, soLuong = {1}, donGia = {2}, tongTien = {3}  where idHoaDon = {4}", cthd.idSanPham, cthd.soLuong, cthd.donGia, cthd.tongTien,cthd.idHoaDon); db.ExecuteNonQuery(str);
        }
    }
}
