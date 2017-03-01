namespace _7820Q
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "75Hz 24bit Video mode",
            "75Hz 30bit Video mode",
            "60Hz 24bit Video mode",
            "60Hz 30bit Video mode",
            "Scaling -Video mode - 720P",
            "Scaling -Video mode -1080P",
            "Command mode",
            "DSC - 2slicex8 - Video mode",
            "DSC - 2slicex16 - Video mode",
            "DSC - 2slicex32 - Video mode",
            "DSC - 2slicex40 - Video mode",
            "DSC - 2slicex64 - Video mode",
            "DSC - 2slicex80 - Video mode",
            "DSC - 2slicex128 - Video mode",
            "DSC - 2slicex160 - Video mode",
            "DSC - 2slicex256 - Video mode",
            "DSC - 2slicex320 - Video mode",
            "DSC - 2slicex512 - Video mode",
            "DSC - 2slicex640 - Video mode",
            "DSC - 2slicex1280 - Video mode",
            "DSC - 1slicex8 - Video mode",
            "DSC - 1slicex16 - Video mode",
            "DSC - 1slicex32 - Video mode",
            "DSC - 1slicex40 - Video mode",
            "DSC - 1slicex64 - Video mode",
            "DSC - 1slicex80 - Video mode",
            "DSC - 1slicex128 - Video mode",
            "DSC - 1slicex160 - Video mode",
            "DSC - 1slicex256 - Video mode",
            "DSC - 1slicex320 - Video mode",
            "DSC - 1slicex512 - Video mode",
            "DSC - 1slicex640 - Video mode",
            "DSC - 1slicex1280 - Video mode",
            "DSC - 2slicex8 - command mode",
            "DSC - 2slicex16 - command mode",
            "DSC - 2slicex32 - command mode",
            "DSC - 2slicex40 - command mode",
            "DSC - 2slicex64 - command mode",
            "DSC - 2slicex80 - command mode",
            "DSC - 2slicex128 - command mode",
            "DSC - 2slicex160 - command mode",
            "DSC - 2slicex256 - command mode",
            "DSC - 2slicex320 - command mode",
            "DSC - 2slicex512 - command mode",
            "DSC - 2slicex640 - command mode",
            "DSC - 2slicex1280 - command mode",
            "DSC - 1slicex8 - command mode",
            "DSC - 1slicex16 - command mode",
            "DSC - 1slicex32 - command mode",
            "DSC - 1slicex40 - command mode",
            "DSC - 1slicex64 - command mode",
            "DSC - 1slicex80 - command mode",
            "DSC - 1slicex128 - command mode",
            "DSC - 1slicex160 - command mode",
            "DSC - 1slicex256 - command mode",
            "DSC - 1slicex320 - command mode",
            "DSC - 1slicex512 - command mode",
            "DSC - 1slicex640 - command mode",
            "DSC - 1slicex1280 - command mode",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(227, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(469, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 328);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Send Picture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 612);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

