namespace Study_Planner
{
    partial class AssignmentDetailsForm
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
            this.AssignmentDate = new System.Windows.Forms.DateTimePicker();
            this.MilestoneNameBox = new System.Windows.Forms.TextBox();
            this.SaveAssignmentButton = new System.Windows.Forms.Button();
            this.MilestonesList = new System.Windows.Forms.CheckedListBox();
            this.AssignmentDescriptionBox = new System.Windows.Forms.TextBox();
            this.MilestoneDate = new System.Windows.Forms.DateTimePicker();
            this.MilestoneDescriptionBox = new System.Windows.Forms.TextBox();
            this.AddMilestoneButton = new System.Windows.Forms.Button();
            this.UpdateMilestoneButton = new System.Windows.Forms.Button();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.AssignmentProgress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.AssignmentTypeBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CancelAssignmentButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AssignmentDate
            // 
            this.AssignmentDate.CustomFormat = "dd/MM/yyyy";
            this.AssignmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AssignmentDate.Location = new System.Drawing.Point(301, 22);
            this.AssignmentDate.Name = "AssignmentDate";
            this.AssignmentDate.Size = new System.Drawing.Size(116, 23);
            this.AssignmentDate.TabIndex = 1;
            // 
            // MilestoneNameBox
            // 
            this.MilestoneNameBox.Location = new System.Drawing.Point(6, 43);
            this.MilestoneNameBox.Name = "MilestoneNameBox";
            this.MilestoneNameBox.Size = new System.Drawing.Size(100, 23);
            this.MilestoneNameBox.TabIndex = 2;
            // 
            // SaveAssignmentButton
            // 
            this.SaveAssignmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SaveAssignmentButton.Location = new System.Drawing.Point(195, 361);
            this.SaveAssignmentButton.Name = "SaveAssignmentButton";
            this.SaveAssignmentButton.Size = new System.Drawing.Size(160, 69);
            this.SaveAssignmentButton.TabIndex = 3;
            this.SaveAssignmentButton.Text = "Save Assignment";
            this.SaveAssignmentButton.UseVisualStyleBackColor = true;
            // 
            // MilestonesList
            // 
            this.MilestonesList.CheckOnClick = true;
            this.MilestonesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MilestonesList.FormattingEnabled = true;
            this.MilestonesList.Location = new System.Drawing.Point(39, 151);
            this.MilestonesList.Name = "MilestonesList";
            this.MilestonesList.Size = new System.Drawing.Size(180, 130);
            this.MilestonesList.TabIndex = 4;
            // 
            // AssignmentDescriptionBox
            // 
            this.AssignmentDescriptionBox.Location = new System.Drawing.Point(97, 49);
            this.AssignmentDescriptionBox.Multiline = true;
            this.AssignmentDescriptionBox.Name = "AssignmentDescriptionBox";
            this.AssignmentDescriptionBox.Size = new System.Drawing.Size(366, 52);
            this.AssignmentDescriptionBox.TabIndex = 5;
            // 
            // MilestoneDate
            // 
            this.MilestoneDate.CustomFormat = "dd/MM/yyyy";
            this.MilestoneDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MilestoneDate.Location = new System.Drawing.Point(6, 89);
            this.MilestoneDate.Name = "MilestoneDate";
            this.MilestoneDate.Size = new System.Drawing.Size(104, 23);
            this.MilestoneDate.TabIndex = 6;
            // 
            // MilestoneDescriptionBox
            // 
            this.MilestoneDescriptionBox.Location = new System.Drawing.Point(115, 43);
            this.MilestoneDescriptionBox.Multiline = true;
            this.MilestoneDescriptionBox.Name = "MilestoneDescriptionBox";
            this.MilestoneDescriptionBox.Size = new System.Drawing.Size(162, 69);
            this.MilestoneDescriptionBox.TabIndex = 7;
            // 
            // AddMilestoneButton
            // 
            this.AddMilestoneButton.Location = new System.Drawing.Point(9, 151);
            this.AddMilestoneButton.Name = "AddMilestoneButton";
            this.AddMilestoneButton.Size = new System.Drawing.Size(140, 25);
            this.AddMilestoneButton.TabIndex = 8;
            this.AddMilestoneButton.Text = "Add Milestone";
            this.AddMilestoneButton.UseVisualStyleBackColor = true;
            // 
            // UpdateMilestoneButton
            // 
            this.UpdateMilestoneButton.Location = new System.Drawing.Point(9, 118);
            this.UpdateMilestoneButton.Name = "UpdateMilestoneButton";
            this.UpdateMilestoneButton.Size = new System.Drawing.Size(140, 25);
            this.UpdateMilestoneButton.TabIndex = 9;
            this.UpdateMilestoneButton.Text = "Update Selected Milestone";
            this.UpdateMilestoneButton.UseVisualStyleBackColor = true;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ProgressLabel.Location = new System.Drawing.Point(26, 336);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(210, 17);
            this.ProgressLabel.TabIndex = 10;
            this.ProgressLabel.Text = "0% complete (0 of 0 milestones)";
            // 
            // AssignmentProgress
            // 
            this.AssignmentProgress.Location = new System.Drawing.Point(39, 296);
            this.AssignmentProgress.Name = "AssignmentProgress";
            this.AssignmentProgress.Size = new System.Drawing.Size(180, 37);
            this.AssignmentProgress.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Description";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MilestoneDescriptionBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MilestoneDate);
            this.groupBox1.Controls.Add(this.UpdateMilestoneButton);
            this.groupBox1.Controls.Add(this.MilestoneNameBox);
            this.groupBox1.Controls.Add(this.AddMilestoneButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(225, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 182);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Milestones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.SubjectLabel.Location = new System.Drawing.Point(34, 9);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(85, 26);
            this.SubjectLabel.TabIndex = 15;
            this.SubjectLabel.Text = "Subject";
            // 
            // AssignmentTypeBox
            // 
            this.AssignmentTypeBox.Location = new System.Drawing.Point(97, 23);
            this.AssignmentTypeBox.Name = "AssignmentTypeBox";
            this.AssignmentTypeBox.Size = new System.Drawing.Size(120, 23);
            this.AssignmentTypeBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.AssignmentTypeBox);
            this.groupBox2.Controls.Add(this.AssignmentDescriptionBox);
            this.groupBox2.Controls.Add(this.AssignmentDate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(39, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 107);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Assignment Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(8, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(47, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Date:";
            // 
            // CancelAssignmentButton
            // 
            this.CancelAssignmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CancelAssignmentButton.Location = new System.Drawing.Point(29, 361);
            this.CancelAssignmentButton.Name = "CancelAssignmentButton";
            this.CancelAssignmentButton.Size = new System.Drawing.Size(160, 69);
            this.CancelAssignmentButton.TabIndex = 17;
            this.CancelAssignmentButton.Text = "Cancel";
            this.CancelAssignmentButton.UseVisualStyleBackColor = true;
            // 
            // AssignmentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.CancelAssignmentButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AssignmentProgress);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.MilestonesList);
            this.Controls.Add(this.SaveAssignmentButton);
            this.Name = "AssignmentDetailsForm";
            this.Text = "Assignment Details";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker AssignmentDate;
        private System.Windows.Forms.TextBox MilestoneNameBox;
        private System.Windows.Forms.Button SaveAssignmentButton;
        private System.Windows.Forms.CheckedListBox MilestonesList;
        private System.Windows.Forms.TextBox AssignmentDescriptionBox;
        private System.Windows.Forms.DateTimePicker MilestoneDate;
        private System.Windows.Forms.TextBox MilestoneDescriptionBox;
        private System.Windows.Forms.Button AddMilestoneButton;
        private System.Windows.Forms.Button UpdateMilestoneButton;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.ProgressBar AssignmentProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.TextBox AssignmentTypeBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CancelAssignmentButton;
    }
}