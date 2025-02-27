namespace Tutorial_4_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            distanceTextBox = new TextBox();
            gasTextBox = new TextBox();
            averageLabel = new Label();
            calculateButton = new Button();
            button1 = new Button();
            logListBox = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(194, 132);
            label1.Name = "label1";
            label1.Size = new Size(143, 24);
            label1.TabIndex = 0;
            label1.Text = "輸入行駛里程數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(194, 207);
            label2.Name = "label2";
            label2.Size = new Size(143, 24);
            label2.TabIndex = 1;
            label2.Text = "消耗油量公升數";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(213, 278);
            label3.Name = "label3";
            label3.Size = new Size(124, 24);
            label3.TabIndex = 2;
            label3.Text = "您的平均油耗";
            // 
            // distanceTextBox
            // 
            distanceTextBox.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            distanceTextBox.Location = new Point(400, 129);
            distanceTextBox.Name = "distanceTextBox";
            distanceTextBox.Size = new Size(152, 32);
            distanceTextBox.TabIndex = 3;
            // 
            // gasTextBox
            // 
            gasTextBox.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            gasTextBox.Location = new Point(400, 207);
            gasTextBox.Name = "gasTextBox";
            gasTextBox.Size = new Size(152, 32);
            gasTextBox.TabIndex = 4;
            // 
            // averageLabel
            // 
            averageLabel.BorderStyle = BorderStyle.Fixed3D;
            averageLabel.Location = new Point(400, 278);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new Size(152, 34);
            averageLabel.TabIndex = 5;
            averageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            calculateButton.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            calculateButton.Location = new Point(194, 344);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(124, 47);
            calculateButton.TabIndex = 6;
            calculateButton.Text = "計算";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(370, 344);
            button1.Name = "button1";
            button1.Size = new Size(124, 47);
            button1.TabIndex = 7;
            button1.Text = "離開";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // logListBox
            // 
            logListBox.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            logListBox.FormattingEnabled = true;
            logListBox.ItemHeight = 24;
            logListBox.Location = new Point(596, 129);
            logListBox.Name = "logListBox";
            logListBox.Size = new Size(192, 244);
            logListBox.TabIndex = 8;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button2.Location = new Point(628, 391);
            button2.Name = "button2";
            button2.Size = new Size(124, 47);
            button2.TabIndex = 9;
            button2.Text = "總平均油耗";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 552);
            Controls.Add(button2);
            Controls.Add(logListBox);
            Controls.Add(button1);
            Controls.Add(calculateButton);
            Controls.Add(averageLabel);
            Controls.Add(gasTextBox);
            Controls.Add(distanceTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox distanceTextBox;
        private TextBox gasTextBox;
        private Label averageLabel;
        private Button calculateButton;
        private Button button1;
        private ListBox logListBox;
        private Button button2;
    }
}
