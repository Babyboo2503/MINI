using MINI.src.BUS;
using MINI.src.DTO;
using MINI.src.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MINI.src.GUI
{
    public partial class NhanVien : Form
    {
        NhanVienBUS nv_bus = new NhanVienBUS();
        TaiKhoanBUS tk_bus = new TaiKhoanBUS();
        ChucVuBUS cv_bus=new ChucVuBUS();
        DataTable dt;
        public string Username, Password;
        public NhanVien(string Username, string Password)
        {
            
            this.Username = Username;
            this.Password = Password;
           
            InitializeComponent();
        }

        /////////NHÂN VIÊN////////////////
        void HienthiDanhSachNhanVien(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lviNV = listViewNhanVien.Items.Add(dt.Rows[i][0].ToString());
                lviNV.SubItems.Add(dt.Rows[i][1].ToString());
                lviNV.SubItems.Add(dt.Rows[i][2].ToString());
                lviNV.SubItems.Add(dt.Rows[i][3].ToString());
                lviNV.SubItems.Add(dt.Rows[i][4].ToString());
                lviNV.SubItems.Add(dt.Rows[i][5].ToString());
                lviNV.SubItems.Add(dt.Rows[i][6].ToString());
                lviNV.SubItems.Add(dt.Rows[i][7].ToString());
                lviNV.SubItems.Add(dt.Rows[i][8].ToString());
                lviNV.SubItems.Add(dt.Rows[i][9].ToString());
            }
        }

        private void listViewNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNhanVien.SelectedIndices.Count > 0)
            {
                txtIDNhanVienNV.Text = listViewNhanVien.SelectedItems[0].SubItems[0].Text;
                txtHoVaTenNV.Text = listViewNhanVien.SelectedItems[0].SubItems[1].Text;
                txtDiaChiNV.Text = listViewNhanVien.SelectedItems[0].SubItems[9].Text;
                txtSDTNV.Text = listViewNhanVien.SelectedItems[0].SubItems[2].Text;
                txtGioiTinhNV.Text = listViewNhanVien.SelectedItems[0].SubItems[3].Text;
                txtIDChucVuNV.Text = listViewNhanVien.SelectedItems[0].SubItems[4].Text;
                labelChucVu.Text = cv_bus.findChucVu(txtIDChucVuNV.Text);
                txtLuongNV.Text = listViewNhanVien.SelectedItems[0].SubItems[5].Text;
                txtTrangThaiNV.Text = listViewNhanVien.SelectedItems[0].SubItems[6].Text;
                DTPNgaySinhNV.Value = DateTime.Parse(listViewNhanVien.SelectedItems[0].SubItems[8].Text);
                if (listViewNhanVien.SelectedItems[0].SubItems[7].Text.Length > 0)
                {
                    DTPNgayNghiNV.Value = DateTime.Parse(listViewNhanVien.SelectedItems[0].SubItems[7].Text);
                    lblNull.Visible = false;
                    DTPNgayNghiNV.Visible = true;
                }
                else
                {
                    lblNull.Visible = true;
                    DTPNgayNghiNV.Visible = false;
                }

            }
            
            if (txtIDNhanVienNV.Text=="1" && Username!="admin")
            {
                btnSuaNV.Visible = false;
                btnTaiKhoanNV.Visible = false;
            }
            else
            {
                btnSuaNV.Visible = true;
                btnTaiKhoanNV.Visible = true;
            }

        }
        void setStateEdit()
        {
            txtIDNhanVienCTNV.ReadOnly = true;
            if (txtTrangThaiNV.Text == "Đang Làm")
            {
                DTPNgayNghiCTNV.Enabled = false;
            }
            ///////////BUG
            else if (cbbTrangThaiCTNV.Text == "Thôi Việc")
            {
                DTPNgayNghiCTNV.Enabled = true;
            }
            //////////BUG
        }
        private void setDataSuaNV()
        {
            setStateEdit();
            txtIDNhanVienCTNV.Text = txtIDNhanVienNV.Text;
            txtHoVaTenCTNV.Text = txtHoVaTenNV.Text;
            txtSDTCTNV.Text = txtSDTNV.Text;
            cbbGioiTinhTSNV.Text = txtGioiTinhNV.Text;
            //CBB id chức vụ
            setCBBChucVu(cbbIDChucVuCTNV);
            cbbIDChucVuCTNV.Text = txtIDChucVuNV.Text;
            txtLuongCTNV.Text = txtLuongNV.Text;
            cbbTrangThaiCTNV.SelectedItem = txtTrangThaiNV.Text;
            DTPNgaySinhCTNV.Value = DTPNgaySinhNV.Value;
            txtDiaChiCTNV.Text = txtDiaChiNV.Text;
        }
        public void setCBBChucVu(System.Windows.Forms.ComboBox x)
        {
            x.Items.Clear();
            DataTable dt = cv_bus.LayDSChucVu();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                x.Items.Add(dt.Rows[i][0]);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            setDataSuaNV();
            tabNhanVien.SelectedTab = tabSuaThemNhanVien;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (nv_bus.checkButtonSave(txtIDNhanVienCTNV.Text)==true)
            {
                try
                {
                    nv_bus.UpdateNV(txtIDNhanVienCTNV.Text, txtHoVaTenCTNV.Text, txtDiaChiCTNV.Text, txtSDTCTNV.Text, cbbGioiTinhTSNV.Text, cbbIDChucVuCTNV.Text, txtLuongCTNV.Text, cbbTrangThaiCTNV.Text, DTPNgaySinhCTNV.Text, DTPNgayNghiCTNV.Text);
                    MessageBox.Show("Lưu thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Lưu không thành công");
                }
            }
            else
            {
                try
                {
                    nv_bus.InsertNV(txtHoVaTenCTNV.Text, txtDiaChiCTNV.Text, txtSDTCTNV.Text, cbbGioiTinhTSNV.Text, cbbIDChucVuCTNV.Text, txtLuongCTNV.Text, "Đang Làm", DTPNgaySinhCTNV.Text);
                    MessageBox.Show("Thêm thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }


        }
        private void btnReloadNV_Click(object sender, EventArgs e)
        {
            comboBoxLocTheo.SelectedItem = null;
            groupBoxTheoDKLoc.Text = null;
            cbbLocTheoDKLoc.Text = null;
            cbbLocTheoDKLoc.Items.Clear();
            listViewNhanVien.Items.Clear();
            HienthiDanhSachNhanVien(nv_bus.LayDSNhanVien());
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabNhanVien.SelectedTab = tabSuaThemNhanVien;
            lblChucVuNvThemSua.Text= string.Empty;
            setDataNhanVienMoi();
        }
        public void setDataNhanVienMoi()
        {
            DataTable dt = nv_bus.LayDSNhanVien();
            txtIDNhanVienCTNV.Text = (dt.Rows.Count + 1).ToString();
            txtHoVaTenCTNV.Text=string.Empty;
            txtSDTCTNV.Text = string.Empty;
            cbbGioiTinhTSNV.Text= string.Empty;
            cbbIDChucVuCTNV.Text = String.Empty;
            setCBBChucVu(cbbIDChucVuCTNV);
            txtLuongCTNV.Text = string.Empty;
            cbbTrangThaiCTNV.Enabled = false;
            cbbTrangThaiCTNV.Text = "Đang Làm";
            DTPNgayNghiCTNV.Enabled = false;
            DTPNgayNghiCTNV.Value=DateTime.Now;
            DTPNgaySinhCTNV.Value = DateTime.Now;
            //Thời gian
            txtDiaChiCTNV.Text = string.Empty;
        }

        void HienThiThongTinTaiKhoan()
        {
            try
            {
                DataTable dt = tk_bus.LayThongTinTaiKhoan(txtIDNhanVienNV.Text);
                txtIDTaiKhoanNVTK.Text = dt.Rows[0][0].ToString();
                txtUsernameNVTK.Text = dt.Rows[0][2].ToString();
                txtPasswordNVTK.Text = dt.Rows[0][3].ToString();
                txtQuyenNVTK.Text = dt.Rows[0][4].ToString();
            }
            catch (Exception)
            {
                ClearTK();
                MessageBox.Show("Nhân viên chưa có tài khoản","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.None);
                button1_Click(new object(),new EventArgs());
            }
        }
        /////////CHỨC VỤ//////////////////////

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            panelTaiKhoan.Visible = true;
            txtHoVaTenNVTK.Text = txtHoVaTenNV.Text;
            lblChucVuNVTK.Text = labelChucVu.Text;
            txtIDNhanVienNVTK.Text = txtIDNhanVienNV.Text;
            panelInfo.Visible = false;
            pictureBoxInfo.Visible = false;
            HienThiThongTinTaiKhoan();
        }
        private void cbbIDChucVuCTNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = cv_bus.getChucVu(cbbIDChucVuCTNV.SelectedItem.ToString());
            lblChucVuNvThemSua.Text = dt.Rows[0][0].ToString();

        }


        /////////FORM/////////////////////////
        private void NhanVien_Load(object sender, EventArgs e)
        {
            txtTimKiem_Leave(sender, e);
            HienthiDanhSachNhanVien(nv_bus.LayDSNhanVien());
            btnTaiKhoanNV.Visible = false;
            btnSuaNV.Visible = false;
            if (txtTrangThaiNV.Text == "Đang Làm")
            {
                DTPNgayNghiNV.Visible = false;
                lblNull.Enabled = true;
            }
            else
            {
                lblNull.Enabled = false;
            }
            

        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            tabNhanVien.SelectedTab = tabThongTinNhanVien;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                listViewNhanVien.Items.Clear();
                HienthiDanhSachNhanVien(nv_bus.TimKiemNhanVien(txtTimKiem.Text));
                
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy thông tin!");
            }
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
        }

        private void comboBoxLocTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbLocTheoDKLoc.Items.Clear();
            groupBoxTheoDKLoc.Text = null;
            cbbLocTheoDKLoc.Text = null;
            if (comboBoxLocTheo.SelectedIndex == 0)
            {
                groupBoxTheoDKLoc.Text = "Giới tính";
                cbbLocTheoDKLoc.Items.Add("Nam");
                cbbLocTheoDKLoc.Items.Add("Nữ");
            }
            if(comboBoxLocTheo.SelectedIndex == 1)
            {
                groupBoxTheoDKLoc.Text = "Chức vụ";
                cbbLocTheoDKLoc.Items.Add("Admin");
                cbbLocTheoDKLoc.Items.Add("Quản lí");
                cbbLocTheoDKLoc.Items.Add("Bán hàng");
                cbbLocTheoDKLoc.Items.Add("Thủ kho");
            }
            if (comboBoxLocTheo.SelectedIndex == 2)
            {
                groupBoxTheoDKLoc.Text = "Trạng thái";
                cbbLocTheoDKLoc.Items.Add("Đang Làm");
                cbbLocTheoDKLoc.Items.Add("Thôi Việc");
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Tên nhân viên";
                txtTimKiem.ForeColor = Color.DarkGray;
            }
        }
        public void ClearTK()
        {
            txtIDTaiKhoanNVTK.Text = string.Empty;
            txtIDNhanVienNVTK.Text = txtIDNhanVienNV.Text;
            txtHoVaTenNVTK.Text = txtHoVaTenNV.Text;
            txtUsernameNVTK.Text = string.Empty;
            txtPasswordNVTK.Text = string.Empty;
            txtQuyenNVTK.Text = string.Empty;
        }

        private void cbbLocTheoDKLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLocTheo.SelectedIndex == 0)
            {
                listViewNhanVien.Items.Clear();
                HienthiDanhSachNhanVien(nv_bus.locNVTheoGioiTinh(cbbLocTheoDKLoc.SelectedItem.ToString()));
            }
            if (comboBoxLocTheo.SelectedIndex == 1)
            {
                listViewNhanVien.Items.Clear();
                HienthiDanhSachNhanVien(nv_bus.locNVTheoChucVu(cbbLocTheoDKLoc.SelectedItem.ToString()));
            }
            if(comboBoxLocTheo.SelectedIndex == 2)
            {
                listViewNhanVien.Items.Clear();
                HienthiDanhSachNhanVien(nv_bus.locNVTheoTrangThai(cbbLocTheoDKLoc.SelectedItem.ToString()));
            }
        }

        private void tabNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            txtTimKiem.ForeColor = Color.Black;
            
        }

        private void cbbTrangThaiCTNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTrangThaiCTNV.SelectedIndex == 0)
            {
                DTPNgayNghiCTNV.Enabled = false;
            }
            else
            {
                DTPNgayNghiCTNV.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            panelTaiKhoan.Visible = false;
            panelInfo.Visible = true;
            pictureBoxInfo.Visible = true;
        }




    }

}

