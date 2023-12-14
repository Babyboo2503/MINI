using MINI.src.BUS;
using MINI.src.DTO;
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
    public partial class PhieuNhapGUI : Form
    {
        PhieuNhapBUS pn = new PhieuNhapBUS();
        public PhieuNhapGUI()
        {
            InitializeComponent();
        }

        void HienThiPhieuNhap()
        {
            lsvpn.Items.Clear();
            DataTable dt = pn.LayDSPN();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvpn.Items.Add(dt.Rows[i][0].ToString()); lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }

        }
        void TimKiemTheoMaPhieuNhap(string maPhieuNhap)
        {
            lsvpn.Items.Clear();
            DataTable dt = pn.LayDSPNTheoMaPhieuNhap(maPhieuNhap); // Giả sử có một phương thức để lấy chi tiết nhập hàng dựa trên mã
                                                                       // Điền dữ liệu vào ListView
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvpn.Items.Add(dt.Rows[i][0].ToString()); lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }

        void TimKiemTheoKhoangThoiGian(DateTime startDate,DateTime endDate)
        {
            lsvpn.Items.Clear();
            DataTable dt = pn.LayDSPNTheoKhoangThoiGian(startDate,endDate); // Giả sử có một phương thức để lấy chi tiết nhập hàng dựa trên mã
                                                                   // Điền dữ liệu vào ListView
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvpn.Items.Add(dt.Rows[i][0].ToString()); lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }

        void TimKiemTheoKhoangTongTien(decimal startTotal,decimal endTotal)
        {
            lsvpn.Items.Clear();
            DataTable dt = pn.LayDSPNTheoKhoangTongTien(startTotal, endTotal); // Giả sử có một phương thức để lấy chi tiết nhập hàng dựa trên mã
                                                                             // Điền dữ liệu vào ListView
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvpn.Items.Add(dt.Rows[i][0].ToString()); lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }

        private void PhieuNhapGUI_Load(object sender, EventArgs e)
        {
            
            txttongtien1.Text = "0";
            txttongtien2.Text = "0";
            HienThiPhieuNhap();
        }

        private void grbktg_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lsvpn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvpn.SelectedIndices.Count > 0)
            {
                txtidphieunhap.Text = lsvpn.SelectedItems[0].SubItems[0].Text;
                txtidnhanvien.Text = lsvpn.SelectedItems[0].SubItems[1].Text;
                txtidncc.Text = lsvpn.SelectedItems[0].SubItems[2].Text;
                txtngaynhap.Text = lsvpn.SelectedItems[0].SubItems[3].Text;
                txttongtien.Text = lsvpn.SelectedItems[0].SubItems[4].Text;

            }
        }

        private void btnchitietphieunhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidphieunhap.Text))
            {
                MessageBox.Show("Vui lòng chọn một mục để Xem Chi Tiết Phiếu Nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string maPhieuNhap = txtidphieunhap.Text;
                ChiTietPhieuNhapGUI ctpn = new ChiTietPhieuNhapGUI(maPhieuNhap);
                ctpn.Show();
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            HienThiPhieuNhap();
            txttimkiem.Text = "";
            txtidphieunhap.Text = "";
            txtngaynhap.Text = "";
            txtidnhanvien.Text = "";
            txtidncc.Text = "";
            txttongtien.Text = "";
            txttongtien1.Text = "0";
            txttongtien2.Text = "0";

        }

        private void txttimkiempn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttimkiem.Text) || !txttimkiem.Text.All(char.IsDigit))
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TimKiemTheoMaPhieuNhap(txttimkiem.Text);
            }
        }

        private void dtpktg2_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpktg1.Value;
            DateTime endDate = dtpktg2.Value;
            TimKiemTheoKhoangThoiGian(startDate, endDate);
        }

        private void dtpktg1_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpktg1.Value;
            DateTime endDate = dtpktg2.Value;
            TimKiemTheoKhoangThoiGian(startDate, endDate);
        }

        private void txttongtien1_Enter(object sender, EventArgs e)
        {
            
            
        }

        private void txttongtien1_TextChanged(object sender, EventArgs e)
        {
            string Total1 = txttongtien1.Text;
            string Total2 = txttongtien2.Text;
            decimal startTotal, endTotal;

            if (decimal.TryParse(Total1, out startTotal) && decimal.TryParse(Total2, out endTotal))
            {
                TimKiemTheoKhoangTongTien(startTotal, endTotal);
            }
            else if(string.IsNullOrEmpty(Total1) && string.IsNullOrEmpty(Total2) || !txttongtien1.Text.All(char.IsDigit) && !txttongtien2.Text.All(char.IsDigit))
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txttongtien2_TextChanged(object sender, EventArgs e)
        {
            string Total1 = txttongtien1.Text;
            string Total2 = txttongtien2.Text;
            decimal startTotal, endTotal;

            if (decimal.TryParse(Total1, out startTotal) && decimal.TryParse(Total2, out endTotal))
            {
                TimKiemTheoKhoangTongTien(startTotal, endTotal);
            }
            else if (string.IsNullOrEmpty(Total1) && string.IsNullOrEmpty(Total2) || !txttongtien1.Text.All(char.IsDigit) && !txttongtien2.Text.All(char.IsDigit))
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttimkiem.Text))
            {
                txttimkiem.Text = "Tên Nhà Cung Cấp ";
                txttimkiem.ForeColor = Color.DimGray;
            }
        }

        private void txttimkiem_Click(object sender, EventArgs e)
        {
            txttimkiem.Clear();
        }
    }
}
