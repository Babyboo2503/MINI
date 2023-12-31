﻿using MINI.src.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MINI.src.GUI.PhieuNhap
{
    public partial class ChonNhaCungCap : Form
    {
        PhieuNhapBUS ncc = new PhieuNhapBUS();
        public string SelectedData { get; private set; }
        public ChonNhaCungCap()
        {
            InitializeComponent();
        }

        void HienThiNCC()
        {
            lsvchonncc.Items.Clear();
            DataTable dt = ncc.LayDSNCC();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvchonncc.Items.Add(dt.Rows[i][0].ToString()); lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
            }

        }

        void TimKiemTheoTenNCC(string tenNCC)
        {
            lsvchonncc.Items.Clear();
            DataTable dt = ncc.LayDSNCCTheoTenNCC(tenNCC); // Giả sử có một phương thức để lấy chi tiết nhập hàng dựa trên mã
                                                           // Điền dữ liệu vào ListView
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // Thêm dữ liệu vào ListView
                ListViewItem lvi =
                 lsvchonncc.Items.Add(dt.Rows[i][0].ToString()); lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
            }
        }

        private void ChonNhaCungCap_Load(object sender, EventArgs e)
        {
            txtsearchncc_Leave(sender, e);
            HienThiNCC();
        }

        private void btntimkiemncc_Click(object sender, EventArgs e)
        {
            TimKiemTheoTenNCC(txtsearchncc.Text);
        }

        private void btnlammoincc_Click(object sender, EventArgs e)
        {
            HienThiNCC();
            txtsearchncc.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            if (lsvchonncc.SelectedItems.Count > 0)
            {
                this.DialogResult = DialogResult.OK; // Thay đổi DialogResult của Form 2 thành OK khi người dùng chọn dữ liệu và click buttonSelect
                this.Close(); // Đóng Form 2 sau khi chọn dữ liệu
            }
        }

        private void lsvchonncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvchonncc.SelectedItems.Count > 0)
            {
                SelectedData = lsvchonncc.SelectedItems[0].SubItems[0].Text; // Lưu giá trị được chọn từ ListView vào SelectedData
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemNCC themncc = new ThemNCC();
            themncc.Controls["btnThem"].Visible = false;
            themncc.Controls["txttenncc"].Text = lsvchonncc.SelectedItems[0].SubItems[2].Text;
            themncc.Controls["txtdiachincc"].Text = lsvchonncc.SelectedItems[0].SubItems[1].Text;
            themncc.Controls["txtsdtncc"].Text = lsvchonncc.SelectedItems[0].SubItems[3].Text;
            themncc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemNCC themncc = new ThemNCC();
            themncc.Controls["btnSua"].Visible = false;
            themncc.Show();
        }

        private void button3_Leave(object sender, EventArgs e)
        {

        }

        private void txtsearchncc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsearchncc_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsearchncc.Text))
            {
                txtsearchncc.Text = "Tên Nhà Cung Cấp ";
                txtsearchncc.ForeColor = Color.DimGray;
            }
        }

        private void txtsearchncc_Click(object sender, EventArgs e)
        {
            txtsearchncc.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string maNCC = lsvchonncc.SelectedItems[0].SubItems[0].Text;
            ncc.XoaNCC(maNCC);
            lsvchonncc.Clear();
            HienThiNCC();
        }

        private void txttenncc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
