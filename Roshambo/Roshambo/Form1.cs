using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Roshambo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showUserFigure(string figure)
        {
            pictureBoxRock.Visible = figure == "Rock";
            pictureBoxScissors.Visible = figure == "Scissors";
            pictureBoxPaper.Visible = figure == "Paper";
        }

        private void userPanel_MouseEnter(object sender, EventArgs e)
        {
            showUserFigure((((Panel)sender).Tag).ToString());
        }
    }
}
