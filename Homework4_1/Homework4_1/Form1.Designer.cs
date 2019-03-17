namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.alarmHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.alarmMinute = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alarmHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(47, 39);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(41, 12);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // alarmHour
            // 
            this.alarmHour.Location = new System.Drawing.Point(46, 108);
            this.alarmHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.alarmHour.Name = "alarmHour";
            this.alarmHour.Size = new System.Drawing.Size(41, 21);
            this.alarmHour.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "时";
            // 
            // alarmMinute
            // 
            this.alarmMinute.Location = new System.Drawing.Point(162, 108);
            this.alarmMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.alarmMinute.Name = "alarmMinute";
            this.alarmMinute.Size = new System.Drawing.Size(44, 21);
            this.alarmMinute.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "分";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "设置闹钟";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alarmMinute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alarmHour);
            this.Controls.Add(this.timeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.alarmHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown alarmHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown alarmMinute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

