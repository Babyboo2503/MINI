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
    internal class CTHoaDonBUS
    {
        Database db;
        public CTHoaDonBUS() 
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
                "Values({0}, {1} , {2} ,{3} ,{4} )",cthd.idHoaDon, cthd.idSanPham.ToString(), cthd.soLuong.ToString(), cthd.donGia.ToString(), cthd.tongTien.ToString());
            db.ExecuteNonQuery(sql);
        }
        

        public void CapNhatCTHoaDon(ChiTietHoaDonDTO cthd)
        {
            //Chuẩn bị câu lẹnh truy vấn
            string str = string.Format("Update ChiTietHoaDon set idSanPham = {0}, soLuong = {1}, donGia = {2}, tongTien = {3}  where idHoaDon = {4}", 
                cthd.idSanPham.ToString(), cthd.soLuong.ToString() , cthd.donGia.ToString(), cthd.tongTien.ToString(),cthd.idHoaDon.ToString()); db.ExecuteNonQuery(str);
        }
        
        public void BotSanPham(string idSanPham,string sl)
        {
            string sql = "Update SanPham set soLuong = soLuong - " + sl +" where idSanPham = " + idSanPham;
            db.ExecuteNonQuery(sql);
        }
        public void UpdateTTSanPham()
        {
            string sql = "Update SanPham set trangThai = N'Hết hàng' where soLuong = 0";
            db.ExecuteNonQuery(sql);
        }

        public void UpdateDiemKH(string diem, string id)
        {
            string sql = "Update KhachHang set diem = diem +" + diem + "where idKhachHang = " + id;
            db.ExecuteNonQuery(sql);
        }

        public void UpdateDiemADKM(string diem, string id)
        {
            string sql = "Update KhachHang set diem = diem -" + diem + "where idKhachHang = " + id;
            db.ExecuteNonQuery(sql);
        }
        /*
                public void TaoCTHD(HoaDonDTO hd,ChiTietHoaDonDTO cthd)
                {
                    string sql = string.Format("DECLARE @HDid int " +
                        "insert into HoaDon(idNhanVien, idKhachHang, ngayLap, idKhuyenMai, tongHoaDon) " +
                        "Values({0}, {1}, '{2}',{3},{4})", hd.idNhanVien.ToString(),hd.idKhachHang.ToString(),hd.ngayLap.ToString(),hd.idKhuyenMai.ToString(),hd.tongHoaDon.ToString() +
                        "SET @HDid = SCOPE_IDENTITY() " +
                        "INSERT INTO ChiTietHoaDon(idHoaDon, idSanPham, soLuong, donGia, tongTien) VALUES(@HDid, {1} , {2} ,{3} )",
                        cthd.idSanPham.ToString(), cthd.soLuong.ToString(), cthd.donGia.ToString(),cthd.tongTien.ToString());

                    db.ExecuteNonQuery(sql);
                }*/
        /*
        public void SanPhamCTHD(ChiTietHoaDonDTO cthd)
        {
            string sql = string.Format(";with CTHD as (select Top 1 * from ChiTietHoaDon ORDER BY idHoaDon DESC)\r\n update CTHD set idSanPham = {0} , soLuong = {1} , donGia ={3} , tongTien = {4} "
                ,cthd.idSanPham.ToString(), cthd.soLuong.ToString(), cthd.donGia.ToString(), cthd.tongTien.ToString());
            db.ExecuteNonQuery(sql);
        }*/

    }
}
