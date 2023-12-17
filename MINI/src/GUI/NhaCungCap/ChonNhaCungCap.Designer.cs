namespace MINI.src.GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChonNhaCungCap));
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
            this.btnthemncc = new System.Windows.Forms.Button();
            this.btnsuancc = new System.Windows.Forms.Button();
            this.btnxoancc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btntimkiemncc
            // 
            this.btntimkiemncc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntimkiemncc.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btntimkiemncc.FlatAppearance.BorderSize = 3;
            this.btntimkiemncc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntimkiemncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiemncc.Location = new System.Drawing.Point(603, 27);
            this.btntimkiemncc.Name = "btntimkiemncc";
            this.btntimkiemncc.Size = new System.Drawing.Size(100, 40);
            this.btntimkiemncc.TabIndex = 7;
            this.btntimkiemncc.Text = "Tìm Kiếm";
            this.btntimkiemncc.UseVisualStyleBackColor = false;
            this.btntimkiemncc.Click += new System.EventHandler(this.btntimkiemncc_Click);
            // 
            // lsvchonncc
            // 
            this.lsvchonncc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idphieunhap,
            this.idsanpham,
            this.soluong,
            this.dongia});
            this.lsvchonncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsvchonncc.FullRowSelect = true;
            this.lsvchonncc.HideSelection = false;
            this.lsvchonncc.Location = new System.Drawing.Point(50, 137);
            this.lsvchonncc.Name = "lsvchonncc";
            this.lsvchonncc.Size = new System.Drawing.Size(700, 250);
            this.lsvchonncc.TabIndex = 6;
            this.lsvchonncc.UseCompatibleStateImageBehavior = false;
            this.lsvchonncc.View = System.Windows.Forms.View.Details;
            this.lsvchonncc.SelectedIndexChanged += new System.EventHandler(this.lsvchonncc_SelectedIndexChanged);
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
            this.btnlammoincc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlammoincc.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnlammoincc.FlatAppearance.BorderSize = 3;
            this.btnlammoincc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlammoincc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoincc.Location = new System.Drawing.Point(332, 91);
            this.btnlammoincc.Name = "btnlammoincc";
            this.btnlammoincc.Size = new System.Drawing.Size(100, 40);
            this.btnlammoincc.TabIndex = 5;
            this.btnlammoincc.Text = "Làm Mới";
            this.btnlammoincc.UseVisualStyleBackColor = false;
            this.btnlammoincc.Click += new System.EventHandler(this.btnlammoincc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox1.Controls.Add(this.txtsearchncc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(122, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 71);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // txtsearchncc
            // 
            this.txtsearchncc.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchncc.ForeColor = System.Drawing.Color.Black;
            this.txtsearchncc.Location = new System.Drawing.Point(6, 25);
            this.txtsearchncc.Multiline = true;
            this.txtsearchncc.Name = "txtsearchncc";
            this.txtsearchncc.Size = new System.Drawing.Size(435, 28);
            this.txtsearchncc.TabIndex = 0;
            this.txtsearchncc.Click += new System.EventHandler(this.txtsearchncc_Click);
            this.txtsearchncc.TextChanged += new System.EventHandler(this.txtsearchncc_TextChanged);
            this.txtsearchncc.Leave += new System.EventHandler(this.txtsearchncc_Leave);
            // 
            // btnchon
            // 
            this.btnchon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnchon.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnchon.FlatAppearance.BorderSize = 3;
            this.btnchon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchon.Location = new System.Drawing.Point(527, 393);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(100, 40);
            this.btnchon.TabIndex = 8;
            this.btnchon.Text = "Chọn";
            this.btnchon.UseVisualStyleBackColor = false;
            this.btnchon.Visible = false;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnThoat.FlatAppearance.BorderSize = 3;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(633, 393);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Visible = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnthemncc
            // 
            this.btnthemncc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthemncc.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnthemncc.FlatAppearance.BorderSize = 3;
            this.btnthemncc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthemncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemncc.Location = new System.Drawing.Point(441, 91);
            this.btnthemncc.Name = "btnthemncc";
            this.btnthemncc.Size = new System.Drawing.Size(100, 40);
            this.btnthemncc.TabIndex = 10;
            this.btnthemncc.Text = "Thêm ";
            this.btnthemncc.UseVisualStyleBackColor = false;
            this.btnthemncc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsuancc
            // 
            this.btnsuancc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsuancc.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnsuancc.FlatAppearance.BorderSize = 3;
            this.btnsuancc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuancc.Location = new System.Drawing.Point(547, 91);
            this.btnsuancc.Name = "btnsuancc";
            this.btnsuancc.Size = new System.Drawing.Size(100, 40);
            this.btnsuancc.TabIndex = 11;
            this.btnsuancc.Text = "Sửa ";
            this.btnsuancc.UseVisualStyleBackColor = false;
            this.btnsuancc.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnxoancc
            // 
            this.btnxoancc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxoancc.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnxoancc.FlatAppearance.BorderSize = 3;
            this.btnxoancc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoancc.Location = new System.Drawing.Point(653, 91);
            this.btnxoancc.Name = "btnxoancc";
            this.btnxoancc.Size = new System.Drawing.Size(100, 40);
            this.btnxoancc.TabIndex = 12;
            this.btnxoancc.Text = "Xóa";
            this.btnxoancc.UseVisualStyleBackColor = false;
            this.btnxoancc.Click += new System.EventHandler(this.button3_Click);
            this.btnxoancc.Leave += new System.EventHandler(this.button3_Leave);
            // 
            // ChonNhaCungCap
            // 
            this.AcceptButton = this.btntimkiemncc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnxoancc);
            this.Controls.Add(this.btnsuancc);
            this.Controls.Add(this.btnthemncc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.btntimkiemncc);
            this.Controls.Add(this.lsvchonncc);
            this.Controls.Add(this.btnlammoincc);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChonNhaCungCap";
            this.Text = "Chọn nhà cung cấp";
            this.Activated += new System.EventHandler(this.ChonNhaCungCap_Activated);
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
        private System.Windows.Forms.Button btnthemncc;
        private System.Windows.Forms.Button btnsuancc;
        private System.Windows.Forms.Button btnxoancc;
    }
}