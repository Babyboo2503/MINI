using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINI.src.GUI.NhapHang
{
    public partial class xuatPhieu : Form
    {
        string MaNCC, IDNhanVien, TongTien, idpn;
        string ThoiGian;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void xuatPhieu_Load(object sender, EventArgs e)
        {
            label7.Text = IDNhanVien;
            label8.Text = MaNCC;
            label9.Text = idpn;
            label10.Text = ThoiGian.ToString();
            panel1.Controls.Add(DSSP);
        }

        ListView DSSP;

        public string Text1 { get; }
        public string Text2 { get; }
        public string Text3 { get; }
        public ListView Lsvdsspnhap { get; }

        public xuatPhieu(string ID, string NCC, string Tien, string tg, ListView DSSP)
        {
            InitializeComponent();
            this.MaNCC = NCC;
            this.IDNhanVien = ID;
            this.TongTien = Tien;
            this.ThoiGian = tg;
            this.DSSP = DSSP;
        }

    }
}
