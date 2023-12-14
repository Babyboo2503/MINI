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


        private void btnThem_Click(object sender, EventArgs e)
        {
            
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool suaThanhCong = ncc.SuaNCC(txttenncc.Text, txtdiachincc.Text, txtsdtncc.Text);
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
    }
}
