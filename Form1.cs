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
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public Form1()
        {
            Instance = this;
            InitializeComponent();
        }

        private void ClosePlayerDatePanel()
        {
            pPlayerDate.Visible = false;
            cobLevel.Text = "Easy";
            cobOperator.Text = "Add";
            nupRounds.Value = 1;
        }

        private void UpdateValueTagInComboBoxLevel()
        {
            switch (cobLevel.SelectedIndex)
            {
                case 0:
                    cobLevel.Tag = 1;
                    break;

                case 1:
                    cobLevel.Tag = 2;
                    break;

                case 2:
                    cobLevel.Tag = 3;
                    break;

                default:
                    cobLevel.Tag = 4;
                    break;
            }
        }

        private void UpdateValueTagInComboBoxOperator()
        {
            switch (cobOperator.SelectedIndex)
            {
                case 0:
                    cobOperator.Tag = 1;
                    break;

                case 1:
                    cobOperator.Tag = 2;
                    break;

                case 2:
                    cobOperator.Tag = 3;
                    break;

                case 3:
                    cobOperator.Tag = 4;
                    break;

                default:
                    cobOperator.Tag = 5;
                    break;
            }
        }









        private void pbbtnClose_Click(object sender, EventArgs e)
        {
            ClosePlayerDatePanel();
        }

        private void btnStrat_Click(object sender, EventArgs e)
        {
            pPlayerDate.Visible = true;
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            this.Hide();

            frm.ShowDialog();

            this.Show();

        }

        private void cobLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateValueTagInComboBoxLevel();
        }

        private void cobOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateValueTagInComboBoxOperator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cobLevel.Tag = 1;
            cobOperator.Tag = 1;
        }
    }
}
