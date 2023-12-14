namespace MINI.src.GUI
{
    partial class ChiTietPhieuNhapGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietPhieuNhapGUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsearchctpn = new System.Windows.Forms.TextBox();
            this.btnlammoictpn = new System.Windows.Forms.Button();
            this.lsvctpn = new System.Windows.Forms.ListView();
            this.idphieunhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idsanpham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dongia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thanhtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btntimkiemctpn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox1.Controls.Add(this.txtsearchctpn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(191, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // txtsearchctpn
            // 
            this.txtsearchctpn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsearchctpn.Location = new System.Drawing.Point(6, 22);
            this.txtsearchctpn.Name = "txtsearchctpn";
            this.txtsearchctpn.Size = new System.Drawing.Size(484, 26);
            this.txtsearchctpn.TabIndex = 0;
            this.txtsearchctpn.Click += new System.EventHandler(this.txtsearchctpn_Click);
            this.txtsearchctpn.Leave += new System.EventHandler(this.txtsearchctpn_Leave);
            // 
            // btnlammoictpn
            // 
            this.btnlammoictpn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlammoictpn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlammoictpn.BackgroundImage")));
            this.btnlammoictpn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlammoictpn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnlammoictpn.FlatAppearance.BorderSize = 3;
            this.btnlammoictpn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlammoictpn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoictpn.Location = new System.Drawing.Point(868, 35);
            this.btnlammoictpn.Name = "btnlammoictpn";
            this.btnlammoictpn.Size = new System.Drawing.Size(100, 50);
            this.btnlammoictpn.TabIndex = 1;
            this.btnlammoictpn.UseVisualStyleBackColor = false;
            this.btnlammoictpn.Click += new System.EventHandler(this.btnlammoictpn_Click);
            // 
            // lsvctpn
            // 
            this.lsvctpn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idphieunhap,
            this.idsanpham,
            this.soluong,
            this.dongia,
            this.thanhtien});
            this.lsvctpn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsvctpn.FullRowSelect = true;
            this.lsvctpn.HideSelection = false;
            this.lsvctpn.Location = new System.Drawing.Point(44, 127);
            this.lsvctpn.Name = "lsvctpn";
            this.lsvctpn.Size = new System.Drawing.Size(1062, 537);
            this.lsvctpn.TabIndex = 2;
            this.lsvctpn.UseCompatibleStateImageBehavior = false;
            this.lsvctpn.View = System.Windows.Forms.View.Details;
            // 
            // idphieunhap
            // 
            this.idphieunhap.Text = "Mã Phiếu Nhập";
            this.idphieunhap.Width = 139;
            // 
            // idsanpham
            // 
            this.idsanpham.Text = "Mã Sản Phẩm";
            this.idsanpham.Width = 135;
            // 
            // soluong
            // 
            this.soluong.Text = "Số Lượng";
            this.soluong.Width = 85;
            // 
            // dongia
            // 
            this.dongia.Text = "Đơn Giá";
            this.dongia.Width = 125;
            // 
            // thanhtien
            // 
            this.thanhtien.Text = "Thành Tiền";
            this.thanhtien.Width = 152;
            // 
            // btntimkiemctpn
            // 
            this.btntimkiemctpn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntimkiemctpn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntimkiemctpn.BackgroundImage")));
            this.btntimkiemctpn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btntimkiemctpn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btntimkiemctpn.FlatAppearance.BorderSize = 3;
            this.btntimkiemctpn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntimkiemctpn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiemctpn.Location = new System.Drawing.Point(745, 35);
            this.btntimkiemctpn.Name = "btntimkiemctpn";
            this.btntimkiemctpn.Size = new System.Drawing.Size(100, 50);
            this.btntimkiemctpn.TabIndex = 3;
            this.btntimkiemctpn.UseVisualStyleBackColor = false;
            this.btntimkiemctpn.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // ChiTietPhieuNhapGUI
            // 
            this.AcceptButton = this.btntimkiemctpn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1166, 722);
            this.Controls.Add(this.btntimkiemctpn);
            this.Controls.Add(this.lsvctpn);
            this.Controls.Add(this.btnlammoictpn);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChiTietPhieuNhapGUI";
            this.Text = "ChiTietPhieuNhapGUI";
            this.Load += new System.EventHandler(this.ChiTietPhieuNhapGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlammoictpn;
        private System.Windows.Forms.ListView lsvctpn;
        private System.Windows.Forms.ColumnHeader idphieunhap;
        private System.Windows.Forms.ColumnHeader idsanpham;
        private System.Windows.Forms.ColumnHeader soluong;
        private System.Windows.Forms.ColumnHeader dongia;
        private System.Windows.Forms.ColumnHeader thanhtien;
        private System.Windows.Forms.TextBox txtsearchctpn;
        private System.Windows.Forms.Button btntimkiemctpn;
    }
}