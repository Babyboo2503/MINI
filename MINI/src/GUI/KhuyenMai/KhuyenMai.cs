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
    public partial class KhuyenMai : Form
    {
        BUS.KhuyenMaiBUS km = new BUS.KhuyenMaiBUS();
        BUS.SanPhamBUS sp = new BUS.SanPhamBUS();
        public bool themmoi = false;
        public KhuyenMai()
        {
            InitializeComponent();
        }
        void HienthiKhuyenMai()
        {
            setNull();
            lsvKhuyenMai.FullRowSelect = true; //cho phép chọn 1 dòng
            lsvKhuyenMai.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
            lsvKhuyenMai.Items.Clear();
            DataTable dt = km.LayDSKhuyenMai();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvKhuyenMai.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString()+"%");
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
            }
        }
        void setNull()
        {
            txtTenKM.Text = "";
            txtPhanTram.Text = "";
            txtNoiDung.Text = "";
            txtDieuKien.Text = "";
        }
        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnSua.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
        }
        private void KhuyenMai_Load(object sender, EventArgs e)
        {
            setButton(true);
            HienthiKhuyenMai();
            HienthiKMSanPham();
        }

        private void lsvKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvKhuyenMai.SelectedIndices.Count > 0)
            {
                dtpNgayBatDau.Value = DateTime.Parse(lsvKhuyenMai.SelectedItems[0].SubItems[1].Text);
                dtpNgayKetThuc.Value = DateTime.Parse(lsvKhuyenMai.SelectedItems[0].SubItems[2].Text);
                txtTenKM.Text = lsvKhuyenMai.SelectedItems[0].SubItems[3].Text;
                txtPhanTram.Text = lsvKhuyenMai.SelectedItems[0].SubItems[4].Text.Replace("%", string.Empty);
                txtNoiDung.Text = lsvKhuyenMai.SelectedItems[0].SubItems[5].Text;
                txtDieuKien.Text = lsvKhuyenMai.SelectedItems[0].SubItems[6].Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setNull();
            themmoi = true;
            setButton(false);
            txtTenKM.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvKhuyenMai.SelectedIndices.Count > 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
        }

        bool checkValue()
        {
            if (tabKhuyenMai.SelectedTab == tabDSKM)
            {
                string check = km.checkValue(dtpNgayBatDau.Value, dtpNgayKetThuc.Value, txtTenKM.Text, txtPhanTram.Text, txtNoiDung.Text, txtDieuKien.Text);
                if (check.Equals("ngaybatdau"))
                {
                    dtpNgayBatDau.Focus();
                    return false;
                }
                else if (check.Equals("ngayketthuc"))
                {
                    dtpNgayKetThuc.Focus();
                    return false;
                }
                else if (check.Equals("tenkm"))
                {
                    txtTenKM.Focus();
                    return false;
                }
                else if (check.Equals("phantram"))
                {
                    txtPhanTram.Focus();
                    return false;
                }
                else if(check.Equals("noidung"))
                {
                    txtNoiDung.Focus();
                    return false;
                }
                else if (check.Equals("dieukien"))
                {
                    txtDieuKien.Focus();
                    return false;
                }
            }
            return true;
        }

        private void CheckValue_Key(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                checkValue();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkValue())
            {
                
                //Định dạng ngày tương ứng với trong CSDL SQLserver
                string ngaybatdau = dtpNgayBatDau.Value.ToString("MM-dd-yyyy");
                string ngayketthuc = dtpNgayKetThuc.Value.ToString("MM-dd-yyyy");
                if (themmoi)
                {
                    km.ThemKhuyenMai(ngaybatdau, ngayketthuc, txtTenKM.Text, txtPhanTram.Text, txtNoiDung.Text, txtDieuKien.Text); MessageBox.Show("Thêm mới thành công");
                    setButton(true);
                    HienthiKhuyenMai();
                    setNull();
                }
                else
                {
                    km.CapNhatKhuyenMai(ngaybatdau, ngayketthuc, txtTenKM.Text, txtPhanTram.Text, txtNoiDung.Text, txtDieuKien.Text, lsvKhuyenMai.SelectedItems[0].SubItems[0].Text); MessageBox.Show("Cập nhật thành công");
                    setButton(true);
                    HienthiKhuyenMai();
                    setNull();
                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            setButton(true);
            setNull();
        }

        void HienthiKMSanPham()
        {
            cbbKhuyenMai.DataSource = km.LayDSKhuyenMai();
            cbbKhuyenMai.DisplayMember = "tenKhuyenMai";
            cbbKhuyenMai.ValueMember = "idKhuyenMai";
            cbbSanPham.DataSource = sp.LayDSSanPham();
            cbbSanPham.DisplayMember = "tenSanPham";
            cbbSanPham.ValueMember = "idSanPham";
            cbbKhuyenMai.SelectedItem = null;
            cbbSanPham.SelectedItem = null;
            lsvKMSanPham.FullRowSelect = true; //cho phép chọn 1 dòng
            lsvKMSanPham.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
            lsvKMSanPham.Items.Clear();
            DataTable dt = sp.LayDSSanPham();
            DataTable dtkm = km.LayDSKhuyenMai();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvKMSanPham.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                for(int j = 0; j <dtkm.Rows.Count; j++)
                {
                    if (dt.Rows[i][5].ToString().Equals(dtkm.Rows[j][0].ToString()))
                    {
                        lvi.SubItems.Add(dtkm.Rows[j][4].ToString()+"%");
                    }
                    else
                        lvi.SubItems.Add("0%");
                }
            }
        }

        private void cbbKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbKhuyenMai.SelectedItem != null)
            {
                txtKhuyenMai.Text = cbbKhuyenMai.SelectedValue.ToString();
            }
            else
                txtKhuyenMai.Text = "";
        }

        private void cbbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSanPham.SelectedItem != null)
            {
                txtSanPham.Text = cbbSanPham.SelectedValue.ToString();
            }
            else
                txtSanPham.Text = "";
        }

        private void lsvKMSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvKMSanPham.SelectedIndices.Count > 0)
            {
                cbbSanPham.SelectedValue = lsvKMSanPham.SelectedItems[0].SubItems[0].Text;
                cbbKhuyenMai.SelectedValue = lsvKMSanPham.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            if(cbbKhuyenMai.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn khuyến mãi để áp dụng", "Áp dụng khuyến mãi");
            }
            else if(cbbSanPham.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn sản phẩm để áp dụng", "Áp dụng khuyến mãi");
            }
            else {
                km.ApDungKhuyenMai(txtKhuyenMai.Text, txtSanPham.Text);
                MessageBox.Show("Áp dụng khuyến mãi thành công", "Áp dụng khuyến mãi");
                HienthiKMSanPham();
            }
        }

        private void btnHuyKhuyenMai_Click(object sender, EventArgs e)
        {

            if (lsvKMSanPham.SelectedIndices.Count > 0)
            {
                if(lsvKMSanPham.SelectedItems[0].SubItems[2].Text == "0")
                {
                    MessageBox.Show("Sản phẩm chưa có khuyến mãi", "Hủy khuyến mãi");
                }
                else
                {
                    km.HuyKhuyenMai(lsvKMSanPham.SelectedItems[0].SubItems[0].Text);
                    MessageBox.Show("Hủy khuyến mãi thành công", "Hủy khuyến mãi");
                    HienthiKMSanPham();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn sản phẩm để hủy", "Hủy khuyến mãi");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                HienthiKMSanPham();
                MessageBox.Show("Hiển thị tất cả sản phẩm", "Tìm kiếm");
            }
            else
            {
                lsvKMSanPham.FullRowSelect = true; //cho phép chọn 1 dòng
                lsvKMSanPham.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
                lsvKMSanPham.Items.Clear();
                DataTable dttk = sp.LayDSSanPham();
                DataTable dtkm = km.LayDSKhuyenMai();
                for (int i = 0; i < dttk.Rows.Count; i++)
                {
                    if (dttk.Rows[i][6].ToString().ToLower().Contains(txtTimKiem.Text.ToLower()))
                    {
                        ListViewItem lvi = lsvKMSanPham.Items.Add(dttk.Rows[i][0].ToString());
                        lvi.SubItems.Add(dttk.Rows[i][6].ToString());
                        lvi.SubItems.Add(dttk.Rows[i][5].ToString());
                        for (int j = 0; j < dtkm.Rows.Count; j++)
                        {
                            if (dttk.Rows[i][5].ToString().Equals(dtkm.Rows[j][0].ToString()))
                            {
                                lvi.SubItems.Add(dtkm.Rows[j][4].ToString() + "%");
                            }
                            else
                                lvi.SubItems.Add("0%");
                        }
                    }
                }
            }
        }
    }
}
