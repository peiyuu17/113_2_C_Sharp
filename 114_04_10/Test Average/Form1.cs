using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Average ��k�����@�� int �}�C�Ѽ�
        // �ê�^�Ӱ}�C���Ȫ������ȡC
        private double Average(int[] scores)
        {
            int total = 0;
            foreach (int score in testscores)
            {
                total += score;
            }
            return (double)total / testscores.Length;
        }

        // Highest ��k�����@�� int �}�C�Ѽ�
        // �ê�^�Ӱ}�C�����̰��ȡC
        private int Highest(int[] scores)
        {
           int highest = scores[0];
            for (int i=1;i<scores.Length;i++)
            {
                if(scores[i] > highest)
                {
                    highest = scores[i];
                }
            }
            return highest;
        }

        // Lowest ��k�����@�� int �}�C�Ѽ�
        // �ê�^�Ӱ}�C�����̧C�ȡC
        private int Lowest(int[] scores)
        {
           int lowest = scores[0];
            foreach (int score in testscores)
            {
                if (score < lowest)
                {
                    lowest = score;
                }
            }
            return lowest;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            const int SIZE = 48;
            int[] testscores = new int[SIZE];
            int index = 0;
            int highestScore = 0;
            int lowestScore = 0;
            double averageScore = 0.0;
            StreamReader inputFile;
            try
            {
                if(OpenFlags.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(OpenFileDialog1.FileName);
                    while (!inputFile.EndOfStream && index < SIZE)
                    {
                        testscores[index] = Convert.ToInt32(inputFile.ReadLine());
                        index++;
                    }
                    inputFile.Close();
                }
                averageScore = Average(testscores);
                highestScore = Highest(testscores);
                lowestScore = Lowest(testscores);

                averageScoreLabel.Text = averageScore.ToString("n1");
                highScoreLabel.Text = highestScore.ToString();
                lowScoreLabel.Text =lowestScore.ToString();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error");
            }
                
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // �������C
            this.Close();
        }
    }
}
