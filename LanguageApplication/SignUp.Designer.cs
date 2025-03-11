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
            label3.Location = new Point(165, 59);
            label3.Name = "label3";
            label3.Size = new Size(111, 37);
            label3.TabIndex = 10;
            label3.Text = "Sign Up";
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(151, 161);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(151, 23);
            txtPassWord.TabIndex = 8;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(151, 127);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(151, 23);
            txtUserName.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 164);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 130);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 7;
            label1.Text = "User name";
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(182, 246);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(75, 23);
            btnSignUp.TabIndex = 4;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = true;
            // 
            // txtReEnterPassWord
            // 
            txtReEnterPassWord.Location = new Point(151, 201);
            txtReEnterPassWord.Name = "txtReEnterPassWord";
            txtReEnterPassWord.Size = new Size(151, 23);
            txtReEnterPassWord.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 204);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 11;
            label4.Text = "Re-enter Password";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 356);
            Controls.Add(txtReEnterPassWord);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPassWord);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSignUp);
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