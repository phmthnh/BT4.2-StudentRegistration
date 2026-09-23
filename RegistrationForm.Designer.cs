namespace BT4_2_StudentRegistration
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle      = new System.Windows.Forms.Label();
            lblFullName   = new System.Windows.Forms.Label();
            txtFullName   = new System.Windows.Forms.TextBox();
            lblBirthDate  = new System.Windows.Forms.Label();
            dtpBirthDate  = new System.Windows.Forms.DateTimePicker();
            lblPhone      = new System.Windows.Forms.Label();
            mtxtPhone     = new System.Windows.Forms.MaskedTextBox();
            lblCourse     = new System.Windows.Forms.Label();
            cboCourse     = new System.Windows.Forms.ComboBox();
            lblExtras     = new System.Windows.Forms.Label();
            chkEnglish    = new System.Windows.Forms.CheckBox();
            chkSoftSkills = new System.Windows.Forms.CheckBox();
            chkIT         = new System.Windows.Forms.CheckBox();
            btnRegister   = new System.Windows.Forms.Button();
            btnClear      = new System.Windows.Forms.Button();
            SuspendLayout();

            // Form - bỏ giới tính nên giảm chiều cao
            Text            = "Đăng Ký Học Viên";
            Size            = new System.Drawing.Size(480, 370);
            StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox     = false;

            // Tiêu đề
            lblTitle.Text      = "FORM ĐĂNG KÝ HỌC VIÊN";
            lblTitle.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTitle.Location  = new System.Drawing.Point(50, 15);
            lblTitle.Size      = new System.Drawing.Size(370, 32);

            int lx = 30, cx = 170, rh = 40, row = 60;

            // Họ và tên
            lblFullName.Text     = "Họ và tên:";
            lblFullName.Location = new System.Drawing.Point(lx, row + 3);
            lblFullName.Size     = new System.Drawing.Size(120, 23);
            txtFullName.Location = new System.Drawing.Point(cx, row);
            txtFullName.Size     = new System.Drawing.Size(260, 23);
            row += rh;

            // Ngày sinh
            lblBirthDate.Text     = "Ngày sinh:";
            lblBirthDate.Location = new System.Drawing.Point(lx, row + 3);
            lblBirthDate.Size     = new System.Drawing.Size(120, 23);
            dtpBirthDate.Location = new System.Drawing.Point(cx, row);
            dtpBirthDate.Size     = new System.Drawing.Size(200, 23);
            dtpBirthDate.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            row += rh;

            // Điện thoại
            lblPhone.Text      = "Điện thoại:";
            lblPhone.Location  = new System.Drawing.Point(lx, row + 3);
            lblPhone.Size      = new System.Drawing.Size(120, 23);
            mtxtPhone.Location = new System.Drawing.Point(cx, row);
            mtxtPhone.Size     = new System.Drawing.Size(200, 23);
            mtxtPhone.Mask     = "(000) 000-0000";
            row += rh;

            // Khóa học
            lblCourse.Text      = "Khóa học:";
            lblCourse.Location  = new System.Drawing.Point(lx, row + 3);
            lblCourse.Size      = new System.Drawing.Size(120, 23);
            cboCourse.Location  = new System.Drawing.Point(cx, row);
            cboCourse.Size      = new System.Drawing.Size(260, 23);
            cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            row += rh;

            // Môn bổ sung
            lblExtras.Text         = "Môn bổ sung:";
            lblExtras.Location     = new System.Drawing.Point(lx, row + 3);
            lblExtras.Size         = new System.Drawing.Size(120, 23);
            chkEnglish.Text        = "Tiếng Anh";
            chkEnglish.Location    = new System.Drawing.Point(cx, row);
            chkEnglish.AutoSize    = true;
            chkSoftSkills.Text     = "Kỹ năng mềm";
            chkSoftSkills.Location = new System.Drawing.Point(cx + 105, row);
            chkSoftSkills.AutoSize = true;
            chkIT.Text             = "Tin học";
            chkIT.Location         = new System.Drawing.Point(cx + 220, row);
            chkIT.AutoSize         = true;
            row += rh + 5;

            // Nút Đăng Ký
            btnRegister.Text      = "Đăng Ký";
            btnRegister.Location  = new System.Drawing.Point(110, row);
            btnRegister.Size      = new System.Drawing.Size(110, 35);
            btnRegister.BackColor = System.Drawing.Color.FromArgb(0, 150, 100);
            btnRegister.ForeColor = System.Drawing.Color.White;
            btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegister.Click    += btnRegister_Click;

            // Nút Xóa
            btnClear.Text      = "Xóa";
            btnClear.Location  = new System.Drawing.Point(250, row);
            btnClear.Size      = new System.Drawing.Size(110, 35);
            btnClear.BackColor = System.Drawing.Color.FromArgb(200, 100, 50);
            btnClear.ForeColor = System.Drawing.Color.White;
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Click    += btnClear_Click;

            Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTitle,
                lblFullName, txtFullName,
                lblBirthDate, dtpBirthDate,
                lblPhone, mtxtPhone,
                lblCourse, cboCourse,
                lblExtras, chkEnglish, chkSoftSkills, chkIT,
                btnRegister, btnClear
            });

            ResumeLayout(false);
        }

        // Fields - đã xóa rdoMale, rdoFemale, lblGender
        private System.Windows.Forms.Label          lblTitle, lblFullName, lblBirthDate, lblPhone, lblCourse, lblExtras;
        private System.Windows.Forms.TextBox        txtFullName;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.MaskedTextBox  mtxtPhone;
        private System.Windows.Forms.ComboBox       cboCourse;
        private System.Windows.Forms.CheckBox       chkEnglish, chkSoftSkills, chkIT;
        private System.Windows.Forms.Button         btnRegister, btnClear;
    }
}
