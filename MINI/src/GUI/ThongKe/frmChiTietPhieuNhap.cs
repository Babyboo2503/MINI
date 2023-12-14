using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINI.src.GUI
{
    public partial class frmChiTietPhieuNhap : Form
    {
        DataTable dtCTPN;
        public frmChiTietPhieuNhap(DataTable dtCTPN)
        {
            InitializeComponent();
            this.dtCTPN = dtCTPN;
        }

        void hienThiChiTietPhieuNhap()
        {
            for (int i = 0; i < dtCTPN.Rows.Count; i++)
            {
                ListViewItem lvi = lvInvoiceDetails.Items.Add(dtCTPN.Rows[i][0].ToString());
                lvi.SubItems.Add(dtCTPN.Rows[i][1].ToString());
                lvi.SubItems.Add(dtCTPN.Rows[i][2].ToString());
                lvi.SubItems.Add(dtCTPN.Rows[i][3].ToString());
                lvi.SubItems.Add(dtCTPN.Rows[i][4].ToString());
            }
        }

        private void frmChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            hienThiChiTietPhieuNhap();
        }
    }
}
