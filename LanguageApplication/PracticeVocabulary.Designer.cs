namespace LanguageApplication
{
    partial class PracticeVocabulary
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
            label1 = new Label();
            label2 = new Label();
            txtEnglishWord = new TextBox();
            txtVietnameseWord = new TextBox();
            btnSubmit = new Button();
            lblResuit = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(460, 117);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "English Word";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 117);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 0;
            label2.Text = "Vietnamese Word";
            // 
            // txtEnglishWord
            // 
            txtEnglishWord.Location = new Point(410, 156);
            txtEnglishWord.Name = "txtEnglishWord";
            txtEnglishWord.Size = new Size(194, 27);
            txtEnglishWord.TabIndex = 1;
            // 
            // txtVietnameseWord
            // 
            txtVietnameseWord.Location = new Point(73, 156);
            txtVietnameseWord.Multiline = true;
            txtVietnameseWord.Name = "txtVietnameseWord";
            txtVietnameseWord.ReadOnly = true;
            txtVietnameseWord.Size = new Size(194, 27);
            txtVietnameseWord.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(279, 263);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblResuit
            // 
            lblResuit.AutoSize = true;
            lblResuit.Location = new Point(411, 200);
            lblResuit.Name = "lblResuit";
            lblResuit.Size = new Size(52, 20);
            lblResuit.TabIndex = 3;
            lblResuit.Text = "Resuit:";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(109, 263);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 4;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(471, 263);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 5;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // PracticeVocabulary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 450);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(lblResuit);
            Controls.Add(btnSubmit);
            Controls.Add(txtVietnameseWord);
            Controls.Add(txtEnglishWord);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PracticeVocabulary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PracticeVocabulary";
            Load += PracticeVocabulary_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEnglishWord;
        private TextBox txtVietnameseWord;
        private Button btnSubmit;
        private Label lblResuit;
        private Button btnPrevious;
        private Button btnNext;
    }
}