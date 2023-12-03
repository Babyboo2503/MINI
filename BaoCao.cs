using MINI.DTO;
using MINI.BLL;
using MINI.GUI.HoaDon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINI.GUI.BaoCao
{
    public partial class BaoCao : Form
    {
        BaoCaoBLL bc =new BaoCaoBLL();
        public BaoCao()
        {
            InitializeComponent();
        }
        void HienthiBaoCao()
        {
            lvBaoCao.FullRowSelect = true; //cho phép chọn 1 dòng
            lvBaoCao.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
            lvBaoCao.Items.Clear();
            DataTable dt = bc.LayDSBaoCao();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lvBaoCao.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
            }
            lvBaoCao.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        private void lvBaoCao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBaoCao.SelectedIndices.Count > 0)
            {
                textBox1.Text = lvBaoCao.SelectedItems[0].SubItems[0].Text;
                dateTimePicker1.Value = DateTime.Parse(lvBaoCao.SelectedItems[0].SubItems[1].Text);
                textBox7.Text = lvBaoCao.SelectedItems[0].SubItems[2].Text;
                textBox3.Text = lvBaoCao.SelectedItems[0].SubItems[3].Text;
                textBox8.Text = lvBaoCao.SelectedItems[0].SubItems[4].Text;
                textBox5.Text = lvBaoCao.SelectedItems[0].SubItems[5].Text;
                textBox2.Text = lvBaoCao.SelectedItems[0].SubItems[6].Text;
                richTextBox1.Text = lvBaoCao.SelectedItems[0].SubItems[7].Text;
            }

        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            HienthiBaoCao();
        }

        private void setNull()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            dateTimePicker1 = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            richTextBox1.Text = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvBaoCao.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Xóa báo cáo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    bc.XoaBaoCao(lvBaoCao.SelectedItems[0].SubItems[0].Text);
                    lvBaoCao.Items.RemoveAt(
                    lvBaoCao.SelectedIndices[0]);
                    setNull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }
    }
}
