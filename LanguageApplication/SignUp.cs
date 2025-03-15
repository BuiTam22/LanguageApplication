using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace LanguageApplication
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ TextBox trên Form
            string userName = txtUserName.Text.Trim();
            string password = txtPassWord.Text.Trim();
            string re_enterpassword = txtReEnterPassWord.Text.Trim();

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(re_enterpassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chuỗi kết nối đến Oracle
            string conString = "User Id=LanguageApplication;Password=123456;Data Source=192.168.29.1";

            using (OracleConnection con = new OracleConnection(conString))
            {
                try
                {
                    con.Open();

                    using (OracleCommand cmd = new OracleCommand("SignUpUser", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("p_userName", OracleDbType.Varchar2).Value = userName;
                        cmd.Parameters.Add("p_passWord", OracleDbType.Varchar2).Value = password;
                        cmd.Parameters.Add("p_name", OracleDbType.NVarchar2).Value = "Default Name"; // Hoặc txtName.Text.Trim();
                        cmd.Parameters.Add("p_email", OracleDbType.Varchar2).Value = "default@email.com"; // Hoặc txtEmail.Text.Trim();

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Chuyển về Form Login
                    Login theLogIn = new Login();
                        theLogIn.Show();
                        this.Close();
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}