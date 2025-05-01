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

        // NumberUpperCase ��k�����@�Ӧr��@���ѼơA
        // �æ^�ǸӦr�ꤤ�]�t���j�g�r���ƶq�C
        // �Ҧp�A�Y��J "Hello123"�A�h�^�ǭȬ� 1�C
        private int NumberUpperCase(string str)
        {
            int upperCaseCount = 0; // �p�ƾ��A��l�Ȭ� 0
            foreach (char c in str) 
            {
                if(char.IsUpper(c)) // �ˬd�r���O�_���j�g�r��
                {
                    upperCaseCount++; // �C���J��j�g�r���A�p�ƾ��[ 1
                }
                return upperCaseCount; // �^�Ǥj�g�r�����ƶq
            }
        

        // NumberLowerCase ��k�����@�Ӧr��@���ѼơA
        // �æ^�ǸӦr�ꤤ�]�t���p�g�r���ƶq�C
        // �Ҧp�A�Y��J "Hello123"�A�h�^�ǭȬ� 4�C
        private int NumberLowerCase(string str)
        {
            int lowerCaseCount = 0; // �p�ƾ��A��l�Ȭ� 0
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLower(str[i])) // �ˬd�r���O�_���p�g�r��
                {
                    lowerCaseCount++; // �C���J��p�g�r���A�p�ƾ��[ 1
                }
            }
            return lowerCaseCount; // �^�Ǥp�g�r�����ƶq
        }

        // NumberDigits ��k�����@�Ӧr��@���ѼơA
        // �æ^�ǸӦr�ꤤ�]�t���Ʀr�r���ƶq�C
        // �Ҧp�A�Y��J "Hello123"�A�h�^�ǭȬ� 3�C
        private int NumberDigits(string str)
        {
            int digits = 0;
            foreach(char c in str)
            {
                if (char.IsDigit(c)) // �ˬd�r���O�_���Ʀr
                {
                    digits++; // �C���J��Ʀr�A�p�ƾ��[ 1
                }
            }
            return digits; // �^�ǼƦr���ƶq
        }

        // ��ϥΪ̫��U "�ˬd�K�X" ���s�ɡAĲ�o���ƥ�B�z��k�C
        // ����k�����ˬd�ϥΪ̿�J���K�X�O�_�ŦX�S�w����A
        // �Ҧp�O�_�]�t�ܤ֤@�Ӥj�g�r���B�@�Ӥp�g�r���M�@�ӼƦr�A
        // �åB�K�X���׬O�_�ŦX�n�D�C
        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 8; // �K�X���̤p����
            string password = passwordTextBox.Text; // ���o�ϥΪ̿�J���K�X
            if(password.Length < MIN_LENGTH && 
                NumberUpperCase(password)>0&&
                NumberLowerCase(password) > 0 &&
                NumberDigits(password) > 0)
            {
                MessageBox.Show("�K�X����!","�K�X�ˬd���G",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("�K�X�L��!", "�K�X�ˬd���G", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // ��ϥΪ̫��U "�h�X" ���s�ɡAĲ�o���ƥ�B�z��k�C
        // ����k�|�����ثe�����A�������ε{���C
        private void exitButton_Click(object sender, EventArgs e)
        {
            // �������C
            this.Close();
        }
    }
}
