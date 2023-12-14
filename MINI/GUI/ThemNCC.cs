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

namespace MINI.src.GUI.PhieuNhap
{
    public partial class ThemNCC : Form
    {
        PhieuNhapBUS ncc = new PhieuNhapBUS();
        public ThemNCC()
        {
            InitializeComponent();
        }

        private void ThemNCC_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateButtonVisibility(bool isVisible)
        {
            btnThem.Visible = isVisible;
        }

        public void UpdateIdnccValue(string value)
        {
            txtidncc.Text = value;
        }

        public void UpdateTenNCCValue(string value)
        {
            txttenncc.Text = value;
        }

        public void UpdateDiaChiNCCValue(string value)
        {
            txtdiachincc.Text = value;
        }

        public void UpdateSDTNCCnccValue(string value)
        {
            txtsdtncc.Text = value;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtdiachincc.Text) && !string.IsNullOrEmpty(txtsdtncc.Text) && !string.IsNullOrEmpty(txttenncc.Text) ){
                bool themThanhCong = ncc.ThemNCC(txttenncc.Text, txtdiachincc.Text, txtsdtncc.Text);
                if (themThanhCong)
                {
                    // Đóng form sau khi thêm thành công
                    this.Close();
                }
                else
                {
                    // Hiển thị thông báo lỗi nếu cần thiết
                    MessageBox.Show("Không thể thêm nhà cung cấp. Vui lòng thử lại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng Nhập Đầy Đủ Thông Tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            bool suaThanhCong = ncc.SuaNCC(txtidncc.Text,txttenncc.Text, txtdiachincc.Text, txtsdtncc.Text);
            
            if (suaThanhCong)
            {
                // Đóng form sau khi thêm thành công
                
                this.Close();
               
            }
            else
            {
                // Hiển thị thông báo lỗi nếu cần thiết
                MessageBox.Show("Không thể thêm nhà cung cấp. Vui lòng thử lại.");
            }

        }

        private void txtidncc_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
