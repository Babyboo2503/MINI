using MINI.src.BUS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MINI.GUI
{
    public partial class SanPham : Form
    {
        private bool themloaisp = false;
        private bool themsp = false;
        SanPhamBUS sp = new SanPhamBUS();
        public SanPham()
        {
            InitializeComponent();
        }
        void HienthiLoaiSanPham()
        {
            setNull_LoaiSanPham();
            lsvLoaiSanPham.FullRowSelect = true; //cho phép chọn 1 dòng
            lsvLoaiSanPham.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
            lsvLoaiSanPham.Items.Clear();
            DataTable dt = sp.LayDSLoaiSanPham();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvLoaiSanPham.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
            }
        }
        void setNull_LoaiSanPham()
        {
            txtIdLoaiSanPham.Text = "";
            txtTenLoaiSanPham.Text = "";
            txtTimKiemLoaiSanPham.Text = "";
            rdMaLoaiSanPham.Checked = false;
            rdTenLoaiSanPham.Checked = false;
        }
        void HienthiSanPham()
        {
            cbbLoaiSanPham.DataSource = sp.LayDSLoaiSanPham();
            cbbLoaiSanPham.DisplayMember = "tenLoaiSanPham";
            cbbLoaiSanPham.ValueMember = "idLoaiSanPham";
            cbbTrangThai.SelectedIndex = 0;
            if (rdPic.Checked)
            {
                panel1.Visible = false;
                flowLayoutPanel1.Visible = true;
                btnSua.Visible = false;
                flowLayoutPanel1.Controls.Clear();
                DataTable dt = sp.LayDSSanPham();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Product pro = new Product();
                    try
                    {
                        pro.BorderStyle = BorderStyle.FixedSingle;
                        if (int.Parse(dt.Rows[i][3].ToString()) < 5)
                        {
                            pro.ForeColor = Color.Red;
                        }
                        pro.Id_Pro = dt.Rows[i][0].ToString();
                        pro.Name_Pro = dt.Rows[i][6].ToString();
                        pro.Num_Pro = dt.Rows[i][3].ToString();
                        pro.Img_Pro = dt.Rows[i][7].ToString();
                    }
                    catch (Exception)
                    {
                    }
                    flowLayoutPanel1.Controls.Add(pro);
                }
            }
            else
            {
                panel1.Visible = true;
                flowLayoutPanel1.Visible = false;
                btnSua.Visible = true;
                lsvSanPham.FullRowSelect = true; //cho phép chọn 1 dòng
                lsvSanPham.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
                lsvSanPham.Items.Clear();
                DataTable dt = sp.LayDSSanPham();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = lsvSanPham.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][6].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                    lvi.SubItems.Add(dt.Rows[i][7].ToString());
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());
                }
            }
        }
        void setNull()
        {
            txtIdSanPham.Text = "";
            txtTenSanPham.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtHinhAnh.Text = "";
            txtTimKiemSanPham.Text = "";
            cbbPhanLoai.SelectedItem = null;
        }

        private void tabSanPham_Load(object sender, EventArgs e)
        {
            setNull();
            setNull_LoaiSanPham();
            HienthiSanPham();
            HienthiLoaiSanPham();
        }

        bool checkValue_SanPham()
        {
            if (tabSanPham.SelectedTab == tabLoaiSanPham && themloaisp)
            {
                if (txtIdLoaiSanPham.Text != "")
                {
                    MessageBox.Show("Id đã tồn tại", "Báo lỗi");
                    return false;
                }
                else if (!sp.checkValue_LoaiSanPham("id", txtTenLoaiSanPham.Text))
                {
                    txtTenLoaiSanPham.Text = "";
                    txtTenLoaiSanPham.Focus();
                    return false;
                }
            }
            else if (tabSanPham.SelectedTab == tabLoaiSanPham && !themloaisp)
            {
                if (!sp.checkValue_LoaiSanPham(txtIdLoaiSanPham.Text, txtTenLoaiSanPham.Text))
                {
                    txtTenLoaiSanPham.Text = "";
                    txtTenLoaiSanPham.Focus();
                    return false;
                }
            }
            else if (tabSanPham.SelectedTab == tabThemSanPham && themsp)
            {
                if (txtIdSanPham.Text != "")
                {
                    MessageBox.Show("Id đã tồn tại", "Báo lỗi");
                    return false;
                }
                string check = sp.checkValue_SanPham("id", cbbLoaiSanPham.SelectedValue.ToString(), txtTenSanPham.Text, txtDonGia.Text, txtSoLuong.Text, txtHinhAnh.Text, cbbTrangThai.SelectedItem.ToString());
                if (check.Equals("loaisp"))
                {
                    cbbLoaiSanPham.Focus();
                    return false;
                }
                else if (check.Equals("ten"))
                {
                    txtTenSanPham.Focus();
                    return false;
                }
                else if (check.Equals("dongia"))
                {
                    txtDonGia.Focus();
                    return false;
                }
                else if (check.Equals("soluong"))
                {
                    txtSoLuong.Focus();
                    return false;
                }
                else if (check.Equals("hinhanh"))
                {
                    btnHinhAnh.Focus();
                    return false;
                }
            }
            else if (tabSanPham.SelectedTab == tabThemSanPham && !themsp)
            {
                string check = sp.checkValue_SanPham(txtIdSanPham.Text, cbbLoaiSanPham.SelectedValue.ToString(), txtTenSanPham.Text, txtDonGia.Text, txtSoLuong.Text, txtHinhAnh.Text, cbbTrangThai.SelectedItem.ToString());
                if (check.Equals("id"))
                {
                    tabSanPham.SelectedTab = tabDSSP;
                    rdList.Checked = true;
                    return false;
                }
                else if (check.Equals("loaisp"))
                {
                    cbbLoaiSanPham.Focus();
                    return false;
                }
                else if (check.Equals("ten"))
                {
                    txtTenSanPham.Focus();
                    return false;
                }
                else if (check.Equals("dongia"))
                {
                    txtDonGia.Focus();
                    return false;
                }
                else if (check.Equals("soluong"))
                {
                    txtSoLuong.Focus();
                    return false;
                }
                else if (check.Equals("hinhanh"))
                {
                    btnHinhAnh.Focus();
                    return false;
                }
            }
            return true;
        }
        private void CheckValue_Key(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                checkValue_SanPham();
            }
        }

        private void btnThemLoaiHang_Click(object sender, EventArgs e)
        {
            themloaisp = true;
            if (checkValue_SanPham())
            {
                sp.ThemLoaiSanPham(txtTenLoaiSanPham.Text); MessageBox.Show("Thêm mới thành công");
            }
            setNull_LoaiSanPham();
            HienthiLoaiSanPham();
            themloaisp = false;
        }

        private void btnSuaLoaiHang_Click(object sender, EventArgs e)
        {
            if (checkValue_SanPham())
            {
                sp.CapNhatLoaiSanPham(txtTenLoaiSanPham.Text, txtIdLoaiSanPham.Text); MessageBox.Show("Sửa thành công");
            }
            setNull_LoaiSanPham();
            HienthiLoaiSanPham();
        }

        private void btnTimKiemLoaiHang_Click(object sender, EventArgs e)
        {
            if (txtTimKiemLoaiSanPham.Text == "")
            {
                HienthiLoaiSanPham();
                MessageBox.Show("Hiển thị tất cả loại sản phẩm", "Tìm kiếm");
            }
            else
            {
                int id;
                if(!int.TryParse(txtTimKiemLoaiSanPham.Text, out id))
                {
                    lsvLoaiSanPham.FullRowSelect = true; //cho phép chọn 1 dòng
                    lsvLoaiSanPham.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
                    lsvLoaiSanPham.Items.Clear();
                    DataTable dttk = sp.LayDSLoaiSanPham();

                    for (int i = 0; i < dttk.Rows.Count; i++)
                    {
                        if (dttk.Rows[i][1].ToString().ToLower().Contains(txtTimKiemLoaiSanPham.Text.ToLower()))
                        {
                            ListViewItem lvi = lsvLoaiSanPham.Items.Add(dttk.Rows[i][0].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][1].ToString());
                        }
                    }
                }
                else
                {
                    lsvLoaiSanPham.FullRowSelect = true; //cho phép chọn 1 dòng
                    lsvLoaiSanPham.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
                    lsvLoaiSanPham.Items.Clear();
                    DataTable dttk = sp.LayDSLoaiSanPham();

                    for (int i = 0; i < dttk.Rows.Count; i++)
                    {
                        if (dttk.Rows[i][0].ToString().ToLower().Contains(txtTimKiemLoaiSanPham.Text.ToLower()))
                        {
                            ListViewItem lvi = lsvLoaiSanPham.Items.Add(dttk.Rows[i][0].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][1].ToString());
                        }
                    }
                }    
            }
            if (lsvLoaiSanPham.Items.Count == 0)
            {
                MessageBox.Show("Không tìm thấy loại sản phẩm", "Tìm kiếm");
                HienthiLoaiSanPham();
            }
            setNull_LoaiSanPham();
        }
        private void btnSapXepLoaiHang_Click(object sender, EventArgs e)
        {
            if (!rdMaLoaiSanPham.Checked && !rdTenLoaiSanPham.Checked)
            {
                MessageBox.Show("Hãy chọn tiêu chí sắp xếp", "Sắp xếp");
            }
            else if (rdMaLoaiSanPham.Checked)
            {
                lsvLoaiSanPham.ListViewItemSorter = new ListViewItemComparerId(0);
                lsvLoaiSanPham.Sort();
            }
            else
            {
                lsvLoaiSanPham.ListViewItemSorter = new ListViewItemComparerName(1);
                lsvLoaiSanPham.Sort();
            }
            setNull_LoaiSanPham();
        }

        private void lsvLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvLoaiSanPham.SelectedIndices.Count > 0)
            {
                txtIdLoaiSanPham.Text = lsvLoaiSanPham.SelectedItems[0].SubItems[0].Text;
                txtTenLoaiSanPham.Text = lsvLoaiSanPham.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setNull_LoaiSanPham();
        }

        private void btnThem_SanPham_Click(object sender, EventArgs e)
        {
            themsp = true;
            if (checkValue_SanPham())
            {
                sp.ThemSanPham(cbbLoaiSanPham.SelectedValue.ToString(), txtTenSanPham.Text, txtDonGia.Text, txtSoLuong.Text, txtHinhAnh.Text, cbbTrangThai.SelectedItem.ToString()); MessageBox.Show("Thêm mới thành công");
                setNull();
                HienthiSanPham();
            }
            themsp = false;
        }

        private void btnSua_SanPham_Click(object sender, EventArgs e)
        {
            if (checkValue_SanPham())
            {
                sp.CapNhatSanPham(cbbLoaiSanPham.SelectedValue.ToString(), txtTenSanPham.Text, txtDonGia.Text, txtSoLuong.Text, txtHinhAnh.Text, cbbTrangThai.SelectedItem.ToString(), txtIdSanPham.Text); MessageBox.Show("Sửa thành công");
                setNull();
                tabSanPham.SelectedTab = tabDSSP;
                rdList.Checked = true;
                HienthiSanPham();
            }
        }

        private void btnHuy_SanPham_Click(object sender, EventArgs e)
        {
            setNull();
        }

        private void rdPic_CheckedChanged(object sender, EventArgs e)
        {
            HienthiSanPham();
        }

        private void rdList_CheckedChanged(object sender, EventArgs e)
        {
            HienthiSanPham();
        }

        private void btnTimKiem_SanPham_Click(object sender, EventArgs e)
        {
            if (txtTimKiemSanPham.Text == "")
            {
                HienthiSanPham();
                MessageBox.Show("Hiển thị tất cả loại sản phẩm", "Tìm kiếm");
            }
            else
            {
                int id;
                if (!int.TryParse(txtTimKiemSanPham.Text, out id))
                {
                    DataTable dttk = sp.LayDSSanPham();
                    if (rdPic.Checked)
                    {
                        panel1.Visible = false;
                        flowLayoutPanel1.Visible = true;
                        flowLayoutPanel1.Controls.Clear();

                        for (int i = 0; i < dttk.Rows.Count; i++)
                        {
                            if (dttk.Rows[i][6].ToString().ToLower().Contains(txtTimKiemSanPham.Text.ToLower()))
                            {
                                Product pro = new Product();
                                try
                                {
                                    pro.BorderStyle = BorderStyle.FixedSingle;
                                    pro.Id_Pro = dttk.Rows[i][0].ToString();
                                    pro.Name_Pro = dttk.Rows[i][6].ToString();
                                    pro.Num_Pro = dttk.Rows[i][3].ToString();
                                    pro.Img_Pro = dttk.Rows[i][7].ToString();
                                }
                                catch (Exception)
                                {
                                }
                                flowLayoutPanel1.Controls.Add(pro);
                            }
                        }
                        if (flowLayoutPanel1.Controls.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm", "Tìm kiếm");
                            HienthiSanPham();
                        }
                        setNull();
                    }
                    else
                    {
                        panel1.Visible = true;
                        flowLayoutPanel1.Visible = false;
                        lsvSanPham.FullRowSelect = true; //cho phép chọn 1 dòng
                        lsvSanPham.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
                        lsvSanPham.Items.Clear();
                        for (int i = 0; i < dttk.Rows.Count; i++)
                        {
                            if (dttk.Rows[i][6].ToString().ToLower().Contains(txtTimKiemSanPham.Text.ToLower()))
                            {
                                ListViewItem lvi = lsvSanPham.Items.Add(dttk.Rows[i][0].ToString());
                                lvi.SubItems.Add(dttk.Rows[i][1].ToString());
                                lvi.SubItems.Add(dttk.Rows[i][6].ToString());
                                lvi.SubItems.Add(dttk.Rows[i][2].ToString());
                                lvi.SubItems.Add(dttk.Rows[i][3].ToString());
                                lvi.SubItems.Add(dttk.Rows[i][7].ToString());
                                lvi.SubItems.Add(dttk.Rows[i][4].ToString());
                            }
                        }
                        if (lsvSanPham.Items.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm", "Tìm kiếm");
                            HienthiSanPham();
                        }
                        setNull();
                    }
                }
                else
                {
                    DataTable dttk = sp.LayDSSanPham();
                    if (rdPic.Checked)
                    {
                        panel1.Visible = false;
                        flowLayoutPanel1.Visible = true;
                        flowLayoutPanel1.Controls.Clear();

                        for (int i = 0; i < dttk.Rows.Count; i++)
                        {
                            if (dttk.Rows[i][0].ToString().ToLower().Contains(txtTimKiemSanPham.Text.ToLower()))
                            {
                                Product pro = new Product();
                                try
                                {
                                    pro.BorderStyle = BorderStyle.FixedSingle;
                                    pro.Id_Pro = dttk.Rows[i][0].ToString();
                                    pro.Name_Pro = dttk.Rows[i][6].ToString();
                                    pro.Num_Pro = dttk.Rows[i][3].ToString();
                                    pro.Img_Pro = dttk.Rows[i][7].ToString();
                                }
                                catch (Exception)
                                {
                                }
                                flowLayoutPanel1.Controls.Add(pro);
                            }
                        }
                        if (flowLayoutPanel1.Controls.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm", "Tìm kiếm");
                            HienthiSanPham();
                        }
                        setNull();
                    }
                    else
                    {
                        panel1.Visible = true;
                        flowLayoutPanel1.Visible = false;
                        lsvSanPham.FullRowSelect = true; //cho phép chọn 1 dòng
                        lsvSanPham.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
                        lsvSanPham.Items.Clear();
                        for (int i = 0; i < dttk.Rows.Count; i++)
                        {
                            if (dttk.Rows[i][0].ToString().ToLower().Contains(txtTimKiemSanPham.Text.ToLower()))
                            {
                                ListViewItem lvi = lsvSanPham.Items.Add(dttk.Rows[i][0].ToString());
                                lvi.SubItems.Add(dttk.Rows[i][1].ToString());
                                lvi.SubItems.Add(dttk.Rows[i][6].ToString());
                                lvi.SubItems.Add(dttk.Rows[i][2].ToString());
                                lvi.SubItems.Add(dttk.Rows[i][3].ToString());
                                lvi.SubItems.Add(dttk.Rows[i][7].ToString());
                                lvi.SubItems.Add(dttk.Rows[i][4].ToString());
                            }
                        }
                        if (lsvSanPham.Items.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm", "Tìm kiếm");
                            HienthiSanPham();
                        }
                        setNull();
                    }
                }
            }
        }

        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Chọn hình ảnh cho sản phẩm";
            dlg.Filter = "Picture (*.png)|*.png|Picture (*.jpg)|*.jpg";
            dlg.FilterIndex = 1;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(dlg.FileName).Equals(".png", StringComparison.InvariantCultureIgnoreCase))
                {
                    txtHinhAnh.Text = dlg.FileName;
                }
                else if (Path.GetExtension(dlg.FileName).Equals(".jpg", StringComparison.InvariantCultureIgnoreCase))
                {
                    txtHinhAnh.Text = dlg.FileName;
                }
                else
                {
                    MessageBox.Show("file ảnh không phù hợp, vui lòng chọn file .jpg hoặc .png");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvSanPham.SelectedIndices.Count > 0)
            {
                txtIdSanPham.Text = lsvSanPham.SelectedItems[0].SubItems[0].Text;
                cbbLoaiSanPham.SelectedValue = lsvSanPham.SelectedItems[0].SubItems[1].Text;
                txtTenSanPham.Text = lsvSanPham.SelectedItems[0].SubItems[2].Text;
                txtDonGia.Text = lsvSanPham.SelectedItems[0].SubItems[3].Text.Replace(",000", string.Empty);
                txtSoLuong.Text = lsvSanPham.SelectedItems[0].SubItems[4].Text;
                txtHinhAnh.Text = lsvSanPham.SelectedItems[0].SubItems[5].Text;
                cbbTrangThai.SelectedItem = lsvSanPham.SelectedItems[0].SubItems[6].Text;
                tabSanPham.SelectedTab = tabThemSanPham;
            }
            else
            {
                MessageBox.Show("Hãy chọn sản phẩm", "Báo lỗi");
            }
        }

        private void cbbPhanLoai_DropDown(object sender, EventArgs e)
        {
            cbbPhanLoai.SelectedIndexChanged -= cbbPhanLoai_SelectedIndexChanged;
            // Đổ dữ liệu vào ComboBox
            cbbPhanLoai.DataSource = sp.LayDSLoaiSanPham();
            cbbPhanLoai.DisplayMember = "tenLoaiSanPham";
            cbbPhanLoai.ValueMember = "idLoaiSanPham";
            cbbPhanLoai.SelectedIndexChanged += cbbPhanLoai_SelectedIndexChanged;
        }

        private void cbbPhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPhanLoai.SelectedItem != null)
            {
                DataTable dttk = sp.LayDSSanPham();
                if (rdPic.Checked)
                {
                    panel1.Visible = false;
                    flowLayoutPanel1.Visible = true;
                    flowLayoutPanel1.Controls.Clear();

                    for (int i = 0; i < dttk.Rows.Count; i++)
                    {
                        if (dttk.Rows[i][1].ToString().ToLower().Contains(cbbPhanLoai.SelectedValue.ToString().ToLower()))
                        {
                            Product pro = new Product();
                            try
                            {
                                pro.BorderStyle = BorderStyle.FixedSingle;
                                pro.Id_Pro = dttk.Rows[i][0].ToString();
                                pro.Name_Pro = dttk.Rows[i][6].ToString();
                                pro.Num_Pro = dttk.Rows[i][3].ToString();
                                pro.Img_Pro = dttk.Rows[i][7].ToString();
                            }
                            catch (Exception)
                            {
                            }
                            flowLayoutPanel1.Controls.Add(pro);
                        }
                    }
                    if (flowLayoutPanel1.Controls.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm", "Tìm kiếm");
                        HienthiSanPham();
                    }
                }
                else
                {
                    panel1.Visible = true;
                    flowLayoutPanel1.Visible = false;
                    lsvSanPham.FullRowSelect = true; //cho phép chọn 1 dòng
                    lsvSanPham.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
                    lsvSanPham.Items.Clear();
                    for (int i = 0; i < dttk.Rows.Count; i++)
                    {
                        if (dttk.Rows[i][1].ToString().ToLower().Contains(cbbPhanLoai.SelectedValue.ToString().ToLower()))
                        {
                            ListViewItem lvi = lsvSanPham.Items.Add(dttk.Rows[i][0].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][1].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][6].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][2].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][3].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][7].ToString());
                            lvi.SubItems.Add(dttk.Rows[i][4].ToString());
                        }
                    }
                    if (lsvSanPham.Items.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm", "Tìm kiếm");
                        HienthiSanPham();
                    }
                }
                setNull();
            }
        }
    }
}
