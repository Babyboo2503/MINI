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
        public trangChu()
        {
            InitializeComponent();
            customizeDesign();
        }
        //Design left menu
        private void DisableHorizontalScroll()
        {
            // Bỏ kích thước thanh cuộn ngang
            flowPanelMenuLeft.HorizontalScroll.Enabled = false;
/*            panelLeftMenu.AutoScroll = true;*/
        }
        public void customizeDesign()
        {
            panelNhanVien.Visible=false;
            panelKhachHang.Visible=false;
            panelHoaDon.Visible=false;
            btnSanPham.Visible=false;
        }
        private void hideSubmenu()
        {
            if(panelHoaDon.Visible==true)
                panelHoaDon.Visible=false;
            if(btnSanPham.Visible==true)
                btnSanPham.Visible=false;
            if(panelKhachHang.Visible==true)
                panelKhachHang.Visible = false;
            if(panelNhanVien.Visible==true)
                panelNhanVien.Visible = false;
        }
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        //      Tạo chức năng cho button nhân viên

        private NhanVien nv;
        //      Load form NhanVien
        private void loadFormNV()
        {
            if (nv == null || nv.IsDisposed)
            {
                // Nếu chưa, tạo một instance mới
                nv = new GUI.NhanVien();

                // Đặt MainForm làm cha của ChildForm
                nv.TopLevel = false;

                // Đặt thuộc tính Dock của ChildForm thành Fill để lấp đầy toàn bộ Panel
                nv.Dock = DockStyle.Fill;

                // Thêm ChildForm vào Panel
                panelContent.Controls.Add(nv);
                nv.Dock = DockStyle.Fill;
                

                // Hiển thị ChildForm
                nv.Show();
            }
            else
            {
                // Nếu đã mở, đưa ChildForm lên trước cùng
                nv.BringToFront();
            }
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            showSubmenu(panelNhanVien);
            loadFormNV();
        }
        private void btnNhanVienThem_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSanPham);
            loadFormNV();
        }

        private void btnSanPhamThem_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private void btnNhanVienDanhSach_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private void btnSanPhamDanhSach_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private void btnHoaDonLichSu_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private void btnHoaDonThem_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private void btnKhachHangDanhSach_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private void btnKhachHangThem_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            showSubmenu(panelKhachHang);
            //..
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            showSubmenu(panelHoaDon);
            //..
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            showSubmenu(panelBaoCao);
            //..
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            showSubmenu(panelPhieuNhap);
            //..
        }

        private void btnPhieuNhapThem_Click(object sender, EventArgs e)
        {

        }

        private void btnPhieuNhapLichSu_Click(object sender, EventArgs e)
        {

        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            showSubmenu(panelKhuyenMai);
            //..
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            showSubmenu(panelThongKe);
            //..
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            showSubmenu(panelNhaCungCap);
            //..
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
