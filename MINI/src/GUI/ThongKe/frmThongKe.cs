using MINI.src.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINI.src.GUI.ThongKe
{
    public partial class frmThongKe : Form
    {
        ThongKeBUS thongKeBus = null;
        public frmThongKe()
        {
            thongKeBus = new ThongKeBUS();
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            lblTotalProduct.Text = thongKeBus.layDSSanPham().Count().ToString();
            lblTotalEmployee.Text = thongKeBus.layDSNhanVien().Count().ToString();
            lblTotalCustomer.Text = thongKeBus.layDSKhachHang().Count().ToString();
            lblTotalVendor.Text = thongKeBus.layDSNhaCungCap().Count().ToString();
            hienThiSanPham();
            hienThiNhanVien();
            hienThiKhachHang();
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
    }
}
