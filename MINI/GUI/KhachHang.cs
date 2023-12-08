using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MINI.GUI
{
    public partial class KhachHang : Form
    {
        BUS.KhachHangBUS kh = new BUS.KhachHangBUS();
        public KhachHang()
        {
            InitializeComponent();
        }
        void HienthiKhachHang()
        {
            setNull();
            lsvKhachHang.FullRowSelect = true; //cho phép chọn 1 dòng
            lsvKhachHang.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
            lsvKhachHang.Items.Clear();
            DataTable dt = kh.LayDSKhachHang();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvKhachHang.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
            }
        }
        void setNull()
        {
            lblId.Text = "";
            lblHoTen.Text = "";
            lblDiaChi.Text = "";
            lblSdt.Text = "";
            lblGioiTinh.Text = "";
            lblEmail.Text = "";
            lblNgaySinh.Text = "";
            lblDiem.Text = "";
            txtTimKiem.Text = "";
            rdId.Checked = false;
            rdTen.Checked = false;
        }

        void setNull_Them()
        {
            txtHoTen_Them.Text = "";
            txtDiaChi_Them.Text = "";
            txtDienThoai_Them.Text = "";
            txtEmail_Them.Text = "";
            dtpNgaySinh_Them.Checked = false;
            rdNam_Them.Checked = false;
            rdNu_Them.Checked = false;
        }

        void setNull_Sua()
        {
            txtId.Text = "";
            txtHoTen_Sua.Text = "";
            txtDiaChi_Sua.Text = "";
            txtDienThoai_Sua.Text = "";
            txtEmail_Sua.Text = "";
            dtpNgaySinh_Sua.Checked = false;
            txtDiem.Text = "";
            rdNam_Sua.Checked = false;
            rdNu_Sua.Checked = false;
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            setNull();
            setNull_Them();
            setNull_Sua();
            HienthiKhachHang();
        }
        private void lsvKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvKhachHang.SelectedIndices.Count > 0)
            {
                lblId.Text = lsvKhachHang.SelectedItems[0].SubItems[0].Text;
                lblHoTen.Text = lsvKhachHang.SelectedItems[0].SubItems[1].Text;
                lblDiaChi.Text = lsvKhachHang.SelectedItems[0].SubItems[2].Text;
                lblSdt.Text = lsvKhachHang.SelectedItems[0].SubItems[3].Text;
                lblGioiTinh.Text = lsvKhachHang.SelectedItems[0].SubItems[4].Text;
                lblEmail.Text = lsvKhachHang.SelectedItems[0].SubItems[5].Text;
                lblNgaySinh.Text = lsvKhachHang.SelectedItems[0].SubItems[6].Text;
                lblDiem.Text = lsvKhachHang.SelectedItems[0].SubItems[7].Text;
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvKhachHang.SelectedIndices.Count > 0)
            {
                tabKhachHang.SelectedTab = tabSuaKH;
                txtId.Text = lblId.Text;
                txtHoTen_Sua.Text = lblHoTen.Text;
                txtDiaChi_Sua.Text = lblDiaChi.Text;
                txtDienThoai_Sua.Text = lblSdt.Text;
                txtEmail_Sua.Text = lblEmail.Text;
                dtpNgaySinh_Sua.Value = DateTime.Parse(lblNgaySinh.Text);
                txtDiem.Text = lblDiem.Text;
                if (lblGioiTinh.Text.Equals("Nam"))
                {
                    rdNam_Sua.Checked = true;
                }
                else if(lblGioiTinh.Text.Equals("Nữ"))
                {
                    rdNu_Sua.Checked = true;
                }
            }
            else
                MessageBox.Show("Bạn phải chọn khách hàng cập nhật", "Sửa khách hàng");
        }
        bool checkValue_KhachHang()
        {
            if (tabKhachHang.SelectedTab == tabThemKH)
            {
                string check = kh.checkValue("id", txtHoTen_Them.Text, txtDienThoai_Them.Text, txtEmail_Them.Text, "1");
                if (check.Equals("hoten"))
                {
                    txtHoTen_Them.Focus();
                    return false;
                }
                else if (check.Equals("sdt"))
                {
                    txtDienThoai_Them.Focus();
                    return false;
                }
                else if (check.Equals("email"))
                {
                    txtEmail_Them.Focus();
                    return false;
                }
            }
            else if(tabKhachHang.SelectedTab == tabSuaKH)
            {
                string check = kh.checkValue(txtId.Text, txtHoTen_Sua.Text, txtDienThoai_Sua.Text, txtEmail_Sua.Text, txtDiem.Text);
                if(check.Equals("id"))
                {
                    tabKhachHang.SelectedTab = tabDSKH;
                    return false;
                }
                else if (check.Equals("hoten"))
                {
                    txtHoTen_Sua.Focus();
                    return false;
                }
                else if (check.Equals("sdt"))
                {
                    txtDienThoai_Sua.Focus();
                    return false;
                }
                else if (check.Equals("email"))
                {
                    txtEmail_Sua.Focus();
                    return false;
                }
                else if (check.Equals("diem"))
                {
                    txtDiem.Focus();
                    return false;
                }
            }
            return true;
        }
        private void CheckValue_Key(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                checkValue_KhachHang();
            }
        }
        private void btnLuu_Them_Click(object sender, EventArgs e)
        {
            if (checkValue_KhachHang())
            {
                string ngay = dtpNgaySinh_Them.Value.ToString("MM-dd-yyyy");
                if (rdNam_Them.Checked)
                {
                    kh.ThemKhachHang(txtHoTen_Them.Text, txtDiaChi_Them.Text, txtDienThoai_Them.Text, rdNam_Them.Text, txtEmail_Them.Text, ngay); MessageBox.Show("Thêm mới thành công");
                }
                else if(rdNu_Them.Checked)
                {
                    kh.ThemKhachHang(txtHoTen_Them.Text, txtDiaChi_Them.Text, txtDienThoai_Them.Text, rdNu_Them.Text, txtEmail_Them.Text, ngay); MessageBox.Show("Thêm mới thành công");
                }
                else
                {
                    kh.ThemKhachHang(txtHoTen_Them.Text, txtDiaChi_Them.Text, txtDienThoai_Them.Text, "", txtEmail_Them.Text, ngay); MessageBox.Show("Thêm mới thành công");
                }
                setNull_Them();
                HienthiKhachHang();
            }
        }
        private void btnLuu_Sua_Click(object sender, EventArgs e)
        {
            if (checkValue_KhachHang())
            {
                string ngay = dtpNgaySinh_Sua.Value.ToString("MM-dd-yyyy");
                if (rdNam_Sua.Checked)
                {
                    kh.CapNhatKhachHang(txtHoTen_Sua.Text, txtDiaChi_Sua.Text, txtDienThoai_Sua.Text, rdNam_Sua.Text, txtEmail_Sua.Text, ngay, txtDiem.Text, txtId.Text); MessageBox.Show("Sửa thành công");
                    tabKhachHang.SelectedTab = tabDSKH;
                }
                else if(rdNu_Sua.Checked)
                {
                    kh.CapNhatKhachHang(txtHoTen_Sua.Text, txtDiaChi_Sua.Text, txtDienThoai_Sua.Text, rdNu_Sua.Text, txtEmail_Sua.Text, ngay, txtDiem.Text, txtId.Text); MessageBox.Show("Sửa thành công");
                    tabKhachHang.SelectedTab = tabDSKH;
                }
                else
                {
                    kh.CapNhatKhachHang(txtHoTen_Sua.Text, txtDiaChi_Sua.Text, txtDienThoai_Sua.Text, "", txtEmail_Sua.Text, ngay, txtDiem.Text, txtId.Text); MessageBox.Show("Sửa thành công");
                    tabKhachHang.SelectedTab = tabDSKH;
                }
                setNull_Sua();
                HienthiKhachHang();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbTimKiem.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn tiêu chí tìm kiếm", "Tìm kiếm");
            }
            else if(txtTimKiem.Text == "")
            {
                HienthiKhachHang();
                MessageBox.Show("Hiển thị tất cả khách hàng", "Tìm kiếm");
            }
            else
            {
                if (cbbTimKiem.SelectedItem.ToString().Equals("theo tên"))
                {
                    lsvKhachHang.FullRowSelect = true; //cho phép chọn 1 dòng
                    lsvKhachHang.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
                    lsvKhachHang.Items.Clear();
                    DataTable dttk = kh.LayDSKhachHang();

                    for (int i = 0; i < dttk.Rows.Count; i++)
                    {
                        if(dttk.Rows[i][1].ToString().ToLower().Contains(txtTimKiem.Text.ToLower()))
                        {
                            ListViewItem lvi = lsvKhachHang.Items.Add(dttk.Rows[i][0].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][1].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][7].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][2].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][3].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][4].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][5].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][6].ToString());
                        }
                    }
                }
                else
                {
                    lsvKhachHang.FullRowSelect = true; //cho phép chọn 1 dòng
                    lsvKhachHang.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
                    lsvKhachHang.Items.Clear();
                    DataTable dttk = kh.LayDSKhachHang();

                    for (int i = 0; i < dttk.Rows.Count; i++)
                    {
                        if (dttk.Rows[i][2].ToString().Contains(txtTimKiem.Text))
                        {
                            ListViewItem lvi = lsvKhachHang.Items.Add(dttk.Rows[i][0].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][1].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][7].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][2].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][3].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][4].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][5].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][6].ToString());
                        }
                    }
                }
                if(lsvKhachHang.Items.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng", "Tìm kiếm");
                }
                setNull();
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if(!rdId.Checked && !rdTen.Checked)
            {
                MessageBox.Show("Hãy chọn tiêu chí sắp xếp", "Sắp xếp");
            }
            else if(rdId.Checked)
            {
                lsvKhachHang.ListViewItemSorter = new ListViewItemComparer(0);
                lsvKhachHang.Sort();
            }
            else
            {
                lsvKhachHang.ListViewItemSorter = new ListViewItemComparer(1);
                lsvKhachHang.Sort();
            }
            setNull();
        }
    }
    class ListViewItemComparer : IComparer
    {
        private int col;
        public ListViewItemComparer(int column)
        {
            col = column;
        }
        public int Compare(object x, object y)
        {
            try
            {
                return String.Compare(((ListViewItem)x).SubItems[col].Text,
                      ((ListViewItem)y).SubItems[col].Text);
            }
            catch (Exception)
            {

            }
            return 0;
        }
    }
}
