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
            this.AssignmentTypeBox = new System.Windows.Forms.TextBox();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AssignmentTypeBox
            // 
            this.AssignmentTypeBox.Location = new System.Drawing.Point(37, 28);
            this.AssignmentTypeBox.Name = "AssignmentTypeBox";
            this.AssignmentTypeBox.Size = new System.Drawing.Size(120, 20);
            this.AssignmentTypeBox.TabIndex = 0;
            // 
            // AssignmentDate
            // 
            this.AssignmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AssignmentDate.Location = new System.Drawing.Point(214, 28);
            this.AssignmentDate.Name = "AssignmentDate";
            this.AssignmentDate.Size = new System.Drawing.Size(200, 20);
            this.AssignmentDate.TabIndex = 1;
            // 
            // MilestoneNameBox
            // 
            this.MilestoneNameBox.Location = new System.Drawing.Point(6, 43);
            this.MilestoneNameBox.Name = "MilestoneNameBox";
            this.MilestoneNameBox.Size = new System.Drawing.Size(100, 20);
            this.MilestoneNameBox.TabIndex = 2;
            // 
            // SaveAssignmentButton
            // 
            this.SaveAssignmentButton.Location = new System.Drawing.Point(56, 297);
            this.SaveAssignmentButton.Name = "SaveAssignmentButton";
            this.SaveAssignmentButton.Size = new System.Drawing.Size(120, 47);
            this.SaveAssignmentButton.TabIndex = 3;
            this.SaveAssignmentButton.Text = "Save Assignment";
            this.SaveAssignmentButton.UseVisualStyleBackColor = true;
            // 
            // MilestonesList
            // 
            this.MilestonesList.CheckOnClick = true;
            this.MilestonesList.FormattingEnabled = true;
            this.MilestonesList.Location = new System.Drawing.Point(28, 91);
            this.MilestonesList.Name = "MilestonesList";
            this.MilestonesList.Size = new System.Drawing.Size(180, 139);
            this.MilestonesList.TabIndex = 4;
            // 
            // AssignmentDescriptionBox
            // 
            this.AssignmentDescriptionBox.Location = new System.Drawing.Point(37, 54);
            this.AssignmentDescriptionBox.Multiline = true;
            this.AssignmentDescriptionBox.Name = "AssignmentDescriptionBox";
            this.AssignmentDescriptionBox.Size = new System.Drawing.Size(120, 20);
            this.AssignmentDescriptionBox.TabIndex = 5;
            // 
            // MilestoneDate
            // 
            this.MilestoneDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MilestoneDate.Location = new System.Drawing.Point(9, 82);
            this.MilestoneDate.Name = "MilestoneDate";
            this.MilestoneDate.Size = new System.Drawing.Size(200, 20);
            this.MilestoneDate.TabIndex = 6;
            // 
            // MilestoneDescriptionBox
            // 
            this.MilestoneDescriptionBox.Location = new System.Drawing.Point(115, 43);
            this.MilestoneDescriptionBox.Multiline = true;
            this.MilestoneDescriptionBox.Name = "MilestoneDescriptionBox";
            this.MilestoneDescriptionBox.Size = new System.Drawing.Size(146, 20);
            this.MilestoneDescriptionBox.TabIndex = 7;
            // 
            // AddMilestoneButton
            // 
            this.AddMilestoneButton.Location = new System.Drawing.Point(9, 108);
            this.AddMilestoneButton.Name = "AddMilestoneButton";
            this.AddMilestoneButton.Size = new System.Drawing.Size(123, 24);
            this.AddMilestoneButton.TabIndex = 8;
            this.AddMilestoneButton.Text = "Add Milestone";
            this.AddMilestoneButton.UseVisualStyleBackColor = true;
            // 
            // UpdateMilestoneButton
            // 
            this.UpdateMilestoneButton.Location = new System.Drawing.Point(9, 138);
            this.UpdateMilestoneButton.Name = "UpdateMilestoneButton";
            this.UpdateMilestoneButton.Size = new System.Drawing.Size(146, 24);
            this.UpdateMilestoneButton.TabIndex = 9;
            this.UpdateMilestoneButton.Text = "Update Selected Milestone";
            this.UpdateMilestoneButton.UseVisualStyleBackColor = true;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(34, 267);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(155, 13);
            this.ProgressLabel.TabIndex = 10;
            this.ProgressLabel.Text = "0% complete (0 of 0 milestones)";
            // 
            // AssignmentProgress
            // 
            this.AssignmentProgress.Location = new System.Drawing.Point(37, 236);
            this.AssignmentProgress.Name = "AssignmentProgress";
            this.AssignmentProgress.Size = new System.Drawing.Size(171, 23);
            this.AssignmentProgress.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
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
            this.groupBox1.Location = new System.Drawing.Point(214, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 168);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Milestones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date";
            // 
            // AssignmentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AssignmentProgress);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.AssignmentDescriptionBox);
            this.Controls.Add(this.MilestonesList);
            this.Controls.Add(this.SaveAssignmentButton);
            this.Controls.Add(this.AssignmentDate);
            this.Controls.Add(this.AssignmentTypeBox);
            this.Name = "AssignmentDetailsForm";
            this.Text = "Assignment Details";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AssignmentTypeBox;
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
    }
}