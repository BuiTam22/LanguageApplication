using Oracle.ManagedDataAccess.Client;
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
    public partial class PracticeVocabulary : Form
    {
        OracleConnection conn;
        OracleDataAdapter da;
        OracleCommand cmd;
        DataTable dt;
        string sql = "";
        private string idTopic = "";
        private List<(string englishWord, string vietnameseWord)> vocabularyList = new List<(string, string)>();
        private int currentIndex = 0;
        private Random random = new Random();

        public PracticeVocabulary(string idTopic)
        {
            InitializeComponent();
            this.idTopic = idTopic;
        }

        private void PracticeVocabulary_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
            try
            {

                if (conn.State != ConnectionState.Open)
                    conn.Open();

                sql = "SELECT v.id, v.englishWord, v.vietnamWord " +
                "FROM Vocabulary v " +
                 "WHERE v.IDTOPIC = :idTopic";

                OracleDataAdapter da = new OracleDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add(new OracleParameter("idTopic", idTopic));
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    // Lưu dữ liệu vào danh sách
                    foreach (DataRow row in dt.Rows)
                    {
                        vocabularyList.Add((row["englishWord"].ToString(), row["vietnamWord"].ToString()));
                    }

                    // Xáo trộn thứ tự từ vựng
                    vocabularyList = vocabularyList.OrderBy(x => random.Next()).ToList();

                    // Hiển thị từ đầu tiên
                    DisplayNextWord();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }
        private void DisplayNextWord()
        {
            if (currentIndex < vocabularyList.Count)
            {
                txtVietnameseWord.Text = vocabularyList[currentIndex].vietnameseWord;
                txtEnglishWord.Clear();
                lblResuit.Text = "Result:";
            }
            else
            {
                MessageBox.Show("Hoàn thành bài tập!", "Thông báo");
                btnSubmit.Enabled = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (currentIndex < vocabularyList.Count)
            {
                string userAnswer = txtEnglishWord.Text.Trim().ToLower();
                string correctAnswer = vocabularyList[currentIndex].englishWord.ToLower();

                if (userAnswer == correctAnswer)
                {
                    lblResuit.Text = "✔ Correct!";
                    lblResuit.ForeColor = Color.Green;
                }
                else
                {
                    lblResuit.Text = $"✘ Incorrect! Correct: {vocabularyList[currentIndex].englishWord}";
                    lblResuit.ForeColor = Color.Red;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < vocabularyList.Count - 1)
            {
                currentIndex++;
                DisplayNextWord();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayNextWord();
            }
        }
    }
}
