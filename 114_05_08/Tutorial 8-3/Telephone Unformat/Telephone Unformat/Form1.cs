using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Unformat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // IsValidFormat 方法接受一個字串參數，並判斷該字串是否正確地格式化為
        // 台灣電話號碼的格式：(XX)XXXX-XXXX。
        // 如果字串符合此格式，則方法返回 true；否則返回 false。
        private bool IsValidFormat(string str)
        {
            if (str.Length == 13 && str[0] == '(' && str[3] == ')' && str[8] == '-')
            {
                string areaCode = str.Substring(1, 2);
                string firstPart = str.Substring(4, 4); // 修正為 4 位數
                string secondPart = str.Substring(9, 4);
                // 確保區域碼和號碼部分是否都是數字  
                if (IsAllDigits(areaCode) && IsAllDigits(firstPart) && IsAllDigits(secondPart))
                {
                    return true;
                }
            }
            return false;
        }
        // 修改 IsAllDigits 方法以接受多個字串參數
        private bool IsAllDigits(string str)
        {
            
                foreach (char c in str)
                {
                    if (!char.IsDigit(c))
                    {
                        return false;
                    }
                }
            
            return true;
        }

        // Unformat 方法接受一個字串參數（以引用方式傳遞），
        // 該字串假設包含格式化為 (XX)XXX-XXXX 的電話號碼。
        // 此方法會移除字串中的括號和連字符，將其轉換為未格式化的電話號碼。
        private void Unformat(ref string str)
        {
            // 使用 Remove 方法移除括號和連字符
            str = str.Remove(0, 1); // 移除第一個括號 '('
            str = str.Remove(2, 1); // 移除第二個括號 ')'
            str = str.Remove(6, 1); // 移除連字符 '-'
            //str = str.Replace("(", "").Replace(")", "").Replace("-", "");
        }

        // 當使用者按下「去格式化」按鈕時，會觸發此事件處理方法。
        // 此方法的具體邏輯尚未實作。
        private void unformatButton_Click(object sender, EventArgs e)
        {
            string input = numberTextBox.Text;

            if (IsValidFormat(input))
            {
                // 如果輸入的電話號碼格式正確，則調用 Unformat 方法進行去格式化。
                Unformat(ref input);
                MessageBox.Show("去格式化後的電話號碼為：" + input,"結果",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                // 如果輸入的電話號碼格式不正確，則顯示錯誤訊息。
                MessageBox.Show("請輸入正確格式的電話號碼","錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numberTextBox.Text = "string.Empty"; // 清空輸入框
                numberTextBox.Focus();
            }
        }

        // 當使用者按下「離開」按鈕時，會觸發此事件處理方法。
        // 此方法會關閉目前的表單。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
