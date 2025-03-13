namespace LanguageApplication
{
    partial class frmTrangChu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            mntLogIn = new ToolStripMenuItem();
            mntLogOut = new ToolStripMenuItem();
            mntOut = new ToolStripMenuItem();
            mntFeature = new ToolStripMenuItem();
            mntTopicStudied = new ToolStripMenuItem();
            thêmToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tàiKhoảnToolStripMenuItem, mntFeature, thêmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1094, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mntLogIn, mntLogOut, mntOut });
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(103, 29);
            tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // mntLogIn
            // 
            mntLogIn.Name = "mntLogIn";
            mntLogIn.Size = new Size(202, 34);
            mntLogIn.Text = "Đăng nhập";
            mntLogIn.Click += mntLogIn_Click;
            // 
            // mntLogOut
            // 
            mntLogOut.Name = "mntLogOut";
            mntLogOut.Size = new Size(202, 34);
            mntLogOut.Text = "Đăng xuất";
            mntLogOut.Click += mntLogOut_Click;
            // 
            // mntOut
            // 
            mntOut.Name = "mntOut";
            mntOut.Size = new Size(202, 34);
            mntOut.Text = "Thoát";
            mntOut.Click += mntOut_Click;
            // 
            // mntFeature
            // 
            mntFeature.DropDownItems.AddRange(new ToolStripItem[] { mntTopicStudied });
            mntFeature.Enabled = false;
            mntFeature.Name = "mntFeature";
            mntFeature.Size = new Size(113, 29);
            mntFeature.Text = "Chức năng";
            // 
            // mntTopicStudied
            // 
            mntTopicStudied.Name = "mntTopicStudied";
            mntTopicStudied.Size = new Size(214, 34);
            mntTopicStudied.Text = "Topic đã học";
            mntTopicStudied.Click += mntTopicStudied_Click;
            // 
            // thêmToolStripMenuItem
            // 
            thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            thêmToolStripMenuItem.Size = new Size(72, 29);
            thêmToolStripMenuItem.Text = "Thêm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(344, 166);
            label1.Name = "label1";
            label1.Size = new Size(385, 54);
            label1.TabIndex = 1;
            label1.Text = "Lady and gentlemen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(286, 284);
            label2.Name = "label2";
            label2.Size = new Size(537, 54);
            label2.TabIndex = 1;
            label2.Text = "Wecome to Group 4's Project";
            // 
            // frmTrangChu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(1094, 740);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmTrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem mntLogIn;
        private ToolStripMenuItem mntLogOut;
        private ToolStripMenuItem mntOut;
        private ToolStripMenuItem mntFeature;
        private ToolStripMenuItem thêmToolStripMenuItem;
        private ToolStripMenuItem mntTopicStudied;
        private Label label1;
        private Label label2;
    }
}
