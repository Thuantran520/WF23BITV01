using System.Text;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra đầu vào hợp lệ
            if (int.TryParse(txtInputN.Text, out int n) && n > 0)
            {
                int sum = 0;
                StringBuilder strBuilder = new StringBuilder();

                // 2. Vòng lặp for xử lý tính tổng và ghép chuỗi
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                    strBuilder.Append(i);

                    // Thêm dấu "+" nếu chưa phải là số cuối cùng
                    if (i < n)
                    {
                        strBuilder.Append("+");
                    }
                }

                // 3. Gán kết quả ra giao diện
                txtChuoiS.Text = strBuilder.ToString();
                txtKetQuaS.Text = sum.ToString();
            }
            else
            {
                // Xử lý lỗi nhập liệu
                MessageBox.Show("Vui lòng nhập vào một số nguyên dương hợp lệ!",
                                "Lỗi nhập liệu",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtInputN.Focus();
                txtInputN.SelectAll();
            }
        }
    }
}
