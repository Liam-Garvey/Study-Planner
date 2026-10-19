namespace Study_Planner
{
    partial class StudySessionForm
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
            this.UpcomingStudySession = new System.Windows.Forms.GroupBox();
            this.ListStudySessions = new System.Windows.Forms.ListView();
            this.ColDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.testTxt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListStudyLog = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnNewStudySession = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudyDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpSessionDate = new System.Windows.Forms.DateTimePicker();
            this.BtnRemoveSession = new System.Windows.Forms.Button();
            this.BtnSessionCompleted = new System.Windows.Forms.Button();
            this.UpcomingStudySession.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Study Session";
            // 
            // UpcomingStudySession
            // 
            this.UpcomingStudySession.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpcomingStudySession.AutoSize = true;
            this.UpcomingStudySession.Controls.Add(this.ListStudySessions);
            this.UpcomingStudySession.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.UpcomingStudySession.Location = new System.Drawing.Point(12, 43);
            this.UpcomingStudySession.Name = "UpcomingStudySession";
            this.UpcomingStudySession.Padding = new System.Windows.Forms.Padding(5);
            this.UpcomingStudySession.Size = new System.Drawing.Size(776, 195);
            this.UpcomingStudySession.TabIndex = 2;
            this.UpcomingStudySession.TabStop = false;
            this.UpcomingStudySession.Text = "Upcoming Sessions";
            // 
            // ListStudySessions
            // 
            this.ListStudySessions.BackColor = System.Drawing.SystemColors.Window;
            this.ListStudySessions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColDescription,
            this.ColDate,
            this.ColStartTime,
            this.ColDuration});
            this.ListStudySessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListStudySessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ListStudySessions.FullRowSelect = true;
            this.ListStudySessions.HideSelection = false;
            this.ListStudySessions.Location = new System.Drawing.Point(5, 30);
            this.ListStudySessions.MultiSelect = false;
            this.ListStudySessions.Name = "ListStudySessions";
            this.ListStudySessions.Size = new System.Drawing.Size(766, 160);
            this.ListStudySessions.TabIndex = 0;
            this.ListStudySessions.UseCompatibleStateImageBehavior = false;
            this.ListStudySessions.View = System.Windows.Forms.View.Details;
            // 
            // ColDescription
            // 
            this.ColDescription.Text = "Description";
            this.ColDescription.Width = 80;
            // 
            // ColDate
            // 
            this.ColDate.Text = "Date";
            this.ColDate.Width = 41;
            // 
            // ColStartTime
            // 
            this.ColStartTime.Text = "Start Time";
            this.ColStartTime.Width = 73;
            // 
            // ColDuration
            // 
            this.ColDuration.Text = "Duration";
            this.ColDuration.Width = 568;
            // 
            // testTxt
            // 
            this.testTxt.AutoSize = true;
            this.testTxt.Location = new System.Drawing.Point(301, 24);
            this.testTxt.Name = "testTxt";
            this.testTxt.Size = new System.Drawing.Size(35, 13);
            this.testTxt.TabIndex = 16;
            this.testTxt.Text = "label8";
            this.testTxt.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.ListStudyLog);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(441, 244);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(347, 217);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Study Log";
            // 
            // ListStudyLog
            // 
            this.ListStudyLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader7});
            this.ListStudyLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListStudyLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ListStudyLog.HideSelection = false;
            this.ListStudyLog.Location = new System.Drawing.Point(5, 30);
            this.ListStudyLog.Name = "ListStudyLog";
            this.ListStudyLog.Size = new System.Drawing.Size(337, 182);
            this.ListStudyLog.TabIndex = 17;
            this.ListStudyLog.UseCompatibleStateImageBehavior = false;
            this.ListStudyLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Description";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Duration";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Date";
            this.columnHeader7.Width = 90;
            // 
            // BtnNewStudySession
            // 
            this.BtnNewStudySession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnNewStudySession.Location = new System.Drawing.Point(154, 154);
            this.BtnNewStudySession.Name = "BtnNewStudySession";
            this.BtnNewStudySession.Size = new System.Drawing.Size(227, 31);
            this.BtnNewStudySession.TabIndex = 4;
            this.BtnNewStudySession.Text = "Add New Session";
            this.BtnNewStudySession.UseVisualStyleBackColor = true;
            this.BtnNewStudySession.Click += new System.EventHandler(this.BtnNewStudySession_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numMinutes);
            this.groupBox2.Controls.Add(this.numHours);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtStudyDescription);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpStartTime);
            this.groupBox2.Controls.Add(this.dtpSessionDate);
            this.groupBox2.Controls.Add(this.BtnNewStudySession);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox2.Location = new System.Drawing.Point(12, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(421, 217);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create new study session";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(351, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(231, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "hr";
            // 
            // numMinutes
            // 
            this.numMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numMinutes.Location = new System.Drawing.Point(269, 127);
            this.numMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(76, 23);
            this.numMinutes.TabIndex = 13;
            // 
            // numHours
            // 
            this.numHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numHours.Location = new System.Drawing.Point(154, 126);
            this.numHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(71, 23);
            this.numHours.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(7, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Study Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Start Time";
            // 
            // txtStudyDescription
            // 
            this.txtStudyDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStudyDescription.Location = new System.Drawing.Point(154, 43);
            this.txtStudyDescription.Multiline = true;
            this.txtStudyDescription.Name = "txtStudyDescription";
            this.txtStudyDescription.Size = new System.Drawing.Size(227, 20);
            this.txtStudyDescription.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(7, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Task Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "hh:mm tt";
            this.dtpStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(154, 97);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(227, 23);
            this.dtpStartTime.TabIndex = 6;
            // 
            // dtpSessionDate
            // 
            this.dtpSessionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpSessionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSessionDate.Location = new System.Drawing.Point(154, 69);
            this.dtpSessionDate.Name = "dtpSessionDate";
            this.dtpSessionDate.Size = new System.Drawing.Size(227, 23);
            this.dtpSessionDate.TabIndex = 5;
            // 
            // BtnRemoveSession
            // 
            this.BtnRemoveSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemoveSession.BackColor = System.Drawing.Color.Firebrick;
            this.BtnRemoveSession.ForeColor = System.Drawing.SystemColors.Info;
            this.BtnRemoveSession.Location = new System.Drawing.Point(658, 24);
            this.BtnRemoveSession.Name = "BtnRemoveSession";
            this.BtnRemoveSession.Size = new System.Drawing.Size(110, 23);
            this.BtnRemoveSession.TabIndex = 17;
            this.BtnRemoveSession.Text = "Remove Session";
            this.BtnRemoveSession.UseVisualStyleBackColor = false;
            this.BtnRemoveSession.Click += new System.EventHandler(this.BtnRemoveSession_Click);
            // 
            // BtnSessionCompleted
            // 
            this.BtnSessionCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSessionCompleted.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnSessionCompleted.ForeColor = System.Drawing.Color.White;
            this.BtnSessionCompleted.Location = new System.Drawing.Point(528, 24);
            this.BtnSessionCompleted.Name = "BtnSessionCompleted";
            this.BtnSessionCompleted.Size = new System.Drawing.Size(111, 23);
            this.BtnSessionCompleted.TabIndex = 18;
            this.BtnSessionCompleted.Text = "Session Completed";
            this.BtnSessionCompleted.UseVisualStyleBackColor = false;
            this.BtnSessionCompleted.Click += new System.EventHandler(this.BtnSessionCompleted_Click);
            // 
            // StudySessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.BtnSessionCompleted);
            this.Controls.Add(this.BtnRemoveSession);
            this.Controls.Add(this.testTxt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UpcomingStudySession);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "StudySessionForm";
            this.Text = "StudySessionForm";
            this.UpcomingStudySession.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox UpcomingStudySession;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnNewStudySession;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpSessionDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudyDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label testTxt;
        private System.Windows.Forms.ListView ListStudySessions;
        private System.Windows.Forms.ColumnHeader ColDescription;
        private System.Windows.Forms.ColumnHeader ColDate;
        private System.Windows.Forms.ColumnHeader ColStartTime;
        private System.Windows.Forms.ColumnHeader ColDuration;
        private System.Windows.Forms.ListView ListStudyLog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button BtnRemoveSession;
        private System.Windows.Forms.Button BtnSessionCompleted;
    }
}