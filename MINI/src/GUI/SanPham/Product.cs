using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINI.GUI
{
    [DefaultEvent(nameof(TextChanged))]
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }
        [Browsable(true)]
        public string Id_Pro
        {
            get => lblIDProduct.Text;
            set => lblIDProduct.Text = value;
        }
        [Browsable(true)]
        public string Img_Pro
        {
            get => pbImgProduct.ImageLocation;
            set => pbImgProduct.ImageLocation = value;
        }
        [Browsable(true)]
        public string Name_Pro
        {
            get => lblNameProduct.Text;
            set => lblNameProduct.Text = value;
        }
        [Browsable(true)]
        public string Num_Pro
        {
            get => lblNumProduct.Text;
            set => lblNumProduct.Text = value;
        }
    }
}
