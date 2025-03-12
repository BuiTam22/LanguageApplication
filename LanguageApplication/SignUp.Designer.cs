namespace LanguageApplication
{
    partial class SignUp
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
            label3 = new Label();
            txtPassWord = new TextBox();
            txtUserName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnSignUp = new Button();
            txtReEnterPassWord = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(236, 98);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(163, 54);
            label3.TabIndex = 10;
            label3.Text = "Sign Up";
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(216, 268);
            txtPassWord.Margin = new Padding(4, 5, 4, 5);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(214, 31);
            txtPassWord.TabIndex = 8;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(216, 212);
            txtUserName.Margin = new Padding(4, 5, 4, 5);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(214, 31);
            txtUserName.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 273);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 217);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 7;
            label1.Text = "User name";
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(260, 410);
            btnSignUp.Margin = new Padding(4, 5, 4, 5);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(107, 38);
            btnSignUp.TabIndex = 4;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // txtReEnterPassWord
            // 
            txtReEnterPassWord.Location = new Point(216, 335);
            txtReEnterPassWord.Margin = new Padding(4, 5, 4, 5);
            txtReEnterPassWord.Name = "txtReEnterPassWord";
            txtReEnterPassWord.Size = new Size(214, 31);
            txtReEnterPassWord.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 340);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 11;
            label4.Text = "Re-enter Password";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 593);
            Controls.Add(txtReEnterPassWord);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPassWord);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSignUp);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtPassWord;
        private TextBox txtUserName;
        private Label label2;
        private Label label1;
        private Button btnSignUp;
        private TextBox txtReEnterPassWord;
        private Label label4;
    }
}