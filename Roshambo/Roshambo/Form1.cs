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

        int score_wins = 0;
        int score_lose = 0;
        int score_draw = 0;

        string mode = "show"; //show, game

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            showScore();
            setCompSpeed();
        }

        private void startGame()
        {
            if (mode != "game")
            {
                mode = "game";
                labelMessage.Text = "Choose your figure!";
            }
        }

        private void showUserFigure(string figure)
        {
            startGame();

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
            if (mode == "game")
                compRandomFigure();
        }

        private void compRandomFigure()
        {
            int figure = rand.Next(1, 4); // 1 - Rock, 2 - Scissors, 3 - Paper 

            if (figure == 1) showCompFigure("Rock");
            if (figure == 2) showCompFigure("Scissors");
            if (figure == 3) showCompFigure("Paper");
        }

        void showScore()
        {
            labelScore.Text =
                "Wins: " + score_wins.ToString() +
                "  Lose: " + score_lose.ToString() +
                "  Draw: " + score_draw.ToString();
        }

        private void pictureBoxUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (mode == "game")
                checkResult();
            else
                startGame();
        }

        private void checkResult()
        {
            mode = "show";
            int wins = 0;
            int lose = 0;
            int draw = 0;

            if (userFigure == compFigure)
                draw = 1;
            else
            {
                if (userFigure == "Rock")
                    if (compFigure == "Scissors")
                        wins = 1;
                    else
                        lose = 1;

                if (userFigure == "Scissors")
                    if (compFigure == "Paper")
                        wins = 1;
                    else
                        lose = 1;

                if (userFigure == "Paper")
                    if (compFigure == "Rock")
                        wins = 1;
                    else
                        lose = 1;
            }
            score_wins += wins;
            score_lose += lose;
            score_draw += draw;

            if (wins > 0)
                labelMessage.Text = "Win!";
            if (lose > 0)
                labelMessage.Text = "Lose :(";
            if (draw > 0)
                labelMessage.Text = "Draw. Try again";
            showScore();
        }

        private void setCompSpeed()
        {
            if (trackBarSpeed.Value == 1) timer.Interval = 400;
            if (trackBarSpeed.Value == 2) timer.Interval = 300;
            if (trackBarSpeed.Value == 3) timer.Interval = 200;
            if (trackBarSpeed.Value == 4) timer.Interval = 100;
            if (trackBarSpeed.Value == 5) timer.Interval = 50;
        }

        private void trackBarSpeed_ValueChanged(object sender, EventArgs e)
        {
            setCompSpeed();
        }
    }
}
