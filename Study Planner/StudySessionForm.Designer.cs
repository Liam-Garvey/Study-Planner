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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NewStudySession = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MinutesDuration = new System.Windows.Forms.NumericUpDown();
            this.HoursDuration = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudyDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Study Session";
            // 
            // UpcomingStudySession
            // 
            this.UpcomingStudySession.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.UpcomingStudySession.Location = new System.Drawing.Point(18, 52);
            this.UpcomingStudySession.Name = "UpcomingStudySession";
            this.UpcomingStudySession.Size = new System.Drawing.Size(493, 184);
            this.UpcomingStudySession.TabIndex = 2;
            this.UpcomingStudySession.TabStop = false;
            this.UpcomingStudySession.Text = "Upcoming Sessions";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(529, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 354);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Study Log";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NewStudySession
            // 
            this.NewStudySession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NewStudySession.Location = new System.Drawing.Point(154, 154);
            this.NewStudySession.Name = "NewStudySession";
            this.NewStudySession.Size = new System.Drawing.Size(298, 31);
            this.NewStudySession.TabIndex = 4;
            this.NewStudySession.Text = "Add New Session";
            this.NewStudySession.UseVisualStyleBackColor = true;
            this.NewStudySession.Click += new System.EventHandler(this.NewStudySession_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.MinutesDuration);
            this.groupBox2.Controls.Add(this.HoursDuration);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtStudyDescription);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.NewStudySession);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox2.Location = new System.Drawing.Point(18, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 196);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create new study session";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(422, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(276, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "hr";
            // 
            // MinutesDuration
            // 
            this.MinutesDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MinutesDuration.Location = new System.Drawing.Point(303, 120);
            this.MinutesDuration.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinutesDuration.Name = "MinutesDuration";
            this.MinutesDuration.Size = new System.Drawing.Size(116, 23);
            this.MinutesDuration.TabIndex = 13;
            // 
            // HoursDuration
            // 
            this.HoursDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HoursDuration.Location = new System.Drawing.Point(154, 120);
            this.HoursDuration.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.HoursDuration.Name = "HoursDuration";
            this.HoursDuration.Size = new System.Drawing.Size(116, 23);
            this.HoursDuration.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(10, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Study Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(10, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Start Time";
            // 
            // txtStudyDescription
            // 
            this.txtStudyDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStudyDescription.Location = new System.Drawing.Point(154, 35);
            this.txtStudyDescription.Name = "txtStudyDescription";
            this.txtStudyDescription.Size = new System.Drawing.Size(298, 23);
            this.txtStudyDescription.TabIndex = 9;
            this.txtStudyDescription.TextChanged += new System.EventHandler(this.txtStudyDescription_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(10, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Task Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "hh:mm";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(154, 90);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(298, 23);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // StudySessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UpcomingStudySession);
            this.Controls.Add(this.label1);
            this.Name = "StudySessionForm";
            this.Text = "StudySessionForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox UpcomingStudySession;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NewStudySession;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudyDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown MinutesDuration;
        private System.Windows.Forms.NumericUpDown HoursDuration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}