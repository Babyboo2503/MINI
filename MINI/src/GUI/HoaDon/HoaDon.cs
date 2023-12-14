using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MINI.src.DTO;
using MINI.src.BUS;
using MINI.src.DAO;


namespace MINI.GUI.HoaDon
{
    public partial class HoaDon : Form
    {
        
        HoaDonBUS hd = new HoaDonBUS();
        CTHoaDonBUS cthd = new CTHoaDonBUS();
        public HoaDon()
        {
            InitializeComponent();
        }
        void HienthiHoaDon()
        {
            lvHoaDon.FullRowSelect = true; //cho phép chọn 1 dòng
            lvHoaDon.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
            lvHoaDon.Items.Clear();
            DataTable dt = hd.LayDSHoaDon();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lvHoaDon.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
                lvi.SubItems.Add(dt.Rows[i][8].ToString());
            }
            lvHoaDon.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {   
            HienthiHoaDon();
            if(textBox1.Text!=null && textBox1.Text!="")
            HienthiCTHoaDon();
            
        }

        void HienthiCTHoaDon()
        {
            lvCTHoaDon.FullRowSelect = true; //cho phép chọn 1 dòng
            lvCTHoaDon.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
            lvCTHoaDon.Items.Clear();
            DataTable dt = cthd.LayDSCTHoaDon(textBox1.Text);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lvCTHoaDon.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
            lvCTHoaDon.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        
        private void lvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHoaDon.SelectedIndices.Count > 0)
            {
                textBox1.Text = lvHoaDon.SelectedItems[0].SubItems[0].Text;
                dateTimePicker1.Value = DateTime.Parse(lvHoaDon.SelectedItems[0].SubItems[1].Text);
                textBox2.Text = lvHoaDon.SelectedItems[0].SubItems[2].Text;
                textBox7.Text = lvHoaDon.SelectedItems[0].SubItems[3].Text;
                textBox3.Text = lvHoaDon.SelectedItems[0].SubItems[4].Text;
                textBox8.Text = lvHoaDon.SelectedItems[0].SubItems[5].Text;
                textBox5.Text = lvHoaDon.SelectedItems[0].SubItems[6].Text;
                textBox9.Text = lvHoaDon.SelectedItems[0].SubItems[7].Text;
                textBox6.Text = lvHoaDon.SelectedItems[0].SubItems[8].Text;
            }
        }

        private void lvCTHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCTHoaDon.SelectedIndices.Count > 0)
            {
                textBox10.Text = lvCTHoaDon.SelectedItems[0].SubItems[0].Text;
                textBox11.Text = lvCTHoaDon.SelectedItems[0].SubItems[1].Text;
                textBox12.Text = lvCTHoaDon.SelectedItems[0].SubItems[2].Text;
                textBox13.Text = lvCTHoaDon.SelectedItems[0].SubItems[3].Text;
                textBox14.Text = lvCTHoaDon.SelectedItems[0].SubItems[4].Text;
                textBox15.Text = lvCTHoaDon.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void lvHoaDon_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
        }

        private void setNullCTHoaDon()
        {
            textBox10.Text = null;
            textBox11.Text = null;
            textBox12.Text = null;
            textBox13.Text = null;
            textBox14.Text = null;
            textBox15.Text = null;
            textBoxTK.Text = string.Empty;
            comboBox2.Text = "Tìm theo";
        }

        private void setNullHoaDon()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
            textBox9.Text = null;

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            setNullCTHoaDon();
            if (textBox1.Text != null && textBox1.Text != "")
                HienthiCTHoaDon();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HienthiHoaDon();
            if (comboBox1.Text == "Id hóa đơn")
            {
                foreach (ListViewItem item in lvHoaDon.Items)
                {
                    if (!item.SubItems[0].Text.ToLower().Equals(txtTimKiem.Text.ToLower()))
                    {
                        lvHoaDon.Items.Remove(item);
                    }
                }
            }
            else if (comboBox1.Text == "Id nhân viên")
            {
                foreach (ListViewItem item in lvHoaDon.Items)
                {
                    if (!item.SubItems[3].Text.ToLower().Equals(txtTimKiem.Text.ToLower()))
                    {
                        lvHoaDon.Items.Remove(item);
                    }
                }
            }
            else if (comboBox1.Text == "Tên nhân viên")
            {
                foreach (ListViewItem item in lvHoaDon.Items)
                {
                    if (!item.SubItems[4].Text.ToLower().Contains(txtTimKiem.Text.ToLower()))
                    {
                        lvHoaDon.Items.Remove(item);
                    }
                }
            }
            else if (comboBox1.Text == "Id khách hàng")
            {
                foreach (ListViewItem item in lvHoaDon.Items)
                {
                    if (!item.SubItems[5].Text.ToLower().Equals(txtTimKiem.Text.ToLower()))
                    {
                        lvHoaDon.Items.Remove(item);
                    }
                }
            }
            else if (comboBox1.Text == "Tên khách hàng")
            {
                foreach (ListViewItem item in lvHoaDon.Items)
                {
                    if (!item.SubItems[6].Text.ToLower().Contains(txtTimKiem.Text.ToLower()))
                    {
                        lvHoaDon.Items.Remove(item);
                    }
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lammoiHD();
        }
        private void lammoiHD()
        {
            txtTimKiem.Text = string.Empty;
            comboBox1.Text = "Tìm theo";
            setNullHoaDon();
            lvCTHoaDon.Items.Clear();
            HienthiHoaDon();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HienthiCTHoaDon();
            if (comboBox2.Text == "Id sản phẩm")
            {
                foreach (ListViewItem item in lvCTHoaDon.Items)
                {
                    if (!item.SubItems[1].Text.ToLower().Equals(textBoxTK.Text.ToLower()))
                    {
                        lvCTHoaDon.Items.Remove(item);
                    }
                }
            }
            else if (comboBox2.Text == "Tên sản phẩm")
            {
                foreach (ListViewItem item in lvCTHoaDon.Items)
                {
                    if (!item.SubItems[2].Text.ToLower().Contains(textBoxTK.Text.ToLower()))
                    {
                        lvCTHoaDon.Items.Remove(item);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxTK.Text = string.Empty;
            comboBox2.Text = "Tìm theo";
            HienthiCTHoaDon();
        }
    }

    
}
