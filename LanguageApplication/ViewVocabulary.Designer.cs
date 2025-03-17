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
<<<<<<< HEAD
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(79, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(714, 237);
            dataGridView1.TabIndex = 0;
=======
            dgvVocabulary = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVocabulary).BeginInit();
            SuspendLayout();
            // 
            // dgvVocabulary
            // 
            dgvVocabulary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVocabulary.Location = new Point(32, 36);
            dgvVocabulary.Name = "dgvVocabulary";
            dgvVocabulary.RowHeadersWidth = 51;
            dgvVocabulary.Size = new Size(791, 411);
            dgvVocabulary.TabIndex = 0;
            dgvVocabulary.CellClick += dgvVocabulary_CellClick;
>>>>>>> 88ccd62 (them,sua,xoa vocabulary,show vocabulary)
            // 
            // ViewVocabulary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 529);
<<<<<<< HEAD
            Controls.Add(dataGridView1);
            Name = "ViewVocabulary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewVocabulary";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
=======
            Controls.Add(dgvVocabulary);
            Name = "ViewVocabulary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewVocabulary";
            Load += ViewVocabulary_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVocabulary).EndInit();
>>>>>>> 88ccd62 (them,sua,xoa vocabulary,show vocabulary)
            ResumeLayout(false);
        }

        #endregion

<<<<<<< HEAD
        private DataGridView dataGridView1;
=======
        private DataGridView dgvVocabulary;
>>>>>>> 88ccd62 (them,sua,xoa vocabulary,show vocabulary)
    }
}