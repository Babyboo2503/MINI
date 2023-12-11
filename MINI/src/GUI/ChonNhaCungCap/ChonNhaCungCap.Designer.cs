namespace MINI.src.GUI.PhieuNhap
{
    partial class ChonNhaCungCap
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
            this.btntimkiemncc = new System.Windows.Forms.Button();
            this.lsvchonncc = new System.Windows.Forms.ListView();
            this.idphieunhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idsanpham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dongia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnlammoincc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsearchncc = new System.Windows.Forms.TextBox();
            this.btnchon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btntimkiemncc
            // 
            this.btntimkiemncc.Location = new System.Drawing.Point(403, 77);
            this.btntimkiemncc.Name = "btntimkiemncc";
            this.btntimkiemncc.Size = new System.Drawing.Size(75, 23);
            this.btntimkiemncc.TabIndex = 7;
            this.btntimkiemncc.Text = "Tìm Kiếm";
            this.btntimkiemncc.UseVisualStyleBackColor = true;
            this.btntimkiemncc.Click += new System.EventHandler(this.btntimkiemncc_Click);
            // 
            // lsvchonncc
            // 
            this.lsvchonncc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idphieunhap,
            this.idsanpham,
            this.soluong,
            this.dongia});
            this.lsvchonncc.FullRowSelect = true;
            this.lsvchonncc.HideSelection = false;
            this.lsvchonncc.Location = new System.Drawing.Point(50, 137);
            this.lsvchonncc.Name = "lsvchonncc";
            this.lsvchonncc.Size = new System.Drawing.Size(700, 250);
            this.lsvchonncc.TabIndex = 6;
            this.lsvchonncc.UseCompatibleStateImageBehavior = false;
            this.lsvchonncc.View = System.Windows.Forms.View.Details;
            // 
            // idphieunhap
            // 
            this.idphieunhap.Text = "Mã Nhà Cung Cấp";
            this.idphieunhap.Width = 100;
            // 
            // idsanpham
            // 
            this.idsanpham.Text = "Tên Nhà Cung Cấp";
            this.idsanpham.Width = 214;
            // 
            // soluong
            // 
            this.soluong.Text = "Địa Chỉ";
            this.soluong.Width = 249;
            // 
            // dongia
            // 
            this.dongia.Text = "Số Điện Thoại";
            this.dongia.Width = 133;
            // 
            // btnlammoincc
            // 
            this.btnlammoincc.Location = new System.Drawing.Point(524, 77);
            this.btnlammoincc.Name = "btnlammoincc";
            this.btnlammoincc.Size = new System.Drawing.Size(75, 20);
            this.btnlammoincc.TabIndex = 5;
            this.btnlammoincc.Text = "Làm Mới";
            this.btnlammoincc.UseVisualStyleBackColor = true;
            this.btnlammoincc.Click += new System.EventHandler(this.btnlammoincc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsearchncc);
            this.groupBox1.Location = new System.Drawing.Point(197, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 40);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // txtsearchncc
            // 
            this.txtsearchncc.Location = new System.Drawing.Point(6, 14);
            this.txtsearchncc.Name = "txtsearchncc";
            this.txtsearchncc.Size = new System.Drawing.Size(188, 20);
            this.txtsearchncc.TabIndex = 0;
            // 
            // btnchon
            // 
            this.btnchon.Location = new System.Drawing.Point(316, 415);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(75, 23);
            this.btnchon.TabIndex = 8;
            this.btnchon.Text = "Chọn";
            this.btnchon.UseVisualStyleBackColor = true;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(422, 415);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ChonNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.btntimkiemncc);
            this.Controls.Add(this.lsvchonncc);
            this.Controls.Add(this.btnlammoincc);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChonNhaCungCap";
            this.Text = "ChonNhaCungCap";
            this.Load += new System.EventHandler(this.ChonNhaCungCap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntimkiemncc;
        private System.Windows.Forms.ListView lsvchonncc;
        private System.Windows.Forms.ColumnHeader idphieunhap;
        private System.Windows.Forms.ColumnHeader idsanpham;
        private System.Windows.Forms.ColumnHeader soluong;
        private System.Windows.Forms.ColumnHeader dongia;
        private System.Windows.Forms.Button btnlammoincc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsearchncc;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.Button btnThoat;
    }
}