using MINI.src.DTO;
using MINI.src.DAO;
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

namespace MINI.GUI.BaoCao
{
    public partial class BaoCao : Form
    {
        BaoCaoBUS bc =new BaoCaoBUS();
        BaoCaoDTO bcDTO;
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
                comboBox2.Text = lvBaoCao.SelectedItems[0].SubItems[2].Text;
                textBox3.Text = lvBaoCao.SelectedItems[0].SubItems[3].Text;
                comboBox3.Text = lvBaoCao.SelectedItems[0].SubItems[4].Text;
                textBox5.Text = lvBaoCao.SelectedItems[0].SubItems[5].Text;
                textBox2.Text = lvBaoCao.SelectedItems[0].SubItems[6].Text;
                richTextBox1.Text = lvBaoCao.SelectedItems[0].SubItems[7].Text;
            }

        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'miniMarketDataSet1.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.miniMarketDataSet1.SanPham);
            // TODO: This line of code loads data into the 'miniMarketDataSet1.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.miniMarketDataSet1.NhanVien);
            HienthiBaoCao();
        }

        private void setNull()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox5.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
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
                    MessageBox.Show("Thành công");
                    setNull();

                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (check_null() == 0)
            {
                bcDTO = new BaoCaoDTO();
                bcDTO.idNhanVien = int.Parse(comboBox4.Text);
                bcDTO.idSanPham = int.Parse(comboBox5.Text);
                bcDTO.ngayLap = DateTime.Now;
                bcDTO.soLuong = int.Parse(textBox12.Text);
                bcDTO.lyDo = richTextBox2.Text;
                bc.ThemBaoCao(bcDTO);
                bc.BotSanPham(comboBox5.Text, textBox12.Text);
                MessageBox.Show("Thành công");
                setNullTao();
            }
        }

        private int check_null()
        {
            if (textBox12.Text=="")
            {
                MessageBox.Show("Phải chọn số lượng");
                return 1;
            }    
            else if(richTextBox2.Text=="") 
            {
                MessageBox.Show("Phải ghi lý do");
                return 1;
            }
            else return 0;
        }
        private void setNullTao()
        {
            comboBox4.Text = null;
            comboBox5.Text=null;
            textBox10.Text = null;
            textBox11.Text = null;
            textBox12.Text = null;
            richTextBox2.Text = null;
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienthiBaoCao();
        }
    }
}
