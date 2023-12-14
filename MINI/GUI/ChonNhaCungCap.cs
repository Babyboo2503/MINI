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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MINI.src.GUI.PhieuNhap
{
    public partial class ChonNhaCungCap : Form
    {
        PhieuNhapBUS ncc = new PhieuNhapBUS();
        public string SelectedData { get; private set; }
        public ChonNhaCungCap()
        {
            InitializeComponent();
        }

        public void HienThiNCC()
        {
            lsvchonncc.Items.Clear();
            DataTable dt = ncc.LayDSNCC();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvchonncc.Items.Add(dt.Rows[i][0].ToString()); lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
            }

        }

        void TimKiemTheoTenNCC(string tenNCC)
        {
            lsvchonncc.Items.Clear();
            DataTable dt = ncc.LayDSNCCTheoTenNCC(tenNCC); // Giả sử có một phương thức để lấy chi tiết nhập hàng dựa trên mã
                                                           // Điền dữ liệu vào ListView
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // Thêm dữ liệu vào ListView
                ListViewItem lvi =
                 lsvchonncc.Items.Add(dt.Rows[i][0].ToString()); lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
            }
        }

        public void UpdateButtonVisibility(bool isVisible)
        {
            btnthemncc.Visible = isVisible;
            btnsuancc.Visible = isVisible;
            btnxoancc.Visible = isVisible;
        }

        private void ChonNhaCungCap_Load(object sender, EventArgs e)
        {
            txtsearchncc_Leave(sender, e);
            HienThiNCC();
        }

        private void btntimkiemncc_Click(object sender, EventArgs e)
        {
            TimKiemTheoTenNCC(txtsearchncc.Text);
        }

        private void btnlammoincc_Click(object sender, EventArgs e)
        {
            HienThiNCC();
            txtsearchncc.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            if (lsvchonncc.SelectedItems.Count > 0)
            {
                this.DialogResult = DialogResult.OK; // Thay đổi DialogResult của Form 2 thành OK khi người dùng chọn dữ liệu và click buttonSelect
                this.Close(); // Đóng Form 2 sau khi chọn dữ liệu
            }
        }

        private void lsvchonncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvchonncc.SelectedItems.Count > 0)
            {
                SelectedData = lsvchonncc.SelectedItems[0].SubItems[0].Text; // Lưu giá trị được chọn từ ListView vào SelectedData
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(lsvchonncc.SelectedItems.Count > 0)
            {
                string idncc = lsvchonncc.SelectedItems[0].SubItems[0].Text;
                string tenNCC = lsvchonncc.SelectedItems[0].SubItems[1].Text;
                string diaChi = lsvchonncc.SelectedItems[0].SubItems[2].Text;
                string SDT = lsvchonncc.SelectedItems[0].SubItems[3].Text;
                ThemNCC themncc = new ThemNCC();
                themncc.UpdateButtonVisibility(false);
                themncc.UpdateIdnccValue(idncc);
                themncc.UpdateDiaChiNCCValue(diaChi);
                themncc.UpdateTenNCCValue(tenNCC);
                themncc.UpdateSDTNCCnccValue(SDT);
                themncc.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Nhà Cung Cấp cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemNCC themncc = new ThemNCC();
            themncc.Controls["btnSua"].Visible = false;
            themncc.Show();
        }

        private void button3_Leave(object sender, EventArgs e)
        {

        }

        private void txtsearchncc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsearchncc_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsearchncc.Text))
            {
                txtsearchncc.Text = "Tên Nhà Cung Cấp ";
                txtsearchncc.ForeColor = Color.DimGray;
            }
        }

        private void txtsearchncc_Click(object sender, EventArgs e)
        {
            txtsearchncc.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lsvchonncc.SelectedItems.Count > 0)
            {
                string maNCC = lsvchonncc.SelectedItems[0].SubItems[0].Text;
                ncc.XoaNCC(maNCC);

                // Xóa mục đã chọn từ ListView
                lsvchonncc.SelectedItems[0].Remove();
            }
        }

        private void txttenncc_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChonNhaCungCap_Activated(object sender, EventArgs e)
        {
            HienThiNCC();
        }
    }
}
