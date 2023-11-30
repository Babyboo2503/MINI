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
        }
    }
}
