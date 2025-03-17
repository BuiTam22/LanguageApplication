namespace LanguageApplication
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSignIn = new Button();
            btnSignUp = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            txtPassWord = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnSignIn
            // 
<<<<<<< HEAD
            btnSignIn.Location = new Point(193, 232);
            btnSignIn.Margin = new Padding(3, 4, 3, 4);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(86, 30);
=======
            btnSignIn.Location = new Point(241, 290);
            btnSignIn.Margin = new Padding(4, 5, 4, 5);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(107, 38);
>>>>>>> main
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "Sign in";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnSignUp
            // 
<<<<<<< HEAD
            btnSignUp.Location = new Point(305, 232);
            btnSignUp.Margin = new Padding(3, 4, 3, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(86, 30);
=======
            btnSignUp.Location = new Point(381, 290);
            btnSignUp.Margin = new Padding(4, 5, 4, 5);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(107, 38);
>>>>>>> main
            btnSignUp.TabIndex = 0;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
<<<<<<< HEAD
            label1.Location = new Point(121, 128);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
=======
            label1.Location = new Point(151, 160);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
>>>>>>> main
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
<<<<<<< HEAD
            label2.Location = new Point(121, 182);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
=======
            label2.Location = new Point(151, 227);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
>>>>>>> main
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtUserName
            // 
<<<<<<< HEAD
            txtUserName.Location = new Point(218, 124);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(172, 27);
=======
            txtUserName.Location = new Point(273, 155);
            txtUserName.Margin = new Padding(4, 5, 4, 5);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(214, 31);
>>>>>>> main
            txtUserName.TabIndex = 2;
            // 
            // txtPassWord
            // 
<<<<<<< HEAD
            txtPassWord.Location = new Point(218, 170);
            txtPassWord.Margin = new Padding(3, 4, 3, 4);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.Size = new Size(172, 27);
=======
            txtPassWord.Location = new Point(273, 212);
            txtPassWord.Margin = new Padding(4, 5, 4, 5);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(214, 31);
>>>>>>> main
            txtPassWord.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
<<<<<<< HEAD
            label3.Location = new Point(249, 34);
            label3.Name = "label3";
            label3.Size = new Size(112, 46);
=======
            label3.Location = new Point(311, 43);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 54);
>>>>>>> main
            label3.TabIndex = 3;
            label3.Text = "Log in";
            // 
            // Login
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 404);
=======
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 505);
>>>>>>> main
            Controls.Add(label3);
            Controls.Add(txtPassWord);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSignUp);
            Controls.Add(btnSignIn);
<<<<<<< HEAD
            Margin = new Padding(3, 4, 3, 4);
=======
            Margin = new Padding(4, 5, 4, 5);
>>>>>>> main
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignIn;
        private Button btnSignUp;
        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPassWord;
        private Label label3;
    }
}