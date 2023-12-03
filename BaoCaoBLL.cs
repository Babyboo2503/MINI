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
    internal class BaoCaoBLL
    {

        Database db;
        public BaoCaoBLL()
        {
            db = new Database();
            //hd = new HoaDonDTO(); 
        }
        public DataTable LayDSBaoCao()
        {
            string strSQL = "Select bc.idBaoCao,bc.ngayLap,bc.idNhanVien,nv.hoVaTen,bc.idSanPham,sp.tenSanPham,bc.soLuong,bc.lyDo" +
                " from BaoCao bc inner join NhanVien nv on bc.idNhanVien = nv.idNhanVien" +
                " inner join SanPham sp on bc.idSanPham = sp.idSanPham";
            DataTable dt = db.Execute(strSQL); //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public void XoaBaoCao(string idBaoCao)
        {
            string sql = "Delete from HoaDon where idHoaDon = " + idBaoCao;
            db.ExecuteNonQuery(sql);
        }

        public void ThemBaoCao(BaoCaoDTO bc)
        {
            try
            {
                string sql = string.Format("Insert Into BaoCao " +
                    "Values({0}, {1}, '{2}',{3},N'{4}')", bc.idNhanVien, bc.idSanPham, bc.ngayLap, bc.soLuong, bc.lyDo); db.ExecuteNonQuery(sql);
            }
            catch (Exception) { }
        }


        public void CapNhatBaoCao(BaoCaoDTO bc)
        {
            try
            {
                //Chuẩn bị câu lẹnh truy vấn
                string str = string.Format("Update BaoCao set idNhanVien = {0}, idSanPham = {1}, ngayLap = '{2}', soLuong = {3}, lyDo = N'{4}' where idBaoCao = {5}",
                    bc.idNhanVien, bc.idSanPham, bc.ngayLap, bc.soLuong, bc.lyDo, bc.idBaoCao);
                db.ExecuteNonQuery(str);
            }
            catch (Exception) { }
        }
    }
}
