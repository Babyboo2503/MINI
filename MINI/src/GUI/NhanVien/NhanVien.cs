using MINI.src.BUS;
using MINI.src.DTO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MINI.GUI
{
    public partial class NhanVien : Form
    {
        NhanVienBUS nv_bus = new NhanVienBUS();
        TaiKhoanBUS tk_bus = new TaiKhoanBUS();
        ChucVuBUS cv_bus=new ChucVuBUS();
        public string Username, Password;
        public NhanVien(string Username, string Password)
        {
            
            this.Username = Username;
            this.Password = Password;
           
            InitializeComponent();
        }

        /////////NHÂN VIÊN////////////////
        void HienthiDanhSachNhanVien()
        {
            DataTable dt = nv_bus.LayDSNhanVien();
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
            }
            else
            {
                btnSuaNV.Visible = true;
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
            else if (cbbTrangThaiCTNV.SelectedText == "Thôi Việc")
            {
                DTPNgayNghiCTNV.Visible = true;
            }
            //////////BUG
        }
        private void setDataSuaNV()
        {
            setStateEdit();
            txtIDNhanVienCTNV.Text = txtIDNhanVienNV.Text;
            txtHoVaTenCTNV.Text = txtHoVaTenNV.Text;
            txtSDTCTNV.Text = txtSDTNV.Text;
            txtGioiTinhCTNV.Text = txtGioiTinhNV.Text;
            //CBB id chức vụ
            setCBBChucVu(cbbIDChucVuCTNV);
            cbbIDChucVuCTNV.SelectedItem = txtIDChucVuNV.Text;
            txtLuongCTNV.Text = txtLuongNV.Text;
            cbbTrangThaiCTNV.SelectedItem = txtTrangThaiNV.Text;
            DTPNgaySinhCTNV.Value = DTPNgaySinhNV.Value;
            txtDiaChiCTNV.Text = txtDiaChiNV.Text;
        }
        public void setCBBChucVu(ComboBox x)
        {
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
            if (nv_bus.checkButtonSave(txtIDNhanVienCTNV.Text))
            {
                try
                {
                    nv_bus.UpdateNV(txtIDNhanVienCTNV.Text, txtHoVaTenCTNV.Text, txtDiaChiCTNV.Text, txtSDTCTNV.Text, txtGioiTinhCTNV.Text, cbbIDChucVuCTNV.Text, txtLuongCTNV.Text, cbbTrangThaiCTNV.Text, DTPNgaySinhCTNV.Text, DTPNgayNghiCTNV.Text);
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
                    nv_bus.InsertNV(txtHoVaTenCTNV.Text, txtDiaChiCTNV.Text, txtSDTCTNV.Text, txtGioiTinhCTNV.Text, cbbIDChucVuCTNV.Text, txtLuongCTNV.Text, "Đang Làm", DTPNgaySinhCTNV.Text);
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

            listViewNhanVien.Items.Clear();
            HienthiDanhSachNhanVien();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabNhanVien.SelectedTab = tabSuaThemNhanVien;
            setDataNhanVienMoi();
        }
        public void setDataNhanVienMoi()
        {
            DataTable dt = nv_bus.LayDSNhanVien();
            txtIDNhanVienCTNV.Text = (dt.Rows.Count + 1).ToString();
            txtHoVaTenCTNV.Text=string.Empty;
            txtSDTCTNV.Text = string.Empty;
            txtGioiTinhCTNV.Text= string.Empty;
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
                txtIDTaiKhoanNV.Text = dt.Rows[0][0].ToString();
                txtUsernameNV.Text = dt.Rows[0][2].ToString();
                txtPasswordNV.Text = dt.Rows[0][3].ToString();
                txtQuyenNV.Text = dt.Rows[0][4].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Nhân viên chưa có tài khoản, thêm tài khoản?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            HienthiDanhSachNhanVien();
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

        private void btnSuaTKNV_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tabNhanVien.SelectedTab = tabThongTinNhanVien;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelTaiKhoan.Visible = false;
            panelInfo.Visible = true;
            pictureBoxInfo.Visible = true;
        }




    }

}

