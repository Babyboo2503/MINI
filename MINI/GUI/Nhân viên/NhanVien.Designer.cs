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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
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
            this.lbHoVaTen = new System.Windows.Forms.Label();
            this.lblSinhNgay = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.radioBtnNam = new System.Windows.Forms.RadioButton();
            this.radioBtnNu = new System.Windows.Forms.RadioButton();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMiniMarket = new System.Windows.Forms.Label();
            this.tabNhanVien.SuspendLayout();
            this.tabDSNV.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabThemNV.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Controls.Add(this.tabDSNV);
            this.tabNhanVien.Controls.Add(this.tabThemNV);
            this.tabNhanVien.Controls.Add(this.tabSuaNV);
            this.tabNhanVien.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNhanVien.ItemSize = new System.Drawing.Size(136, 50);
            this.tabNhanVien.Location = new System.Drawing.Point(0, 0);
            this.tabNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.SelectedIndex = 0;
            this.tabNhanVien.Size = new System.Drawing.Size(869, 605);
            this.tabNhanVien.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabNhanVien.TabIndex = 1;
            // 
            // tabDSNV
            // 
            this.tabDSNV.AutoScroll = true;
            this.tabDSNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabDSNV.BackgroundImage")));
            this.tabDSNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDSNV.Controls.Add(this.panel2);
            this.tabDSNV.Controls.Add(this.listViewNhanVien);
            this.tabDSNV.Controls.Add(this.btnSua);
            this.tabDSNV.Controls.Add(this.panel1);
            this.tabDSNV.Location = new System.Drawing.Point(4, 54);
            this.tabDSNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDSNV.Name = "tabDSNV";
            this.tabDSNV.Size = new System.Drawing.Size(861, 547);
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
            this.listViewNhanVien.Location = new System.Drawing.Point(105, 340);
            this.listViewNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewNhanVien.Name = "listViewNhanVien";
            this.listViewNhanVien.Size = new System.Drawing.Size(573, 157);
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
            this.btnSua.Location = new System.Drawing.Point(635, 49);
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
            this.panel1.Location = new System.Drawing.Point(184, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 279);
            this.panel1.TabIndex = 2;
            // 
            // lable8
            // 
            this.lable8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lable8.AutoSize = true;
            this.lable8.Location = new System.Drawing.Point(27, 244);
            this.lable8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable8.Name = "lable8";
            this.lable8.Size = new System.Drawing.Size(102, 22);
            this.lable8.TabIndex = 10;
            this.lable8.Text = "Trạng Thái:";
            // 
            // lable7
            // 
            this.lable7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lable7.AutoSize = true;
            this.lable7.Location = new System.Drawing.Point(27, 222);
            this.lable7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable7.Name = "lable7";
            this.lable7.Size = new System.Drawing.Size(84, 22);
            this.lable7.TabIndex = 9;
            this.lable7.Text = "Giới tính:";
            // 
            // lable6
            // 
            this.lable6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lable6.AutoSize = true;
            this.lable6.Location = new System.Drawing.Point(27, 200);
            this.lable6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable6.Name = "lable6";
            this.lable6.Size = new System.Drawing.Size(75, 22);
            this.lable6.TabIndex = 8;
            this.lable6.Text = "Chức Vụ";
            // 
            // lable5
            // 
            this.lable5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lable5.AutoSize = true;
            this.lable5.Location = new System.Drawing.Point(27, 178);
            this.lable5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable5.Name = "lable5";
            this.lable5.Size = new System.Drawing.Size(96, 22);
            this.lable5.TabIndex = 7;
            this.lable5.Text = "Ngày sinh:";
            // 
            // lable4
            // 
            this.lable4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lable4.AutoSize = true;
            this.lable4.Location = new System.Drawing.Point(27, 156);
            this.lable4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(68, 22);
            this.lable4.TabIndex = 6;
            this.lable4.Text = "Địa chỉ:";
            // 
            // lable3
            // 
            this.lable3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lable3.AutoSize = true;
            this.lable3.Location = new System.Drawing.Point(27, 134);
            this.lable3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(124, 22);
            this.lable3.TabIndex = 5;
            this.lable3.Text = "Số điện thoại:";
            // 
            // lable2
            // 
            this.lable2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(27, 112);
            this.lable2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(92, 22);
            this.lable2.TabIndex = 4;
            this.lable2.Text = "Họ và tên:";
            // 
            // lable1
            // 
            this.lable1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(27, 90);
            this.lable1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(33, 22);
            this.lable1.TabIndex = 3;
            this.lable1.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(332, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 123);
            this.panel2.TabIndex = 2;
            // 
            // tabThemNV
            // 
            this.tabThemNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabThemNV.BackgroundImage")));
            this.tabThemNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabThemNV.Controls.Add(this.panel4);
            this.tabThemNV.Controls.Add(this.button2);
            this.tabThemNV.Controls.Add(this.lblTittle);
            this.tabThemNV.Controls.Add(this.panel3);
            this.tabThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabThemNV.Location = new System.Drawing.Point(4, 54);
            this.tabThemNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabThemNV.Name = "tabThemNV";
            this.tabThemNV.Size = new System.Drawing.Size(861, 547);
            this.tabThemNV.TabIndex = 0;
            this.tabThemNV.Text = "Thêm nhân viên";
            this.tabThemNV.UseVisualStyleBackColor = true;
            // 
            // tabSuaNV
            // 
            this.tabSuaNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabSuaNV.BackgroundImage")));
            this.tabSuaNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabSuaNV.Location = new System.Drawing.Point(4, 54);
            this.tabSuaNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSuaNV.Name = "tabSuaNV";
            this.tabSuaNV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSuaNV.Size = new System.Drawing.Size(861, 547);
            this.tabSuaNV.TabIndex = 1;
            this.tabSuaNV.Text = "Sửa nhân viên";
            this.tabSuaNV.UseVisualStyleBackColor = true;
            // 
            // lbHoVaTen
            // 
            this.lbHoVaTen.AutoSize = true;
            this.lbHoVaTen.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoVaTen.Location = new System.Drawing.Point(30, 58);
            this.lbHoVaTen.Name = "lbHoVaTen";
            this.lbHoVaTen.Size = new System.Drawing.Size(92, 22);
            this.lbHoVaTen.TabIndex = 0;
            this.lbHoVaTen.Text = "Họ và tên:";
            // 
            // lblSinhNgay
            // 
            this.lblSinhNgay.AutoSize = true;
            this.lblSinhNgay.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinhNgay.Location = new System.Drawing.Point(30, 88);
            this.lblSinhNgay.Name = "lblSinhNgay";
            this.lblSinhNgay.Size = new System.Drawing.Size(94, 22);
            this.lblSinhNgay.TabIndex = 1;
            this.lblSinhNgay.Text = "Sinh ngày:";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.Location = new System.Drawing.Point(30, 118);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(124, 22);
            this.lblSoDienThoai.TabIndex = 2;
            this.lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(30, 148);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(68, 22);
            this.lblDiaChi.TabIndex = 3;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien.Location = new System.Drawing.Point(30, 28);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(122, 22);
            this.lblMaNhanVien.TabIndex = 4;
            this.lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Honeydew;
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.lblNote);
            this.panel3.Controls.Add(this.lblChucVu);
            this.panel3.Controls.Add(this.radioBtnNu);
            this.panel3.Controls.Add(this.radioBtnNam);
            this.panel3.Controls.Add(this.lblGioiTinh);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.maskedTextBox3);
            this.panel3.Controls.Add(this.maskedTextBox2);
            this.panel3.Controls.Add(this.maskedTextBox1);
            this.panel3.Controls.Add(this.lbHoVaTen);
            this.panel3.Controls.Add(this.lblMaNhanVien);
            this.panel3.Controls.Add(this.lblSinhNgay);
            this.panel3.Controls.Add(this.lblDiaChi);
            this.panel3.Controls.Add(this.lblSoDienThoai);
            this.panel3.Location = new System.Drawing.Point(44, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 322);
            this.panel3.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(160, 58);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(202, 24);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(160, 88);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(202, 24);
            this.maskedTextBox2.TabIndex = 6;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(160, 118);
            this.maskedTextBox3.Mask = "0000000000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(202, 24);
            this.maskedTextBox3.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 24);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 24);
            this.textBox2.TabIndex = 9;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(30, 191);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(84, 22);
            this.lblGioiTinh.TabIndex = 10;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // radioBtnNam
            // 
            this.radioBtnNam.AutoSize = true;
            this.radioBtnNam.Location = new System.Drawing.Point(168, 200);
            this.radioBtnNam.Name = "radioBtnNam";
            this.radioBtnNam.Size = new System.Drawing.Size(58, 22);
            this.radioBtnNam.TabIndex = 11;
            this.radioBtnNam.TabStop = true;
            this.radioBtnNam.Text = "Nam";
            this.radioBtnNam.UseVisualStyleBackColor = true;
            // 
            // radioBtnNu
            // 
            this.radioBtnNu.AutoSize = true;
            this.radioBtnNu.Location = new System.Drawing.Point(168, 228);
            this.radioBtnNu.Name = "radioBtnNu";
            this.radioBtnNu.Size = new System.Drawing.Size(45, 22);
            this.radioBtnNu.TabIndex = 12;
            this.radioBtnNu.TabStop = true;
            this.radioBtnNu.Text = "Nữ";
            this.radioBtnNu.UseVisualStyleBackColor = true;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTittle.Location = new System.Drawing.Point(98, 26);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(308, 31);
            this.lblTittle.TabIndex = 6;
            this.lblTittle.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(30, 269);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(78, 22);
            this.lblChucVu.TabIndex = 13;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNote.Location = new System.Drawing.Point(90, 306);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(217, 16);
            this.lblNote.TabIndex = 14;
            this.lblNote.Text = "Các trường thông tin trên là bắt buộc";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(160, 270);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 21);
            this.listBox1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(471, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblMiniMarket);
            this.panel4.Location = new System.Drawing.Point(471, 166);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 180);
            this.panel4.TabIndex = 9;
            // 
            // lblMiniMarket
            // 
            this.lblMiniMarket.AutoSize = true;
            this.lblMiniMarket.Location = new System.Drawing.Point(128, 10);
            this.lblMiniMarket.Name = "lblMiniMarket";
            this.lblMiniMarket.Size = new System.Drawing.Size(85, 18);
            this.lblMiniMarket.TabIndex = 0;
            this.lblMiniMarket.Text = "Mini Market";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 603);
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
            this.tabThemNV.ResumeLayout(false);
            this.tabThemNV.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Label lblSinhNgay;
        private System.Windows.Forms.Label lbHoVaTen;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.RadioButton radioBtnNu;
        private System.Windows.Forms.RadioButton radioBtnNam;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblMiniMarket;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}