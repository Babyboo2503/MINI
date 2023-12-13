namespace MINI.GUI.BanHang
{
    partial class BanHang
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
            this.components = new System.ComponentModel.Container();
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.colIdSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIdLoaiSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSanPhamMua = new System.Windows.Forms.ListView();
            this.colIdSPmua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSPmua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSLmua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonGiaMua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTongTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIdKM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCKMua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBot = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.khuyenMaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miniMarketDataSet1 = new MINI.MiniMarketDataSet();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nhanVienTableAdapter = new MINI.MiniMarketDataSetTableAdapters.NhanVienTableAdapter();
            this.khachHangTableAdapter = new MINI.MiniMarketDataSetTableAdapters.KhachHangTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.textTimKiem = new System.Windows.Forms.TextBox();
            this.khuyenMaiTableAdapter = new MINI.MiniMarketDataSetTableAdapters.KhuyenMaiTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khuyenMaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMarketDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvSanPham
            // 
            this.lvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIdSP,
            this.colIdLoaiSP,
            this.colDonGia,
            this.colSoLuong,
            this.colTrangThai,
            this.colTenSP});
            this.lvSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSanPham.HideSelection = false;
            this.lvSanPham.Location = new System.Drawing.Point(0, 271);
            this.lvSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(678, 488);
            this.lvSanPham.TabIndex = 5;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            this.lvSanPham.View = System.Windows.Forms.View.Details;
            this.lvSanPham.SelectedIndexChanged += new System.EventHandler(this.lvSanPham_SelectedIndexChanged);
            // 
            // colIdSP
            // 
            this.colIdSP.Text = "Id sản phẩm";
            this.colIdSP.Width = 88;
            // 
            // colIdLoaiSP
            // 
            this.colIdLoaiSP.Text = "Id loại sản phẩm";
            this.colIdLoaiSP.Width = 115;
            // 
            // colDonGia
            // 
            this.colDonGia.Text = "Đơn giá";
            this.colDonGia.Width = 68;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 73;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Text = "Trạng thái";
            this.colTrangThai.Width = 74;
            // 
            // colTenSP
            // 
            this.colTenSP.Text = "Tên sản phẩm";
            this.colTenSP.Width = 110;
            // 
            // lvSanPhamMua
            // 
            this.lvSanPhamMua.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIdSPmua,
            this.colTenSPmua,
            this.colSLmua,
            this.colDonGiaMua,
            this.colTongTien,
            this.colIdKM,
            this.colCKMua});
            this.lvSanPhamMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSanPhamMua.HideSelection = false;
            this.lvSanPhamMua.Location = new System.Drawing.Point(688, 4);
            this.lvSanPhamMua.Margin = new System.Windows.Forms.Padding(4);
            this.lvSanPhamMua.Name = "lvSanPhamMua";
            this.lvSanPhamMua.Size = new System.Drawing.Size(485, 406);
            this.lvSanPhamMua.TabIndex = 7;
            this.lvSanPhamMua.UseCompatibleStateImageBehavior = false;
            this.lvSanPhamMua.View = System.Windows.Forms.View.Details;
            this.lvSanPhamMua.SelectedIndexChanged += new System.EventHandler(this.lvSanPhamMua_SelectedIndexChanged);
            // 
            // colIdSPmua
            // 
            this.colIdSPmua.Text = "Id sản phẩm";
            this.colIdSPmua.Width = 84;
            // 
            // colTenSPmua
            // 
            this.colTenSPmua.Text = "Tên sản phẩm";
            this.colTenSPmua.Width = 118;
            // 
            // colSLmua
            // 
            this.colSLmua.Text = "Số lượng mua";
            this.colSLmua.Width = 88;
            // 
            // colDonGiaMua
            // 
            this.colDonGiaMua.Text = "Đơn giá";
            this.colDonGiaMua.Width = 75;
            // 
            // colTongTien
            // 
            this.colTongTien.Text = "Tổng tiền";
            this.colTongTien.Width = 74;
            // 
            // colIdKM
            // 
            this.colIdKM.Text = "Id KM";
            // 
            // colCKMua
            // 
            this.colCKMua.Text = "Chiết khấu";
            this.colCKMua.Width = 74;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTang);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnBot);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(936, 577);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(242, 184);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hành động";
            // 
            // btnTang
            // 
            this.btnTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTang.Location = new System.Drawing.Point(8, 108);
            this.btnTang.Margin = new System.Windows.Forms.Padding(4);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(111, 74);
            this.btnTang.TabIndex = 20;
            this.btnTang.Text = "Tăng";
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(126, 26);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 74);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBot
            // 
            this.btnBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBot.Location = new System.Drawing.Point(126, 108);
            this.btnBot.Margin = new System.Windows.Forms.Padding(4);
            this.btnBot.Name = "btnBot";
            this.btnBot.Size = new System.Drawing.Size(111, 74);
            this.btnBot.TabIndex = 1;
            this.btnBot.Text = "Bớt";
            this.btnBot.UseVisualStyleBackColor = true;
            this.btnBot.Click += new System.EventHandler(this.btnBot_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(8, 26);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 74);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(59, 88);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(120, 80);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.textBox12);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(686, 580);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 181);
            this.panel1.TabIndex = 9;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Window;
            this.textBox12.Enabled = false;
            this.textBox12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox12.Location = new System.Drawing.Point(2, 48);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(238, 24);
            this.textBox12.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tổng hóa đơn";
            // 
            // khuyenMaiBindingSource
            // 
            this.khuyenMaiBindingSource.DataMember = "KhuyenMai";
            this.khuyenMaiBindingSource.DataSource = this.miniMarketDataSet1;
            // 
            // miniMarketDataSet1
            // 
            this.miniMarketDataSet1.DataSetName = "MiniMarketDataSet1";
            this.miniMarketDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.miniMarketDataSet1;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.miniMarketDataSet1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox11);
            this.panel3.Controls.Add(this.textBox9);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.textBox8);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.textBox10);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(686, 414);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(487, 158);
            this.panel3.TabIndex = 19;
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(364, 66);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(110, 27);
            this.textBox11.TabIndex = 18;
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(154, 65);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(92, 27);
            this.textBox9.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(144, 15);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(92, 27);
            this.textBox7.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(254, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tổng tiền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Số lượng mua:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Id sản phẩm:";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(158, 115);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(186, 27);
            this.textBox8.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(254, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Đơn giá:";
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(364, 15);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(110, 27);
            this.textBox10.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 120);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Tên sản phẩm:";
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.textTimKiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 207);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(611, 56);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(409, 20);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(186, 26);
            this.comboBox4.TabIndex = 3;
            this.comboBox4.Text = "Tìm theo";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(307, 18);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(94, 29);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(205, 18);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 29);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // textTimKiem
            // 
            this.textTimKiem.Location = new System.Drawing.Point(8, 20);
            this.textTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.textTimKiem.Name = "textTimKiem";
            this.textTimKiem.Size = new System.Drawing.Size(189, 24);
            this.textTimKiem.TabIndex = 0;
            // 
            // khuyenMaiTableAdapter
            // 
            this.khuyenMaiTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(26, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 166);
            this.panel2.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.khuyenMaiBindingSource;
            this.comboBox3.DisplayMember = "idKhuyenMai";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(136, 124);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(92, 28);
            this.comboBox3.TabIndex = 21;
            this.comboBox3.ValueMember = "idKhuyenMai";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.khachHangBindingSource;
            this.comboBox2.DisplayMember = "idKhachHang";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(136, 74);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 28);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.ValueMember = "idKhachHang";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.nhanVienBindingSource;
            this.comboBox1.DisplayMember = "idNhanVien";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 24);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 28);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "idNhanVien";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 128);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 18);
            this.label13.TabIndex = 15;
            this.label13.Text = "Id khuyến mãi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Id khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id nhân viên:";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khuyenMaiBindingSource, "tenKhuyenMai", true));
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(372, 124);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(235, 27);
            this.textBox6.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "hoVaTen", true));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(372, 24);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 27);
            this.textBox2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên khách hàng:";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "hoVaTen", true));
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(372, 74);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(235, 27);
            this.textBox4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên khuyến mãi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.lvSanPhamMua);
            this.panel4.Controls.Add(this.lvSanPham);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1182, 761);
            this.panel4.TabIndex = 22;
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 761);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BanHang";
            this.Text = "BanHang";
            this.Load += new System.EventHandler(this.BanHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khuyenMaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMarketDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.ColumnHeader colIdSP;
        private System.Windows.Forms.ColumnHeader colIdLoaiSP;
        private System.Windows.Forms.ColumnHeader colDonGia;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colTrangThai;
        private System.Windows.Forms.ColumnHeader colTenSP;
        private System.Windows.Forms.ListView lvSanPhamMua;
        private System.Windows.Forms.ColumnHeader colIdSPmua;
        private System.Windows.Forms.ColumnHeader colTenSPmua;
        private System.Windows.Forms.ColumnHeader colSLmua;
        private System.Windows.Forms.ColumnHeader colDonGiaMua;
        private System.Windows.Forms.ColumnHeader colTongTien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBot;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label15;
        private MiniMarketDataSet miniMarketDataSet1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private MiniMarketDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private MiniMarketDataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox textTimKiem;
        private System.Windows.Forms.ColumnHeader colIdKM;
        private System.Windows.Forms.ColumnHeader colCKMua;
        private System.Windows.Forms.BindingSource khuyenMaiBindingSource;
        private MiniMarketDataSetTableAdapters.KhuyenMaiTableAdapter khuyenMaiTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
    }
}