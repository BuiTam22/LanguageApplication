using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageApplication
{
    public partial class Login : Form
    {
        private Form1 mainForm;

        public Login(Form1 form)
        {
            InitializeComponent();
            mainForm = form;  // Nhận tham chiếu tới Form1 hiện tại
        }
        public Login() {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // Gọi phương thức để bật mntFeature trên form chính
            // Viết mã Sql Truy vấn User hợp lệ
            mainForm.setMntFeatureEnableTrue();
            this.Close();  // Đóng form Login
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp theSignUp = new SignUp();
            theSignUp.Show();
            this.Close();
        }


    }
}
