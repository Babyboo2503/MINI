namespace MINI.src.GUI
{
    partial class KhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhuyenMai));
            this.tabApDungKM = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnHuyKhuyenMai = new System.Windows.Forms.Button();
            this.btnApDung = new System.Windows.Forms.Button();
            this.lsvKMSanPham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSanPham = new System.Windows.Forms.TextBox();
            this.txtKhuyenMai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbSanPham = new System.Windows.Forms.ComboBox();
            this.cbbKhuyenMai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDSKM = new System.Windows.Forms.TabPage();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbDieuKien = new System.Windows.Forms.ComboBox();
            this.cbbNoiDung = new System.Windows.Forms.ComboBox();
            this.txtPhanTram = new System.Windows.Forms.TextBox();
            this.txtTenKM = new System.Windows.Forms.TextBox();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lsvKhuyenMai = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayBatDau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayKetThuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenKhuyenMai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhanTram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NoiDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DieuKien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabKhuyenMai = new System.Windows.Forms.TabControl();
            this.label11 = new System.Windows.Forms.Label();
            this.tabApDungKM.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabDSKM.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabKhuyenMai.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabApDungKM
            // 
            this.tabApDungKM.AutoScroll = true;
            this.tabApDungKM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabApDungKM.BackgroundImage")));
            this.tabApDungKM.Controls.Add(this.label11);
            this.tabApDungKM.Controls.Add(this.groupBox1);
            this.tabApDungKM.Controls.Add(this.btnHuyKhuyenMai);
            this.tabApDungKM.Controls.Add(this.lsvKMSanPham);
            this.tabApDungKM.Controls.Add(this.txtSanPham);
            this.tabApDungKM.Controls.Add(this.txtKhuyenMai);
            this.tabApDungKM.Controls.Add(this.label8);
            this.tabApDungKM.Controls.Add(this.label3);
            this.tabApDungKM.Controls.Add(this.cbbSanPham);
            this.tabApDungKM.Controls.Add(this.cbbKhuyenMai);
            this.tabApDungKM.Controls.Add(this.label2);
            this.tabApDungKM.Controls.Add(this.label1);
            this.tabApDungKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabApDungKM.Location = new System.Drawing.Point(4, 54);
            this.tabApDungKM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabApDungKM.Name = "tabApDungKM";
            this.tabApDungKM.Size = new System.Drawing.Size(1174, 703);
            this.tabApDungKM.TabIndex = 0;
            this.tabApDungKM.Text = "Áp dụng khuyến mãi";
            this.tabApDungKM.UseVisualStyleBackColor = true;
            this.tabApDungKM.Click += new System.EventHandler(this.KhuyenMai_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.btnApDung);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(9, 310);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(547, 60);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm sản phẩm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.PowderBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Image = global::MINI.Properties.Resources.icons8_search_32;
            this.btnTimKiem.Location = new System.Drawing.Point(276, 13);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(122, 43);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(4, 22);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(253, 28);
            this.txtTimKiem.TabIndex = 0;
            // 
            // btnHuyKhuyenMai
            // 
            this.btnHuyKhuyenMai.BackColor = System.Drawing.Color.PowderBlue;
            this.btnHuyKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyKhuyenMai.Image = global::MINI.Properties.Resources.icons8_cancel_32;
            this.btnHuyKhuyenMai.Location = new System.Drawing.Point(323, 411);
            this.btnHuyKhuyenMai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuyKhuyenMai.Name = "btnHuyKhuyenMai";
            this.btnHuyKhuyenMai.Size = new System.Drawing.Size(219, 43);
            this.btnHuyKhuyenMai.TabIndex = 10;
            this.btnHuyKhuyenMai.Text = "Hủy Khuyến Mãi";
            this.btnHuyKhuyenMai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuyKhuyenMai.UseVisualStyleBackColor = false;
            this.btnHuyKhuyenMai.Click += new System.EventHandler(this.btnHuyKhuyenMai_Click);
            // 
            // btnApDung
            // 
            this.btnApDung.BackColor = System.Drawing.Color.PowderBlue;
            this.btnApDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnApDung.Image = global::MINI.Properties.Resources.icons8_promotion_32;
            this.btnApDung.Location = new System.Drawing.Point(411, 12);
            this.btnApDung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApDung.Name = "btnApDung";
            this.btnApDung.Size = new System.Drawing.Size(122, 43);
            this.btnApDung.TabIndex = 9;
            this.btnApDung.Text = "Áp Dụng";
            this.btnApDung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApDung.UseVisualStyleBackColor = false;
            this.btnApDung.Click += new System.EventHandler(this.btnApDung_Click);
            // 
            // lsvKMSanPham
            // 
            this.lsvKMSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvKMSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsvKMSanPham.HideSelection = false;
            this.lsvKMSanPham.Location = new System.Drawing.Point(577, 158);
            this.lsvKMSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsvKMSanPham.Name = "lsvKMSanPham";
            this.lsvKMSanPham.Size = new System.Drawing.Size(573, 448);
            this.lsvKMSanPham.TabIndex = 8;
            this.lsvKMSanPham.UseCompatibleStateImageBehavior = false;
            this.lsvKMSanPham.View = System.Windows.Forms.View.Details;
            this.lsvKMSanPham.SelectedIndexChanged += new System.EventHandler(this.lsvKMSanPham_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Sản Phẩm";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Sản Phẩm";
            this.columnHeader2.Width = 168;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Khuyến Mãi";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Chiết Khấu";
            this.columnHeader4.Width = 150;
            // 
            // txtSanPham
            // 
            this.txtSanPham.Enabled = false;
            this.txtSanPham.Location = new System.Drawing.Point(168, 266);
            this.txtSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.Size = new System.Drawing.Size(76, 24);
            this.txtSanPham.TabIndex = 7;
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.Enabled = false;
            this.txtKhuyenMai.Location = new System.Drawing.Point(168, 201);
            this.txtKhuyenMai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.Size = new System.Drawing.Size(98, 24);
            this.txtKhuyenMai.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(32, 266);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "id sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(32, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "id khuyến mãi:";
            // 
            // cbbSanPham
            // 
            this.cbbSanPham.FormattingEnabled = true;
            this.cbbSanPham.Location = new System.Drawing.Point(168, 233);
            this.cbbSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbSanPham.Name = "cbbSanPham";
            this.cbbSanPham.Size = new System.Drawing.Size(262, 25);
            this.cbbSanPham.TabIndex = 3;
            this.cbbSanPham.SelectedIndexChanged += new System.EventHandler(this.cbbSanPham_SelectedIndexChanged);
            // 
            // cbbKhuyenMai
            // 
            this.cbbKhuyenMai.FormattingEnabled = true;
            this.cbbKhuyenMai.Location = new System.Drawing.Point(168, 168);
            this.cbbKhuyenMai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbKhuyenMai.Name = "cbbKhuyenMai";
            this.cbbKhuyenMai.Size = new System.Drawing.Size(262, 25);
            this.cbbKhuyenMai.TabIndex = 2;
            this.cbbKhuyenMai.SelectedIndexChanged += new System.EventHandler(this.cbbKhuyenMai_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(32, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(32, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khuyến mãi:";
            // 
            // tabDSKM
            // 
            this.tabDSKM.AutoScroll = true;
            this.tabDSKM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabDSKM.BackgroundImage")));
            this.tabDSKM.Controls.Add(this.btnHuy);
            this.tabDSKM.Controls.Add(this.btnLuu);
            this.tabDSKM.Controls.Add(this.btnSua);
            this.tabDSKM.Controls.Add(this.btnThem);
            this.tabDSKM.Controls.Add(this.groupBox2);
            this.tabDSKM.Controls.Add(this.lsvKhuyenMai);
            this.tabDSKM.Location = new System.Drawing.Point(4, 54);
            this.tabDSKM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDSKM.Name = "tabDSKM";
            this.tabDSKM.Size = new System.Drawing.Size(1174, 703);
            this.tabDSKM.TabIndex = 0;
            this.tabDSKM.Text = "Danh sách khuyến mãi";
            this.tabDSKM.UseVisualStyleBackColor = true;
            this.tabDSKM.Click += new System.EventHandler(this.KhuyenMai_Load);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.PowderBlue;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::MINI.Properties.Resources.icons8_cancel_32;
            this.btnHuy.Location = new System.Drawing.Point(1034, 261);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(88, 54);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::MINI.Properties.Resources.icons8_save_32;
            this.btnLuu.Location = new System.Drawing.Point(932, 261);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 54);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::MINI.Properties.Resources.icons8_edit_32;
            this.btnSua.Location = new System.Drawing.Point(830, 261);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 54);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.PowderBlue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::MINI.Properties.Resources.icons8_add_32;
            this.btnThem.Location = new System.Drawing.Point(728, 261);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 54);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Controls.Add(this.cbbDieuKien);
            this.groupBox2.Controls.Add(this.cbbNoiDung);
            this.groupBox2.Controls.Add(this.txtPhanTram);
            this.groupBox2.Controls.Add(this.txtTenKM);
            this.groupBox2.Controls.Add(this.dtpNgayKetThuc);
            this.groupBox2.Controls.Add(this.dtpNgayBatDau);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(126, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(557, 293);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết khuyến mãi";
            // 
            // cbbDieuKien
            // 
            this.cbbDieuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbDieuKien.FormattingEnabled = true;
            this.cbbDieuKien.Items.AddRange(new object[] {
            ">10",
            ">15",
            ">20",
            ">25",
            ">30"});
            this.cbbDieuKien.Location = new System.Drawing.Point(209, 244);
            this.cbbDieuKien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbDieuKien.Name = "cbbDieuKien";
            this.cbbDieuKien.Size = new System.Drawing.Size(273, 26);
            this.cbbDieuKien.TabIndex = 13;
            // 
            // cbbNoiDung
            // 
            this.cbbNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbNoiDung.FormattingEnabled = true;
            this.cbbNoiDung.Items.AddRange(new object[] {
            "Giảm trên tổng hóa đơn",
            "Giảm trên từng sản phẩm"});
            this.cbbNoiDung.Location = new System.Drawing.Point(209, 205);
            this.cbbNoiDung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbNoiDung.Name = "cbbNoiDung";
            this.cbbNoiDung.Size = new System.Drawing.Size(273, 26);
            this.cbbNoiDung.TabIndex = 12;
            // 
            // txtPhanTram
            // 
            this.txtPhanTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhanTram.Location = new System.Drawing.Point(209, 166);
            this.txtPhanTram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhanTram.Name = "txtPhanTram";
            this.txtPhanTram.Size = new System.Drawing.Size(273, 24);
            this.txtPhanTram.TabIndex = 9;
            // 
            // txtTenKM
            // 
            this.txtTenKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenKM.Location = new System.Drawing.Point(209, 126);
            this.txtTenKM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenKM.Name = "txtTenKM";
            this.txtTenKM.Size = new System.Drawing.Size(273, 24);
            this.txtTenKM.TabIndex = 8;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "MM-dd-yyyy";
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(209, 86);
            this.dtpNgayKetThuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(273, 24);
            this.dtpNgayKetThuc.TabIndex = 7;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "MM-dd-yyyy";
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(209, 48);
            this.dtpNgayBatDau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(273, 24);
            this.dtpNgayBatDau.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(33, 245);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Điều kiện*:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(33, 205);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Nội dung*:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(33, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Phần trăm*:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(33, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên khuyến mãi*:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(33, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày kết thúc*:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(33, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày bắt đầu*:";
            // 
            // lsvKhuyenMai
            // 
            this.lsvKhuyenMai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.TenKhuyenMai,
            this.PhanTram,
            this.NoiDung,
            this.DieuKien});
            this.lsvKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsvKhuyenMai.HideSelection = false;
            this.lsvKhuyenMai.Location = new System.Drawing.Point(20, 328);
            this.lsvKhuyenMai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsvKhuyenMai.Name = "lsvKhuyenMai";
            this.lsvKhuyenMai.Size = new System.Drawing.Size(1117, 349);
            this.lsvKhuyenMai.TabIndex = 4;
            this.lsvKhuyenMai.UseCompatibleStateImageBehavior = false;
            this.lsvKhuyenMai.View = System.Windows.Forms.View.Details;
            this.lsvKhuyenMai.SelectedIndexChanged += new System.EventHandler(this.lsvKhuyenMai_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 37;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.Text = "Ngày Bắt Đầu";
            this.NgayBatDau.Width = 121;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.Text = "Ngày Kết Thúc";
            this.NgayKetThuc.Width = 130;
            // 
            // TenKhuyenMai
            // 
            this.TenKhuyenMai.Text = "Tên Khuyến Mãi";
            this.TenKhuyenMai.Width = 145;
            // 
            // PhanTram
            // 
            this.PhanTram.Text = "Phần Trăm";
            this.PhanTram.Width = 96;
            // 
            // NoiDung
            // 
            this.NoiDung.Text = "Nội Dung";
            this.NoiDung.Width = 120;
            // 
            // DieuKien
            // 
            this.DieuKien.Text = "Điều Kiện";
            this.DieuKien.Width = 100;
            // 
            // tabKhuyenMai
            // 
            this.tabKhuyenMai.Controls.Add(this.tabDSKM);
            this.tabKhuyenMai.Controls.Add(this.tabApDungKM);
            this.tabKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabKhuyenMai.ItemSize = new System.Drawing.Size(136, 50);
            this.tabKhuyenMai.Location = new System.Drawing.Point(0, 0);
            this.tabKhuyenMai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabKhuyenMai.Name = "tabKhuyenMai";
            this.tabKhuyenMai.SelectedIndex = 0;
            this.tabKhuyenMai.Size = new System.Drawing.Size(1182, 761);
            this.tabKhuyenMai.TabIndex = 1;
            this.tabKhuyenMai.Click += new System.EventHandler(this.KhuyenMai_Load);
            this.tabKhuyenMai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckValue_Key);
            this.tabKhuyenMai.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CheckValue_Key);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(437, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(259, 42);
            this.label11.TabIndex = 12;
            this.label11.Text = "KHUYẾN MÃI";
            // 
            // KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 761);
            this.Controls.Add(this.tabKhuyenMai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KhuyenMai";
            this.Text = "Nhân viên";
            this.tabApDungKM.ResumeLayout(false);
            this.tabApDungKM.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabDSKM.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabKhuyenMai.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabApDungKM;
        private System.Windows.Forms.TabPage tabDSKM;
        private System.Windows.Forms.ListView lsvKhuyenMai;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NgayBatDau;
        private System.Windows.Forms.ColumnHeader NgayKetThuc;
        private System.Windows.Forms.ColumnHeader TenKhuyenMai;
        private System.Windows.Forms.ColumnHeader PhanTram;
        private System.Windows.Forms.ColumnHeader NoiDung;
        private System.Windows.Forms.ColumnHeader DieuKien;
        private System.Windows.Forms.TabControl tabKhuyenMai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenKM;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhanTram;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbKhuyenMai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSanPham;
        private System.Windows.Forms.TextBox txtKhuyenMai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbSanPham;
        private System.Windows.Forms.Button btnHuyKhuyenMai;
        private System.Windows.Forms.Button btnApDung;
        private System.Windows.Forms.ListView lsvKMSanPham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cbbNoiDung;
        private System.Windows.Forms.ComboBox cbbDieuKien;
        private System.Windows.Forms.Label label11;
    }
}