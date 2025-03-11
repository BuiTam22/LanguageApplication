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
            btnSignIn.Location = new Point(169, 174);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(75, 23);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "Sign in";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(267, 174);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(75, 23);
            btnSignUp.TabIndex = 0;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 96);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 136);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Pass word";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(191, 93);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(151, 23);
            txtUserName.TabIndex = 2;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(191, 127);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(151, 23);
            txtPassWord.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(218, 26);
            label3.Name = "label3";
            label3.Size = new Size(91, 37);
            label3.TabIndex = 3;
            label3.Text = "Log in";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 303);
            Controls.Add(label3);
            Controls.Add(txtPassWord);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSignUp);
            Controls.Add(btnSignIn);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
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