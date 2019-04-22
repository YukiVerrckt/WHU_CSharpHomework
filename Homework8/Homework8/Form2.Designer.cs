namespace Homework8
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_orderId = new System.Windows.Forms.TextBox();
            this.textBox_clientId = new System.Windows.Forms.TextBox();
            this.textBox_clientName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "客户编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "客户名";
            // 
            // textBox_orderId
            // 
            this.textBox_orderId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_orderId.Location = new System.Drawing.Point(134, 63);
            this.textBox_orderId.MaxLength = 11;
            this.textBox_orderId.Name = "textBox_orderId";
            this.textBox_orderId.Size = new System.Drawing.Size(100, 21);
            this.textBox_orderId.TabIndex = 3;
            this.textBox_orderId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_orderId_KeyPress);
            // 
            // textBox_clientId
            // 
            this.textBox_clientId.Location = new System.Drawing.Point(134, 105);
            this.textBox_clientId.Name = "textBox_clientId";
            this.textBox_clientId.Size = new System.Drawing.Size(100, 21);
            this.textBox_clientId.TabIndex = 4;
            this.textBox_clientId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_clientId_KeyPress);
            // 
            // textBox_clientName
            // 
            this.textBox_clientName.Location = new System.Drawing.Point(134, 145);
            this.textBox_clientName.Name = "textBox_clientName";
            this.textBox_clientName.Size = new System.Drawing.Size(100, 21);
            this.textBox_clientName.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_clientName);
            this.Controls.Add(this.textBox_clientId);
            this.Controls.Add(this.textBox_orderId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_orderId;
        private System.Windows.Forms.TextBox textBox_clientId;
        private System.Windows.Forms.TextBox textBox_clientName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}