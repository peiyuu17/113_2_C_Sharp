using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The NumberUpperCase method accepts a string argument
        // and returns the number of uppercase letters it contains.
        private int NumberUpperCase(string str)
        {
            int upperCaseCount = 0; // 計數器，初始值為 0
            foreach (char c in str)
            {
                if (char.IsUpper(c)) // 檢查字元是否為大寫字母
                {
                    upperCaseCount++; // 每次遇到大寫字母，計數器加 1
                }
                return upperCaseCount; // 回傳大寫字母的數量
            }
        }

        // The NumberLowerCase method accepts a string argument
        // and returns the number of lowercase letters it contains.
        private int NumberLowerCase(string str)
        {
            int lowerCaseCount = 0; // 計數器，初始值為 0
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLower(str[i])) // 檢查字元是否為小寫字母
                {
                    lowerCaseCount++; // 每次遇到小寫字母，計數器加 1
                }
            }
            return lowerCaseCount; // 回傳小寫字母的數量
        }

        // The NumberDigits method accepts a string argument
        // and returns the number of numeric digits it contains.
        private int NumberDigits(string str)
        {
            int digits = 0;
            foreach (char c in str)
            {
                if (char.IsDigit(c)) // 檢查字元是否為數字
                {
                    digits++; // 每次遇到數字，計數器加 1
                }
            }
            return digits; // 回傳數字的數量
        }

        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 8; // 密碼的最小長度
            string password = passwordTextBox.Text; // 取得使用者輸入的密碼
            if (password.Length < MIN_LENGTH &&
                NumberUpperCase(password) > 0 &&
                NumberLowerCase(password) > 0 &&
                NumberDigits(password) > 0)
            {
                MessageBox.Show("密碼有效!", "密碼檢查結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("密碼無效!", "密碼檢查結果", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
