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

        private void PhieuNhapGUI_Load(object sender, EventArgs e)
        {
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
    }
}
