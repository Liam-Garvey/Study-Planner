using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            BackButton.Text = "Back";
            if (subjects.Count == 0)
            {
                return;
            }
            Subject subject = subjects[0];
            SubjectTitle.Text = subject.subjectID + " " + subject.subjectName;
            FacultySession.Text = subject.teachingSession + " " + subject.subjectFaculty;
            FillGroupBox<Class>(subject.lectures, LectureList);
            FillGroupBox<Class>(subject.classes, ClassBox);
            FillAssignmentButtons(subject.assignments, Assignments);
            FillAssignmentList(subjects);
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
        private void FillAssignmentList(List<Subject> subjects)
        {
            ListView assList = (ListView)AssignmentPanel.Controls[0].Controls[0];
            foreach (Subject subject in subjects)
            {
                foreach (Assignment assignment in subject.assignments)
                {
                    ListViewItem listItem = new ListViewItem(assignment.assignmentType);
                    listItem.Font = new Font(assList.Font, listItem.Font.Style);
                    listItem.SubItems.Add(assignment.dueDate.ToString("dd/MM/yyyy"));
                    listItem.SubItems.Add(assignment.progress.ToString());
                    listItem.SubItems.Add(assignment.milestones.Count + " Milestones");
                    listItem.SubItems.Add(assignment.assignmentDescription);
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

        }

        private void Subject3_Click(object sender, EventArgs e)
        {

        }

        private void Subject4_Click(object sender, EventArgs e)
        {

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
    }
}
