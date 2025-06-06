using Math_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        struct stGameResults
        {
            public short NumberOfRounds;
            public string Level;
            public string Operator;
            public short NumberOfCorrectAnswer;
            public short NumberOfWorngAnswer;
            public short FinalResults;
        }

        stGameResults GameResults;

        private void ReadGameResults()
        {
            GameResults.Level = Form1.Instance.cobLevel.Text;
            GameResults.Operator = Form1.Instance.cobOperator.Text;
            GameResults.NumberOfRounds = Convert.ToInt16(Form1.Instance.nupRounds.Value.ToString());
            GameResults.NumberOfCorrectAnswer = Convert.ToInt16(Form2.Instance.lblPlayerAnswer.Tag.ToString());
            GameResults.NumberOfWorngAnswer = Convert.ToInt16(Form2.Instance.lblRightAnswer.Tag.ToString());
            GameResults.FinalResults = Convert.ToInt16(CalculateFinalResults());
        }

        private void SetImage(PictureBox pictureBox)
        {
            if (pictureBox.Tag.ToString() == "1")
            {
                pictureBox.Image = Resources.fireworks;
               
                pictureBox.Tag = "0";
            }
            else
            {
                pictureBox.Image = Resources.fireworks2;
              
                pictureBox.Tag = "1";
            }
        }

        private float CalculateFinalResults()
        {
            return (((float)GameResults.NumberOfCorrectAnswer / GameResults.NumberOfRounds) * 100);
        }

        private string ResultToText(float FinalResult)
        {
            if (FinalResult <= 100 && FinalResult >= 90)
                return "Excellent";

            else if (FinalResult <= 89 && FinalResult >= 80)
                return "Very Good";

            else if (FinalResult <= 79 && FinalResult >= 70)
                return "Good";

            else if (FinalResult <= 69 && FinalResult >= 60)
                return "Acceptable";

            else if (FinalResult <= 59 && FinalResult >= 50)
                return "Weak";

            else
                return "Fail";
        }

        private void UpdateUserInterfaceAfterLoadThisForm()
        {
            lblRounds.Text = GameResults.NumberOfRounds.ToString();
            lblLevel.Text = GameResults.Level;
            lblOperator.Text = GameResults.Operator;

            lblNumberOfQuestions.Text = GameResults.NumberOfRounds.ToString();
            lblNumberOfCorrectAnswer.Text = GameResults.NumberOfCorrectAnswer.ToString();
            lblNumberOfWrongAnswer.Text = GameResults.NumberOfWorngAnswer.ToString();

            lblFinalResult.Text = GameResults.FinalResults.ToString() + "% - " + ResultToText(GameResults.FinalResults);
        }

        private void LoadResultsInThisForm()
        {
            ReadGameResults();
            UpdateUserInterfaceAfterLoadThisForm();
        }




        private void Form3_Load(object sender, EventArgs e)
        {
            LoadResultsInThisForm();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetImage(pictureBox1);
            SetImage(pictureBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
