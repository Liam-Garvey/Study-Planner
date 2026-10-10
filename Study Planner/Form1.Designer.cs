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
            this.HomePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.Subject1Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Subject1Panel.Location = new System.Drawing.Point(0, 0);
            this.Subject1Panel.Name = "Subject1Panel";
            this.Subject1Panel.Size = new System.Drawing.Size(800, 450);
            this.Subject1Panel.TabIndex = 6;
            this.Subject1Panel.Visible = false;
            this.Subject1Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Subject1Panel_Paint);
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
    }
}

