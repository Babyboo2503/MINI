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

namespace MINI.src.GUI
{
    public partial class frmThongKe : Form
    {
        DateTime ngayBD, ngayKT;
        ThongKeBUS thongKeBus = null;
        List<HoaDonDTO> dsHoaDon = null;
        List<ChiTietHoaDonDTO> dsChiTietHoaDon = null;
        List<PhieuNhapDTO> dsPhieuNhap = null;
        DateTime ngayLapHD;
        String messageCBNhanVien = "Hóa Đơn Bán";
        public frmThongKe()
        {
            thongKeBus = new ThongKeBUS();
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            float totalInvoice = tinhTongHoaDonBanHang();
            float totalReciept = tinhTongHoaDonNhapHang();
            lblTotalProduct.Text = thongKeBus.layDSSanPham().Count().ToString();
            lblTotalEmployee.Text = thongKeBus.layDSNhanVien().Count().ToString();
            lblTotalCustomer.Text = thongKeBus.layDSKhachHang().Count().ToString();
            lblTotalVendor.Text = thongKeBus.layDSNhaCungCap().Count().ToString();
            lblTotalInvoice.Text = chuyenDoiGiaTriThanhChuoiTienTe(totalInvoice);
            lblTotalReceipt.Text = chuyenDoiGiaTriThanhChuoiTienTe(totalReciept);
            hienThiSanPhamTheoHoaDonBan();
            hienThiNhanVienTheoHoaDon();
            hienThiKhachHang();
            hienThiNhaCungCap();
            hienThiHoaDon();
            hienThiPhieuNhap();
        }

        void hienThiNhanVienTheoHoaDon()
        {
            lsvEmpolyee.Items.Clear();
            DataTable dt = thongKeBus.layDanhSachNhanVienTheoHoaDon();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvEmpolyee.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
            }
        }

        void hienThiNhanVienTheoPhieuNhap()
        {
            lsvEmpolyee.Items.Clear();
            DataTable dt = thongKeBus.layDanhSachNhanVienTheoPhieuNhap();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvEmpolyee.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
            }
        }

        void hienThiSanPhamTheoHoaDonBan()
        {
            lsvProduct.Items.Clear();
            DataTable dt = thongKeBus.layDanhSachSanPhamTheoHoaDonBan();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvProduct.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }

        void hienThiSanPhamTheoPhieuNhap()
        {
            lsvProduct.Items.Clear();
            DataTable dt = thongKeBus.layDanhSachSanPhamTheoPhieuNhap();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvProduct.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
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
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
            }
        }

        void hienThiHoaDon()
        {
            lsvInvoice.Items.Clear();
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

        float tinhTongHoaDonBanHang()
        {
            float total = 0;
            dsHoaDon = thongKeBus.layDanhSachHoaDon();
            for (int i = 0; i < dsHoaDon.Count; i++)
            {
                total += dsHoaDon[i].tongHoaDon;
            }
            return total;
        }

        float tinhTongHoaDonNhapHang()
        {
            float total = 0;
            dsPhieuNhap = thongKeBus.layDanhSachNhapHang();
            for (int i = 0; i < dsPhieuNhap.Count; i++)
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
            ngayBD = DateTime.Now;
            dtpNgayBD.Text = DateTime.Now.ToString();
            ngayKT = DateTime.Now;
            dtpNgayKT.Text = DateTime.Now.ToString();
            hienThiHoaDon();
            hienThiPhieuNhap();
            float totalInvoice = tinhTongHoaDonBanHang();
            float totalReciept = tinhTongHoaDonNhapHang();
            lblTotalInvoice.Text = chuyenDoiGiaTriThanhChuoiTienTe(totalInvoice);
            lblTotalReceipt.Text = chuyenDoiGiaTriThanhChuoiTienTe(totalReciept);
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            float totalInvoice = 0;
            float totalReciept = 0;
            ngayBD = DateTime.Parse(dtpNgayBD.Text);
            ngayKT = DateTime.Parse(dtpNgayKT.Text);
            if (checkDate())
            {
                foreach (ListViewItem lvt in lsvInvoice.Items)
                {
                    ngayLapHD = DateTime.Parse(lvt.SubItems[3].Text);
                    if (ngayBD > ngayLapHD || ngayKT < ngayLapHD)
                    {
                        lsvInvoice.Items.Remove(lvt);
                    }
                    else
                    {
                        totalInvoice += float.Parse(lvt.SubItems[5].Text);
                    }
                }
                foreach (ListViewItem lvt in lsvReceipt.Items)
                {
                    ngayLapHD = DateTime.Parse(lvt.SubItems[3].Text);
                    if (ngayBD > ngayLapHD || ngayKT < ngayLapHD)
                    {
                        lsvReceipt.Items.Remove(lvt);
                    }
                    else
                    {
                        totalReciept += float.Parse(lvt.SubItems[4].Text);
                    }
                }
            }
            lblTotalInvoice.Text = chuyenDoiGiaTriThanhChuoiTienTe(totalInvoice);
            lblTotalReceipt.Text = chuyenDoiGiaTriThanhChuoiTienTe(totalReciept);
        }

        private void cbDSSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string message = cbDSSP.SelectedItem.ToString();
            if (message.Equals("Hóa Đơn"))
            {
                hienThiSanPhamTheoHoaDonBan();
            }
            else
            {
                hienThiSanPhamTheoPhieuNhap();
            }
        }

        private void cbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            messageCBNhanVien = cbNhanVien.SelectedItem.ToString();
            ngayBD = DateTime.Now;
            dtpBDNV.Text = DateTime.Now.ToString();
            ngayKT = DateTime.Now;
            dtpKTNV.Text = DateTime.Now.ToString();
            if (messageCBNhanVien.Equals("Hóa Đơn Bán"))
            {
                hienThiNhanVienTheoHoaDon();
            }
            else
            {
                hienThiNhanVienTheoPhieuNhap();
            }
        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            ngayBD = DateTime.Parse(dtpBDNV.Text);
            ngayKT = DateTime.Parse(dtpKTNV.Text);
            if (checkDate())
            {
                foreach (ListViewItem lvt in lsvEmpolyee.Items)
                {
                    ngayLapHD = DateTime.Parse(lvt.SubItems[3].Text);
                    if (ngayBD > ngayLapHD || ngayKT < ngayLapHD)
                    {
                        lsvEmpolyee.Items.Remove(lvt);
                    }
                }
            }
        }

        private void btnClearNV_Click(object sender, EventArgs e)
        {
            ngayBD = DateTime.Now;
            dtpBDNV.Text = DateTime.Now.ToString();
            ngayKT = DateTime.Now;
            dtpKTNV.Text = DateTime.Now.ToString();
            cbNhanVien.Text = "Thống Kê Nhân Viên Theo";
            hienThiNhanVienTheoHoaDon();
        }

        private void lsvEmpolyee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvEmpolyee.SelectedItems.Count > 0)
            {
                int selectdReceptId = Convert.ToInt32(lsvEmpolyee.SelectedItems[0].Text);
                if (messageCBNhanVien.Equals("Hóa Đơn Bán"))
                {
                    hienThiChiTietHoaDon(selectdReceptId);
                }
                else
                {
                    hienThiChiTietPhieuNhap(selectdReceptId);
                }
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            ngayBD = DateTime.Parse(dtpBDKH.Text);
            ngayKT = DateTime.Parse(dtpKHKT.Text);
            if (checkDate())
            {
                foreach (ListViewItem lvt in lsvCustomer.Items)
                {
                    ngayLapHD = DateTime.Parse(lvt.SubItems[6].Text);
                    if (ngayBD > ngayLapHD || ngayKT < ngayLapHD)
                    {
                        lsvCustomer.Items.Remove(lvt);
                    }
                }
            }
        }

        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            ngayBD = DateTime.Now;
            dtpBDKH.Text = DateTime.Now.ToString();
            ngayKT = DateTime.Now;
            dtpKHKT.Text = DateTime.Now.ToString();
            hienThiKhachHang();
        }

        private void lsvCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvCustomer.SelectedItems.Count > 0)
            {
                int selectdReceptId = Convert.ToInt32(lsvCustomer.SelectedItems[0].Text);
                hienThiChiTietHoaDon(selectdReceptId);
            }
        }

        private void lsvVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvVendor.SelectedItems.Count > 0)
            {
                int selectdReceptId = Convert.ToInt32(lsvVendor.SelectedItems[0].Text);
                hienThiChiTietHoaDon(selectdReceptId);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ngayBD = DateTime.Parse(dtpBDNCC.Text);
            ngayKT = DateTime.Parse(dtpKTNCC.Text);
            if (checkDate())
            {
                foreach (ListViewItem lvt in lsvVendor.Items)
                {
                    ngayLapHD = DateTime.Parse(lvt.SubItems[5].Text);
                    if (ngayBD > ngayLapHD || ngayKT < ngayLapHD)
                    {
                        lsvVendor.Items.Remove(lvt);
                    }
                }
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ngayBD = DateTime.Now;
            dtpNgayBD.Text = DateTime.Now.ToString();
            ngayKT = DateTime.Now;
            dtpNgayKT.Text = DateTime.Now.ToString();
            hienThiNhaCungCap();
        }

        bool checkDate()
        {
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
