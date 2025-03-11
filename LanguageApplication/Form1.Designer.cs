namespace LanguageApplication
{
    partial class Form1
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
            thêmToolStripMenuItem = new ToolStripMenuItem();
            mntTopicStudied = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tàiKhoảnToolStripMenuItem, mntFeature, thêmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(766, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mntLogIn, mntLogOut, mntOut });
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(70, 20);
            tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // mntLogIn
            // 
            mntLogIn.Name = "mntLogIn";
            mntLogIn.Size = new Size(132, 22);
            mntLogIn.Text = "Đăng nhập";
            mntLogIn.Click += mntLogIn_Click;
            // 
            // mntLogOut
            // 
            mntLogOut.Name = "mntLogOut";
            mntLogOut.Size = new Size(132, 22);
            mntLogOut.Text = "Đăng xuất";
            // 
            // mntOut
            // 
            mntOut.Name = "mntOut";
            mntOut.Size = new Size(132, 22);
            mntOut.Text = "Thoát";
            // 
            // mntFeature
            // 
            mntFeature.DropDownItems.AddRange(new ToolStripItem[] { mntTopicStudied });
            mntFeature.Enabled = false;
            mntFeature.Name = "mntFeature";
            mntFeature.Size = new Size(77, 20);
            mntFeature.Text = "Chức năng";
            // 
            // thêmToolStripMenuItem
            // 
            thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            thêmToolStripMenuItem.Size = new Size(49, 20);
            thêmToolStripMenuItem.Text = "Thêm";
            // 
            // mntTopicStudied
            // 
            mntTopicStudied.Name = "mntTopicStudied";
            mntTopicStudied.Size = new Size(180, 22);
            mntTopicStudied.Text = "Topic đã học";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 444);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
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
    }
}
