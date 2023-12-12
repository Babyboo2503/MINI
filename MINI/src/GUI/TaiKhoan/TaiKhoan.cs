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

namespace MINI.src.GUI.TK
{
    public partial class TaiKhoan : Form
    {
        NhanVienBUS nv_bus = new NhanVienBUS();
        TaiKhoanBUS tk_bus = new TaiKhoanBUS();
        ChucVuBUS cv_bus = new ChucVuBUS();
        public string Username, Password;
        public TaiKhoan()
        {
            InitializeComponent();
        }

        void HienthiDanhSachTaiKhoan()
        {

            DataTable dt = tk_bus.LayDSTaiKhoan();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lviTK = listViewTaiKhoan.Items.Add(dt.Rows[i][0].ToString());
                lviTK.SubItems.Add(dt.Rows[i][1].ToString());
                DataTable dtChucVu = cv_bus.LayChucVuNhanVien(dt.Rows[i][1].ToString());
                lviTK.SubItems.Add(dtChucVu.Rows[0][0].ToString());
                lviTK.SubItems.Add(dtChucVu.Rows[0][1].ToString());
                lviTK.SubItems.Add(dt.Rows[i][2].ToString());
                lviTK.SubItems.Add(dt.Rows[i][3].ToString());
                lviTK.SubItems.Add(dt.Rows[i][4].ToString());
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
                DataTable dt = cv_bus.getChucVu(txtIDChucVuTK.Text);
                lblChucVuTK.Text = dt.Rows[0][0].ToString();
                txtUsernameTK.Text = listViewTaiKhoan.SelectedItems[0].SubItems[4].Text;
                txtPasswordTK.Text = listViewTaiKhoan.SelectedItems[0].SubItems[5].Text;
                txtQuyenTK.Text = listViewTaiKhoan.SelectedItems[0].SubItems[6].Text;
            }
        }
        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            tabTaiKhoan.SelectedTab = tabThemSuaTaiKhoan;
            setDataSuaTaiKhoan();
        }
        public void setCBBChucVu(ComboBox x)
        {
            DataTable dt = cv_bus.LayDSChucVu();
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
            txtIDNhanVienTSTK.Text=txtIDNhanVienTK.Text;
            setCBBChucVu(cbbIDChucVuTSTK);
            cbbIDChucVuTSTK.SelectedItem = txtIDChucVuTK.Text;
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
        void HienthiDanhSachChucVu()
        {
            DataTable dt = cv_bus.LayDSChucVu();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lviCV = listViewChucVu.Items.Add(dt.Rows[i][0].ToString());
                lviCV.SubItems.Add(dt.Rows[i][1].ToString());
            }
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            HienthiDanhSachTaiKhoan();
        }

        private void btnXemChucVu_Click(object sender, EventArgs e)
        {
            lblTittleCV.Visible = true;
            btnSuaChucVu.Visible = true;
            listViewChucVu.Visible = true;
            HienthiDanhSachChucVu();
        }



    }
}
