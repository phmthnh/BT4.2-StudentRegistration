using System;
using System.Windows.Forms;

namespace BT4_2_StudentRegistration
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            LoadCourseData();
        }

        // Nạp danh sách khóa học vào ComboBox
        private void LoadCourseData()
        {
            var courses = new[]
            {
                new { Id = 1, Name = "Lập trình C# cơ bản" },
                new { Id = 2, Name = "Lập trình Web ASP.NET" },
                new { Id = 3, Name = "Lập trình Mobile Xamarin" },
                new { Id = 4, Name = "Cơ sở dữ liệu SQL Server" },
                new { Id = 5, Name = "Trí tuệ nhân tạo Python" }
            };

            cboCourse.DataSource    = courses;
            cboCourse.DisplayMember = "Name";
            cboCourse.ValueMember   = "Id";
        }

        // Nút Đăng Ký
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Thu thập môn học thêm (CheckBox)
            var extras = new System.Collections.Generic.List<string>();
            if (chkEnglish.Checked)    extras.Add("Tiếng Anh");
            if (chkSoftSkills.Checked) extras.Add("Kỹ năng mềm");
            if (chkIT.Checked)         extras.Add("Tin học văn phòng");
            string extraStr = extras.Count > 0 ? string.Join(", ", extras) : "Không";

            string info = "===== THÔNG TIN ĐĂNG KÝ =====\n" +
                          $"Họ tên:      {txtFullName.Text}\n" +
                          $"Ngày sinh:   {dtpBirthDate.Value:dd/MM/yyyy}\n" +
                          $"Điện thoại:  {mtxtPhone.Text}\n" +
                          $"Khóa học:    {cboCourse.Text}\n" +
                          $"Môn bổ sung: {extraStr}\n" +
                          "==============================";

            MessageBox.Show(info, "Đăng Ký Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Nút Xóa form
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            dtpBirthDate.Value      = DateTime.Today;
            mtxtPhone.Clear();
            cboCourse.SelectedIndex = 0;
            chkEnglish.Checked      = false;
            chkSoftSkills.Checked   = false;
            chkIT.Checked           = false;
        }
    }
}
