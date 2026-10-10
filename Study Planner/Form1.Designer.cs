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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Subject4 = new System.Windows.Forms.Button();
            this.Subject3 = new System.Windows.Forms.Button();
            this.Subject2 = new System.Windows.Forms.Button();
            this.subjectList = new System.Windows.Forms.Label();
            this.Subject1 = new System.Windows.Forms.Button();
            this.Subject1Panel = new System.Windows.Forms.Panel();
            this.FacultySession = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Class5 = new System.Windows.Forms.Label();
            this.Class4 = new System.Windows.Forms.Label();
            this.Class3 = new System.Windows.Forms.Label();
            this.Class2 = new System.Windows.Forms.Label();
            this.Class1 = new System.Windows.Forms.Label();
            this.Classes = new System.Windows.Forms.Label();
            this.LectureList = new System.Windows.Forms.GroupBox();
            this.Lecture5 = new System.Windows.Forms.Label();
            this.Lecture4 = new System.Windows.Forms.Label();
            this.Lecture3 = new System.Windows.Forms.Label();
            this.Lecture2 = new System.Windows.Forms.Label();
            this.Lecture1 = new System.Windows.Forms.Label();
            this.Lectures = new System.Windows.Forms.Label();
            this.SubjectTitle = new System.Windows.Forms.Label();
            this.HomePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Subject1Panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.LectureList.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.HomePanel.Controls.Add(this.groupBox1);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(800, 450);
            this.HomePanel.TabIndex = 0;
            this.HomePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HomePanel_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Subject4);
            this.groupBox1.Controls.Add(this.Subject3);
            this.groupBox1.Controls.Add(this.Subject2);
            this.groupBox1.Controls.Add(this.subjectList);
            this.groupBox1.Controls.Add(this.Subject1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 324);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Subject4
            // 
            this.Subject4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Subject4.Location = new System.Drawing.Point(12, 255);
            this.Subject4.Name = "Subject4";
            this.Subject4.Size = new System.Drawing.Size(217, 57);
            this.Subject4.TabIndex = 5;
            this.Subject4.Text = "Subject 4";
            this.Subject4.UseVisualStyleBackColor = true;
            this.Subject4.Click += new System.EventHandler(this.Subject4_Click);
            // 
            // Subject3
            // 
            this.Subject3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Subject3.Location = new System.Drawing.Point(13, 192);
            this.Subject3.Name = "Subject3";
            this.Subject3.Size = new System.Drawing.Size(217, 57);
            this.Subject3.TabIndex = 4;
            this.Subject3.Text = "Subject 3";
            this.Subject3.UseVisualStyleBackColor = true;
            this.Subject3.Click += new System.EventHandler(this.Subject3_Click);
            // 
            // Subject2
            // 
            this.Subject2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Subject2.Location = new System.Drawing.Point(13, 129);
            this.Subject2.Name = "Subject2";
            this.Subject2.Size = new System.Drawing.Size(217, 57);
            this.Subject2.TabIndex = 3;
            this.Subject2.Text = "Subject 2";
            this.Subject2.UseVisualStyleBackColor = true;
            this.Subject2.Click += new System.EventHandler(this.Subject2_Click);
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
            this.subjectList.Click += new System.EventHandler(this.label1_Click);
            // 
            // Subject1
            // 
            this.Subject1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Subject1.Location = new System.Drawing.Point(12, 67);
            this.Subject1.Name = "Subject1";
            this.Subject1.Size = new System.Drawing.Size(217, 57);
            this.Subject1.TabIndex = 0;
            this.Subject1.Text = "Subject 1";
            this.Subject1.UseVisualStyleBackColor = true;
            this.Subject1.Click += new System.EventHandler(this.Subject1_Click);
            // 
            // Subject1Panel
            // 
            this.Subject1Panel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Subject1Panel.Controls.Add(this.FacultySession);
            this.Subject1Panel.Controls.Add(this.groupBox2);
            this.Subject1Panel.Controls.Add(this.LectureList);
            this.Subject1Panel.Controls.Add(this.SubjectTitle);
            this.Subject1Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Subject1Panel.Location = new System.Drawing.Point(0, 0);
            this.Subject1Panel.Name = "Subject1Panel";
            this.Subject1Panel.Size = new System.Drawing.Size(800, 450);
            this.Subject1Panel.TabIndex = 6;
            this.Subject1Panel.Visible = false;
            this.Subject1Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Subject1Panel_Paint);
            // 
            // FacultySession
            // 
            this.FacultySession.AutoSize = true;
            this.FacultySession.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FacultySession.Location = new System.Drawing.Point(403, 19);
            this.FacultySession.Name = "FacultySession";
            this.FacultySession.Size = new System.Drawing.Size(328, 31);
            this.FacultySession.TabIndex = 12;
            this.FacultySession.Text = "Subject Session + Faculty";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Class5);
            this.groupBox2.Controls.Add(this.Class4);
            this.groupBox2.Controls.Add(this.Class3);
            this.groupBox2.Controls.Add(this.Class2);
            this.groupBox2.Controls.Add(this.Class1);
            this.groupBox2.Controls.Add(this.Classes);
            this.groupBox2.Location = new System.Drawing.Point(282, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 359);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // Class5
            // 
            this.Class5.AutoSize = true;
            this.Class5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Class5.Location = new System.Drawing.Point(7, 301);
            this.Class5.Name = "Class5";
            this.Class5.Size = new System.Drawing.Size(57, 20);
            this.Class5.TabIndex = 10;
            this.Class5.Text = "Class5";
            // 
            // Class4
            // 
            this.Class4.AutoSize = true;
            this.Class4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Class4.Location = new System.Drawing.Point(7, 248);
            this.Class4.Name = "Class4";
            this.Class4.Size = new System.Drawing.Size(57, 20);
            this.Class4.TabIndex = 9;
            this.Class4.Text = "Class4";
            // 
            // Class3
            // 
            this.Class3.AutoSize = true;
            this.Class3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Class3.Location = new System.Drawing.Point(7, 185);
            this.Class3.Name = "Class3";
            this.Class3.Size = new System.Drawing.Size(57, 20);
            this.Class3.TabIndex = 8;
            this.Class3.Text = "Class3";
            // 
            // Class2
            // 
            this.Class2.AutoSize = true;
            this.Class2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Class2.Location = new System.Drawing.Point(7, 125);
            this.Class2.Name = "Class2";
            this.Class2.Size = new System.Drawing.Size(57, 20);
            this.Class2.TabIndex = 7;
            this.Class2.Text = "Class2";
            // 
            // Class1
            // 
            this.Class1.AutoSize = true;
            this.Class1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Class1.Location = new System.Drawing.Point(7, 71);
            this.Class1.Name = "Class1";
            this.Class1.Size = new System.Drawing.Size(57, 20);
            this.Class1.TabIndex = 6;
            this.Class1.Text = "Class1";
            // 
            // Classes
            // 
            this.Classes.AutoSize = true;
            this.Classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Classes.Location = new System.Drawing.Point(6, 16);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(96, 26);
            this.Classes.TabIndex = 2;
            this.Classes.Text = "Classes:";
            // 
            // LectureList
            // 
            this.LectureList.Controls.Add(this.Lecture5);
            this.LectureList.Controls.Add(this.Lecture4);
            this.LectureList.Controls.Add(this.Lecture3);
            this.LectureList.Controls.Add(this.Lecture2);
            this.LectureList.Controls.Add(this.Lecture1);
            this.LectureList.Controls.Add(this.Lectures);
            this.LectureList.Location = new System.Drawing.Point(12, 67);
            this.LectureList.Name = "LectureList";
            this.LectureList.Size = new System.Drawing.Size(228, 359);
            this.LectureList.TabIndex = 1;
            this.LectureList.TabStop = false;
            this.LectureList.UseCompatibleTextRendering = true;
            // 
            // Lecture5
            // 
            this.Lecture5.AutoSize = true;
            this.Lecture5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lecture5.Location = new System.Drawing.Point(7, 301);
            this.Lecture5.Name = "Lecture5";
            this.Lecture5.Size = new System.Drawing.Size(72, 20);
            this.Lecture5.TabIndex = 10;
            this.Lecture5.Text = "Lecture5";
            // 
            // Lecture4
            // 
            this.Lecture4.AutoSize = true;
            this.Lecture4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lecture4.Location = new System.Drawing.Point(7, 248);
            this.Lecture4.Name = "Lecture4";
            this.Lecture4.Size = new System.Drawing.Size(72, 20);
            this.Lecture4.TabIndex = 9;
            this.Lecture4.Text = "Lecture4";
            // 
            // Lecture3
            // 
            this.Lecture3.AutoSize = true;
            this.Lecture3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lecture3.Location = new System.Drawing.Point(7, 185);
            this.Lecture3.Name = "Lecture3";
            this.Lecture3.Size = new System.Drawing.Size(72, 20);
            this.Lecture3.TabIndex = 8;
            this.Lecture3.Text = "Lecture3";
            // 
            // Lecture2
            // 
            this.Lecture2.AutoSize = true;
            this.Lecture2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lecture2.Location = new System.Drawing.Point(7, 125);
            this.Lecture2.Name = "Lecture2";
            this.Lecture2.Size = new System.Drawing.Size(72, 20);
            this.Lecture2.TabIndex = 7;
            this.Lecture2.Text = "Lecture2";
            // 
            // Lecture1
            // 
            this.Lecture1.AutoSize = true;
            this.Lecture1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lecture1.Location = new System.Drawing.Point(7, 71);
            this.Lecture1.Name = "Lecture1";
            this.Lecture1.Size = new System.Drawing.Size(72, 20);
            this.Lecture1.TabIndex = 6;
            this.Lecture1.Text = "Lecture1";
            // 
            // Lectures
            // 
            this.Lectures.AutoSize = true;
            this.Lectures.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Lectures.Location = new System.Drawing.Point(6, 16);
            this.Lectures.Name = "Lectures";
            this.Lectures.Size = new System.Drawing.Size(101, 26);
            this.Lectures.TabIndex = 2;
            this.Lectures.Text = "Lectures:";
            // 
            // SubjectTitle
            // 
            this.SubjectTitle.AutoSize = true;
            this.SubjectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.SubjectTitle.Location = new System.Drawing.Point(14, 16);
            this.SubjectTitle.Name = "SubjectTitle";
            this.SubjectTitle.Size = new System.Drawing.Size(286, 37);
            this.SubjectTitle.TabIndex = 0;
            this.SubjectTitle.Text = "Subject ID + Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Subject1Panel);
            this.Controls.Add(this.HomePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.HomePanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Subject1Panel.ResumeLayout(false);
            this.Subject1Panel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.LectureList.ResumeLayout(false);
            this.LectureList.PerformLayout();
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
        private System.Windows.Forms.Label Lectures;
        private System.Windows.Forms.Label Lecture5;
        private System.Windows.Forms.Label Lecture4;
        private System.Windows.Forms.Label Lecture3;
        private System.Windows.Forms.Label Lecture2;
        private System.Windows.Forms.Label Lecture1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Class5;
        private System.Windows.Forms.Label Class4;
        private System.Windows.Forms.Label Class3;
        private System.Windows.Forms.Label Class2;
        private System.Windows.Forms.Label Class1;
        private System.Windows.Forms.Label Classes;
        private System.Windows.Forms.Label FacultySession;
    }
}

