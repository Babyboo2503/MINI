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

namespace MINI.GUI
{
    public partial class DangNhap : Form
    {
        TaiKhoanBUS taikhoan_bus = new TaiKhoanBUS();
        public DangNhap()
        {
            InitializeComponent();
        }
        
        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
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
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0 || txtUsername.Text.Length == 0)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu đang để trống");
            }
            else
            {
                if (taikhoan_bus.findAccount(txtUsername.Text, txtPassword.Text))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    trangChu trangchu = new trangChu(PhanQuyenBUS.DangNhap(txtUsername.Text,txtPassword.Text), txtUsername.Text,txtPassword.Text);
                    trangchu.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ");
                }
            }

        }
        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
