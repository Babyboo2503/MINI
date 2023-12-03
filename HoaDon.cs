using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MINI.DTO;
using MINI.BLL;
using MINI.DAL;
using MINI.GUI.BaoCao;

namespace MINI.GUI.HoaDon
{
    public partial class HoaDon : Form
    {
        
        HoaDonBLL hd = new HoaDonBLL();
        CTHoaDonBLL cthd = new CTHoaDonBLL();
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
            
        }

        private void setNullHoaDon()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            dateTimePicker1 = null;
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
            if (lvHoaDon.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Xóa hóa đơn", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    hd.XoaHoaDon(lvHoaDon.SelectedItems[0].SubItems[0].Text);
                    lvHoaDon.Items.RemoveAt(
                    lvHoaDon.SelectedIndices[0]);
                    setNullHoaDon();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }
    }

    
}
