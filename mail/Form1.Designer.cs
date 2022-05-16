namespace mail
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_mailFrom = new System.Windows.Forms.TextBox();
            this.textBox_passwd = new System.Windows.Forms.TextBox();
            this.textBox_mailTo = new System.Windows.Forms.TextBox();
            this.textBox_Subject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_mailText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_read = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 599);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "SEND";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_mailFrom
            // 
            this.textBox_mailFrom.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox_mailFrom.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_mailFrom.Location = new System.Drawing.Point(366, 41);
            this.textBox_mailFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_mailFrom.Name = "textBox_mailFrom";
            this.textBox_mailFrom.Size = new System.Drawing.Size(440, 26);
            this.textBox_mailFrom.TabIndex = 1;
            // 
            // textBox_passwd
            // 
            this.textBox_passwd.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_passwd.Location = new System.Drawing.Point(366, 79);
            this.textBox_passwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_passwd.Name = "textBox_passwd";
            this.textBox_passwd.Size = new System.Drawing.Size(440, 26);
            this.textBox_passwd.TabIndex = 2;
            this.textBox_passwd.UseSystemPasswordChar = true;
            // 
            // textBox_mailTo
            // 
            this.textBox_mailTo.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_mailTo.Location = new System.Drawing.Point(366, 180);
            this.textBox_mailTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_mailTo.Name = "textBox_mailTo";
            this.textBox_mailTo.Size = new System.Drawing.Size(440, 26);
            this.textBox_mailTo.TabIndex = 3;
            // 
            // textBox_Subject
            // 
            this.textBox_Subject.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_Subject.Location = new System.Drawing.Point(366, 268);
            this.textBox_Subject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Subject.Name = "textBox_Subject";
            this.textBox_Subject.Size = new System.Drawing.Size(440, 26);
            this.textBox_Subject.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email From :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox_mailText
            // 
            this.richTextBox_mailText.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox_mailText.Location = new System.Drawing.Point(366, 332);
            this.richTextBox_mailText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox_mailText.Name = "richTextBox_mailText";
            this.richTextBox_mailText.Size = new System.Drawing.Size(440, 228);
            this.richTextBox_mailText.TabIndex = 7;
            this.richTextBox_mailText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email to :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Subject :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email text :";
            // 
            // button_read
            // 
            this.button_read.Location = new System.Drawing.Point(694, 599);
            this.button_read.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(112, 34);
            this.button_read.TabIndex = 13;
            this.button_read.Text = "Read Email";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email CC :";
            // 
            // textBoxCC
            // 
            this.textBoxCC.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxCC.Location = new System.Drawing.Point(366, 221);
            this.textBoxCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCC.Name = "textBoxCC";
            this.textBoxCC.Size = new System.Drawing.Size(440, 26);
            this.textBoxCC.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1120, 663);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCC);
            this.Controls.Add(this.button_read);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_mailText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Subject);
            this.Controls.Add(this.textBox_mailTo);
            this.Controls.Add(this.textBox_passwd);
            this.Controls.Add(this.textBox_mailFrom);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "E-mail Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_mailFrom;
        private System.Windows.Forms.TextBox textBox_passwd;
        private System.Windows.Forms.TextBox textBox_mailTo;
        private System.Windows.Forms.TextBox textBox_Subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_mailText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCC;
    }
}

