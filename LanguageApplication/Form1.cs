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

        private void mntLogIn_Click(object sender, EventArgs e)
        {
            Login theLogIn = new Login(this);
            theLogIn.Show();

        }
    }
}
