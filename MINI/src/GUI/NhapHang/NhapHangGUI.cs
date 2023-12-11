using MINI.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MINI.src.GUI.PhieuNhap
{
    public partial class NhapHangGUI : Form
    {
        public bool Themmoi = false;
        SanPhamBUS sp = new SanPhamBUS();
        
        public NhapHangGUI()
        {
            InitializeComponent();
        }

        void HienThiSanPham()
        {
            lsvdssp.Items.Clear();
            DataTable dt = sp.LayDSSanPham();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvdssp.Items.Add(dt.Rows[i][0].ToString()); lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }

        }



        void TimKiemTheoTenSanPham(string tenSP)
        {
            lsvdssp.Items.Clear();
            DataTable dt = sp.LayDSCTPNTheoTenSP(tenSP); // Giả sử có một phương thức để lấy chi tiết nhập hàng dựa trên mã
                                                                       // Điền dữ liệu vào ListView
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // Thêm dữ liệu vào ListView
                ListViewItem lvi = lsvdssp.Items.Add(dt.Rows[i][0].ToString()); lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }

       
        void ThemSanPhamVaoListView(string maSanPham, string tenSanPham, string soLuong, string donGia)
        {
            bool sanPhamDaTonTai = false;
            int Soluong = int.Parse(soLuong);
            decimal DonGia = decimal.Parse(donGia);

            // Duyệt qua các mục trong List View để tìm sản phẩm trùng nhau
            foreach (ListViewItem item in lsvdsspnhap.Items)
            {
                if (item.SubItems[1].Text == maSanPham) // Giả sử cột đầu tiên chứa mã sản phẩm
                {
                    // Tìm thấy sản phẩm trùng nhau, tăng số lượng lên và cập nhật thành tiền
                    int soLuongHienTai = int.Parse(item.SubItems[3].Text); // Giả sử cột thứ ba chứa số lượng
                    soLuongHienTai += Soluong;

                    item.SubItems[3].Text = soLuongHienTai.ToString(); // Cập nhật số lượng trong List View

                    decimal thanhTien = soLuongHienTai * DonGia;
                    item.SubItems[5].Text = thanhTien.ToString(); // Cập nhật thành tiền trong List View

                    sanPhamDaTonTai = true;
                    break; // Thoát khỏi vòng lặp sau khi tìm thấy sản phẩm
                }
            }

            // Nếu sản phẩm chưa tồn tại trong List View, thêm sản phẩm mới vào List View
            if (!sanPhamDaTonTai)
            {
                
                string[] row = { (lsvdsspnhap.Items.Count + 1).ToString(), maSanPham, tenSanPham, soLuong, donGia, (Soluong * DonGia).ToString() };
                var listViewItem = new ListViewItem(row);
                lsvdsspnhap.Items.Add(listViewItem);
            }
            CapNhatTongThanhTien();
        }

        decimal TinhTongThanhTien()
        {
            decimal tongThanhTien = 0;

            // Duyệt qua các mục trong List View và cộng dồn thành tiền
            foreach (ListViewItem item in lsvdsspnhap.Items)
            {
                tongThanhTien += decimal.Parse(item.SubItems[5].Text);
            }

            return tongThanhTien;
        }

        // Gọi phương thức tính tổng thành tiền và cập nhật vào TextBox tổng tiền
        void CapNhatTongThanhTien()
        {
            decimal tongThanhTien = TinhTongThanhTien();
            txttongtien.Text = tongThanhTien.ToString();
        }

        void CapNhatSTT()
        {
            for (int i = 0; i < lsvdsspnhap.Items.Count; i++)
            {
                lsvdsspnhap.Items[i].Text = (i + 1).ToString();
            }
        }

        void SuaMucListView()
        {
            if (lsvdsspnhap.SelectedItems.Count > 0)
            {
                // Lấy mục được chọn
                ListViewItem selected = lsvdsspnhap.SelectedItems[0];

                // Hiển thị thông tin của mục được chọn lên các control phía dưới hoặc trong các ô nhập liệu tương ứng.
                txtidsanpham.Text = selected.SubItems[1].Text;
                txttensp.Text = selected.SubItems[2].Text;
                txtsoluong.Text = selected.SubItems[3].Text;
                txtdongia.Text = selected.SubItems[4].Text;
                lsvdsspnhap.Items.RemoveAt(lsvdsspnhap.SelectedIndices[0]);
                CapNhatSTT();
                // Sau khi chỉnh sửa thông tin, người dùng có thể ấn một nút "Lưu" để cập nhật lại thông tin trong ListView
                // Và sau đó cập nhật lại số thứ tự và tổng thành tiền nếu cần
            }
        }

        private void OpenformChonNCC()
        {
            ChonNhaCungCap chonNhaCungCap = new ChonNhaCungCap();
            chonNhaCungCap.Show();
        }

        private void NhapHangGUI_Load(object sender, EventArgs e)
        {
            HienThiSanPham();
            
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnlmthanhtoan_Click(object sender, EventArgs e)
        {
            lsvdsspnhap.Items.Clear();
            txtidncc.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenformChonNCC();  
        }

        private void lsvdssp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            if (lsvdssp.SelectedIndices.Count > 0)
            {
               txtidsanpham.Text = lsvdssp.SelectedItems[0].SubItems[0].Text;
                txtidlsp.Text = lsvdssp.SelectedItems[0].SubItems[1].Text;
                txttensp.Text = lsvdssp.SelectedItems[0].SubItems[2].Text;
                txtdongia.Text = lsvdssp.SelectedItems[0].SubItems[3].Text;
                txtsoluong.Text = "1";

                // Lấy đường dẫn ảnh từ cơ sở dữ liệu hoặc từ đối tượng sản phẩm
               /* string imagePath = sp.GetImagePathForSelectedProduct(lsvdssp.SelectedItems[0].SubItems[0].Text); // Thay thế bằng cách lấy đường dẫn ảnh tương ứng với sản phẩm được chọn

                if (!string.IsNullOrEmpty(imagePath))
                {
                    // Hiển thị ảnh trong PictureBox
                    ptbsanpham.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // Nếu không có ảnh tương ứng, hiển thị ảnh mặc định hoặc ẩn PictureBox
                    ptbsanpham.Image = null;
                }*/
            }

        }

        private void btntimkiemsp_Click(object sender, EventArgs e)
        {
            TimKiemTheoTenSanPham(txtsearchsp.Text);
        }

        private void btnlammoisp_Click(object sender, EventArgs e)
        {
            HienThiSanPham();
            txtsearchsp.Text = "";
            txtidsanpham.Text = "";
            txtidlsp.Text = "";
            txttensp.Text = "";
            txtsoluong.Text = "";
            txtdongia.Text = "";
        }

        private void btnthemsp_Click(object sender, EventArgs e)
        {
            ThemSanPhamVaoListView(txtidsanpham.Text, txttensp.Text, txtsoluong.Text, txtdongia.Text);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            lsvdsspnhap.Items.Clear();
        }

        private void btnxoathanhtoan_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn không
            
            lsvdsspnhap.Items.RemoveAt(lsvdsspnhap.SelectedIndices[0]);
            CapNhatSTT();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SuaMucListView();
        }
    }
}
