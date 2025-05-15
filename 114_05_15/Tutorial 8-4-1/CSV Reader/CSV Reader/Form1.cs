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

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;
                // 顯示檔案開啟對話方塊，讓使用者選擇要開啟的 CSV 檔案
                string line;
                int count = 0;
                int total = 0;
                double average;
                char[] delim = { ',',':'};
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    // 以唯讀方式開啟使用者所選擇的檔案，並建立 StreamReader 物件以便後續讀取檔案內容
                    inputFile = File.OpenText(openFile.FileName);

                    while(!inputFile.EndOfStream)
                    {
                        // 讀取檔案中的每一行，並將其存入 line 變數
                        line = inputFile.ReadLine();
                        line=line.Trim();//去除行首行尾的空白字元
                        string[] tokens=line.Split(delim);
                        total = 0;

                        for (int i = 1; i < tokens.Length; i++)
                        {
                            // 將每一行的分數轉換為整數，並累加到 total 變數中
                            total += int.Parse(tokens[i]);
                        }
                        average = (double)total / tokens.Length-1;
                        averagesListBox.Items.Add(tokens[0]+"的平均分數為：" + average.ToString("F2"));
                    }
                }
                else
                {
                    MessageBox.Show("未選擇任何檔案");
                }
            }
            catch (Exception ex)
            {
                // 若發生例外狀況（如檔案無法開啟或讀取），顯示錯誤訊息給使用者
                MessageBox.Show("錯誤： " + ex.Message, "檔案讀取錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的視窗，結束應用程式
            this.Close();
        }
    }
}
