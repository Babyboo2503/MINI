using MINI.BUS;
using MINI.src.BUS;
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

namespace MINI.src.GUI
{
    public partial class NhapHangGUI : Form
    {
        public bool Themmoi = false;
        SanPhamBUS sp = new SanPhamBUS();
        PhieuNhapBUS pn = new PhieuNhapBUS();
        string user, pass;
        public NhapHangGUI(string Username, string Password)
        {
            InitializeComponent();
            this.user = Username;
            this.pass = Password;
        }

        void HienThiSanPham()
        {
            lsvdssp.Items.Clear();
            DataTable dt = sp.layDSSP();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                decimal donGia = Convert.ToDecimal(dt.Rows[i][2]); // Lấy đơn giá từ cột thứ 3 - Sửa đổi kiểu dữ liệu nếu cần thiết
                decimal donGiaGiam10PhanTram = donGia * 0.9m; // Tính đơn giá giảm 10%
                ListViewItem lvi =
                lsvdssp.Items.Add(dt.Rows[i][0].ToString()); lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(donGiaGiam10PhanTram.ToString());
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
            if(int.TryParse(soLuong, out int number) && number > 0)
            {
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
            else
            {
                MessageBox.Show("Vui lòng Nhập Đúng Thông Tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

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
            chonNhaCungCap.UpdateButtonVisibility(false);
            DialogResult result = chonNhaCungCap.ShowDialog();  // Hiển thị form ChonNhaCungCap dưới dạng dialog

            if (result == DialogResult.OK)  // Nếu người dùng click nút "Chon" trong form ChonNhaCungCap
            {
                string selectedValue = chonNhaCungCap.SelectedData;  // Lấy giá trị được chọn từ form ChonNhaCungCap
                if (!string.IsNullOrEmpty(selectedValue))
                {
                    txtidncc.Text = selectedValue;  // Cập nhật textbox txtidncc với giá trị được chọn
                }
            }
        }

        void LayNgayHienTai()
        {
            // Lấy ngày hiện tại
            DateTime currentDate = DateTime.Now;

            // Đặt ngày hiện tại vào TextBox
            txtngaylap.Text = currentDate.ToShortDateString();
        }
        /*void ThanhToanButton_Click(object sender, EventArgs e)
        {
            // Duyệt qua tất cả sản phẩm trong ListView
            foreach (ListViewItem item in lsvdssp.Items)
            {
                string maSanPham = item.SubItems[0].Text; // Lấy mã sản phẩm từ ListView
                int soLuongBan = int.Parse(item.SubItems[2].Text); // Lấy số lượng sản phẩm cần cập nhật

                // Cập nhật số lượng sản phẩm trong cơ sở dữ liệu
                pn.CapNhatSoLuongSanPhamTrongDatabase(maSanPham, soLuongBan);

                // Cập nhật lại danh sách sản phẩm (dssp)
                // Đây là nơi bạn cần cập nhật lại danh sách sản phẩm trong ứng dụng của mình
                // Sau khi cập nhật cơ sở dữ liệu
                // Ví dụ: gọi lại hàm HienThiSanPham() để refresh danh sách sản phẩm
                HienThiSanPham();
            }
        }*/

        private void NhapHangGUI_Load(object sender, EventArgs e)
        {
            txtsearchsp_Leave(sender, e);
            LayNgayHienTai();
            txtidnhanvien.Text = "1";
            txttongtien.Text = "0";
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
            if (lsvdsspnhap.SelectedIndices.Count > 0)
            {
                lsvdsspnhap.Items.RemoveAt(lsvdsspnhap.SelectedIndices[0]);
                CapNhatSTT();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để Xóa Sản Phẩm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lsvdsspnhap.SelectedIndices.Count > 0) { 
            SuaMucListView();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để Sửa Sản Phẩm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtidncc.Text) && string.IsNullOrEmpty(txtngaylap.Text))
            {
                MessageBox.Show("Vui lòng Chọn nhà cung cấp trước khi thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Duyệt qua tất cả sản phẩm trong ListView
                foreach (ListViewItem item in lsvdsspnhap.Items)
                {
                    string maSanPham = item.SubItems[1].Text; // Lấy mã sản phẩm từ ListView
                    int soLuongBan = int.Parse(item.SubItems[3].Text); // Lấy số lượng sản phẩm cần cập nhật

                    // Cập nhật số lượng sản phẩm trong cơ sở dữ liệu
                    pn.CapNhatSoLuongSanPhamTrongDatabase(maSanPham, soLuongBan);

                    // Cập nhật lại danh sách sản phẩm (dssp)
                    // Đây là nơi bạn cần cập nhật lại danh sách sản phẩm trong ứng dụng của mình
                    // Sau khi cập nhật cơ sở dữ liệu
                    // Ví dụ: gọi lại hàm HienThiSanPham() để refresh danh sách sản phẩm
                    HienThiSanPham();
                }
                DateTime ngaylap;
                decimal tongtien;
                if (DateTime.TryParse(txtngaylap.Text, out ngaylap) && decimal.TryParse(txttongtien.Text, out tongtien))
                {
                    pn.ThemPhieuNhap(txtidncc.Text, txtidnhanvien.Text, ngaylap, tongtien);

                    // Hiển thị thông báo khi thêm phiếu nhập thành công
                    MessageBox.Show("Thêm phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                lsvdsspnhap.Items.Clear();
                txttongtien.Text = "0";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btntimkiemsp_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtsearchsp_Click(object sender, EventArgs e)
        {
            txtsearchsp.Clear();
        }

        private void txtsearchsp_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsearchsp.Text))
            {
                txtsearchsp.Text = "Tên Sản Phẩm ";
                txtsearchsp.ForeColor = Color.DimGray;
            }
        }

        private void txtsearchsp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidlsp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
