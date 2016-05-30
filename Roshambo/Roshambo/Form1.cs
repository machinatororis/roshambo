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
        string userFigure = "";
        string compFigure = "";
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void showUserFigure(string figure)
        {
            pictureBoxRockUser.Visible = figure == "Rock";
            pictureBoxScissorsUser.Visible = figure == "Scissors";
            pictureBoxPaperUser.Visible = figure == "Paper";
            userFigure = figure;
        }

        private void showCompFigure(string figure)
        {
            pictureBoxRockComp.Visible = figure == "Rock";
            pictureBoxScissorsComp.Visible = figure == "Scissors";
            pictureBoxPaperComp.Visible = figure == "Paper";
            compFigure = figure;

        }

        private void userPanel_MouseEnter(object sender, EventArgs e)
        {
            showUserFigure((((Panel)sender).Tag).ToString());
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            compRandomFigure();
        }

        private void compRandomFigure()
        {
            int figure = rand.Next(1, 4); // 1 - Rock, 2 - Scissors, 3 - Paper 

            if (figure == 1) showCompFigure("Rock");
            if (figure == 2) showCompFigure("Scissors");
            if (figure == 3) showCompFigure("Paper");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
