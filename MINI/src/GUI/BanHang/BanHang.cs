﻿using MINI.src.DTO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MINI.src.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MINI.GUI
{
    
    public partial class BanHang : Form
    {
        HoaDonBUS hd = new HoaDonBUS();
        CTHoaDonBUS cthd = new CTHoaDonBUS();
        ChiTietHoaDonDTO cthdDTO;
        HoaDonDTO hdDTO;
        public string Username,PassWord;
        public BanHang(string Username, string PassWord)
        {
            InitializeComponent();
            this.Username = Username;
            this.PassWord =PassWord; 
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            /*// TODO: This line of code loads data into the 'miniMarketDataSet1.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.miniMarketDataSet1.NhanVien);
            // TODO: This line of code loads data into the 'miniMarketDataSet1.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.miniMarketDataSet1.KhachHang);
            // TODO: This line of code loads data into the 'miniMarketDataSet1.KhuyenMai' table. You can move, or remove it, as needed.
            this.khuyenMaiTableAdapter.Fill(this.miniMarketDataSet1.KhuyenMai);*/
            
            DataTable dt = hd.LayId_TenNV(Username);
            textBox2.Text = dt.Rows[0][0].ToString();
            textBox5.Text = dt.Rows[0][1].ToString();
            comboBox2.DataSource = hd.LayDSKhachHang();
            comboBox2.DisplayMember = "hoVaTen";
            comboBox2.ValueMember = "idKhachHang";
            textBox4.Text = comboBox2.Items[0].ToString();

            comboBox3.DataSource = hd.LayDSKhuyenMai();
            comboBox3.DisplayMember = "tenKhuyenMai";
            comboBox3.ValueMember = "idKhuyenMai";
            textBox4.Text = comboBox3.Items[0].ToString();
            DataTable dt1 = hd.LayDSKhuyenMai();
            textBox3.Text = dt.Rows[0][6].ToString();

            HienthiSanPham();
        }



        void HienthiSanPham()
        {
            lvSanPham.FullRowSelect = true; //cho phép chọn 1 dòng
            lvSanPham.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
            lvSanPham.Items.Clear();
            DataTable dt = hd.LayDSSanPham();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lvSanPham.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());

            }
            lvSanPham.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lvSanPhamMua.FullRowSelect = true; //cho phép chọn 1 dòng
            lvSanPhamMua.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng

            if (lvSanPham.SelectedIndices.Count > 0)
            {

                for (int i = 0; i < lvSanPham.SelectedIndices.Count; i++)
                {
                    if (trungMaSP(lvSanPham.SelectedItems[i].SubItems[0].Text) == 1)
                    {
                        ListViewItem lvi = lvSanPhamMua.Items.Add(lvSanPham.SelectedItems[i].SubItems[0].Text);
                        lvi.SubItems.Add(lvSanPham.SelectedItems[i].SubItems[5].Text);
                        lvi.SubItems.Add("1");
                        lvi.SubItems.Add(lvSanPham.SelectedItems[i].SubItems[2].Text);
                        lvi.SubItems.Add(tongTien(lvi.SubItems[2].Text, lvi.SubItems[3].Text));
                        lvi.SubItems.Add(comboBox3.Text);
                        lvi.SubItems.Add("0");
                    }

                }
                lvSanPhamMua.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                tongHoaDon();
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu hàng để thêm");

        }

        private string tongTien(string a, string b)
        {
            return (int.Parse(a) * decimal.Parse(b)).ToString();
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            if (lvSanPhamMua.SelectedIndices.Count > 0)
            {
                textBox9.Text = tangSoLuong(lvSanPhamMua.SelectedItems[0].SubItems[2].Text, lvSanPhamMua.SelectedItems[0].SubItems[0].Text);
                lvSanPhamMua.SelectedItems[0].SubItems[2].Text = textBox9.Text;
                textBox11.Text = tongTien(lvSanPhamMua.SelectedItems[0].SubItems[2].Text, lvSanPhamMua.SelectedItems[0].SubItems[3].Text);
                lvSanPhamMua.SelectedItems[0].SubItems[4].Text = textBox11.Text;

            }
            tongHoaDon();
        }

        private void lvSanPhamMua_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPhamMua.SelectedIndices.Count > 0)
            {
                textBox7.Text = lvSanPhamMua.SelectedItems[0].SubItems[0].Text;
                textBox8.Text = lvSanPhamMua.SelectedItems[0].SubItems[1].Text;
                textBox9.Text = lvSanPhamMua.SelectedItems[0].SubItems[2].Text;
                textBox10.Text = lvSanPhamMua.SelectedItems[0].SubItems[3].Text;
                textBox11.Text = lvSanPhamMua.SelectedItems[0].SubItems[4].Text;

            }

        }

        private string GioiHanSL(string a)
        {
            string b = "0";
            for (int i = 0; i < lvSanPham.Items.Count; i++)
            {
                if (a == lvSanPham.Items[i].SubItems[0].Text)
                {
                    b = lvSanPham.Items[i].SubItems[3].Text;
                    break;
                }
            }
            return b;
        }

        private string tangSoLuong(string a, string b)
        {
            if (int.Parse(a) + 1 <= int.Parse(GioiHanSL(b)))
                return (int.Parse(a) + 1).ToString();
            return (int.Parse(a)).ToString();
        }

        private void btnBot_Click(object sender, EventArgs e)
        {
            if (lvSanPhamMua.SelectedIndices.Count > 0)
            {
                textBox9.Text = botSoLuong(lvSanPhamMua.SelectedItems[0].SubItems[2].Text);
                lvSanPhamMua.SelectedItems[0].SubItems[2].Text = textBox9.Text;
                textBox11.Text = tongTien(lvSanPhamMua.SelectedItems[0].SubItems[2].Text, lvSanPhamMua.SelectedItems[0].SubItems[3].Text);
                lvSanPhamMua.SelectedItems[0].SubItems[4].Text = textBox11.Text;
            }
            tongHoaDon();
        }

        private string botSoLuong(string a)
        {
            if (int.Parse(a) - 1 > 0)
                return (int.Parse(a) - 1).ToString();
            else return a;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSanPhamMua.SelectedIndices.Count > 0)
            {
                lvSanPhamMua.Items.RemoveAt(lvSanPhamMua.SelectedIndices[0]);
                setNullSanPhamMua();
            }
            tongHoaDon();
        }

        private void setNullSanPhamMua()
        {
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
        }

        private void tongHoaDon()
        {
            textBox12.Text = "0";
            for (int i = 0; i < lvSanPhamMua.Items.Count; i++)
            {
                textBox12.Text = tongHoaDon(textBox12.Text, lvSanPhamMua.Items[i].SubItems[4].Text);
            }
            KiemTraDieuKienKM();

        }
        private string tongHoaDon(string a, string b)
        {
            return (decimal.Parse(a) + decimal.Parse(b)).ToString();
        }

        private int trungMaSP(string id)
        {
            if (lvSanPhamMua.Items.Count > 0)
            {
                int k = 0;
                for (int i = 0; i < lvSanPhamMua.Items.Count; i++)
                {
                    if (id == lvSanPhamMua.Items[i].SubItems[0].Text)
                    {
                        k = 1; break;
                    }
                }
                if (k == 1)
                    return 0;
                else return 1;
            }
            else return 1;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            hdDTO = new HoaDonDTO();
            hdDTO.idNhanVien = int.Parse(textBox2.Text);
            hdDTO.idKhachHang = int.Parse(textBox4.Text);
            hdDTO.ngayLap = DateTime.Now;
            hdDTO.idKhuyenMai = int.Parse(textBox6.Text);
            hdDTO.tongHoaDon = float.Parse(textBox1.Text);
            hd.ThemHoaDon(hdDTO);
            DataTable dt = hd.LayMaHDMoi();
            string a = dt.Rows[0][0].ToString();

            for (int i = 0; i < lvSanPhamMua.Items.Count; i++)
            {
                cthdDTO = new ChiTietHoaDonDTO();
                cthdDTO.idHoaDon = int.Parse(a);
                cthdDTO.idSanPham = int.Parse(lvSanPhamMua.Items[i].SubItems[0].Text);
                cthdDTO.soLuong = int.Parse(lvSanPhamMua.Items[i].SubItems[2].Text);
                cthdDTO.donGia = decimal.Parse(lvSanPhamMua.Items[i].SubItems[3].Text);
                cthdDTO.tongTien = decimal.Parse(lvSanPhamMua.Items[i].SubItems[4].Text);
                cthd.ThemCTHoaDon(cthdDTO);
            }

            MessageBox.Show("Thành công");
            cthd.UpdateDiemKH(xetTongHoaDon().ToString(), textBox4.Text);
            if (textBox12.Text != textBox1.Text)
                cthd.UpdateDiemADKM(int.Parse(textBox3.Text.Replace(">", string.Empty)).ToString(), textBox4.Text);
            for (int i = 0; i < lvSanPhamMua.Items.Count; i++)
            {
                cthd.BotSanPham(lvSanPhamMua.Items[i].SubItems[0].Text, lvSanPhamMua.Items[i].SubItems[2].Text);
            }
            cthd.UpdateTTSanPham();
            lvSanPhamMua.Items.Clear();
            setNull();
            lammoi();

        }
        public void setNull()
        {
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox10.Text = string.Empty;
            textBox11.Text = string.Empty;
            textBox12.Text = string.Empty;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HienthiSanPham();
            if (comboBox4.Text == "Id sản phẩm")
            {
                foreach (ListViewItem item in lvSanPham.Items)
                {
                    if (!item.SubItems[0].Text.ToLower().Equals(textTimKiem.Text.ToLower()))
                    {
                        lvSanPham.Items.Remove(item);
                    }
                }
            }
            else if (comboBox4.Text == "Id loại sản phẩm")
            {
                foreach (ListViewItem item in lvSanPham.Items)
                {
                    if (!item.SubItems[1].Text.ToLower().Equals(textTimKiem.Text.ToLower()))
                    {
                        lvSanPham.Items.Remove(item);
                    }
                }
            }
            else if (comboBox4.Text == "Tên sản phẩm")
            {
                foreach (ListViewItem item in lvSanPham.Items)
                {
                    if (!item.SubItems[5].Text.ToLower().Contains(textTimKiem.Text.ToLower()))
                    {
                        lvSanPham.Items.Remove(item);
                    }
                }
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lammoi();
        }
        private void lammoi()
        {
            textTimKiem.Text = string.Empty;
            comboBox4.Text = "Tìm theo";
            HienthiSanPham();
        }

        private void KiemTraDieuKienKM()
        {
            DataTable dt = hd.LayDiemKH(textBox4.Text);
            DataTable dt1 = hd.LayphanTramKM(textBox6.Text);
            int a = int.Parse(dt.Rows[0][0].ToString());
            int b = int.Parse(textBox3.Text.Replace(">", string.Empty));
            if (a > b)
            {
                string c = dt1.Rows[0][0].ToString();
                textBox1.Text = ApDungKM(c, textBox12.Text);
            }
            else textBox1.Text = textBox12.Text;
        }

        private string ApDungKM(string c, string d)
        {
            decimal a = decimal.Parse(d) - (decimal.Parse(d) * decimal.Parse(c)) / 100;
            return a.ToString();
        }

        private int xetTongHoaDon()
        {
            int a = 0;
            decimal b = decimal.Parse(textBox1.Text);
            while (b >= 50000)
            {
                a++;
                b = b - (decimal)50000;
            }
            return a;

        }

        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox4.Text = comboBox2.SelectedValue.ToString();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox6.Text = comboBox3.SelectedValue.ToString();
            DataTable dt = hd.LayDSKhuyenMai();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString().Equals(comboBox3.SelectedValue.ToString()))
                {
                    textBox3.Text = dt.Rows[i][6].ToString();
                }
            }

        }
    }
}
