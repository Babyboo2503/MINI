using System.Windows.Forms;

namespace MINI.src.GUI.PhieuNhap
{
    partial class NhapHangGUI
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
            this.lsvdssp = new System.Windows.Forms.ListView();
            this.lsvidsp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvidlsp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvtensp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvdonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvsoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtidncc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtidnhanvien = new System.Windows.Forms.TextBox();
            this.grbTimkiem = new System.Windows.Forms.GroupBox();
            this.txtsearchsp = new System.Windows.Forms.TextBox();
            this.grbdongia = new System.Windows.Forms.GroupBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.grbsoluong = new System.Windows.Forms.GroupBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.grbidsanpham = new System.Windows.Forms.GroupBox();
            this.txtidsanpham = new System.Windows.Forms.TextBox();
            this.grbidlsp = new System.Windows.Forms.GroupBox();
            this.txtidlsp = new System.Windows.Forms.TextBox();
            this.grbtensp = new System.Windows.Forms.GroupBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.lsvdsspnhap = new System.Windows.Forms.ListView();
            this.stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.masp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dongia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thanhtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnxoathanhtoan = new System.Windows.Forms.Button();
            this.btnchonncc = new System.Windows.Forms.Button();
            this.btnlammoisp = new System.Windows.Forms.Button();
            this.btnthemsp = new System.Windows.Forms.Button();
            this.btnlmthanhtoan = new System.Windows.Forms.Button();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.btnxoatatca = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnchonnv = new System.Windows.Forms.Button();
            this.ptbsanpham = new System.Windows.Forms.PictureBox();
            this.btntimkiemsp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbTimkiem.SuspendLayout();
            this.grbdongia.SuspendLayout();
            this.grbsoluong.SuspendLayout();
            this.grbidsanpham.SuspendLayout();
            this.grbidlsp.SuspendLayout();
            this.grbtensp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbsanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvdssp
            // 
            this.lsvdssp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lsvidsp,
            this.lsvidlsp,
            this.lsvtensp,
            this.lsvdonGia,
            this.lsvsoLuong});
            this.lsvdssp.FullRowSelect = true;
            this.lsvdssp.HideSelection = false;
            this.lsvdssp.Location = new System.Drawing.Point(1, 57);
            this.lsvdssp.Name = "lsvdssp";
            this.lsvdssp.Size = new System.Drawing.Size(600, 418);
            this.lsvdssp.TabIndex = 0;
            this.lsvdssp.UseCompatibleStateImageBehavior = false;
            this.lsvdssp.View = System.Windows.Forms.View.Details;
            this.lsvdssp.SelectedIndexChanged += new System.EventHandler(this.lsvdssp_SelectedIndexChanged);
            // 
            // lsvidsp
            // 
            this.lsvidsp.Text = "Mã Sản Phẩm";
            this.lsvidsp.Width = 80;
            // 
            // lsvidlsp
            // 
            this.lsvidlsp.Text = "Mã Loại Sản Phẩm";
            this.lsvidlsp.Width = 120;
            // 
            // lsvtensp
            // 
            this.lsvtensp.Text = "Tên Sản Phẩm";
            this.lsvtensp.Width = 200;
            // 
            // lsvdonGia
            // 
            this.lsvdonGia.Text = "Đơn Giá";
            this.lsvdonGia.Width = 100;
            // 
            // lsvsoLuong
            // 
            this.lsvsoLuong.Text = "Số Lượng";
            this.lsvsoLuong.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtidncc);
            this.groupBox1.Location = new System.Drawing.Point(607, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 40);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhà Cung Cấp";
            // 
            // txtidncc
            // 
            this.txtidncc.Location = new System.Drawing.Point(6, 13);
            this.txtidncc.Name = "txtidncc";
            this.txtidncc.Size = new System.Drawing.Size(188, 20);
            this.txtidncc.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtidnhanvien);
            this.groupBox2.Location = new System.Drawing.Point(868, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 40);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhân Viên";
            // 
            // txtidnhanvien
            // 
            this.txtidnhanvien.Location = new System.Drawing.Point(6, 19);
            this.txtidnhanvien.Name = "txtidnhanvien";
            this.txtidnhanvien.Size = new System.Drawing.Size(188, 20);
            this.txtidnhanvien.TabIndex = 3;
            // 
            // grbTimkiem
            // 
            this.grbTimkiem.Controls.Add(this.txtsearchsp);
            this.grbTimkiem.Location = new System.Drawing.Point(36, 11);
            this.grbTimkiem.Name = "grbTimkiem";
            this.grbTimkiem.Size = new System.Drawing.Size(200, 40);
            this.grbTimkiem.TabIndex = 3;
            this.grbTimkiem.TabStop = false;
            this.grbTimkiem.Text = "Tìm Kiếm";
            this.grbTimkiem.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // txtsearchsp
            // 
            this.txtsearchsp.Location = new System.Drawing.Point(6, 17);
            this.txtsearchsp.Name = "txtsearchsp";
            this.txtsearchsp.Size = new System.Drawing.Size(188, 20);
            this.txtsearchsp.TabIndex = 2;
            // 
            // grbdongia
            // 
            this.grbdongia.Controls.Add(this.txtdongia);
            this.grbdongia.Location = new System.Drawing.Point(413, 541);
            this.grbdongia.Name = "grbdongia";
            this.grbdongia.Size = new System.Drawing.Size(188, 40);
            this.grbdongia.TabIndex = 5;
            this.grbdongia.TabStop = false;
            this.grbdongia.Text = "Đơn Giá";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(4, 14);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.ReadOnly = true;
            this.txtdongia.Size = new System.Drawing.Size(182, 20);
            this.txtdongia.TabIndex = 4;
            // 
            // grbsoluong
            // 
            this.grbsoluong.Controls.Add(this.txtsoluong);
            this.grbsoluong.Location = new System.Drawing.Point(207, 587);
            this.grbsoluong.Name = "grbsoluong";
            this.grbsoluong.Size = new System.Drawing.Size(200, 40);
            this.grbsoluong.TabIndex = 7;
            this.grbsoluong.TabStop = false;
            this.grbsoluong.Text = "Số Lượng";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(8, 14);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(188, 20);
            this.txtsoluong.TabIndex = 3;
            // 
            // grbidsanpham
            // 
            this.grbidsanpham.Controls.Add(this.txtidsanpham);
            this.grbidsanpham.Location = new System.Drawing.Point(207, 495);
            this.grbidsanpham.Name = "grbidsanpham";
            this.grbidsanpham.Size = new System.Drawing.Size(200, 40);
            this.grbidsanpham.TabIndex = 8;
            this.grbidsanpham.TabStop = false;
            this.grbidsanpham.Text = "Mã Sản Phẩm";
            // 
            // txtidsanpham
            // 
            this.txtidsanpham.Location = new System.Drawing.Point(6, 14);
            this.txtidsanpham.Name = "txtidsanpham";
            this.txtidsanpham.ReadOnly = true;
            this.txtidsanpham.Size = new System.Drawing.Size(188, 20);
            this.txtidsanpham.TabIndex = 0;
            // 
            // grbidlsp
            // 
            this.grbidlsp.Controls.Add(this.txtidlsp);
            this.grbidlsp.Location = new System.Drawing.Point(413, 495);
            this.grbidlsp.Name = "grbidlsp";
            this.grbidlsp.Size = new System.Drawing.Size(188, 40);
            this.grbidlsp.TabIndex = 9;
            this.grbidlsp.TabStop = false;
            this.grbidlsp.Text = "Mã Loại Sản Phẩm";
            // 
            // txtidlsp
            // 
            this.txtidlsp.Location = new System.Drawing.Point(2, 14);
            this.txtidlsp.Name = "txtidlsp";
            this.txtidlsp.ReadOnly = true;
            this.txtidlsp.Size = new System.Drawing.Size(182, 20);
            this.txtidlsp.TabIndex = 5;
            // 
            // grbtensp
            // 
            this.grbtensp.Controls.Add(this.txttensp);
            this.grbtensp.Location = new System.Drawing.Point(207, 541);
            this.grbtensp.Name = "grbtensp";
            this.grbtensp.Size = new System.Drawing.Size(200, 40);
            this.grbtensp.TabIndex = 4;
            this.grbtensp.TabStop = false;
            this.grbtensp.Text = "Tên Sản Phẩm";
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(6, 14);
            this.txttensp.Name = "txttensp";
            this.txttensp.ReadOnly = true;
            this.txttensp.Size = new System.Drawing.Size(188, 20);
            this.txttensp.TabIndex = 6;
            // 
            // lsvdsspnhap
            // 
            this.lsvdsspnhap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stt,
            this.masp,
            this.ten,
            this.soluong,
            this.dongia,
            this.thanhtien});
            this.lsvdsspnhap.FullRowSelect = true;
            this.lsvdsspnhap.HideSelection = false;
            this.lsvdsspnhap.Location = new System.Drawing.Point(607, 58);
            this.lsvdsspnhap.Name = "lsvdsspnhap";
            this.lsvdsspnhap.Size = new System.Drawing.Size(570, 417);
            this.lsvdsspnhap.TabIndex = 10;
            this.lsvdsspnhap.UseCompatibleStateImageBehavior = false;
            this.lsvdsspnhap.View = System.Windows.Forms.View.Details;
            // 
            // stt
            // 
            this.stt.Text = "STT";
            this.stt.Width = 50;
            // 
            // masp
            // 
            this.masp.Text = "Mã Sản Phẩm";
            this.masp.Width = 80;
            // 
            // ten
            // 
            this.ten.Text = "Tên Sản Phẩm";
            this.ten.Width = 159;
            // 
            // soluong
            // 
            this.soluong.Text = "Số Lượng";
            this.soluong.Width = 67;
            // 
            // dongia
            // 
            this.dongia.Text = "Đơn Giá";
            this.dongia.Width = 104;
            // 
            // thanhtien
            // 
            this.thanhtien.Text = "Thành Tiền";
            this.thanhtien.Width = 109;
            // 
            // btnxoathanhtoan
            // 
            this.btnxoathanhtoan.Location = new System.Drawing.Point(607, 555);
            this.btnxoathanhtoan.Name = "btnxoathanhtoan";
            this.btnxoathanhtoan.Size = new System.Drawing.Size(85, 28);
            this.btnxoathanhtoan.TabIndex = 11;
            this.btnxoathanhtoan.Text = "Xóa";
            this.btnxoathanhtoan.UseVisualStyleBackColor = true;
            this.btnxoathanhtoan.Click += new System.EventHandler(this.btnxoathanhtoan_Click);
            // 
            // btnchonncc
            // 
            this.btnchonncc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchonncc.Location = new System.Drawing.Point(813, 20);
            this.btnchonncc.Name = "btnchonncc";
            this.btnchonncc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnchonncc.Size = new System.Drawing.Size(35, 28);
            this.btnchonncc.TabIndex = 12;
            this.btnchonncc.Text = "...";
            this.btnchonncc.UseVisualStyleBackColor = true;
            this.btnchonncc.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnlammoisp
            // 
            this.btnlammoisp.Location = new System.Drawing.Point(362, 23);
            this.btnlammoisp.Name = "btnlammoisp";
            this.btnlammoisp.Size = new System.Drawing.Size(85, 28);
            this.btnlammoisp.TabIndex = 13;
            this.btnlammoisp.Text = "Làm Mới";
            this.btnlammoisp.UseVisualStyleBackColor = true;
            this.btnlammoisp.Click += new System.EventHandler(this.btnlammoisp_Click);
            // 
            // btnthemsp
            // 
            this.btnthemsp.Location = new System.Drawing.Point(362, 641);
            this.btnthemsp.Name = "btnthemsp";
            this.btnthemsp.Size = new System.Drawing.Size(85, 28);
            this.btnthemsp.TabIndex = 14;
            this.btnthemsp.Text = "Thêm";
            this.btnthemsp.UseVisualStyleBackColor = true;
            this.btnthemsp.Click += new System.EventHandler(this.btnthemsp_Click);
            // 
            // btnlmthanhtoan
            // 
            this.btnlmthanhtoan.Location = new System.Drawing.Point(789, 555);
            this.btnlmthanhtoan.Name = "btnlmthanhtoan";
            this.btnlmthanhtoan.Size = new System.Drawing.Size(85, 28);
            this.btnlmthanhtoan.TabIndex = 15;
            this.btnlmthanhtoan.Text = "Làm Mới";
            this.btnlmthanhtoan.UseVisualStyleBackColor = true;
            this.btnlmthanhtoan.Click += new System.EventHandler(this.btnlmthanhtoan_Click);
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Location = new System.Drawing.Point(1024, 555);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(85, 28);
            this.btnthanhtoan.TabIndex = 16;
            this.btnthanhtoan.Text = "Thanh Toán";
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            // 
            // btnxoatatca
            // 
            this.btnxoatatca.Location = new System.Drawing.Point(924, 555);
            this.btnxoatatca.Name = "btnxoatatca";
            this.btnxoatatca.Size = new System.Drawing.Size(85, 28);
            this.btnxoatatca.TabIndex = 17;
            this.btnxoatatca.Text = "Xóa Tất Cả";
            this.btnxoatatca.UseVisualStyleBackColor = true;
            this.btnxoatatca.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(698, 555);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(85, 28);
            this.btnsua.TabIndex = 18;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnchonnv
            // 
            this.btnchonnv.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchonnv.Location = new System.Drawing.Point(1074, 23);
            this.btnchonnv.Name = "btnchonnv";
            this.btnchonnv.Size = new System.Drawing.Size(35, 28);
            this.btnchonnv.TabIndex = 19;
            this.btnchonnv.Text = "...";
            this.btnchonnv.UseVisualStyleBackColor = true;
            this.btnchonnv.Click += new System.EventHandler(this.button9_Click);
            // 
            // ptbsanpham
            // 
            this.ptbsanpham.Location = new System.Drawing.Point(7, 478);
            this.ptbsanpham.Name = "ptbsanpham";
            this.ptbsanpham.Size = new System.Drawing.Size(200, 200);
            this.ptbsanpham.TabIndex = 20;
            this.ptbsanpham.TabStop = false;
            // 
            // btntimkiemsp
            // 
            this.btntimkiemsp.Location = new System.Drawing.Point(242, 25);
            this.btntimkiemsp.Name = "btntimkiemsp";
            this.btntimkiemsp.Size = new System.Drawing.Size(75, 23);
            this.btntimkiemsp.TabIndex = 21;
            this.btntimkiemsp.Text = "Tìm Kiếm";
            this.btntimkiemsp.UseVisualStyleBackColor = true;
            this.btntimkiemsp.Click += new System.EventHandler(this.btntimkiemsp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(852, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tổng Tiền:";
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(924, 492);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(185, 20);
            this.txttongtien.TabIndex = 23;
            // 
            // NhapHangGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntimkiemsp);
            this.Controls.Add(this.ptbsanpham);
            this.Controls.Add(this.btnchonnv);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoatatca);
            this.Controls.Add(this.btnthanhtoan);
            this.Controls.Add(this.btnlmthanhtoan);
            this.Controls.Add(this.btnthemsp);
            this.Controls.Add(this.btnlammoisp);
            this.Controls.Add(this.btnchonncc);
            this.Controls.Add(this.btnxoathanhtoan);
            this.Controls.Add(this.lsvdsspnhap);
            this.Controls.Add(this.grbdongia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbsoluong);
            this.Controls.Add(this.grbidsanpham);
            this.Controls.Add(this.grbidlsp);
            this.Controls.Add(this.grbtensp);
            this.Controls.Add(this.grbTimkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsvdssp);
            this.Name = "NhapHangGUI";
            this.Text = "NhapHangGUI";
            this.Load += new System.EventHandler(this.NhapHangGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbTimkiem.ResumeLayout(false);
            this.grbTimkiem.PerformLayout();
            this.grbdongia.ResumeLayout(false);
            this.grbdongia.PerformLayout();
            this.grbsoluong.ResumeLayout(false);
            this.grbsoluong.PerformLayout();
            this.grbidsanpham.ResumeLayout(false);
            this.grbidsanpham.PerformLayout();
            this.grbidlsp.ResumeLayout(false);
            this.grbidlsp.PerformLayout();
            this.grbtensp.ResumeLayout(false);
            this.grbtensp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbsanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvdssp;
        private System.Windows.Forms.ColumnHeader lsvidsp;
        private System.Windows.Forms.ColumnHeader lsvidlsp;
        private System.Windows.Forms.ColumnHeader lsvtensp;
        private System.Windows.Forms.ColumnHeader lsvdonGia;
        private System.Windows.Forms.ColumnHeader lsvsoLuong;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grbTimkiem;
        private System.Windows.Forms.GroupBox grbdongia;
        private System.Windows.Forms.GroupBox grbsoluong;
        private System.Windows.Forms.GroupBox grbidsanpham;
        private System.Windows.Forms.GroupBox grbidlsp;
        private System.Windows.Forms.GroupBox grbtensp;
        private System.Windows.Forms.ListView lsvdsspnhap;
        private System.Windows.Forms.Button btnxoathanhtoan;
        private System.Windows.Forms.Button btnchonncc;
        private System.Windows.Forms.Button btnlammoisp;
        private System.Windows.Forms.Button btnthemsp;
        private System.Windows.Forms.Button btnlmthanhtoan;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.Button btnxoatatca;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnchonnv;
        private System.Windows.Forms.ColumnHeader stt;
        private System.Windows.Forms.ColumnHeader masp;
        private System.Windows.Forms.ColumnHeader ten;
        private System.Windows.Forms.ColumnHeader soluong;
        private System.Windows.Forms.ColumnHeader dongia;
        private System.Windows.Forms.TextBox txtidncc;
        private System.Windows.Forms.TextBox txtidnhanvien;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtidsanpham;
        private System.Windows.Forms.TextBox txtidlsp;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.PictureBox ptbsanpham;
        private ListViewItemSelectionChangedEventHandler lsvdssp_ItemSelectionChanged;
        private Button btntimkiemsp;
        private TextBox txtsearchsp;
        private Label label1;
        private TextBox txttongtien;
        private ColumnHeader thanhtien;
    }
}