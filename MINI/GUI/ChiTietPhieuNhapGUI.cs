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

namespace MINI.src.GUI.PhieuNhap
{
    public partial class ChiTietPhieuNhapGUI : Form
    {
        PhieuNhapBUS ctpn = new PhieuNhapBUS();
        public string maPhieuNhap;
        public ChiTietPhieuNhapGUI(string maPhieuNhap)
        {
            InitializeComponent();
            this.maPhieuNhap = maPhieuNhap;
           /* TimKiemTheoMaPhieuNhap(maPhieuNhap);*/
        }


        void HienThiCTPhieuNhap()
        {
            lsvctpn.Items.Clear();
            DataTable dt = ctpn.LayDSCTPN();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvctpn.Items.Add(dt.Rows[i][0].ToString()); lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }

        }

        void TimKiemTheoMaPhieuNhap(string maPhieuNhap)
        {
            lsvctpn.Items.Clear();
            DataTable dt = ctpn.LayDSCTPNTheoMaPhieuNhap(maPhieuNhap); // Giả sử có một phương thức để lấy chi tiết nhập hàng dựa trên mã
                                                                       // Điền dữ liệu vào ListView
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // Thêm dữ liệu vào ListView
                ListViewItem lvi = lsvctpn.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString()); // Dòng này có vẻ bị lặp trong code gốc
            }
        }

        private void ChiTietPhieuNhapGUI_Load(object sender, EventArgs e)
        {
            TimKiemTheoMaPhieuNhap(maPhieuNhap);
        }

        private void btnlammoictpn_Click(object sender, EventArgs e)
        {
            HienThiCTPhieuNhap();
            txtsearchctpn.Text = "";
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsearchctpn.Text) || !txtsearchctpn.Text.All(char.IsDigit))
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TimKiemTheoMaPhieuNhap(txtsearchctpn.Text);
            }
        }

        private void txtsearchctpn_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsearchctpn.Text))
            {
                txtsearchctpn.Text = "Tên Nhà Cung Cấp ";
                txtsearchctpn.ForeColor = Color.DimGray;
            }
        }

        private void txtsearchctpn_Click(object sender, EventArgs e)
        {
            txtsearchctpn.Clear();
        }
    }
}
