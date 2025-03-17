using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageApplication
{
    public partial class TopicDetail : Form
    {
<<<<<<< HEAD
        public TopicDetail()
        {
            InitializeComponent();
        }

        private void btnViewVocabulary_Click(object sender, EventArgs e)
        {
            ViewVocabulary viewVocabulary = new ViewVocabulary();
=======
        private string idTopic = "";
        public TopicDetail()
        {
            InitializeComponent();
            
        }
        public TopicDetail(string idTopic)
        {
            InitializeComponent();
            this.idTopic = idTopic;
        }
        private void btnViewVocabulary_Click(object sender, EventArgs e)
        {
            ViewVocabulary viewVocabulary = new ViewVocabulary(idTopic);
>>>>>>> 88ccd62 (them,sua,xoa vocabulary,show vocabulary)
            viewVocabulary.Show();
        }

        private void btnPracticeVocabulary_Click(object sender, EventArgs e)
        {
            PracticeVocabulary practiceVocabulary = new PracticeVocabulary();
            practiceVocabulary.Show();
        }

        private void btnPracticePronunciation_Click(object sender, EventArgs e)
        {
            PracticePronunciation practicePronunciation = new PracticePronunciation();  
            practicePronunciation.Show();
        }
    }
}
