namespace MINI.GUI
{
    partial class tabSanPham
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
            this.tabThemSanPham = new System.Windows.Forms.TabControl();
            this.tabDSSP = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabThemSanPham.SuspendLayout();
            this.tabDSSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabThemSanPham
            // 
            this.tabThemSanPham.Controls.Add(this.tabDSSP);
            this.tabThemSanPham.Controls.Add(this.tabPage2);
            this.tabThemSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabThemSanPham.ItemSize = new System.Drawing.Size(136, 50);
            this.tabThemSanPham.Location = new System.Drawing.Point(0, 0);
            this.tabThemSanPham.Name = "tabThemSanPham";
            this.tabThemSanPham.SelectedIndex = 0;
            this.tabThemSanPham.Size = new System.Drawing.Size(800, 450);
            this.tabThemSanPham.TabIndex = 0;
            // 
            // tabDSSP
            // 
            this.tabDSSP.Controls.Add(this.flowLayoutPanel1);
            this.tabDSSP.Location = new System.Drawing.Point(4, 54);
            this.tabDSSP.Name = "tabDSSP";
            this.tabDSSP.Padding = new System.Windows.Forms.Padding(3);
            this.tabDSSP.Size = new System.Drawing.Size(792, 392);
            this.tabDSSP.TabIndex = 0;
            this.tabDSSP.Text = "Danh sách sản phẩm";
            this.tabDSSP.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thêm sản phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(724, 392);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabThemSanPham);
            this.Name = "tabSanPham";
            this.Text = "SanPham";
            this.tabThemSanPham.ResumeLayout(false);
            this.tabDSSP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabThemSanPham;
        private System.Windows.Forms.TabPage tabDSSP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}