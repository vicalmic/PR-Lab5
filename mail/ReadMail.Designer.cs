namespace mail
{
    partial class ReadMail
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
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_passwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_retrieve = new System.Windows.Forms.Button();
            this.listViewMails = new System.Windows.Forms.ListView();
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mesage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(332, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox_email.Location = new System.Drawing.Point(435, 26);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(480, 26);
            this.textBox_email.TabIndex = 2;
            this.textBox_email.UseWaitCursor = true;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            this.textBox_email.Enter += new System.EventHandler(this.textBox_email_Enter);
            this.textBox_email.Leave += new System.EventHandler(this.textBox_email_TextChanged);
            this.textBox_email.MouseLeave += new System.EventHandler(this.textBox_email_MouseLeave);
            // 
            // textBox_passwd
            // 
            this.textBox_passwd.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_passwd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_passwd.Location = new System.Drawing.Point(435, 69);
            this.textBox_passwd.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_passwd.Name = "textBox_passwd";
            this.textBox_passwd.Size = new System.Drawing.Size(480, 26);
            this.textBox_passwd.TabIndex = 3;
            this.textBox_passwd.UseSystemPasswordChar = true;
            this.textBox_passwd.MouseEnter += new System.EventHandler(this.textBox_passwd_MouseEnter);
            this.textBox_passwd.MouseLeave += new System.EventHandler(this.textBox_passwd_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 253);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "messages";
            // 
            // button_retrieve
            // 
            this.button_retrieve.Location = new System.Drawing.Point(532, 747);
            this.button_retrieve.Margin = new System.Windows.Forms.Padding(4);
            this.button_retrieve.Name = "button_retrieve";
            this.button_retrieve.Size = new System.Drawing.Size(278, 34);
            this.button_retrieve.TabIndex = 10;
            this.button_retrieve.Text = "Retrieve data";
            this.button_retrieve.UseVisualStyleBackColor = true;
            this.button_retrieve.Click += new System.EventHandler(this.button_retrieve_Click);
            // 
            // listViewMails
            // 
            this.listViewMails.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listViewMails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.From,
            this.Date,
            this.Subject,
            this.Mesage});
            this.listViewMails.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listViewMails.HideSelection = false;
            this.listViewMails.Location = new System.Drawing.Point(18, 189);
            this.listViewMails.Margin = new System.Windows.Forms.Padding(4);
            this.listViewMails.Name = "listViewMails";
            this.listViewMails.Size = new System.Drawing.Size(1279, 499);
            this.listViewMails.TabIndex = 11;
            this.listViewMails.UseCompatibleStateImageBehavior = false;
            this.listViewMails.View = System.Windows.Forms.View.Details;
            this.listViewMails.SelectedIndexChanged += new System.EventHandler(this.listViewMails_SelectedIndexChanged);
            // 
            // From
            // 
            this.From.Text = "From";
            this.From.Width = 199;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 90;
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            this.Subject.Width = 250;
            // 
            // Mesage
            // 
            this.Mesage.Text = "Mesage";
            this.Mesage.Width = 734;
            // 
            // ReadMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1317, 798);
            this.Controls.Add(this.listViewMails);
            this.Controls.Add(this.button_retrieve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_passwd);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReadMail";
            this.Text = "ReadMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_passwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_retrieve;
        private System.Windows.Forms.ListView listViewMails;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader Mesage;
        public System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader Date;
    }
}