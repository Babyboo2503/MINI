using MINI.src.GUI.ThongKe;
using MINI.src.GUI.TK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINI.GUI
{
    public partial class trangChu : Form
    {
        private bool[] quyen;
        public string Username, Password;
        public trangChu(bool[] quyen, string Username, string Password)
        {
            InitializeComponent();
            this.quyen = quyen;
            this.Username=Username;
            this.Password = Password;
            show();
        }

        //
        private void show()
        {
            btnBanHang.Visible = quyen[0];
            btnNhapHang.Visible = quyen[1];
            btnNhanVien.Visible = quyen[2];
            btnSanPham.Visible = quyen[3];
            btnHoaDon.Visible = quyen[4];
            btnPhieuNhap.Visible = quyen[5];
            btnKhachHang.Visible = quyen[6];
            btnBaoCao.Visible = quyen[7];
            btnNhaCungCap.Visible = quyen[8];
            btnKhuyenMai.Visible = quyen[9];
            btnTaiKhoan.Visible = quyen[10];
            btnThongKe.Visible = quyen[11];
        }
        //

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        //Design left menu
        private void DisableHorizontalScroll()
        {
            // Bỏ kích thước thanh cuộn ngang
            flowPanelMenuLeft.HorizontalScroll.Enabled = false;
/*            panelLeftMenu.AutoScroll = true;*/
        }



        private NhanVien nv;
        //      Load form NhanVien

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new NhanVien(Username,Password));
        }
       
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            
        }


        private void btnKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {

        }


        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongKe());
            //..
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            openChildForm(new TaiKhoan());
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
