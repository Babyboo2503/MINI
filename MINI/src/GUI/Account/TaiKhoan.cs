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

namespace MINI.src.GUI
{
    public partial class TaiKhoan : Form
    {
        NhanVienBUS nv_bus = new NhanVienBUS();
        TaiKhoanBUS tk_bus = new TaiKhoanBUS();
        ChucVuBUS cv_bus = new ChucVuBUS();
        public string Username, Password;
        DataTable dt;
        public TaiKhoan(string user, string pass)
        {
            this.Username = user;
            this.Password = pass;
            InitializeComponent();
        }

        void HienthiDanhSachTaiKhoan()
        {

            dt = tk_bus.LayDSTaiKhoan();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lviTK = listViewTaiKhoan.Items.Add(dt.Rows[i][0].ToString());
                lviTK.SubItems.Add(dt.Rows[i][1].ToString());
                DataTable dtChucVu = cv_bus.LayChucVuNhanVien(dt.Rows[i][1].ToString());
                lviTK.SubItems.Add(dtChucVu.Rows[0][0].ToString());
                lviTK.SubItems.Add(dtChucVu.Rows[0][1].ToString());
                lviTK.SubItems.Add(dt.Rows[i][3].ToString());
                lviTK.SubItems.Add(dt.Rows[i][4].ToString());
                lviTK.SubItems.Add(dt.Rows[i][2].ToString());
            }
        }

        private void listViewTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTaiKhoan.SelectedIndices.Count > 0)
            {
                txtIDTaiKhoanTK.Text = listViewTaiKhoan.SelectedItems[0].SubItems[0].Text;
                txtIDNhanVienTK.Text = listViewTaiKhoan.SelectedItems[0].SubItems[1].Text;
                txtHoVaTenTK.Text = listViewTaiKhoan.SelectedItems[0].SubItems[2].Text;
                txtIDChucVuTK.Text = listViewTaiKhoan.SelectedItems[0].SubItems[3].Text;
                dt = cv_bus.getChucVu(txtIDChucVuTK.Text);
                lblChucVuTK.Text = dt.Rows[0][0].ToString();
                txtUsernameTK.Text = listViewTaiKhoan.SelectedItems[0].SubItems[4].Text;
                txtPasswordTK.Text = listViewTaiKhoan.SelectedItems[0].SubItems[5].Text;
                txtQuyenTK.Text = listViewTaiKhoan.SelectedItems[0].SubItems[6].Text;
                btnSuaTaiKhoan.Visible = true;
            }
            if(txtIDNhanVienTK.Text=="1" && Username!="admin")
            {
                btnSuaTaiKhoan.Visible = false;
            }
            else
            {
                btnSuaTaiKhoan.Visible=true;
            }
        }
        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            tabTaiKhoan.SelectedTab = tabThemSuaTaiKhoan;
            setDataSuaTaiKhoan();
        }
        public void setCBBChucVu(ComboBox x)
        {
            dt = cv_bus.LayDSChucVu();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                x.Items.Add(dt.Rows[i][0]);
            }
        }
        public void setChecklistNull(CheckedListBox x)
        {
            for(int i = 0; i < x.Items.Count; i++)
            {
                x.SetItemChecked(i, false);
            }
        }
        public void setDataSuaTaiKhoan()
        {
            txtIDTaiKhoanTSTK.Text = txtIDTaiKhoanTK.Text;
            txtHoVaTenTSTK.Text=txtHoVaTenTK.Text;
            CBBIDNhanVienTSTK.Text=txtIDNhanVienTK.Text;
            CBBIDNhanVienTSTK.Enabled = false;
            txtIDChucVuTSTK.Text = txtIDChucVuTK.Text;
            dt = cv_bus.getChucVu(txtIDChucVuTSTK.Text);
            lblChucVuTSTK.Text = dt.Rows[0][0].ToString();
            txtUsernameTSTK.Text= txtUsernameTK.Text;
            txtPasswordTSTK.Text= txtPasswordTK.Text;
            setChecklistNull(checkedListBoxQuyenTK);
            tachQuyen();
        }
        public void tachQuyen()
        {
            bool[] quyen=tk_bus.fillQuyen(txtQuyenTK.Text);
            for(int i = 0; i < quyen.Length; i++)
            {
                if (quyen[i] == true)
                {
                    checkedListBoxQuyenTK.SetItemChecked(i, true);
                }
            }
        }

        /////////CHỨC VỤ//////////////////////
/*        void HienthiDanhSachChucVu()
        {
            dt = cv_bus.LayDSChucVu();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lviCV = listViewChucVu.Items.Add(dt.Rows[i][0].ToString());
                lviCV.SubItems.Add(dt.Rows[i][1].ToString());
            }
        }*/

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            HienthiDanhSachTaiKhoan();
            btnSuaTaiKhoan.Visible = false;
        }

        private void btnReloadTaiKhoan_Click(object sender, EventArgs e)
        {
            listViewTaiKhoan.Items.Clear();
            HienthiDanhSachTaiKhoan();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabTaiKhoan.SelectedTab = tabThongTinTaiKhoan;
        }

        private void btnLuuTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtIDTaiKhoanTSTK.Text == txtIDTaiKhoanTK.Text)
            {
                try
                {
                    tk_bus.UploadTK(txtIDTaiKhoanTSTK.Text, CBBIDNhanVienTSTK.Text, txtUsernameTSTK.Text, txtPasswordTSTK.Text, checkedListBoxQuyenTK);
                    MessageBox.Show("Lưu thành công!");
                }catch (Exception)
                {
                    MessageBox.Show("Lưu không thành công!");
                }

            }
            else
            {
                try
                {
                    tk_bus.InsertTK(txtIDTaiKhoanTSTK.Text, CBBIDNhanVienTSTK.Text, txtUsernameTSTK.Text, txtPasswordTSTK.Text, checkedListBoxQuyenTK);
                MessageBox.Show("Thêm mới thành công!");
            }
                catch (Exception)
                {
                MessageBox.Show("Thêm mới không thành công!");
            }
                tabTaiKhoan.SelectedTab = tabThongTinTaiKhoan;
        }
        }
        public void setCBBIDNhanVienTSTK()
        {
            dt = nv_bus.layDSIDNhanVienChuaCoTK();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                CBBIDNhanVienTSTK.Items.Add(dt.Rows[i][0].ToString());
            }
        }
        public void setNULLThemNV()
        {
            txtIDTaiKhoanTSTK.Text = null;
            txtHoVaTenTSTK.Text = null;
            CBBIDNhanVienTSTK.Text = null;
            txtIDChucVuTSTK.Text = null;
            txtUsernameTSTK.Text = null;
            txtPasswordTSTK.Text = null;
            setChecklistNull(checkedListBoxQuyenTK);
            lblChucVuTSTK.Text= null;
        }
        public void setDataThemTaiKhoan()
        {
            setNULLThemNV();
            dt= tk_bus.LayDSTaiKhoan();
            txtIDTaiKhoanTSTK.Text = (dt.Rows.Count + 1).ToString();
            CBBIDNhanVienTSTK.Enabled = true;
            setCBBIDNhanVienTSTK();

        }
        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            tabTaiKhoan.SelectedTab = tabThemSuaTaiKhoan;
            setDataThemTaiKhoan();
        }

        private void CBBIDNhanVienTSTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = nv_bus.layNhanVienDuaVaoID(CBBIDNhanVienTSTK.Text);
            txtHoVaTenTSTK.Text = dt.Rows[0][1].ToString();
            txtIDChucVuTSTK.Text = dt.Rows[0][4].ToString();
            dt = cv_bus.getChucVu(txtIDChucVuTSTK.Text);
            lblChucVuTSTK.Text = dt.Rows[0][0].ToString();
        }

        private void tabTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabTaiKhoan.SelectedTab = tabThongTinTaiKhoan;
        }

/*        private void btnXemChucVu_Click(object sender, EventArgs e)
        {
            lblTittleCV.Visible = true;
            btnSuaChucVu.Visible = true;
            listViewChucVu.Visible = true;
            HienthiDanhSachChucVu();
        }*/



    }
}
