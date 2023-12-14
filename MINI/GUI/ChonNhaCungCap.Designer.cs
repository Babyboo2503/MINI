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
            this.btnthemncc = new System.Windows.Forms.Button();
            this.btnsuancc = new System.Windows.Forms.Button();
            this.btnxoancc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btntimkiemncc
            // 
            this.btntimkiemncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiemncc.Location = new System.Drawing.Point(264, 81);
            this.btntimkiemncc.Name = "btntimkiemncc";
            this.btntimkiemncc.Size = new System.Drawing.Size(100, 50);
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
            this.btnlammoincc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoincc.Location = new System.Drawing.Point(370, 81);
            this.btnlammoincc.Name = "btnlammoincc";
            this.btnlammoincc.Size = new System.Drawing.Size(100, 50);
            this.btnlammoincc.TabIndex = 5;
            this.btnlammoincc.Text = "Làm Mới";
            this.btnlammoincc.UseVisualStyleBackColor = true;
            this.btnlammoincc.Click += new System.EventHandler(this.btnlammoincc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsearchncc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // txtsearchncc
            // 
            this.txtsearchncc.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchncc.ForeColor = System.Drawing.Color.Black;
            this.txtsearchncc.Location = new System.Drawing.Point(6, 25);
            this.txtsearchncc.Name = "txtsearchncc";
            this.txtsearchncc.Size = new System.Drawing.Size(188, 20);
            this.txtsearchncc.TabIndex = 0;
            this.txtsearchncc.Click += new System.EventHandler(this.txtsearchncc_Click);
            this.txtsearchncc.TextChanged += new System.EventHandler(this.txtsearchncc_TextChanged);
            this.txtsearchncc.Leave += new System.EventHandler(this.txtsearchncc_Leave);
            // 
            // btnchon
            // 
            this.btnchon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchon.Location = new System.Drawing.Point(527, 393);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(100, 50);
            this.btnchon.TabIndex = 8;
            this.btnchon.Text = "Chọn";
            this.btnchon.UseVisualStyleBackColor = true;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(633, 393);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 50);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnthemncc
            // 
            this.btnthemncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemncc.Location = new System.Drawing.Point(479, 81);
            this.btnthemncc.Name = "btnthemncc";
            this.btnthemncc.Size = new System.Drawing.Size(100, 50);
            this.btnthemncc.TabIndex = 10;
            this.btnthemncc.Text = "Thêm ";
            this.btnthemncc.UseVisualStyleBackColor = true;
            this.btnthemncc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsuancc
            // 
            this.btnsuancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuancc.Location = new System.Drawing.Point(585, 81);
            this.btnsuancc.Name = "btnsuancc";
            this.btnsuancc.Size = new System.Drawing.Size(100, 50);
            this.btnsuancc.TabIndex = 11;
            this.btnsuancc.Text = "Sửa ";
            this.btnsuancc.UseVisualStyleBackColor = true;
            this.btnsuancc.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnxoancc
            // 
            this.btnxoancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoancc.Location = new System.Drawing.Point(691, 81);
            this.btnxoancc.Name = "btnxoancc";
            this.btnxoancc.Size = new System.Drawing.Size(100, 50);
            this.btnxoancc.TabIndex = 12;
            this.btnxoancc.Text = "Xóa";
            this.btnxoancc.UseVisualStyleBackColor = true;
            this.btnxoancc.Click += new System.EventHandler(this.button3_Click);
            this.btnxoancc.Leave += new System.EventHandler(this.button3_Leave);
            // 
            // ChonNhaCungCap
            // 
            this.AcceptButton = this.btntimkiemncc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "ChonNhaCungCap";
            this.Text = "ChonNhaCungCap";
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