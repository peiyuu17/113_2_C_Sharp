using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetControlTextToTraditionalChinese(this);
        }
        private bool IsValidNumber(string str)
        {
            // 檢查輸入是否為 10 位數字
            const int VALID_LENGTH = 10;

            if (str.Length != VALID_LENGTH)
                return false;

            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }
        //telephoneFormat 方法接受一個字串參數
        // 並將其格式化為電話號碼的形式，例如:(12) 3456-7890
        private void TelephoneFormat(ref string str)
        {
            // 檢查字串長度是否為 10
            //if (str.Length == 10)
            //{
                // 格式化為 (123) 456-7890
              //  str = $"({str.Substring(0, 2)}) {str.Substring(2, 4)}-{str.Substring(6, 4)}";
            //}
            str=str.Insert(0, "(");//在字串的開頭插入 (
            str = str.Insert(3, ") ");//在字串的第 3 個位置插入 )和空格
            str = str.Insert(9, "-");//在字串的第 9 個位置插入 -
        }
        private void SetControlTextToTraditionalChinese(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                // 根據元件類型設定繁體中文的 Text 屬性
                if (!string.IsNullOrEmpty(control.Text))
                {
                    control.Text = ConvertToTraditionalChinese(control.Text);
                }

                // 如果該元件有子元件，遞迴處理
                if (control.HasChildren)
                {
                    SetControlTextToTraditionalChinese(control);
                }
            }
        }

        private string ConvertToTraditionalChinese(string text)
        {
            // 在這裡將文字轉換為繁體中文
            // 這裡假設你已經有繁體中文的對應翻譯
            // 以下為範例，請根據實際需求修改
            switch (text)
            {
                case "Hello": return "您好";
                case "Submit": return "提交";
                case "Cancel": return "取消";
                default: return text; // 如果沒有對應翻譯，保留原文字
            }
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            string input = numberTextBox.Text;

            if(IsValidNumber(input))
            {
                TelephoneFormat(ref input);
                
                MessageBox.Show(input, "格式化的結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("請輸入有效的 10 位數字。","錯誤", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
