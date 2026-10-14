using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Planner
{
    public partial class StudySessionForm : Form
    {

        private List<StudySession> sessions = new List<StudySession>();

        public StudySessionForm()
        {
            InitializeComponent();
        }

        private void btnNewStudySession_Click(object sender, EventArgs e)
        {

            // IMPORTANT TO DO
            // MAKE SURE THERE IS A CONFIRM THE STUDY SESSION BUTTON
            // MAKE SURE THERE IS INPUT VALIDATION for the task description

            string TaskDescription = txtStudyDescription.Text;
            DateTime SessionDate = dtpSessionDate.Value.Date;
            TimeSpan StartTime = dtpStartTime.Value.TimeOfDay;

            // time duration
            int hours = (int)numHours.Value;
            int minutes = (int)numMinutes.Value;
            TimeSpan SessionDuration = new TimeSpan(hours, minutes, 0);

            StudySession newSession = new StudySession(SessionDate, SessionDuration, SessionDuration, TaskDescription);
            sessions.Add(newSession);

            testTxt.Text = newSession.ToString();
        }
    }
}
