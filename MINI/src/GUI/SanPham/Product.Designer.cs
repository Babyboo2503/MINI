namespace MINI.src.GUI
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
            this.lblNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNameProduct.Location = new System.Drawing.Point(2, 112);
            this.lblNameProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNameProduct.Size = new System.Drawing.Size(128, 46);
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
            this.lblIDProduct.Location = new System.Drawing.Point(94, 0);
            this.lblIDProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDProduct.Name = "lblIDProduct";
            this.lblIDProduct.Size = new System.Drawing.Size(23, 17);
            this.lblIDProduct.TabIndex = 1;
            this.lblIDProduct.Text = "ID";
            // 
            // lblNumProduct
            // 
            this.lblNumProduct.AutoSize = true;
            this.lblNumProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNumProduct.Location = new System.Drawing.Point(48, 158);
            this.lblNumProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumProduct.Name = "lblNumProduct";
            this.lblNumProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNumProduct.Size = new System.Drawing.Size(23, 17);
            this.lblNumProduct.TabIndex = 2;
            this.lblNumProduct.Text = "...";
            this.lblNumProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbImgProduct);
            this.panel1.Controls.Add(this.lblIDProduct);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 108);
            this.panel1.TabIndex = 3;
            // 
            // pbImgProduct
            // 
            this.pbImgProduct.ImageLocation = "";
            this.pbImgProduct.Location = new System.Drawing.Point(22, 19);
            this.pbImgProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbImgProduct.Name = "pbImgProduct";
            this.pbImgProduct.Size = new System.Drawing.Size(92, 87);
            this.pbImgProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgProduct.TabIndex = 2;
            this.pbImgProduct.TabStop = false;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNumProduct);
            this.Controls.Add(this.lblNameProduct);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(133, 175);
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
