using System;
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
            int pos = 0;
            foreach (Control control in this.HomePanel.Controls[1].Controls)
            {
                Subject subject = subjects[pos];
                control.Text = subject.subjectID + " " + subject.subjectName;
                ++pos;
            }
            Panel[] subjectPanels = new Panel[] { this.Subject1Panel };
            for (int i = 0; i < subjectPanels.Length; ++i)
            {
                Panel panel = subjectPanels[i];
                panel.Controls[0].Text = subjects[i].subjectID + " " + subjects[i].subjectName;
                panel.Controls[1].Text = subjects[i].teachingSession + " " + subjects[i].subjectFaculty;
                Panel[] panels = new Panel[3];
                GroupBox[] groupBoxes = panel.Controls.OfType<GroupBox>().ToArray();
                FillGroupBox<Class>(subjects[i].lectures, groupBoxes[0]);
                FillGroupBox<Class>(subjects[i].classes, groupBoxes[1]);
                FillAssignmentButtons(subjects[i].assignments, groupBoxes[2]);
            }
        }
        private void FillGroupBox<T>(List<T> classes, GroupBox box) where T : Class
        {
            for (int i = 0; i < box.Controls.Count; ++i)
            {
                if (i >= classes.Count) { box.Controls[i].Text = ""; }
                else { box.Controls[i].Text = classes[i].ClassInfo(); }
            }
        }
        private void FillAssignmentButtons(List<Assignment> assignments, GroupBox box)
        {
            for (int i = 0; i < box.Controls.Count; ++i)
            {
                if (i >= assignments.Count) { box.Controls[i].Text = ""; }
                else { box.Controls[i].Text = assignments[i].AssignmentInfo(); }
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
    }
}
