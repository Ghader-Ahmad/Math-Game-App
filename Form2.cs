using Math_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game
{
    public partial class Form2 : Form
    {
        public static Form2 Instance;
        public Form2()
        {
            Instance = this;
            InitializeComponent();
        }

        enum enLevel {  Easy = 1, Meduim = 2, Hard = 3, Mix = 4 };
        enum enOperator { Add = 1, Subtract = 2, Multiply = 3, Divide = 4, Mix = 5 };

        struct stGameDetails
        {
            public short NumberOfRounds;
            public enLevel Level;
            public enOperator Operator;
            public short NumberOfCorrectAnswer;
            public short NumberOfWorngAnswer;
        }
        struct stRound
        {
            public int FirstNumber;
            public int SecondNumber;
            public enOperator Operator;
            public int CorrectAnswer;
            public int PlayerAnswer;
        }
    
        stRound Round;
        stGameDetails GameDetails;

        short Rounds = 0;
        static SByte Counter = 60; 

        Random randNumber = new Random();
        private int RandomNumber(int From, int To)
        {
            return randNumber.Next(From, To);
        }

        private void LoadDateFromFormOne()
        {
            lblLevel.Text = Form1.Instance.cobLevel.Text;
            lblOperator.Text = Form1.Instance.cobOperator.Text;
            lblRound.Text = Rounds.ToString() + "/" + Form1.Instance.nupRounds.Value.ToString();
        }

        private char ConvertEnumOperatorToChar(int Oprtator)
        {
            char[] arr= { ' ','+', '-', '*', '/' };
            return arr[Oprtator];
        }

        private void ShowQesation()
        {
            lblFirstNumber.Text = Round.FirstNumber.ToString();
            lblSecondNumber.Text = Round.SecondNumber.ToString();
            lblEqual.Text = "=";
            lblArthmeticProcess.Text = ConvertEnumOperatorToChar(Convert.ToInt32(Round.Operator)).ToString();
        }

        private void GenerateQuestion ()
        {
            if (GameDetails.Level == enLevel.Mix)
                GameDetails.Level = (enLevel)RandomNumber(1, 4);

            if (GameDetails.Operator == enOperator.Mix)
                GameDetails.Operator = (enOperator)RandomNumber(1, 5);

            Round.Operator = GameDetails.Operator;

            switch (GameDetails.Level)
            {
                case enLevel.Easy:
                    Round.FirstNumber = RandomNumber(1, 11);
                    Round.SecondNumber = RandomNumber(1, 11);
                    break;

                case enLevel.Meduim:
                    Round.FirstNumber = RandomNumber(11, 101);
                    Round.SecondNumber = RandomNumber(11, 101);
                    break;

                case enLevel.Hard:
                    Round.FirstNumber = RandomNumber(101, 500);
                    Round.SecondNumber = RandomNumber(101, 500);
                    break;
            }

            ShowQesation();
        }
 
        private void StopTimer()
        {
            timer1.Enabled = false;
            Counter = 60;
        
        }

        private void StartTimer()
        {
            timer1.Enabled = true;
            Counter = 60;
        }

        private void TheTimerHasRunOut()
        {
            Counter = 60;
            timer1.Enabled = false;
            GameDetails.NumberOfWorngAnswer++;
            btnCheckAnswer.Visible = false;
            btnNext.Visible = true;
            MessageBox.Show("The timer has run out!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void UpdateUserInterfaceAfterTheLess()
        {
            GameDetails.NumberOfWorngAnswer++;
            SystemSounds.Hand.Play();

            this.BackColor = Color.LightSalmon;

            lblRightAnswer.Text = Round.CorrectAnswer.ToString();
            lblPlayerAnswer.Text = txtAnswer.Text;

            txtAnswer.Text = "";
            pbPicture.Image = Resources.WorngAnswer;
        }

        private void UpdateUserInterfaceAfterTheProfit()
        {
            GameDetails.NumberOfCorrectAnswer++;

            this.BackColor = Color.LightGreen;

            lblRightAnswer.Text = Round.CorrectAnswer.ToString();
            lblPlayerAnswer.Text = txtAnswer.Text;

            txtAnswer.Text = "";
            pbPicture.Image = Resources.CorrectAnswer_;
        }

        private void UpdateButtonsAfterStartGame()
        {
            btnBack.Visible = true;
            btnReset.Visible = true;
            btnResult.Visible = true;
            btnCheckAnswer.Visible = true;
            txtAnswer.Visible = true;

            txtAnswer.Enabled = true;
            btnCheckAnswer.Enabled = true;
        }

        private void UpdateLabelsAfterShowQuestion()
        {
            lblPlayerAnswer.Text = "0";
            lblRightAnswer.Text = "0";

            txtAnswer.Focus();
            lblTime.Visible = true;
            lblTimer.Visible = true;
        }

        private void UpdateUserInterfaceAfterShowQuestion()
        {
            pbPicture.Image = Resources.thinking;
            this.BackColor = Color.White;

            lblRound.Text = Rounds.ToString() + "/" + GameDetails.NumberOfRounds.ToString();

            StartTimer();

            UpdateLabelsAfterShowQuestion();
            UpdateButtonsAfterStartGame();
        }




        private int GetRightQuestion()
        {
            switch (Round.Operator)
            {
                case enOperator.Add:
                    Round.CorrectAnswer = Round.FirstNumber + Round.SecondNumber;
                    return Round.CorrectAnswer;
                    
                case enOperator.Subtract:
                    Round.CorrectAnswer = Round.FirstNumber - Round.SecondNumber;
                    return Round.CorrectAnswer;
                    
                case enOperator.Multiply:
                    Round.CorrectAnswer = Round.FirstNumber * Round.SecondNumber;
                    return Round.CorrectAnswer;
                    
                case enOperator.Divide:
                    Round.CorrectAnswer = Round.FirstNumber / Round.SecondNumber;
                    return Round.CorrectAnswer;

                default:
                    Round.CorrectAnswer = Round.FirstNumber + Round.SecondNumber;
                    return Round.CorrectAnswer;
            }
        }

        private bool ValidationNumber(string Input)
        {
            int Number = 0;
            bool isValideNumber = int.TryParse(Input, out Number);

            return isValideNumber;
        }

        private bool ValidationTextBox()
        {
            if (string.IsNullOrEmpty(txtAnswer.Text) || !ValidationNumber(txtAnswer.Text))
                return false;

            else
                return true;
        }

        private void UpdateAfterClickCheckButton()
        {
            btnCheckAnswer.Visible = false;
            btnNext.Visible = true;
        }

        private void UpdateAfterClickNextButton()
        {
            btnCheckAnswer.Visible = true;
            btnNext.Visible = false;
        }

        private void CheckQuestion()
        {
            if (ValidationTextBox())
            {
                StopTimer();

                if (Convert.ToInt32(txtAnswer.Text) == GetRightQuestion())
                {
                    UpdateUserInterfaceAfterTheProfit();
                }
                else
                {
                    UpdateUserInterfaceAfterTheLess();
                }

                UpdateAfterClickCheckButton();
            }
            else
            {
                MessageBox.Show("Please enter a positive number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnswer.Text = "";
                txtAnswer.Focus();
            }
        }

        private void ReadGameDetails()
        {
            GameDetails.Level = (enLevel)Form1.Instance.cobLevel.Tag;
            GameDetails.Operator = (enOperator)Form1.Instance.cobOperator.Tag;
            GameDetails.NumberOfRounds = Convert.ToInt16(Form1.Instance.nupRounds.Value);
        }

        private void ShowNotifyIcon()
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Game Over";
            notifyIcon1.BalloonTipText = "Click here to show results";
            notifyIcon1.ShowBalloonTip(2000);
        }
        
        private void SaveTheResults()
        {
            lblPlayerAnswer.Tag = GameDetails.NumberOfCorrectAnswer;
            lblRightAnswer.Tag = GameDetails.NumberOfWorngAnswer;
        }
  

        private void StartGame()
        {
            ReadGameDetails();

            if (++Rounds <= GameDetails.NumberOfRounds)
            {
                UpdateUserInterfaceAfterShowQuestion();
                GenerateQuestion();
            }

            else
            {
                SaveTheResults();

              if (MessageBox.Show("The exam is over", "Game Over", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    MessageBox.Show("Click the results button to view them", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowNotifyIcon();
                }
            }
        }

        private bool IsTheExamFinished()
        {
            return (Rounds -1 == GameDetails.NumberOfRounds);
        }

        private void Back()
        {
            if(IsTheExamFinished())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Please complete the exam", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ResetLabelControl()
        {
            lblArthmeticProcess.Text = "";
            lblFirstNumber.Text = "";
            lblSecondNumber.Text = "";
            lblEqual.Text = "";

            lblTime.Visible = false;
            lblTimer.Visible = false;

            lblPlayerAnswer.Text = "0";
            lblRightAnswer.Text = "0";
        }

        private void ResetButtonControl()
        {
            btnStart.Visible = true;

            btnNext.Visible = false;
            btnBack.Visible = false;
            btnReset.Visible = false;
            btnResult.Visible = false;
            btnCheckAnswer.Visible = false;
            txtAnswer.Visible = false;

            txtAnswer.Enabled = false;
            btnCheckAnswer.Enabled = false;
        }

        private void ResetThisForm()
        {
            this.BackColor = Color.White;
            pbPicture.Image = Resources.Math;
        }

        private void Reset()
        {
            GameDetails = new stGameDetails();
            Round = new stRound();

            Rounds = 0;

            ResetLabelControl();
            ResetButtonControl();
            ResetThisForm();

            LoadDateFromFormOne();
        }

        private void RestartGame()
        {
            if (IsTheExamFinished())
            {
                Reset();
            }
            else
            {
                MessageBox.Show("Please complete the exam", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ShowResult()
        {
            this.Hide();

            Form3 frm = new Form3();
            frm.ShowDialog();

            this.Close();
        }

        private void ShowResultsScreen()
        {
            if (IsTheExamFinished())
            {
                ShowResult();
            }
            else
            {
                MessageBox.Show("Please complete the exam", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }






        private void btnResult_Click(object sender, EventArgs e)
        {
            ShowResultsScreen();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Start Exam", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                StartGame();
                btnStart.Visible = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            StartGame();
            UpdateAfterClickNextButton();
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            CheckQuestion();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadDateFromFormOne();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Counter > 0)
            {
                Counter--;
                lblTime.Text = Counter.ToString();
            }
            else
            {
                TheTimerHasRunOut();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            ShowResultsScreen();
        }
    }
}
