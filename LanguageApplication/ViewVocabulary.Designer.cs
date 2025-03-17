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
            dgvVocabulary = new DataGridView();
            label1 = new Label();
            txtSearch = new TextBox();
            btnsearch = new Button();
=======
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
>>>>>>> main
            ((System.ComponentModel.ISupportInitialize)dgvVocabulary).BeginInit();
            SuspendLayout();
            // 
            // dgvVocabulary
            // 
            dgvVocabulary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            dgvVocabulary.Location = new Point(34, 106);
=======
            dgvVocabulary.Location = new Point(32, 36);
>>>>>>> main
            dgvVocabulary.Name = "dgvVocabulary";
            dgvVocabulary.RowHeadersWidth = 51;
            dgvVocabulary.Size = new Size(791, 411);
            dgvVocabulary.TabIndex = 0;
            dgvVocabulary.CellClick += dgvVocabulary_CellClick;
<<<<<<< HEAD
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 44);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 1;
            label1.Text = "Tìm Kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(273, 47);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(247, 30);
            txtSearch.TabIndex = 2;
            // 
            // btnsearch
            // 
            btnsearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnsearch.Location = new Point(549, 43);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(98, 37);
            btnsearch.TabIndex = 3;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
=======
>>>>>>> 88ccd62 (them,sua,xoa vocabulary,show vocabulary)
>>>>>>> main
            // 
            // ViewVocabulary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 529);
<<<<<<< HEAD
            Controls.Add(btnsearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
=======
<<<<<<< HEAD
            Controls.Add(dataGridView1);
            Name = "ViewVocabulary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewVocabulary";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
=======
>>>>>>> main
            Controls.Add(dgvVocabulary);
            Name = "ViewVocabulary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewVocabulary";
            Load += ViewVocabulary_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVocabulary).EndInit();
<<<<<<< HEAD
            ResumeLayout(false);
            PerformLayout();
=======
>>>>>>> 88ccd62 (them,sua,xoa vocabulary,show vocabulary)
            ResumeLayout(false);
>>>>>>> main
        }

        #endregion

        private DataGridView dgvVocabulary;
<<<<<<< HEAD
        private Label label1;
        private TextBox txtSearch;
        private Button btnsearch;
=======
>>>>>>> main
    }
}