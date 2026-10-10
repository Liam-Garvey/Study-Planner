namespace Study_Planner
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
            this.HomePanel = new System.Windows.Forms.Panel();
            this.subjectList = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Subject4 = new System.Windows.Forms.Button();
            this.Subject3 = new System.Windows.Forms.Button();
            this.Subject2 = new System.Windows.Forms.Button();
            this.Subject1 = new System.Windows.Forms.Button();
            this.Subject1Panel = new System.Windows.Forms.Panel();
            this.SubjectTitle = new System.Windows.Forms.Label();
            this.FacultySession = new System.Windows.Forms.Label();
            this.LectureList = new System.Windows.Forms.GroupBox();
            this.Lecture1 = new System.Windows.Forms.Label();
            this.ClassBox = new System.Windows.Forms.GroupBox();
            this.Assignments = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.HomePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Subject1Panel.SuspendLayout();
            this.LectureList.SuspendLayout();
            this.ClassBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.HomePanel.Controls.Add(this.subjectList);
            this.HomePanel.Controls.Add(this.groupBox1);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(800, 450);
            this.HomePanel.TabIndex = 0;
            this.HomePanel.UseWaitCursor = true;
            this.HomePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HomePanel_Paint);
            // 
            // subjectList
            // 
            this.subjectList.AutoSize = true;
            this.subjectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.subjectList.Location = new System.Drawing.Point(12, 28);
            this.subjectList.Name = "subjectList";
            this.subjectList.Size = new System.Drawing.Size(166, 26);
            this.subjectList.TabIndex = 2;
            this.subjectList.Text = "List of Subjects:";
            this.subjectList.UseWaitCursor = true;
            this.subjectList.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Subject4);
            this.groupBox1.Controls.Add(this.Subject3);
            this.groupBox1.Controls.Add(this.Subject2);
            this.groupBox1.Controls.Add(this.Subject1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.UseWaitCursor = true;
            // 
            // Subject4
            // 
            this.Subject4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Subject4.Location = new System.Drawing.Point(12, 339);
            this.Subject4.Name = "Subject4";
            this.Subject4.Size = new System.Drawing.Size(228, 87);
            this.Subject4.TabIndex = 5;
            this.Subject4.Text = "Subject 4";
            this.Subject4.UseVisualStyleBackColor = true;
            this.Subject4.UseWaitCursor = true;
            this.Subject4.Click += new System.EventHandler(this.Subject4_Click);
            // 
            // Subject3
            // 
            this.Subject3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Subject3.Location = new System.Drawing.Point(12, 246);
            this.Subject3.Name = "Subject3";
            this.Subject3.Size = new System.Drawing.Size(228, 87);
            this.Subject3.TabIndex = 4;
            this.Subject3.Text = "Subject 3";
            this.Subject3.UseVisualStyleBackColor = true;
            this.Subject3.UseWaitCursor = true;
            this.Subject3.Click += new System.EventHandler(this.Subject3_Click);
            // 
            // Subject2
            // 
            this.Subject2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Subject2.Location = new System.Drawing.Point(12, 155);
            this.Subject2.Name = "Subject2";
            this.Subject2.Size = new System.Drawing.Size(228, 87);
            this.Subject2.TabIndex = 3;
            this.Subject2.Text = "Subject 2";
            this.Subject2.UseVisualStyleBackColor = true;
            this.Subject2.UseWaitCursor = true;
            this.Subject2.Click += new System.EventHandler(this.Subject2_Click);
            // 
            // Subject1
            // 
            this.Subject1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Subject1.Location = new System.Drawing.Point(12, 61);
            this.Subject1.Name = "Subject1";
            this.Subject1.Size = new System.Drawing.Size(228, 88);
            this.Subject1.TabIndex = 0;
            this.Subject1.Text = "Subject 1";
            this.Subject1.UseVisualStyleBackColor = true;
            this.Subject1.UseWaitCursor = true;
            this.Subject1.Click += new System.EventHandler(this.Subject1_Click);
            // 
            // Subject1Panel
            // 
            this.Subject1Panel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Subject1Panel.Controls.Add(this.SubjectTitle);
            this.Subject1Panel.Controls.Add(this.FacultySession);
            this.Subject1Panel.Controls.Add(this.LectureList);
            this.Subject1Panel.Controls.Add(this.ClassBox);
            this.Subject1Panel.Controls.Add(this.Assignments);
            this.Subject1Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Subject1Panel.Location = new System.Drawing.Point(0, 0);
            this.Subject1Panel.Name = "Subject1Panel";
            this.Subject1Panel.Size = new System.Drawing.Size(800, 450);
            this.Subject1Panel.TabIndex = 6;
            this.Subject1Panel.Visible = false;
            this.Subject1Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Subject1Panel_Paint);
            // 
            // SubjectTitle
            // 
            this.SubjectTitle.AutoSize = true;
            this.SubjectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SubjectTitle.Location = new System.Drawing.Point(14, 16);
            this.SubjectTitle.Name = "SubjectTitle";
            this.SubjectTitle.Size = new System.Drawing.Size(242, 31);
            this.SubjectTitle.TabIndex = 0;
            this.SubjectTitle.Text = "Subject ID + Name";
            // 
            // FacultySession
            // 
            this.FacultySession.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.FacultySession.Location = new System.Drawing.Point(375, 16);
            this.FacultySession.Name = "FacultySession";
            this.FacultySession.Size = new System.Drawing.Size(403, 31);
            this.FacultySession.TabIndex = 12;
            this.FacultySession.Text = "Subject Session + Faculty";
            this.FacultySession.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LectureList
            // 
            this.LectureList.Controls.Add(this.label4);
            this.LectureList.Controls.Add(this.label3);
            this.LectureList.Controls.Add(this.label2);
            this.LectureList.Controls.Add(this.label1);
            this.LectureList.Controls.Add(this.Lecture1);
            this.LectureList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LectureList.Location = new System.Drawing.Point(12, 57);
            this.LectureList.Name = "LectureList";
            this.LectureList.Size = new System.Drawing.Size(228, 369);
            this.LectureList.TabIndex = 1;
            this.LectureList.TabStop = false;
            this.LectureList.Text = "Lectures";
            this.LectureList.UseCompatibleTextRendering = true;
            // 
            // Lecture1
            // 
            this.Lecture1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lecture1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lecture1.Location = new System.Drawing.Point(7, 301);
            this.Lecture1.Name = "Lecture1";
            this.Lecture1.Size = new System.Drawing.Size(215, 56);
            this.Lecture1.TabIndex = 6;
            this.Lecture1.Text = "Lecture1";
            // 
            // ClassBox
            // 
            this.ClassBox.Controls.Add(this.label5);
            this.ClassBox.Controls.Add(this.label6);
            this.ClassBox.Controls.Add(this.label7);
            this.ClassBox.Controls.Add(this.label8);
            this.ClassBox.Controls.Add(this.label9);
            this.ClassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ClassBox.Location = new System.Drawing.Point(282, 57);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(228, 369);
            this.ClassBox.TabIndex = 11;
            this.ClassBox.TabStop = false;
            this.ClassBox.Text = "Classes";
            this.ClassBox.UseCompatibleTextRendering = true;
            // 
            // Assignments
            // 
            this.Assignments.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Assignments.Location = new System.Drawing.Point(550, 67);
            this.Assignments.Name = "Assignments";
            this.Assignments.Size = new System.Drawing.Size(228, 359);
            this.Assignments.TabIndex = 13;
            this.Assignments.TabStop = false;
            this.Assignments.Text = "Assignments";
            this.Assignments.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(7, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 56);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(6, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 56);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 58);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 58);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 56);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(7, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 56);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(6, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 56);
            this.label7.TabIndex = 11;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(6, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 56);
            this.label8.TabIndex = 12;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(6, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 56);
            this.label9.TabIndex = 13;
            this.label9.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.Subject1Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.Subject1Panel.ResumeLayout(false);
            this.Subject1Panel.PerformLayout();
            this.LectureList.ResumeLayout(false);
            this.ClassBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Button Subject1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label subjectList;
        private System.Windows.Forms.Button Subject4;
        private System.Windows.Forms.Button Subject3;
        private System.Windows.Forms.Button Subject2;
        private System.Windows.Forms.Panel Subject1Panel;
        private System.Windows.Forms.Label SubjectTitle;
        private System.Windows.Forms.GroupBox LectureList;
        private System.Windows.Forms.Label Lecture1;
        private System.Windows.Forms.GroupBox ClassBox;
        private System.Windows.Forms.Label FacultySession;
        private System.Windows.Forms.GroupBox Assignments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

