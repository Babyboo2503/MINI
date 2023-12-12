using MINI.src.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MINI.src.DTO;
using System.Windows.Forms;

namespace MINI.src.GUI.ThongKe
{
    public partial class frmThongKe : Form
    {
        DateTime ngayBD, ngayKT;
        ThongKeBUS thongKeBus = null;
        List<HoaDonDTO> dsHoaDon = null;
        List<ChiTietHoaDonDTO> dsChiTietHoaDon = null;
        List<PhieuNhapDTO> dsPhieuNhap = null;
        public frmThongKe()
        {
            thongKeBus = new ThongKeBUS();
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            if (checkDate())
            {
                float totalInvoice = tinhTongHoaDonBanHang();
                float totalReciept = tinhTongHoaDonNhapHang();
                lblTotalProduct.Text = thongKeBus.layDSSanPham().Count().ToString();
                lblTotalEmployee.Text = thongKeBus.layDSNhanVien().Count().ToString();
                lblTotalCustomer.Text = thongKeBus.layDSKhachHang().Count().ToString();
                lblTotalVendor.Text = thongKeBus.layDSNhaCungCap().Count().ToString();
                lblTotalInvoice.Text = chuyenDoiGiaTriThanhChuoiTienTe(totalInvoice);
                lblTotalReceipt.Text = chuyenDoiGiaTriThanhChuoiTienTe(totalReciept);
                hienThiSanPham();
                hienThiNhanVien();
                hienThiKhachHang();
                hienThiNhaCungCap();
                hienThiHoaDon();
                hienThiPhieuNhap();
            }
        }

        void hienThiNhanVien()
        {
            DataTable dt = thongKeBus.layDanhSachNhanVien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvEmpolyee.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
                lvi.SubItems.Add(dt.Rows[i][8].ToString());
                lvi.SubItems.Add(dt.Rows[i][9].ToString());
            }
        }

        void hienThiSanPham()
        {
            DataTable dt = thongKeBus.layDanhSachSanPham();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvProduct.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
            }
        }

        void hienThiKhachHang()
        {
            DataTable dt = thongKeBus.layDanhSachKhachHang();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvCustomer.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
            }
        }

        void hienThiNhaCungCap()
        {
            DataTable dt = thongKeBus.layDanhSachNhaCungCap();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvVendor.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
            }
        }

        void hienThiHoaDon()
        {
            lsvInvoice.Items.Clear();
            if (ngayBD < DateTime.Now && ngayKT > ngayBD)
            {
                DataTable dt = thongKeBus.layDanhSachBanHangTheoNgayBatDauVaKetThuc(ngayBD, ngayKT);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = lsvReceipt.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());
                }
            } else {
                DataTable dt = thongKeBus.layDanhSachBanHang();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = lsvInvoice.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());
                    lvi.SubItems.Add(dt.Rows[i][5].ToString());
                }
            }
        }

        float tinhTongHoaDonBanHang()
        {
            float total = 0;
            dsHoaDon = thongKeBus.layDanhSachHoaDon();
            for (int i = 0; i < dsHoaDon.Count;i++)
            {
                total += dsHoaDon[i].tongHoaDon;
            }
            return total;
        }
        
        float tinhTongHoaDonNhapHang()
        {
            float total = 0;
            dsPhieuNhap = thongKeBus.layDanhSachNhapHang();
            for (int i = 0; i < dsPhieuNhap.Count;i++)
            {
                total += dsPhieuNhap[i].tongTien;
            }
            return total;
        }

        string chuyenDoiGiaTriThanhChuoiTienTe(float giaTri)
        {
            string chuoiTienTe = giaTri.ToString("#,##0") + " VND";
            return chuoiTienTe;
        }

        private void lsvInvoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvInvoice.SelectedItems.Count > 0)
            {
                int selectedInvoiceId = Convert.ToInt32(lsvInvoice.SelectedItems[0].Text);
                hienThiChiTietHoaDon(selectedInvoiceId);
            }
        }

        void hienThiChiTietHoaDon(int idHoaDon)
        {
            /*dsChiTietHoaDon = thongKeBus.layDanhSachChiTietHoaDon(idHoaDon);*/
            DataTable dt = thongKeBus.layDanhSachChiTietBanHang(idHoaDon);
            frmChiTietHoaDon frmChiTietHoaDon = new frmChiTietHoaDon(dt);
            frmChiTietHoaDon.ShowDialog();
        }

        void hienThiPhieuNhap()
        {
            lsvReceipt.Items.Clear();
            if (ngayBD < DateTime.Now && ngayKT > ngayBD)
            {
                DataTable dt = thongKeBus.layDanhSachPhieuNhapTheoNgayBatDauVaKetThuc(ngayBD, ngayKT);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = lsvReceipt.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());
                }
            }
            else
            {
                DataTable dt = thongKeBus.layDanhSachPhieuNhap();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = lsvReceipt.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());
                }
            }
        }

        private void lsvReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvReceipt.SelectedItems.Count > 0)
            {
                int selectdReceptId = Convert.ToInt32(lsvReceipt.SelectedItems[0].Text);
                hienThiChiTietPhieuNhap(selectdReceptId);
            }
        }

        void hienThiChiTietPhieuNhap(int idPhieuNhap)
        {
            DataTable dt = thongKeBus.layDanhSachChiTietPhieuNhap(idPhieuNhap);
            frmChiTietPhieuNhap frmChiTietPhieuNhap = new frmChiTietPhieuNhap(dt);
            frmChiTietPhieuNhap.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpNgayBD.Value = DateTime.Now;
            dtpNgayKT.Value = DateTime.Now;
        }

        bool checkDate()
        {
            ngayBD = dtpNgayBD.Value;
            ngayKT = dtpNgayKT.Value;
            if (ngayBD > DateTime.Now)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ngayBD > ngayKT)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;            
        }
    }
}
