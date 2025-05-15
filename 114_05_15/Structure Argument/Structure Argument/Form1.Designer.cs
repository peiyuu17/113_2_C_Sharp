namespace Structure_Argument
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應釋放受控資源則為 true，否則為 false。</param>
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
        /// 設計工具所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.auto1Button = new System.Windows.Forms.Button();
            this.auto2Button = new System.Windows.Forms.Button();
            this.auto3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // auto1Button
            // 
            this.auto1Button.Location = new System.Drawing.Point(24, 20);
            this.auto1Button.Name = "auto1Button";
            this.auto1Button.Size = new System.Drawing.Size(75, 36);
            this.auto1Button.TabIndex = 0;
            this.auto1Button.Text = "顯示汽車 #1";
            this.auto1Button.UseVisualStyleBackColor = true;
            this.auto1Button.Click += new System.EventHandler(this.auto1Button_Click);
            // 
            // auto2Button
            // 
            this.auto2Button.Location = new System.Drawing.Point(105, 20);
            this.auto2Button.Name = "auto2Button";
            this.auto2Button.Size = new System.Drawing.Size(75, 36);
            this.auto2Button.TabIndex = 1;
            this.auto2Button.Text = "顯示汽車 #2";
            this.auto2Button.UseVisualStyleBackColor = true;
            this.auto2Button.Click += new System.EventHandler(this.auto2Button_Click);
            // 
            // auto3Button
            // 
            this.auto3Button.Location = new System.Drawing.Point(186, 20);
            this.auto3Button.Name = "auto3Button";
            this.auto3Button.Size = new System.Drawing.Size(75, 36);
            this.auto3Button.TabIndex = 2;
            this.auto3Button.Text = "顯示汽車 #3";
            this.auto3Button.UseVisualStyleBackColor = true;
            this.auto3Button.Click += new System.EventHandler(this.auto3Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 77);
            this.Controls.Add(this.auto3Button);
            this.Controls.Add(this.auto2Button);
            this.Controls.Add(this.auto1Button);
            this.Name = "Form1";
            this.Text = "結構參數範例";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button auto1Button;
        private System.Windows.Forms.Button auto2Button;
        private System.Windows.Forms.Button auto3Button;
    }
}

