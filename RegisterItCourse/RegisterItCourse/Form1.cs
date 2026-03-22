using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterItCourse
{
    public partial class Form1 : Form
    {
        public List<HocVien> danhSachHocVien = new List<HocVien>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(870, 410);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // kiểm tra các trường bắt buộc
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboNganhHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một ngành học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tính toán học phí
            double donGiaThang = 2000000; // 2 triệu/tháng
            int soThang = Convert.ToInt32(numThoiGian.Value);
            double hocPhiGoc = soThang * donGiaThang;
            double phanTramGiam = 0;

            // Xác định mức giảm giá dựa trên CheckBox
            if (chkSinhVien.Checked) phanTramGiam = 0.10;
            else if (chkNguoiDiLam.Checked) phanTramGiam = 0.05;
            else if (chkHocSinh.Checked) phanTramGiam = 0.15;

            double tongTien = hocPhiGoc * (1 - phanTramGiam);

            string nganhHoc = cboNganhHoc.SelectedItem.ToString();

            // Xử lý CheckedListBox (Kỹ năng bổ trợ)
            double phiKyNangBoTro = 0;
            List<string> kyNangs = new List<string>();
            const double giaMoiKyNang = 500000; // Phí mỗi môn bổ trợ

            //foreach (var item in clbKyNang.CheckedItems)
            //{
            //    phiKyNangBoTro += giaMoiKyNang;
            //    danhSachKyNang += item.ToString() + ", ";
            //}
            //// Xóa dấu phẩy thừa ở cuối chuỗi
            //danhSachKyNang = danhSachKyNang.TrimEnd(' ', ',');
            foreach(var item in clbKyNang.CheckedItems)
            {
                kyNangs.Add(item.ToString());
            }
            string danhSachKyNang = string.Join(", ", kyNangs);
            tongTien += phiKyNangBoTro + kyNangs.Count * giaMoiKyNang;

            //thêm thông tin vào datagridview
            var hv = new HocVien
            {
                HoTen = txtHoTen.Text,
                DienThoai = txtSDT.Text,
                NganhHoc = nganhHoc,
                ThoiGianHoc = soThang,
                MonBoTro = danhSachKyNang,
                Email = txtEmail.Text,
                LaNam = radNam.Checked,
                MaUuDai = dudMaGiamGia.SelectedItem.ToString(),
                NgaySinh = dtpNgaySinh.Value,
                PhanTramGiam = phanTramGiam * 100,
                TongTien = tongTien
            };
            danhSachHocVien.Add(hv);

            //update lưới
            dgvDanhSach.DataSource = null;
            dgvDanhSach.DataSource = danhSachHocVien;

            tabControl1.SelectedTab = tabPage2;
        }

        private void chkSinhVien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSinhVien.Checked)
            {
                chkHocSinh.Checked = false;
                chkNguoiDiLam.Checked = false;
            }
        }

        private void chkNguoiDiLam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNguoiDiLam.Checked)
            {
                chkSinhVien.Checked = false;
                chkHocSinh.Checked = false;
            }
        }

        private void chkHocSinh_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHocSinh.Checked)
            {
                chkSinhVien.Checked = false;
                chkNguoiDiLam.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
