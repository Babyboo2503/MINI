using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINI.GUI.BanHang
{
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'miniMarketDataSet1.KhuyenMai' table. You can move, or remove it, as needed.
            this.khuyenMaiTableAdapter.Fill(this.miniMarketDataSet1.KhuyenMai);
            // TODO: This line of code loads data into the 'miniMarketDataSet1.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.miniMarketDataSet1.KhachHang);
            // TODO: This line of code loads data into the 'miniMarketDataSet1.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.miniMarketDataSet1.NhanVien);

        }
    }
}
