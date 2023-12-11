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
        public ChiTietPhieuNhapGUI()
        {
            InitializeComponent();
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
            HienThiCTPhieuNhap();
        }

        private void btnlammoictpn_Click(object sender, EventArgs e)
        {
            HienThiCTPhieuNhap();
            txtsearchctpn.Text = "";
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            TimKiemTheoMaPhieuNhap(txtsearchctpn.Text);
        }
    }
}
