namespace LanguageApplication
{
    partial class ViewVocabulary
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
            dgvVocabulary = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVocabulary).BeginInit();
            SuspendLayout();
            // 
            // dgvVocabulary
            // 
            dgvVocabulary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVocabulary.Location = new Point(100, 76);
            dgvVocabulary.Name = "dgvVocabulary";
            dgvVocabulary.RowHeadersWidth = 51;
            dgvVocabulary.Size = new Size(791, 411);
            dgvVocabulary.TabIndex = 0;
            dgvVocabulary.CellClick += dgvVocabulary_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 508);
            label1.Name = "label1";
            label1.Size = new Size(454, 20);
            label1.TabIndex = 1;
            label1.Text = "Bạn có thể thêm từ vựng bằng cách ấn vào dòng trống ở cuối bảng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 545);
            label2.Name = "label2";
            label2.Size = new Size(416, 20);
            label2.TabIndex = 2;
            label2.Text = "Bạn có thể chỉnh sửa, xóa từ vựn bằng cách bấm thẳng vào từ";
            // 
            // ViewVocabulary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 591);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvVocabulary);
            Name = "ViewVocabulary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewVocabulary";
            Load += ViewVocabulary_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVocabulary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVocabulary;
        private Label label1;
        private Label label2;
    }
}