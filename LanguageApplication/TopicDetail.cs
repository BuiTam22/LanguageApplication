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
        private string idTopic = "";
=======
<<<<<<< HEAD
>>>>>>> 7cbf72d50f91fba888ceb01791b71dda90268081
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
<<<<<<< HEAD
            ViewVocabulary viewVocabulary = new ViewVocabulary(idTopic);
=======
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
>>>>>>> 7cbf72d50f91fba888ceb01791b71dda90268081
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
