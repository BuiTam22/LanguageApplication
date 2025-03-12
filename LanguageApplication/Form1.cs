namespace LanguageApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Login theLogIn = new Login();
            //theLogIn.Show();
        }

        public void setMntFeatureEnableTrue()
        {
            this.mntFeature.Enabled = true;
        }

        public void openLogInForm()
        {
            Login theLogIn = new Login(this);
            theLogIn.Show();
        }

        private void mntLogIn_Click(object sender, EventArgs e)
        {
            openLogInForm();

        }

        private void mntLogOut_Click(object sender, EventArgs e)
        {
            // dang xuat thi phan chuc nang se bi tat
            this.mntFeature.Enabled = false;
            openLogInForm();
        }

        private void mntOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mntTopicStudied_Click(object sender, EventArgs e)
        {
            TopicDaHoc theTopicDaHoc = new TopicDaHoc();
            theTopicDaHoc.Show();
          
        }
    }
}
