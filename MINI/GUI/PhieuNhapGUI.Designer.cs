namespace MINI.src.GUI.PhieuNhap
{
    partial class PhieuNhapGUI
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
            this.grbtimkiem = new System.Windows.Forms.GroupBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.grbktg = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpktg2 = new System.Windows.Forms.DateTimePicker();
            this.dtpktg1 = new System.Windows.Forms.DateTimePicker();
            this.grbtongtien = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttongtien2 = new System.Windows.Forms.TextBox();
            this.txttongtien1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnnhapexcel = new System.Windows.Forms.Button();
            this.btnxuatexcel = new System.Windows.Forms.Button();
            this.btnchitietphieunhap = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.phieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miniMarketDataSet = new MINI.MiniMarketDataSet();
            this.phieuNhapTableAdapter = new MINI.MiniMarketDataSetTableAdapters.PhieuNhapTableAdapter();
            this.txtidphieunhap = new System.Windows.Forms.TextBox();
            this.txtngaynhap = new System.Windows.Forms.TextBox();
            this.txtidnhanvien = new System.Windows.Forms.TextBox();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.txtidncc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.phieuNhapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lsvpn = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btntimkiempn = new System.Windows.Forms.Button();
            this.grbtimkiem.SuspendLayout();
            this.grbktg.SuspendLayout();
            this.grbtongtien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMarketDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbtimkiem
            // 
            this.grbtimkiem.Controls.Add(this.txttimkiem);
            this.grbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbtimkiem.Location = new System.Drawing.Point(36, 112);
            this.grbtimkiem.Name = "grbtimkiem";
            this.grbtimkiem.Size = new System.Drawing.Size(200, 50);
            this.grbtimkiem.TabIndex = 0;
            this.grbtimkiem.TabStop = false;
            this.grbtimkiem.Text = "Tìm Kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(6, 22);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(188, 22);
            this.txttimkiem.TabIndex = 0;
            this.txttimkiem.Click += new System.EventHandler(this.txttimkiem_Click);
            this.txttimkiem.Leave += new System.EventHandler(this.txttimkiem_Leave);
            // 
            // grbktg
            // 
            this.grbktg.Controls.Add(this.label4);
            this.grbktg.Controls.Add(this.label3);
            this.grbktg.Controls.Add(this.dtpktg2);
            this.grbktg.Controls.Add(this.dtpktg1);
            this.grbktg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbktg.Location = new System.Drawing.Point(373, 112);
            this.grbktg.Name = "grbktg";
            this.grbktg.Size = new System.Drawing.Size(300, 50);
            this.grbktg.TabIndex = 1;
            this.grbktg.TabStop = false;
            this.grbktg.Text = "Khoảng thời gian";
            this.grbktg.Enter += new System.EventHandler(this.grbktg_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Từ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpktg2
            // 
            this.dtpktg2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpktg2.Location = new System.Drawing.Point(179, 22);
            this.dtpktg2.Name = "dtpktg2";
            this.dtpktg2.Size = new System.Drawing.Size(101, 22);
            this.dtpktg2.TabIndex = 1;
            this.dtpktg2.ValueChanged += new System.EventHandler(this.dtpktg2_ValueChanged);
            // 
            // dtpktg1
            // 
            this.dtpktg1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpktg1.Location = new System.Drawing.Point(35, 22);
            this.dtpktg1.Name = "dtpktg1";
            this.dtpktg1.Size = new System.Drawing.Size(95, 22);
            this.dtpktg1.TabIndex = 0;
            this.dtpktg1.ValueChanged += new System.EventHandler(this.dtpktg1_ValueChanged);
            // 
            // grbtongtien
            // 
            this.grbtongtien.Controls.Add(this.label2);
            this.grbtongtien.Controls.Add(this.label1);
            this.grbtongtien.Controls.Add(this.txttongtien2);
            this.grbtongtien.Controls.Add(this.txttongtien1);
            this.grbtongtien.Location = new System.Drawing.Point(784, 112);
            this.grbtongtien.Name = "grbtongtien";
            this.grbtongtien.Size = new System.Drawing.Size(316, 50);
            this.grbtongtien.TabIndex = 1;
            this.grbtongtien.TabStop = false;
            this.grbtongtien.Text = "Tổng Tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ";
            // 
            // txttongtien2
            // 
            this.txttongtien2.Location = new System.Drawing.Point(195, 24);
            this.txttongtien2.Name = "txttongtien2";
            this.txttongtien2.Size = new System.Drawing.Size(107, 20);
            this.txttongtien2.TabIndex = 1;
            this.txttongtien2.TextChanged += new System.EventHandler(this.txttongtien2_TextChanged);
            // 
            // txttongtien1
            // 
            this.txttongtien1.Location = new System.Drawing.Point(32, 25);
            this.txttongtien1.Name = "txttongtien1";
            this.txttongtien1.Size = new System.Drawing.Size(124, 20);
            this.txttongtien1.TabIndex = 0;
            this.txttongtien1.TextChanged += new System.EventHandler(this.txttongtien1_TextChanged);
            this.txttongtien1.Enter += new System.EventHandler(this.txttongtien1_Enter);
            // 
            // btnnhapexcel
            // 
            this.btnnhapexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhapexcel.Location = new System.Drawing.Point(211, 44);
            this.btnnhapexcel.Name = "btnnhapexcel";
            this.btnnhapexcel.Size = new System.Drawing.Size(100, 40);
            this.btnnhapexcel.TabIndex = 2;
            this.btnnhapexcel.Text = "Nhập Excel";
            this.btnnhapexcel.UseVisualStyleBackColor = true;
            // 
            // btnxuatexcel
            // 
            this.btnxuatexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxuatexcel.Location = new System.Drawing.Point(352, 44);
            this.btnxuatexcel.Name = "btnxuatexcel";
            this.btnxuatexcel.Size = new System.Drawing.Size(100, 40);
            this.btnxuatexcel.TabIndex = 3;
            this.btnxuatexcel.Text = "Xuất Excel";
            this.btnxuatexcel.UseVisualStyleBackColor = true;
            // 
            // btnchitietphieunhap
            // 
            this.btnchitietphieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchitietphieunhap.Location = new System.Drawing.Point(639, 44);
            this.btnchitietphieunhap.Name = "btnchitietphieunhap";
            this.btnchitietphieunhap.Size = new System.Drawing.Size(100, 40);
            this.btnchitietphieunhap.TabIndex = 4;
            this.btnchitietphieunhap.Text = "Xem Chi Tiết";
            this.btnchitietphieunhap.UseVisualStyleBackColor = true;
            this.btnchitietphieunhap.Click += new System.EventHandler(this.btnchitietphieunhap_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoi.Location = new System.Drawing.Point(753, 44);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(100, 40);
            this.btnlammoi.TabIndex = 5;
            this.btnlammoi.Text = "Làm Mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // phieuNhapBindingSource
            // 
            this.phieuNhapBindingSource.DataMember = "PhieuNhap";
            this.phieuNhapBindingSource.DataSource = this.miniMarketDataSet;
            // 
            // miniMarketDataSet
            // 
            this.miniMarketDataSet.DataSetName = "MiniMarketDataSet";
            this.miniMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // txtidphieunhap
            // 
            this.txtidphieunhap.Location = new System.Drawing.Point(0, 15);
            this.txtidphieunhap.Name = "txtidphieunhap";
            this.txtidphieunhap.Size = new System.Drawing.Size(100, 20);
            this.txtidphieunhap.TabIndex = 7;
            // 
            // txtngaynhap
            // 
            this.txtngaynhap.Location = new System.Drawing.Point(0, 15);
            this.txtngaynhap.Name = "txtngaynhap";
            this.txtngaynhap.Size = new System.Drawing.Size(140, 20);
            this.txtngaynhap.TabIndex = 8;
            this.txtngaynhap.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtidnhanvien
            // 
            this.txtidnhanvien.Location = new System.Drawing.Point(0, 15);
            this.txtidnhanvien.Name = "txtidnhanvien";
            this.txtidnhanvien.Size = new System.Drawing.Size(100, 20);
            this.txtidnhanvien.TabIndex = 9;
            this.txtidnhanvien.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(0, 15);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(100, 20);
            this.txttongtien.TabIndex = 10;
            this.txttongtien.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtidncc
            // 
            this.txtidncc.Location = new System.Drawing.Point(0, 15);
            this.txtidncc.Name = "txtidncc";
            this.txtidncc.Size = new System.Drawing.Size(113, 20);
            this.txtidncc.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(175, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtidphieunhap);
            this.groupBox2.Location = new System.Drawing.Point(36, 525);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 35);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "id Phiếu Nhập";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtidnhanvien);
            this.groupBox3.Location = new System.Drawing.Point(226, 525);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 35);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "id Nhân Viên";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtidncc);
            this.groupBox4.Location = new System.Drawing.Point(433, 525);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(113, 35);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "id Nhà Cung Cấp";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtngaynhap);
            this.groupBox5.Location = new System.Drawing.Point(603, 525);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(146, 35);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ngày Nhập";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txttongtien);
            this.groupBox6.Location = new System.Drawing.Point(815, 525);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(100, 35);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tổng Tiền";
            // 
            // phieuNhapBindingSource1
            // 
            this.phieuNhapBindingSource1.DataMember = "PhieuNhap";
            this.phieuNhapBindingSource1.DataSource = this.miniMarketDataSet;
            // 
            // lsvpn
            // 
            this.lsvpn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvpn.FullRowSelect = true;
            this.lsvpn.HideSelection = false;
            this.lsvpn.Location = new System.Drawing.Point(133, 170);
            this.lsvpn.Name = "lsvpn";
            this.lsvpn.Size = new System.Drawing.Size(905, 300);
            this.lsvpn.TabIndex = 15;
            this.lsvpn.UseCompatibleStateImageBehavior = false;
            this.lsvpn.View = System.Windows.Forms.View.Details;
            this.lsvpn.SelectedIndexChanged += new System.EventHandler(this.lsvpn_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Phiếu Nhập";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã Nhân Viên";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã Nhà Cung Cấp";
            this.columnHeader4.Width = 142;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày Nhập";
            this.columnHeader5.Width = 259;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tổng Tiền";
            this.columnHeader6.Width = 300;
            // 
            // btntimkiempn
            // 
            this.btntimkiempn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiempn.Location = new System.Drawing.Point(242, 122);
            this.btntimkiempn.Name = "btntimkiempn";
            this.btntimkiempn.Size = new System.Drawing.Size(100, 40);
            this.btntimkiempn.TabIndex = 16;
            this.btntimkiempn.Text = "Tìm Kiếm";
            this.btntimkiempn.UseVisualStyleBackColor = true;
            this.btntimkiempn.Click += new System.EventHandler(this.txttimkiempn_Click);
            // 
            // PhieuNhapGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.btntimkiempn);
            this.Controls.Add(this.lsvpn);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnchitietphieunhap);
            this.Controls.Add(this.btnxuatexcel);
            this.Controls.Add(this.btnnhapexcel);
            this.Controls.Add(this.grbktg);
            this.Controls.Add(this.grbtongtien);
            this.Controls.Add(this.grbtimkiem);
            this.Name = "PhieuNhapGUI";
            this.Text = "PhieuNhapGUI";
            this.Load += new System.EventHandler(this.PhieuNhapGUI_Load);
            this.grbtimkiem.ResumeLayout(false);
            this.grbtimkiem.PerformLayout();
            this.grbktg.ResumeLayout(false);
            this.grbktg.PerformLayout();
            this.grbtongtien.ResumeLayout(false);
            this.grbtongtien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMarketDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbtimkiem;
        private System.Windows.Forms.GroupBox grbktg;
        private System.Windows.Forms.GroupBox grbtongtien;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnnhapexcel;
        private System.Windows.Forms.Button btnxuatexcel;
        private System.Windows.Forms.Button btnchitietphieunhap;
        private System.Windows.Forms.Button btnlammoi;
        private MiniMarketDataSet miniMarketDataSet;
        private System.Windows.Forms.BindingSource phieuNhapBindingSource;
        private MiniMarketDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttongtien2;
        private System.Windows.Forms.TextBox txttongtien1;
        private System.Windows.Forms.DateTimePicker dtpktg2;
        private System.Windows.Forms.DateTimePicker dtpktg1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidphieunhap;
        private System.Windows.Forms.TextBox txtngaynhap;
        private System.Windows.Forms.TextBox txtidnhanvien;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.TextBox txtidncc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.BindingSource phieuNhapBindingSource1;
        private System.Windows.Forms.ListView lsvpn;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btntimkiempn;
    }
}