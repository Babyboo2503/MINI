using MINI.src.DAO;
using MINI.src.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINI.src.BUS
{
    public class ThongKeBUS
    {
        Database db;
        List<NhanVien> dsNhanVien = null;
        List<SanPham> dsSanPham = null;
        List<KhachHang> dsKhachHang = null;
        List<NhaCungCap> dsNhaCungCap = null;
        public ThongKeBUS()
        {
            db = new Database();
        }
        public DataTable layDanhSachNhanVien()
        {
            string strSQL = "SELECT * FROM NhanVien";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public List<NhanVien> layDSNhanVien()
        {
            dsNhanVien = new List<NhanVien>();
            string strSQL = "SELECT * FROM NhanVien";
            DataTable dt = db.Execute(strSQL);
            foreach (DataRow dr in dt.Rows)
            {
                NhanVien nv = new NhanVien();
                nv.idNhanVien = Convert.ToInt32(dr["idNhanVien"]);
                nv.hoTenNhanVien = dr["hoVaTen"].ToString();
                nv.soDienThoai = dr["soDienThoai"].ToString();
                nv.gioiTinh = dr["gioiTinh"].ToString();
                nv.idChucVu = Convert.ToInt32(dr["idChucVu"].ToString());
                nv.luong = float.Parse(dr["luong"].ToString());
                nv.trangThai = dr["trangThai"].ToString();
                /*                nv.ngayNghi = DateTime.Parse(dr["ngayNghi"].ToString());
                                nv.ngaySinh = DateTime.Parse(dr["ngaySinh"].ToString());*/
                nv.ngayNghi = DateTime.TryParseExact(dr["ngayNghi"].ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedNgayNghi) ? parsedNgayNghi : default(DateTime);
                nv.ngaySinh = DateTime.TryParseExact(dr["ngaySinh"].ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedNgaySinh) ? parsedNgaySinh : default(DateTime);

                nv.diaChi = dr["diaChi"].ToString();
                dsNhanVien.Add(nv);
            }
            return dsNhanVien;
        }

        public DataTable layDanhSachSanPham()
        {
            string strSQL = "SELECT * FROM SanPham";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public List<SanPham> layDSSanPham()
        {
            dsSanPham = new List<SanPham>();
            string strSQL = "SELECT * FROM SanPham";
            DataTable dt = db.Execute(strSQL);
            foreach (DataRow dr in dt.Rows)
            {
                SanPham sp = new SanPham();
                sp.idSanPham = Convert.ToInt32(dr["idSanPham"]);
                sp.idLoaiSanPham = Convert.ToInt32(dr["idLoaiSanPham"]);
                sp.donGia = float.Parse(dr["donGia"].ToString());
                sp.soLuong = Convert.ToInt32(dr["soLuong"]);
                sp.trangThai = dr["trangThai"].ToString();
                sp.chietKhau = Convert.ToInt32(dr["chietKhau"]);
                sp.tenSanPham = dr["tenSanPham"].ToString();
                sp.hinhAnh = dr["hinhAnh"].ToString();
                dsSanPham.Add(sp);
            } 
            return dsSanPham;
        }

        public DataTable layDanhSachKhachHang()
        {
            string strSQL = "SELECT * FROM KhachHang";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public List<KhachHang> layDSKhachHang()
        {
            string strSQL = "SELECT * FROM KhachHang";
            dsKhachHang = new List<KhachHang>();
            DataTable dt = db.Execute(strSQL);
            foreach(DataRow dr in dt.Rows )
            {
                KhachHang kh = new KhachHang();
                kh.idKhachHang = Convert.ToInt32(dr["idKhachHang"]);
                kh.hoTenKhachHang = dr["hoVaTen"].ToString();
                kh.soDienThoai = dr["soDienThoai"].ToString();
                kh.gioiTinh = dr["gioiTinh"].ToString();
                kh.email = dr["email"].ToString();
                kh.ngaySinh = DateTime.TryParseExact(dr["ngaySinh"].ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedNgaySinh) ? parsedNgaySinh : default(DateTime);
                kh.diem = Convert.ToInt32(dr["diem"]);
                kh.diaChi = dr["diaChi"].ToString();
                dsKhachHang.Add(kh);
                Console.WriteLine(kh.hoTenKhachHang);
            }
            return dsKhachHang;
        }

        public DataTable layDanhSachNhaCungCap()
        {
            string strSQL = "SELECT * FROM NhaCungCap";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public List<NhaCungCap> layDSNhaCungCap()
        {
            string strSQL = "SELECT * FROM NhaCungCap";
            dsNhaCungCap = new List<NhaCungCap>();
            DataTable dt = db.Execute(strSQL);
            foreach (DataRow dr in dt.Rows)
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc.idNhaCungCap = Convert.ToInt32(dr["idNhaCungCap"]);
                ncc.tenNhaCungCap = dr["tenNhaCungCap"].ToString();
                ncc.soDienThoai = dr["soDienThoai"].ToString();
                ncc.diaChi = dr["diaChi"].ToString();
                Console.WriteLine(ncc.tenNhaCungCap);
                dsNhaCungCap.Add(ncc);
            }
            return dsNhaCungCap;
        }        

        

    }
}
