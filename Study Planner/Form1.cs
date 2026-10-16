using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Planner
{
    public partial class Form1 : Form
    {
        public Form1(List<Subject> subjects)
        {
            InitializeComponent();
            DisplaySubjectData(subjects);
        }
        private void DisplaySubjectData(List<Subject> subjects)
        {
            Button[] subjectButtons =
            { Subject1, Subject2, Subject3, Subject4 };

            for (int i = 0; i < subjectButtons.Length; i++)
            {
                subjectButtons[i].Enabled = i < subjects.Count;
                subjectButtons[i].Text = i < subjects.Count
                    ? subjects[i].subjectID + " " + subjects[i].subjectName
                    : "No subject";
            }
            S1BackButton.Text = "Back";
            if (subjects.Count == 0)
            {
                return;
            }
            Panel[] panels = new Panel[] { Subject1Panel, Subject2Panel, Subject3Panel, Subject4Panel };
            for (int i = 0; i < panels.Length; ++i)
            {
                Subject subject = subjects[i];
                Control.ControlCollection panelItems = panels[i].Controls;
                panelItems[1].Text = subject.subjectID + " " + subject.subjectName;
                panelItems[2].Text = subject.teachingSession + ", " + subject.subjectFaculty;
                FillGroupBox<Class>(subject.lectures, (GroupBox)panelItems[4]);
                FillGroupBox<Class>(subject.classes, (GroupBox)panelItems[5]);
                FillAssignmentList(new List<Subject>() { subject }, panels[i]);
            }
            FillAssignmentList(subjects, AssignmentPanel);
        }
        private void FillGroupBox<T>(List<T> classes, GroupBox box) where T : Class
        {
            ListView list = (ListView)box.Controls[0];
            foreach (T item in classes)
            {
                ListViewItem listItem = new ListViewItem(item.classType);
                listItem.Font = new Font(list.Font, listItem.Font.Style);
                listItem.SubItems.Add(item.startTime.ToString());
                listItem.SubItems.Add(item.duration);
                listItem.SubItems.Add(item.classDay);
                listItem.SubItems.Add(item.classLocation);
                listItem.SubItems.Add(item.weeksRunning);
                list.Items.Add(listItem);
            }
        }
        private void FillAssignmentButtons(List<Assignment> assignments, GroupBox box)
        {
            Button[] buttons = box.Controls
                .OfType<Button>()
                .OrderBy(button => button.Top)
                .ThenBy(button => button.Left)
                .ToArray();
            for (int i = 0; i < buttons.Length; i++)
            {
                Button button = buttons[i];

                button.Click -= AssignmentButton_Click;

                bool hasAssignment = i < assignments.Count;

                button.Visible = hasAssignment;
                button.Enabled = hasAssignment;
                button.Tag = hasAssignment ? assignments[i] : null;
                button.Text = hasAssignment
                    ? assignments[i].AssignmentInfo()
                    : "";

                if (hasAssignment)
                {
                    button.Click += AssignmentButton_Click;
                }
            }
        }
        private void FillAssignmentList(List<Subject> subjects, Panel panel)
        {
            ListView assList = (ListView)panel.Controls[1].Controls[0];
            foreach (Subject subject in subjects)
            {
                foreach (Assignment assignment in subject.assignments)
                {
                    ListViewItem listItem = new ListViewItem(subject.subjectID + " " + subject.subjectName);
                    listItem.Font = new Font(assList.Font, listItem.Font.Style);
                    listItem.SubItems.Add(assignment.assignmentType);
                    listItem.SubItems.Add(assignment.dueDate.ToString("dd/MM/yyyy"));
                    listItem.SubItems.Add(assignment.progress.ToString());
                    listItem.SubItems.Add(assignment.milestones.Count + " Milestones");
                    listItem.SubItems.Add(assignment.assignmentDescription);
                    listItem.Tag = assignment;
                    assList.Items.Add(listItem);
                }
            }
        }
        private void ChangePanel(Panel oldPanel, Panel newPanel)
        {
            oldPanel.Visible = false;
            newPanel.Visible = true;
        }

        private void HomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Subject1_Click(object sender, EventArgs e)
        {
            ChangePanel(HomePanel, Subject1Panel);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Subject2_Click(object sender, EventArgs e)
        {
            ChangePanel(HomePanel, Subject2Panel);
        }

        private void Subject3_Click(object sender, EventArgs e)
        {
            ChangePanel(HomePanel, Subject3Panel);
        }

        private void Subject4_Click(object sender, EventArgs e)
        {
            ChangePanel(HomePanel, Subject4Panel);
        }

        private void Subject1Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AssignmentButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
            {
                return;
            }

            Assignment assignment = button.Tag as Assignment;

            if (assignment == null)
            {
                return;
            }

            using (AssignmentDetailsForm details = new AssignmentDetailsForm(assignment))
            {
                details.ShowDialog(this);
            }

            button.Text = assignment.AssignmentInfo();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ChangePanel(Subject1Panel, HomePanel);
            HomePanel.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangePanel(AssignmentPanel, HomePanel);
            HomePanel.BringToFront();
        }

        private void AllAssignmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView list = (ListView)sender;
            if (list.SelectedItems.Count > 0)
            {
                LoadAssignment(list.SelectedItems[0], e);
            }
        }
        private void LoadAssignment(object sender, EventArgs e)
        {
            ListViewItem item = (ListViewItem)sender;
            Assignment assignment = (Assignment) item.Tag;
            AssignmentDetailsForm details = new AssignmentDetailsForm(assignment);
            details.ShowDialog(this);
        }

        private void AssignmentListButton_Click(object sender, EventArgs e)
        {
            ChangePanel(HomePanel, AssignmentPanel);
        }

        private void S1Assignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView list = (ListView)sender;
            if (list.SelectedItems.Count > 0)
            {
                LoadAssignment(list.SelectedItems[0], e);
            }
        }

        private void S4Back_Click(object sender, EventArgs e)
        {
            ChangePanel(Subject4Panel, HomePanel);
            HomePanel.BringToFront();
        }

        private void S3BackButton_Click(object sender, EventArgs e)
        {
            ChangePanel(Subject3Panel, HomePanel);
            HomePanel.BringToFront();
        }

        private void S2BackButton_Click(object sender, EventArgs e)
        {
            ChangePanel(Subject2Panel, HomePanel);
            HomePanel.BringToFront();
        }
    }
}
