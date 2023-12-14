using MINI.GUI;
using MINI.GUI.HoaDon;
using MINI.src.DAO;
using MINI.src.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhanVienDTO = MINI.src.DTO.NhanVienDTO;

namespace MINI.src.BUS
{
    public class ThongKeBUS
    {
        Database db;
        List<NhanVienDTO> dsNhanVien = null;
        List<SanPhamDTO> dsSanPham = null;
        List<KhachHangDTO> dsKhachHang = null;
        List<NhaCungCapDTO> dsNhaCungCap = null;
        List<HoaDonDTO> dsHoaDon = null;
        List<ChiTietHoaDonDTO> dsChiTietHoaDon = null;
        List<PhieuNhapDTO> dsPhieuNhap = null;
        List<ChiTietPhieuNhapDTO> dsChiTietPhieuNhap = null;
        public ThongKeBUS()
        {
            db = new Database();
        }
        public DataTable layDanhSachNhanVienTheoHoaDon()
        {
            string strSQL = "SELECT " +
                "HD.idHoaDon, " +
                "NV.idNhanVien, " +
                "NV.hoVaTen, " +
                "HD.ngayLap, " +
                "HD.tongHoaDon, " +
                "CV.tenChucVu, " +
                "NV.ngayNghi " +
                "FROM NhanVien NV " +
                "JOIN HoaDon HD ON NV.idNhanVien = HD.idNhanVien " +
                "JOIN ChucVu CV ON NV.idChucVu = CV.idChucVu " +
                "ORDER BY HD.idHoaDon ASC;";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }


        public DataTable layDanhSachNhanVienTheoPhieuNhap()
        {
            string strSQL = "SELECT " +
                "PN.idPhieuNhap, " +
                "NV.idNhanVien, " +
                "NV.hoVaTen, " +
                "PN.ngayNhap, " +
                "PN.tongTien, " +
                "CV.tenChucVu, " +
                "NV.ngayNghi " +
                "FROM NhanVien NV " +
                "JOIN PhieuNhap PN ON NV.idNhanVien = PN.idNhanVien " +
                "JOIN ChucVu CV ON NV.idChucVu = CV.idChucVu " +
                "ORDER BY PN.idNhanVien ASC;";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public List<NhanVienDTO> layDSNhanVien()
        {
            dsNhanVien = new List<NhanVienDTO>();
            string strSQL = "SELECT * FROM NhanVien";
            DataTable dt = db.Execute(strSQL);
            foreach (DataRow dr in dt.Rows)
            {
                NhanVienDTO nv = new NhanVienDTO();
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

        public DataTable layDanhSachSanPhamTheoHoaDonBan()
        {
            string strSQL = "SELECT " +
                "CHD.idSanPham, " +
                "SP.tenSanPham, " +
                "SP.donGia, " +
                "MAX(CHD.donGia) AS MaxDonGia, " +
                "SUM(CHD.soLuong) AS TongSoLuong, " +
                "SUM(CHD.tongTien) AS TongTien " +
                "FROM ChiTietHoaDon CHD " +
                "JOIN SanPham SP ON CHD.idSanPham = SP.idSanPham " +
                "GROUP BY CHD.idSanPham, SP.tenSanPham, SP.donGia " +
                "ORDER BY CHD.idSanPham ASC;";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable layDanhSachSanPhamTheoPhieuNhap()
        {
            string strSQL = "SELECT " +
                "CTPN.idSanPham, " +
                "SP.tenSanPham, " +
                "SP.donGia, " +
                "MAX(CTPN.donGia) AS MaxDonGia, " +
                "SUM(CTPN.soLuong) AS TongSoLuong, " +
                "SUM(CTPN.thanhTien) AS TongTien " +
                "FROM ChiTietPhieuNhap CTPN " +
                "JOIN SanPham SP ON CTPN.idSanPham = SP.idSanPham " +
                "GROUP BY CTPN.idSanPham, SP.tenSanPham, SP.donGia " +
                "ORDER BY CTPN.idSanPham ASC;";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public List<SanPhamDTO> layDSSanPham()
        {
            dsSanPham = new List<SanPhamDTO>();
            string strSQL = "SELECT * FROM SanPham";
            DataTable dt = db.Execute(strSQL);
            foreach (DataRow dr in dt.Rows)
            {
                SanPhamDTO sp = new SanPhamDTO();
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
            string strSQL = "SELECT " +
                "HD.idHoaDon, " +
                "KH.idKhachHang, " +
                "KH.hoVaTen AS TenKhachHang, " +
                "KH.soDienThoai, " +
                "KH.diem, " +
                "KM.tenKhuyenMai, " +
                "HD.ngayLap, " +
                "HD.tongHoaDon " +
                "FROM HoaDon HD " +
                "JOIN KhachHang KH ON HD.idKhachHang = KH.idKhachHang " +
                "LEFT JOIN KhuyenMai KM ON HD.idKhuyenMai = KM.idKhuyenMai;";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public List<KhachHangDTO> layDSKhachHang()
        {
            string strSQL = "SELECT * FROM KhachHang";
            dsKhachHang = new List<KhachHangDTO>();
            DataTable dt = db.Execute(strSQL);
            foreach (DataRow dr in dt.Rows)
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.idKhachHang = Convert.ToInt32(dr["idKhachHang"]);
                kh.hoTenKhachHang = dr["hoVaTen"].ToString();
                kh.soDienThoai = dr["soDienThoai"].ToString();
                kh.gioiTinh = dr["gioiTinh"].ToString();
                kh.email = dr["email"].ToString();
                kh.ngaySinh = DateTime.TryParseExact(dr["ngaySinh"].ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedNgaySinh) ? parsedNgaySinh : default(DateTime);
                kh.diem = Convert.ToInt32(dr["diem"]);
                kh.diaChi = dr["diaChi"].ToString();
                dsKhachHang.Add(kh);
            }
            return dsKhachHang;
        }

        public DataTable layDanhSachNhaCungCap()
        {
            string strSQL = "SELECT " +
                "PN.idPhieuNhap, " +
                "NCC.idNhaCungCap, " +
                "NCC.tenNhaCungCap, " +
                "NCC.diaChi, " +
                "NCC.soDienThoai, " +
                "PN.ngayNhap, " +
                "PN.tongTien " +
                "FROM PhieuNhap PN " +
                "JOIN NhaCungCap NCC " +
                "ON PN.idNhaCungCap = NCC.idNhaCungCap;";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public List<NhaCungCapDTO> layDSNhaCungCap()
        {
            string strSQL = "SELECT * FROM NhaCungCap";
            dsNhaCungCap = new List<NhaCungCapDTO>();
            DataTable dt = db.Execute(strSQL);
            foreach (DataRow dr in dt.Rows)
            {
                NhaCungCapDTO ncc = new NhaCungCapDTO();
                ncc.idNhaCungCap = Convert.ToInt32(dr["idNhaCungCap"]);
                ncc.tenNhaCungCap = dr["tenNhaCungCap"].ToString();
                ncc.soDienThoai = dr["soDienThoai"].ToString();
                ncc.diaChi = dr["diaChi"].ToString();
                dsNhaCungCap.Add(ncc);
            }
            return dsNhaCungCap;
        }

        public DataTable layDanhSachBanHang()
        {
            string strSQL = @"
                SELECT HD.idHoaDon,
                       NV.hoVaTen AS tenNhanVien,
                       KH.hoVaTen AS tenKhachHang,
                       HD.ngayLap,
                       KM.tenKhuyenMai,
                       tongHoaDon
                FROM HoaDon HD
                JOIN NhanVien NV ON HD.idNhanVien = NV.idNhanVien
                JOIN KhachHang KH ON HD.idKhachHang = KH.idKhachHang
                LEFT JOIN KhuyenMai KM ON HD.idKhuyenMai = KM.idKhuyenMai";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable layDanhSachBanHangTheoNgayBatDauVaKetThuc(DateTime ngayBD, DateTime ngayKT)
        {
            string strSQL = @"
                SELECT  HD.idHoaDon,
                        NV.hoVaTen AS tenNhanVien,
                        KH.hoVaTen AS tenKhachHang,
                        HD.ngayLap,
                        KM.tenKhuyenMai,
                        tongHoaDon
                        FROM HoaDon HD
                        JOIN NhanVien NV ON HD.idNhanVien = NV.idNhanVien
                        JOIN KhachHang KH ON HD.idKhachHang = KH.idKhachHang
                        LEFT JOIN KhuyenMai KM ON HD.idKhuyenMai = KM.idKhuyenMai
                        WHERE HD.ngayLap >= '" + ngayBD + "' AND HD.ngayLap <= '" + ngayKT + "'";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable layDanhSachChiTietBanHang(int idHoaDon)
        {
            string strSQL = "SELECT cthd.idHoaDon," +
                " tenSanPham," +
                " cthd.soLuong," +
                " cthd.donGia," +
                " cthd.tongTien" +
                " FROM SanPham sp, ChiTietHoaDon cthd" +
                " WHERE sp.idSanPham = cthd.idSanPham " +
                " AND cthd.idHoaDon = " + idHoaDon.ToString();
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public List<HoaDonDTO> layDanhSachHoaDon()
        {
            string strSQL = "SELECT * FROM HoaDon";
            dsHoaDon = new List<HoaDonDTO>();
            DataTable dt = db.Execute(strSQL);
            foreach (DataRow dr in dt.Rows)
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.idHoaDon = Convert.ToInt32(dr["idHoaDon"]);
                hd.idNhanVien = Convert.ToInt32(dr["idNhanVien"]);
                hd.idKhachHang = Convert.ToInt32(dr["idKhachHang"]);
                hd.idKhuyenMai = Convert.ToInt32(dr["idKhuyenMai"]);
                hd.ngayLap = DateTime.TryParseExact(dr["ngayLap"].ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedNgayLap) ? parsedNgayLap : default(DateTime);
                hd.tongHoaDon = Convert.ToInt32(dr["tongHoaDon"]);
                dsHoaDon.Add(hd);
            }
            return dsHoaDon;
        }

        public List<PhieuNhapDTO> layDanhSachNhapHang()
        {
            string strSQL = "SELECT * FROM PhieuNhap";
            dsPhieuNhap = new List<PhieuNhapDTO>();
            DataTable dt = db.Execute(strSQL);
            foreach (DataRow dr in dt.Rows)
            {
                PhieuNhapDTO pn = new PhieuNhapDTO();
                pn.idPhieuNhap = Convert.ToInt32(dr["idPhieuNhap"]);
                pn.idNhanVien = Convert.ToInt32(dr["idNhanVien"]);
                pn.idNhaCungCap = Convert.ToInt32(dr["idNhaCungCap"]);
                pn.ngayNhap = DateTime.TryParseExact(dr["ngayNhap"].ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedngayNhap) ? parsedngayNhap : default(DateTime);
                pn.tongTien = Convert.ToInt32(dr["tongTien"]);
                dsPhieuNhap.Add(pn);
            }
            return dsPhieuNhap;
        }

         

        public List<ChiTietHoaDonDTO> layDanhSachChiTietHoaDon(int idHoaDon)
        {
            string SQL = "SELECT * FROM ChiTietHoaDon WHERE idHoaDon = " + idHoaDon.ToString();
            dsChiTietHoaDon = new List<ChiTietHoaDonDTO>();
            DataTable dt = db.Execute(SQL);
            foreach (DataRow dr in dt.Rows)
            {
                ChiTietHoaDonDTO cthd = new ChiTietHoaDonDTO();
                cthd.idHoaDon = Convert.ToInt32(dr["idHoaDon"]);
                cthd.idSanPham = Convert.ToInt32(dr["idSanPham"]);
                cthd.soLuong = Convert.ToInt32(dr["soLuong"]);
                cthd.donGia = decimal.Parse(dr["donGia"].ToString());
                cthd.tongTien = decimal.Parse(dr["tongTien"].ToString());
                dsChiTietHoaDon.Add(cthd);
            }
            return dsChiTietHoaDon;
        }

        public DataTable layDanhSachPhieuNhap()
        {
            string strSQL = @"
                SELECT pn.idPhieuNhap,
                    NV.hoVaTen AS tenNhanVien,
                    NCC.tenNhaCungCap AS tenNhaCungCap,
                    pn.ngayNhap,
	                pn.tongTien
                FROM PhieuNhap pn
                JOIN NhanVien NV ON pn.idNhanVien = NV.idNhanVien
                JOIN NhaCungCap NCC ON NCC.idNhaCungCap = pn.idNhaCungCap";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable layDanhSachPhieuNhapTheoNgayBatDauVaKetThuc(DateTime ngayBD, DateTime ngayKetThuc)
        {
            string strSQL = @"
                SELECT pn.idPhieuNhap,
                    NV.hoVaTen AS tenNhanVien,
                    NCC.tenNhaCungCap AS tenNhaCungCap,
                    pn.ngayNhap,
	                pn.tongTien
                FROM PhieuNhap pn
                JOIN NhanVien NV ON pn.idNhanVien = NV.idNhanVien
                JOIN NhaCungCap NCC ON NCC.idNhaCungCap = pn.idNhaCungCap
                WHERE pn.ngayNhap <= '" + ngayBD + "' AND pn.ngayNhap >= '" + ngayKetThuc + "'";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable layDanhSachChiTietPhieuNhap(int idPhieuNhap)
        {
            string strSQL = @"
                SELECT CTPN.idPhieuNhap,
                    SP.tenSanPham,
                    CTPN.soLuong,
                    CTPN.donGia,
                    CTPN.thanhTien
                FROM ChiTietPhieuNhap CTPN, SanPham SP 
                WHERE CTPN.idSanPham = SP.idSanPham 
                AND CTPN.idPhieuNhap = " + idPhieuNhap.ToString();
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
    }
}
