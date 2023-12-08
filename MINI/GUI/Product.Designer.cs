namespace MINI.GUI
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNameProduct = new System.Windows.Forms.Label();
            this.lblIDProduct = new System.Windows.Forms.Label();
            this.lblNumProduct = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbImgProduct = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.AutoSize = true;
            this.lblNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNameProduct.Location = new System.Drawing.Point(28, 155);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNameProduct.Size = new System.Drawing.Size(127, 20);
            this.lblNameProduct.TabIndex = 0;
            this.lblNameProduct.Text = "Tên sản phẩm";
            this.lblNameProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIDProduct
            // 
            this.lblIDProduct.AutoSize = true;
            this.lblIDProduct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIDProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIDProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblIDProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblIDProduct.Location = new System.Drawing.Point(126, 0);
            this.lblIDProduct.Name = "lblIDProduct";
            this.lblIDProduct.Size = new System.Drawing.Size(26, 20);
            this.lblIDProduct.TabIndex = 1;
            this.lblIDProduct.Text = "ID";
            // 
            // lblNumProduct
            // 
            this.lblNumProduct.AutoSize = true;
            this.lblNumProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNumProduct.Location = new System.Drawing.Point(43, 184);
            this.lblNumProduct.Name = "lblNumProduct";
            this.lblNumProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNumProduct.Size = new System.Drawing.Size(82, 20);
            this.lblNumProduct.TabIndex = 2;
            this.lblNumProduct.Text = "Số lượng";
            this.lblNumProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbImgProduct);
            this.panel1.Controls.Add(this.lblIDProduct);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 133);
            this.panel1.TabIndex = 3;
            // 
            // pbImgProduct
            // 
            this.pbImgProduct.ImageLocation = "";
            this.pbImgProduct.Location = new System.Drawing.Point(29, 23);
            this.pbImgProduct.Name = "pbImgProduct";
            this.pbImgProduct.Size = new System.Drawing.Size(123, 107);
            this.pbImgProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgProduct.TabIndex = 2;
            this.pbImgProduct.TabStop = false;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNumProduct);
            this.Controls.Add(this.lblNameProduct);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(177, 215);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameProduct;
        private System.Windows.Forms.Label lblIDProduct;
        private System.Windows.Forms.Label lblNumProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbImgProduct;
    }
}
