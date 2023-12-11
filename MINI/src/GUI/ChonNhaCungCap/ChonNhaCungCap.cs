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
    public partial class ChonNhaCungCap : Form
    {
        PhieuNhapBUS ncc = new PhieuNhapBUS();

        public ChonNhaCungCap()
        {
            InitializeComponent();
        }

        void HienThiNCC()
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

        private void ChonNhaCungCap_Load(object sender, EventArgs e)
        {
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

        }
    }
}
