namespace library_management_system
{
    partial class issuebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(issuebook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exitbtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.searchstbtn = new System.Windows.Forms.Button();
            this.txtenrollment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtstname = new System.Windows.Forms.TextBox();
            this.txtdept = new System.Windows.Forms.TextBox();
            this.txtstsem = new System.Windows.Forms.TextBox();
            this.txtstcont = new System.Windows.Forms.TextBox();
            this.txtstemail = new System.Windows.Forms.TextBox();
            this.bookissuedate = new System.Windows.Forms.DateTimePicker();
            this.issuebookbtn = new System.Windows.Forms.Button();
            this.combobookbox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 451);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Issue Book";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(274, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.exitbtn);
            this.panel3.Controls.Add(this.refreshbtn);
            this.panel3.Controls.Add(this.searchstbtn);
            this.panel3.Controls.Add(this.txtenrollment);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(12, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 445);
            this.panel3.TabIndex = 1;
            // 
            // exitbtn
            // 
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitbtn.Location = new System.Drawing.Point(139, 308);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(122, 35);
            this.exitbtn.TabIndex = 5;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshbtn.Location = new System.Drawing.Point(17, 308);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(116, 35);
            this.refreshbtn.TabIndex = 4;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // searchstbtn
            // 
            this.searchstbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchstbtn.Location = new System.Drawing.Point(64, 220);
            this.searchstbtn.Name = "searchstbtn";
            this.searchstbtn.Size = new System.Drawing.Size(137, 42);
            this.searchstbtn.TabIndex = 3;
            this.searchstbtn.Text = "Search Student";
            this.searchstbtn.UseVisualStyleBackColor = true;
            this.searchstbtn.Click += new System.EventHandler(this.searchstbtn_Click);
            // 
            // txtenrollment
            // 
            this.txtenrollment.Location = new System.Drawing.Point(17, 174);
            this.txtenrollment.Name = "txtenrollment";
            this.txtenrollment.Size = new System.Drawing.Size(244, 26);
            this.txtenrollment.TabIndex = 2;
            this.txtenrollment.TextChanged += new System.EventHandler(this.txtenrollment_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Enrollment No";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(64, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Student Semester";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Student Contact";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Student Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Book Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Book Issue Date";
            // 
            // txtstname
            // 
            this.txtstname.Location = new System.Drawing.Point(445, 124);
            this.txtstname.Name = "txtstname";
            this.txtstname.ReadOnly = true;
            this.txtstname.Size = new System.Drawing.Size(274, 26);
            this.txtstname.TabIndex = 13;
            // 
            // txtdept
            // 
            this.txtdept.Location = new System.Drawing.Point(445, 163);
            this.txtdept.Name = "txtdept";
            this.txtdept.ReadOnly = true;
            this.txtdept.Size = new System.Drawing.Size(274, 26);
            this.txtdept.TabIndex = 14;
            // 
            // txtstsem
            // 
            this.txtstsem.Location = new System.Drawing.Point(445, 208);
            this.txtstsem.Name = "txtstsem";
            this.txtstsem.ReadOnly = true;
            this.txtstsem.Size = new System.Drawing.Size(274, 26);
            this.txtstsem.TabIndex = 15;
            // 
            // txtstcont
            // 
            this.txtstcont.Location = new System.Drawing.Point(445, 252);
            this.txtstcont.Name = "txtstcont";
            this.txtstcont.ReadOnly = true;
            this.txtstcont.Size = new System.Drawing.Size(274, 26);
            this.txtstcont.TabIndex = 16;
            // 
            // txtstemail
            // 
            this.txtstemail.Location = new System.Drawing.Point(445, 295);
            this.txtstemail.Name = "txtstemail";
            this.txtstemail.ReadOnly = true;
            this.txtstemail.Size = new System.Drawing.Size(274, 26);
            this.txtstemail.TabIndex = 17;
            // 
            // bookissuedate
            // 
            this.bookissuedate.Location = new System.Drawing.Point(445, 382);
            this.bookissuedate.Name = "bookissuedate";
            this.bookissuedate.Size = new System.Drawing.Size(274, 26);
            this.bookissuedate.TabIndex = 19;
            // 
            // issuebookbtn
            // 
            this.issuebookbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.issuebookbtn.Location = new System.Drawing.Point(539, 431);
            this.issuebookbtn.Name = "issuebookbtn";
            this.issuebookbtn.Size = new System.Drawing.Size(180, 50);
            this.issuebookbtn.TabIndex = 20;
            this.issuebookbtn.Text = "Issue Book";
            this.issuebookbtn.UseVisualStyleBackColor = true;
            this.issuebookbtn.Click += new System.EventHandler(this.issuebookbtn_Click);
            // 
            // combobookbox
            // 
            this.combobookbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobookbox.FormattingEnabled = true;
            this.combobookbox.Location = new System.Drawing.Point(445, 334);
            this.combobookbox.Name = "combobookbox";
            this.combobookbox.Size = new System.Drawing.Size(274, 28);
            this.combobookbox.TabIndex = 22;
            this.combobookbox.SelectedIndexChanged += new System.EventHandler(this.combobookbox_SelectedIndexChanged);
            // 
            // issuebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.combobookbox);
            this.Controls.Add(this.issuebookbtn);
            this.Controls.Add(this.bookissuedate);
            this.Controls.Add(this.txtstemail);
            this.Controls.Add(this.txtstcont);
            this.Controls.Add(this.txtstsem);
            this.Controls.Add(this.txtdept);
            this.Controls.Add(this.txtstname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "issuebook";
            this.Text = "issuebook";
            this.Load += new System.EventHandler(this.issuebook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Button searchstbtn;
        private System.Windows.Forms.TextBox txtenrollment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtstname;
        private System.Windows.Forms.TextBox txtdept;
        private System.Windows.Forms.TextBox txtstsem;
        private System.Windows.Forms.TextBox txtstcont;
        private System.Windows.Forms.TextBox txtstemail;
        private System.Windows.Forms.DateTimePicker bookissuedate;
        private System.Windows.Forms.Button issuebookbtn;
        private System.Windows.Forms.ComboBox combobookbox;
    }
}