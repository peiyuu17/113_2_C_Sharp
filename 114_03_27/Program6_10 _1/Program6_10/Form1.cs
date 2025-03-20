using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace Program6_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        string compChoice;
        int compScore, playerScore,tiescore;

        private void Form1_Load(object sender, EventArgs e)
        {
            getCompChoice();
        }

        private void getCompChoice()
        {
            int n = rand.Next(1, 4);
            switch (n) 
            {
                case 1:
                    compChoice = "Rock";
                    break;
                case 2:
                    compChoice = "Paper";
                    break;
                case 3:
                    compChoice = "Scissors";
                    break;
            }
        }

        private void showWinner(string myChoice)
            
        {
            string winner="";
            //winner = winnerDecide(myChoice);
            winnerDecide(myChoice, ref winner);
            label1.Text = "You chose " + myChoice + ". Computer chose " + compChoice + ". " + winner;
            
            if(winner == "You win!")
            {
                playerScore++;
            }
            else if (winner == "Computer wins!")
            {
                compScore++;
            }
            else
            {
                tiescore++;
            }
        }
        //private string winnerDecide(string myChoice)
       // {
        //   string winnerWho;
           // if (myChoice == compChoice)
           // {
              //  winnerWho = "It's a tie!";
           // }
            //else if (myChoice == "Rock" && compChoice == "Scissors")
           // winnerWho = "You win!";
           // else if (myChoice == "Paper" && compChoice == "Rock")
           // winnerWho = "You win!"
           //else if (myChoice == "Scissors" && compChoice == "Paper")
           // winnerWho = "You win!"
           // else
           //winnerWho = "Computer wins!";
           //return winnerWho;
        private void winnerDecide(string myChoice,ref string winner)
        {
            if (myChoice == compChoice)
            {
                winner = "It's a tie!";
            }
            else if (myChoice == "Rock" && compChoice == "Scissors")
                winner = "You win!";
            else if (myChoice == "Paper" && compChoice == "Rock")
                winner = "You win!";
            else if (myChoice == "Scissors" && compChoice == "Paper")
                winner = "You win!";
            else
                winner = "Computer wins!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myChoice = "Rock";
            showWinner(myChoice);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string myChoice = "Paper";
            showWinner(myChoice);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string myChoice = "Scissors";
            showWinner(myChoice);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getCompChoice();
            label1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Computer: " + compScore + " Player: " + playerScore +"Tie:"+tiescore);
            this.Close();
        }
    }
}
