using MINI.src.BUS;
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

namespace MINI.GUI
{
    public partial class NhanVien : Form
    {
        NhanVienBUS nv_bus=new NhanVienBUS();
        TaiKhoanBUS tk_bus= new TaiKhoanBUS();
        
        public NhanVien()
        {
            InitializeComponent();
        }
 

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabNhanVien.SelectedTab = tabSuaThemNhanVien;
        }


        private void nhanVienDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelChucVu.Text = nv_bus.findChucVu(Convert.ToInt32(txtIDChucVuNV.Text));
            if (txtTrangThaiNV.Text == "Đang Làm")
            {
                DTPNgayNghiNV.Visible = false;
                lblNull.Visible = true;
            }
            if(txtTrangThaiNV.Text=="Thôi Việc")
            {
                DTPNgayNghiNV.Visible = true;
                lblNull.Visible = false;
            }
        }
        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            panelSuaTaiKhoan.Visible = true;
        }

        private void tabThongTinTaiKhoan_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            panelTaiKhoan.Visible = false;
            panelInfo.Visible = true;
            pictureBoxInfo.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabNhanVien.SelectedTab = tabSuaThemNhanVien;
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
            if (txtIDNhanVienNV.Text == "1")
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
            else if(cbbTrangThaiCTNV.SelectedText=="Thôi Việc")
            {
                DTPNgayNghiCTNV.Visible=true;
            }
            //////////BUG
        }
        private void setDataSuaNV()
        {
            setStateEdit();
            txtIDNhanVienCTNV.Text = txtIDNhanVienNV.Text;
            txtHoVaTenCTNV.Text=txtHoVaTenNV.Text;
            txtSDTCTNV.Text = txtSDTNV.Text;
            txtGioiTinhCTNV.Text=txtGioiTinhNV.Text;
            //CBB id chức vụ
            DataTable dt = nv_bus.LayDSChucVu();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbbIDChucVuCTNV.Items.Add(dt.Rows[i][0]);
            }
            cbbIDChucVuCTNV.SelectedItem=txtIDChucVuNV.Text;
            txtLuongCTNV.Text=txtLuongNV.Text;
            cbbTrangThaiCTNV.SelectedItem=txtTrangThaiNV.Text;
            DTPNgaySinhCTNV.Value = DTPNgaySinhNV.Value;
            txtDiaChiCTNV.Text=txtDiaChiNV.Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setDataSuaNV();
            tabNhanVien.SelectedTab = tabSuaThemNhanVien;
        }

        /////////TÀI KHOẢN/////////////////
        void HienthiDanhSachTaiKhoan()
        {
            DataTable dt = tk_bus.LayDSTaiKhoan();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lviTK =listViewTaiKhoan.Items.Add(dt.Rows[i][0].ToString());
                lviTK.SubItems.Add(dt.Rows[i][1].ToString());
                lviTK.SubItems.Add(dt.Rows[i][2].ToString());
                lviTK.SubItems.Add(dt.Rows[i][3].ToString());
                lviTK.SubItems.Add(dt.Rows[i][4].ToString());
            }
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
                MessageBox.Show("Nhân viên chưa có tài khoản, thêm tài khoản?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            }
        }
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

        /////////FORM/////////////////////////
        private void NhanVien_Load(object sender, EventArgs e)
        {
            HienthiDanhSachTaiKhoan();
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
/*            labelChucVu.Text = nv_bus.findChucVu(Convert.ToInt32(txtIDChucVuNV.Text));*/

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                nv_bus.UpdateNV(txtIDNhanVienCTNV.Text, txtHoVaTenCTNV.Text, txtDiaChiCTNV.Text, txtGioiTinhCTNV.Text, cbbIDChucVuCTNV.Text, txtLuongCTNV.Text, cbbTrangThaiCTNV.Text, DTPNgaySinhCTNV.Text, DTPNgayNghiCTNV.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu không thành công");
            }
            
        }
    }

    }

