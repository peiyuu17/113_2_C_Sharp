namespace Tutorial_4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double distance, gas, average;

            if (double.TryParse(distanceTextBox.Text, out distance))
            {
                if (double.TryParse(gasTextBox.Text, out gas))
                {
                    average = distance / gas;
                    averageLabel.Text = average.ToString("f2") + "����/����";
                    logListBox.Items.Add(average.ToString("f2") + "����/����");
                }
                else
                {
                    MessageBox.Show("�o�ӽп�J�Ʀr");
                    gasTextBox.Focus();
                    gasTextBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("���{�п�J�Ʀr");
                distanceTextBox.Focus();
                distanceTextBox.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logListBox.Items.Clear();
            logListBox.Items.Add("�����o�Ӭ���:");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum = 0;
            if (logListBox.Items.Count>1)
            {
                
                for (int i = 1; i < logListBox.Items.Count; i++)
                {
                    sum += double.Parse(logListBox.Items[i].ToString().Replace("����/����", ""));
                }
                logListBox.Items.Add("�����o��:" + (sum / (logListBox.Items.Count - 1)).ToString("f2") + "����/����");
            }
            else
            {
                MessageBox.Show("�S������");
            }
        }
    }
}
