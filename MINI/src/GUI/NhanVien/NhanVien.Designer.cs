namespace MINI.GUI
{
    partial class NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabNhanVien = new System.Windows.Forms.TabControl();
            this.tabDSNV = new System.Windows.Forms.TabPage();
            this.listViewNhanVien = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoVaTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChucVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lable8 = new System.Windows.Forms.Label();
            this.lable7 = new System.Windows.Forms.Label();
            this.lable6 = new System.Windows.Forms.Label();
            this.lable5 = new System.Windows.Forms.Label();
            this.lable4 = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabThemNV = new System.Windows.Forms.TabPage();
            this.tabSuaNV = new System.Windows.Forms.TabPage();
            this.tabNhanVien.SuspendLayout();
            this.tabDSNV.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Controls.Add(this.tabDSNV);
            this.tabNhanVien.Controls.Add(this.tabThemNV);
            this.tabNhanVien.Controls.Add(this.tabSuaNV);
            this.tabNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabNhanVien.ItemSize = new System.Drawing.Size(136, 50);
            this.tabNhanVien.Location = new System.Drawing.Point(0, 0);
            this.tabNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.SelectedIndex = 0;
            this.tabNhanVien.Size = new System.Drawing.Size(868, 449);
            this.tabNhanVien.TabIndex = 1;
            // 
            // tabDSNV
            // 
            this.tabDSNV.AutoScroll = true;
            this.tabDSNV.Controls.Add(this.listViewNhanVien);
            this.tabDSNV.Controls.Add(this.btnSua);
            this.tabDSNV.Controls.Add(this.panel1);
            this.tabDSNV.Location = new System.Drawing.Point(4, 54);
            this.tabDSNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDSNV.Name = "tabDSNV";
            this.tabDSNV.Size = new System.Drawing.Size(860, 391);
            this.tabDSNV.TabIndex = 0;
            this.tabDSNV.Text = "Danh sách nhân viên";
            this.tabDSNV.UseVisualStyleBackColor = true;
            // 
            // listViewNhanVien
            // 
            this.listViewNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.HoVaTen,
            this.GioiTinh,
            this.SDT,
            this.DiaChi,
            this.ChucVu,
            this.TrangThai});
            this.listViewNhanVien.HideSelection = false;
            this.listViewNhanVien.Location = new System.Drawing.Point(20, 240);
            this.listViewNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewNhanVien.Name = "listViewNhanVien";
            this.listViewNhanVien.Size = new System.Drawing.Size(486, 157);
            this.listViewNhanVien.TabIndex = 4;
            this.listViewNhanVien.UseCompatibleStateImageBehavior = false;
            this.listViewNhanVien.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // HoVaTen
            // 
            this.HoVaTen.Text = "Họ và tên";
            this.HoVaTen.Width = 121;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DisplayIndex = 4;
            this.GioiTinh.Text = "Giới tính";
            // 
            // SDT
            // 
            this.SDT.Text = "Số điện thoại";
            this.SDT.Width = 111;
            // 
            // DiaChi
            // 
            this.DiaChi.DisplayIndex = 2;
            this.DiaChi.Text = "Địa chỉ";
            this.DiaChi.Width = 90;
            // 
            // ChucVu
            // 
            this.ChucVu.Text = "Chức vụ";
            // 
            // TrangThai
            // 
            this.TrangThai.Text = "Trạng Thái";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::MINI.Properties.Resources.icons8_sort_32;
            this.btnSua.Location = new System.Drawing.Point(424, 40);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(60, 31);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lable8);
            this.panel1.Controls.Add(this.lable7);
            this.panel1.Controls.Add(this.lable6);
            this.panel1.Controls.Add(this.lable5);
            this.panel1.Controls.Add(this.lable4);
            this.panel1.Controls.Add(this.lable3);
            this.panel1.Controls.Add(this.lable2);
            this.panel1.Controls.Add(this.lable1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(103, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 170);
            this.panel1.TabIndex = 2;
            // 
            // lable8
            // 
            this.lable8.AutoSize = true;
            this.lable8.Location = new System.Drawing.Point(100, 143);
            this.lable8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable8.Name = "lable8";
            this.lable8.Size = new System.Drawing.Size(62, 13);
            this.lable8.TabIndex = 10;
            this.lable8.Text = "Trạng Thái:";
            // 
            // lable7
            // 
            this.lable7.AutoSize = true;
            this.lable7.Location = new System.Drawing.Point(100, 125);
            this.lable7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable7.Name = "lable7";
            this.lable7.Size = new System.Drawing.Size(50, 13);
            this.lable7.TabIndex = 9;
            this.lable7.Text = "Giới tính:";
            // 
            // lable6
            // 
            this.lable6.AutoSize = true;
            this.lable6.Location = new System.Drawing.Point(100, 107);
            this.lable6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable6.Name = "lable6";
            this.lable6.Size = new System.Drawing.Size(48, 13);
            this.lable6.TabIndex = 8;
            this.lable6.Text = "Chức Vụ";
            // 
            // lable5
            // 
            this.lable5.AutoSize = true;
            this.lable5.Location = new System.Drawing.Point(100, 89);
            this.lable5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable5.Name = "lable5";
            this.lable5.Size = new System.Drawing.Size(57, 13);
            this.lable5.TabIndex = 7;
            this.lable5.Text = "Ngày sinh:";
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Location = new System.Drawing.Point(100, 72);
            this.lable4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(43, 13);
            this.lable4.TabIndex = 6;
            this.lable4.Text = "Địa chỉ:";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Location = new System.Drawing.Point(100, 54);
            this.lable3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(73, 13);
            this.lable3.TabIndex = 5;
            this.lable3.Text = "Số điện thoại:";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(100, 36);
            this.lable2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(57, 13);
            this.lable2.TabIndex = 4;
            this.lable2.Text = "Họ và tên:";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(100, 18);
            this.lable1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(21, 13);
            this.lable1.TabIndex = 3;
            this.lable1.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(18, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 87);
            this.panel2.TabIndex = 2;
            // 
            // tabThemNV
            // 
            this.tabThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabThemNV.Location = new System.Drawing.Point(4, 54);
            this.tabThemNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabThemNV.Name = "tabThemNV";
            this.tabThemNV.Size = new System.Drawing.Size(860, 391);
            this.tabThemNV.TabIndex = 0;
            this.tabThemNV.Text = "Thêm nhân viên";
            this.tabThemNV.UseVisualStyleBackColor = true;
            // 
            // tabSuaNV
            // 
            this.tabSuaNV.Location = new System.Drawing.Point(4, 54);
            this.tabSuaNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSuaNV.Name = "tabSuaNV";
            this.tabSuaNV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSuaNV.Size = new System.Drawing.Size(860, 391);
            this.tabSuaNV.TabIndex = 1;
            this.tabSuaNV.Text = "Sửa nhân viên";
            this.tabSuaNV.UseVisualStyleBackColor = true;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 449);
            this.Controls.Add(this.tabNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NhanVien";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.tabNhanVien.ResumeLayout(false);
            this.tabDSNV.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabNhanVien;
        private System.Windows.Forms.TabPage tabDSNV;
        private System.Windows.Forms.TabPage tabThemNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lable8;
        private System.Windows.Forms.Label lable7;
        private System.Windows.Forms.Label lable6;
        private System.Windows.Forms.Label lable5;
        private System.Windows.Forms.TabPage tabSuaNV;
        private System.Windows.Forms.ListView listViewNhanVien;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader HoVaTen;
        private System.Windows.Forms.ColumnHeader GioiTinh;
        private System.Windows.Forms.ColumnHeader SDT;
        private System.Windows.Forms.ColumnHeader DiaChi;
        private System.Windows.Forms.ColumnHeader ChucVu;
        private System.Windows.Forms.ColumnHeader TrangThai;
    }
}