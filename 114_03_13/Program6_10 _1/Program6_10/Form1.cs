﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        string compChoice,  winner;

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
            if(myChoice == compChoice)
            {
                winner = "It's a tie!";
            }
            else if (myChoice == "Rock" && compChoice == "Scissors")
            {
                winner = "You win!";
            }
            else if (myChoice == "Paper" && compChoice == "Rock")
            {
                winner = "You win!";
            }
            else if (myChoice == "Scissors" && compChoice == "Paper")
            {
                winner = "You win!";
            }
            else
            {
                winner = "Computer wins!";
            }
            label1.Text = "You chose " + myChoice + ". Computer chose " + compChoice + ". " + winner;
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


    }
}
