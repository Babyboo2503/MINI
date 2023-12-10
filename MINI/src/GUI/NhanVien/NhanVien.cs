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
    public partial class NhanVien : Form
    {
        NhanVienBUS nv_bus=new NhanVienBUS();
        TaiKhoanBUS tk_bus= new TaiKhoanBUS();
        
        public NhanVien()
        {
            InitializeComponent();
        }
 
        private void NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'miniMarketDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.miniMarketDataSet.TaiKhoan);
            // TODO: This line of code loads data into the 'miniMarketDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.miniMarketDataSet.TaiKhoan);
            // TODO: This line of code loads data into the 'miniMarketDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.miniMarketDataSet.TaiKhoan);
            // TODO: This line of code loads data into the 'miniMarketDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.miniMarketDataSet.TaiKhoan);
            // TODO: This line of code loads data into the 'miniMarketDataSet.SanPham' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.miniMarketDataSet.NhanVien);
            if (trangThaiTextBox.Text == "Đang Làm")
            {
                ngayNghiDateTimePicker.Visible = false;
                lblNull.Enabled = true;
            }
            else
            {
                lblNull.Enabled = false;
            }
            labelChucVu.Text=nv_bus.findChucVu(Convert.ToInt32(idChucVuTextBox.Text));

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            tabNhanVien.SelectedTab = tabSuaThemNhanVien;
            txtChiTietIDNhanVien.Text = idNhanVienTextBox.Text;
            hoVaTenTextBox1.Text = hoVaTenTextBox.Text;
            soDienThoaiTextBox1.Text = soDienThoaiTextBox.Text;
            ngayNghiDateTimePicker1.Value = ngayNghiDateTimePicker.Value;
            ngaySinhDateTimePicker1.Value = ngaySinhDateTimePicker.Value;
            idChucVuComboBox.Text = idChucVuTextBox.Text;
            diaChiTextBox1.Text = diaChiTextBox.Text;
            luongTextBox1.Text = luongTextBox.Text;
            trangThaiComboBox.Text = trangThaiTextBox.Text;
        }



        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.miniMarketDataSet);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabNhanVien.SelectedTab = tabSuaThemNhanVien;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.nhanVienTableAdapter.Fill(this.miniMarketDataSet.NhanVien);

        }

        private void nhanVienDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelChucVu.Text = nv_bus.findChucVu(Convert.ToInt32(idChucVuTextBox.Text));
            if (trangThaiTextBox.Text == "Đang Làm")
            {
                ngayNghiDateTimePicker.Visible = false;
                lblNull.Visible = true;
            }
            if(trangThaiTextBox.Text=="Thôi Việc")
            {
                ngayNghiDateTimePicker.Visible = true;
                lblNull.Visible = false;
            }
        }
        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            panelSuaTaiKhoan.Visible = true;
        }

        private void danh_sáchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.taiKhoanTableAdapter.Danh_sách(this.miniMarketDataSet.TaiKhoan);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.taiKhoanTableAdapter.FillBy(this.miniMarketDataSet.TaiKhoan);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tabThongTinTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            panelTaiKhoan.Visible = true;
            txtHoTenTaiKhoan.Text = hoVaTenTextBox.Text;
            lblCV.Text = labelChucVu.Text;
            panelInfo.Visible = false;
            pictureBoxInfo.Visible = false;
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.nhanVienBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.miniMarketDataSet);
                nv_bus.UpdateToSQL(txtChiTietIDNhanVien.Text, hoVaTenTextBox1.Text, soDienThoaiTextBox1.Text, gioiTinhTextBox1.Text, idChucVuComboBox.Text, luongTextBox1.Text, trangThaiComboBox.Text, ngaySinhDateTimePicker1.Value, ngayNghiDateTimePicker1.Value, diaChiTextBox1.Text);
                MessageBox.Show("Đã lưu");
            }catch (Exception)
            {
                MessageBox.Show("Lưu không thành công");
            }
            
        }
    }
}
