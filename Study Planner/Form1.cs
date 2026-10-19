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
        private readonly List<Subject> subjects;
        private bool refreshingAssignments;

        public Form1(List<Subject> subjects)
        {
            InitializeComponent();

            AllAssignmentList.SelectedIndexChanged -= AllAssignmentList_SelectedIndexChanged;
            S1Assignment.SelectedIndexChanged -= S1Assignment_SelectedIndexChanged;
            //All lists of assignments across different panels
            ListView[] assignmentLists =
            {
            AllAssignmentList,
            S1Assignment,
            S2Assignment,
            S3Assignment,
            S4Assignment
            };

            foreach (ListView list in assignmentLists)
            {
                list.ItemActivate += AssignmentList_ItemActivate;
            }

            if (subjects == null) throw new ArgumentNullException(nameof(subjects));
            this.subjects = subjects;
            DisplaySubjectData(subjects);
        }

        private void DisplaySubjectData(List<Subject> subjects)
        {   //Displays data on and activate subject buttons on Home page
            Button[] subjectButtons =
            { Subject1, Subject2, Subject3, Subject4 };

            for (int i = 0; i < subjectButtons.Length; i++)
            {
                subjectButtons[i].Enabled = i < subjects.Count;
                subjectButtons[i].Text = i < subjects.Count
                    ? subjects[i].subjectID + " " + subjects[i].subjectName
                    : "No subject";
            }
            if (subjects.Count == 0)
            {
                return;
            }
            Panel[] panels = new Panel[] { Subject1Panel, Subject2Panel, Subject3Panel, Subject4Panel };
            for (int i = 0; i < panels.Length && i < subjects.Count; ++i)
            {   //Fills out all sections of the subject panels
                Subject subject = subjects[i];
                Control.ControlCollection panelItems = panels[i].Controls;
                panelItems[3].Text = subject.subjectID + " " + subject.subjectName;
                panelItems[4].Text = subject.teachingSession + ", " + subject.subjectFaculty;
                FillGroupBox<Class>(subject.lectures, (GroupBox)panelItems[5]);
                FillGroupBox<Class>(subject.classes, (GroupBox)panelItems[6]);
                FillAssignmentList(new List<Subject>() { subject }, panels[i]);
            }
            FillAssignmentList(subjects, AssignmentPanel);
        }
        private void FillGroupBox<T>(List<T> classes, GroupBox box) where T : Class
        {   //Fills the class listboxes, one line for each item
            ListView list = (ListView)box.Controls[0];
            foreach (T item in classes)
            {
                ListViewItem listItem = new ListViewItem(item.classType);
                listItem.Font = new Font(list.Font, listItem.Font.Style);
                listItem.SubItems.Add(item.startTime.ToString());
                listItem.SubItems.Add(item.duration.ToString());
                listItem.SubItems.Add(item.classDay);
                listItem.SubItems.Add(item.classLocation);
                listItem.SubItems.Add(item.weeksRunning);
                list.Items.Add(listItem);
            }
        }
        private void FillAssignmentList(List<Subject> subjects, Panel panel)
        {
            ListView assList = (ListView)panel.Controls[2].Controls[0];
            foreach (Subject subject in subjects)
            {   //Fills the assignment listbox, one line for each item
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
        private void RefreshAssignmentLists()
        {
            //Ignore selection changes while rebuilding the list to prevent the editor reopening
            refreshingAssignments = true;

            try
            {   //Empties, then refilles the assignment list panel
                AllAssignmentList.Items.Clear();
                FillAssignmentList(subjects, AssignmentPanel);

                Panel[] panels =
                {
            Subject1Panel, Subject2Panel,
            Subject3Panel, Subject4Panel
        };

                ListView[] lists =
                {
            S1Assignment, S2Assignment, S3Assignment, S4Assignment
        };
                //Empties then refilles each assignment page
                for (int i = 0; i < panels.Length; i++)
                {
                    lists[i].Items.Clear();

                    if (i < subjects.Count)
                    {
                        FillAssignmentList(
                            new List<Subject> { subjects[i] },
                            panels[i]);
                    }
                }
            }
            finally
            {
                refreshingAssignments = false;
            }
        }

        private void AssignmentList_ItemActivate(object sender, EventArgs e)
        {
            if (refreshingAssignments)
            {   //Does nothing if project already refreshing
                return;
            }

            ListView list = (ListView)sender;
            //Prevents the change from 1 to 0 selections from throwing an exception
            if (list.SelectedItems.Count > 0)
            {   
                LoadAssignment(list.SelectedItems[0], e);
            }
        }

        private void ChangePanel(Panel oldPanel, Panel newPanel)
        {   //Controls which panels the user interacts with by chanigng panel visibility
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

            RefreshAssignmentLists();
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
            if (refreshingAssignments)
            {
                return;
            }
            ListView list = (ListView)sender;
            if (list.SelectedItems.Count > 0)
            {
                LoadAssignment(list.SelectedItems[0], e);
            }
        }
        private void LoadAssignment(object sender, EventArgs e)
        {   //Load the assignment of the ListViewItem that was selected
            ListViewItem item = (ListViewItem)sender;
            Assignment assignment = (Assignment)item.Tag;

            using (AssignmentDetailsForm details =
                new AssignmentDetailsForm(assignment))
            {
                details.ShowDialog(this);
            }

            RefreshAssignmentLists();
        }

        private void AssignmentListButton_Click(object sender, EventArgs e)
        {
            ChangePanel(HomePanel, AssignmentPanel);
        }

        private void S1Assignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (refreshingAssignments)
            {
                return;
            }
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
        private void AddAssignment(Subject subject)
        {   //Associates passed subject with new assignment
            Assignment newAssignment = new Assignment(
                "New Assignment", DateTime.Today, "", subject);

            //Only add the new assignment to its subject when the details form saves successfully
            using (AssignmentDetailsForm details = new AssignmentDetailsForm(
                newAssignment,
                edited => subject.assignments.Add(edited)))
        {
            details.Text = "Add Assignment";
            details.ShowDialog(this);
        }

        RefreshAssignmentLists();
    }

        private void S1AddAss_Click(object sender, EventArgs e)
        {
            AddAssignment(subjects[0]);
        }

        private void S2AddAss_Click(object sender, EventArgs e)
        {
            AddAssignment(subjects[1]);
        }

        private void S3AddAss_Click(object sender, EventArgs e)
        {
            AddAssignment(subjects[2]);
        }

        private void S4AddAss_Click(object sender, EventArgs e)
        {
            AddAssignment(subjects[3]);
        }

        private void StudySessionButton_Click(object sender, EventArgs e)
        {   //Creates a study session form
            using (StudySessionForm studySessions = new StudySessionForm())
            {
                studySessions.ShowDialog(this);
            }
        }
    }
}
