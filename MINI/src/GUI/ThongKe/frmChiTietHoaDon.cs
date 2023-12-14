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

namespace MINI.src.GUI
{
    public partial class frmChiTietHoaDon : Form
    {
        DataTable dtCTHD;
        public frmChiTietHoaDon(DataTable dtCTHD)
        {
            InitializeComponent();
            this.dtCTHD = dtCTHD;
        }

        void hienThiDanhSachChiTietHoaDon()
        {
            /*foreach (var cthd in dsChiTietHoaDon)
            {
                ListViewItem lvi = new ListViewItem(cthd.idHoaDon.ToString());
                lvi.SubItems.Add(cthd.idSanPham.ToString());
                lvi.SubItems.Add(cthd.soLuong.ToString());
                lvi.SubItems.Add(cthd.donGia.ToString());
                lvi.SubItems.Add(cthd.tongTien.ToString());

                lvInvoiceDetails.Items.Add(lvi);
            }*/
            for (int i = 0; i < dtCTHD.Rows.Count; i++)
            {
                ListViewItem lvi = lvInvoiceDetails.Items.Add(dtCTHD.Rows[i][0].ToString());
                lvi.SubItems.Add(dtCTHD.Rows[i][1].ToString());
                lvi.SubItems.Add(dtCTHD.Rows[i][2].ToString());
                lvi.SubItems.Add(dtCTHD.Rows[i][3].ToString());
                lvi.SubItems.Add(dtCTHD.Rows[i][4].ToString());
            }
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            hienThiDanhSachChiTietHoaDon();
        }
    }
}