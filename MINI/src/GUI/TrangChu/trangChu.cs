using MINI.src.GUI;
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
        private void ChangeButtonColor(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Thiết lập màu cho nút hiện tại
            clickedButton.BackColor = Color.LightBlue;
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
        public void openChildForm(Form childForm)
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

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            openChildForm(new KhuyenMai());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongKe());
            //..
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            openChildForm(new TaiKhoan(Username,Password));
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            openChildForm(new BanHang(Username,Password));
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            openChildForm(new NhapHangGUI(Username,Password));
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new SanPham(Username,Password));
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            openChildForm(new HoaDon());
        }
        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            openChildForm(new PhieuNhapGUI());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new KhachHang());
        }
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            openChildForm(new BaoCao(Username,Password));
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            openChildForm(new ChonNhaCungCap());
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
