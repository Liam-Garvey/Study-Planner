using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Study_Planner
{
    public partial class StudySessionForm : Form
    {
        private readonly bool refreshingView;
        private readonly List<StudySession> sessions = new List<StudySession>();

        public StudySessionForm()
        {
            InitializeComponent();
            AddDummyData();
            SessionsInListStudySessions();
            SessionsInStudyLog();
        }


        private void BtnNewStudySession_Click(object sender, EventArgs e)
        {

            string TaskDescription = txtStudyDescription.Text; 
            DateTime SessionDate = dtpSessionDate.Value.Date;
            TimeSpan StartTime = dtpStartTime .Value.TimeOfDay;

            // time duration
            int hours = (int)numHours.Value;
            int minutes = (int)numMinutes.Value;
            TimeSpan SessionDuration = new TimeSpan(hours, minutes, 0);


            // validation - all inputs entered otherwise can not add
            if (string.IsNullOrWhiteSpace(TaskDescription))
            {
                MessageBox.Show("Please enter a description!", "Empty Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((SessionDate < DateTime.Today)) 
            {
                MessageBox.Show("Please enter today or a future date", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((SessionDate + StartTime <= (DateTime.Now.AddMinutes(-1))))
            {
                MessageBox.Show("Please enter a future time", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (hours == 0 && minutes == 0)
            {
                MessageBox.Show("Please enter a duration of time!", "Invalid Duration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            StudySession newSession = new StudySession(SessionDate, StartTime, SessionDuration, TaskDescription);

            DialogResult result = MessageBox.Show("Confirm your session", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                sessions.Add(newSession);
                ClearInputs();
            }
            else if (result == DialogResult.No)
            {
                return;
            }


            SessionsInListStudySessions();
            SessionsInStudyLog();

            // tester code
            //testTxt.Text = newSession.ToString();
            
        }

        private void ClearInputs()
        {
            txtStudyDescription.Clear();

            numHours.Value = 0;
            dtpSessionDate.Value = DateTime.Now;
            dtpStartTime.Value = DateTime.Now;
            numMinutes.Value = 0;
        }

        private void SessionsInListStudySessions()
        {
            ListStudySessions.Items.Clear();

            var incompleteSessions = (from session in sessions
                                     where !session.StudyCompleted
                                      orderby session.StudyDate, session.StartTime
                                      select session).ToList(); // creates a new list

            foreach (StudySession session in incompleteSessions)
            {
                ListViewItem item = new ListViewItem(session.StudyDescription);
                item.SubItems.Add(session.GetFormattedStudyDate());
                item.SubItems.Add(session.GetFormattedStartTime());
                item.SubItems.Add(session.GetFormattedDuration());
                item.Tag = session;
                ListStudySessions.Items.Add(item);
            }

        }

        private void SessionsInStudyLog()
        {
           ListStudyLog.Items.Clear();

            var completeSessions = (from session in sessions
                                     where session.StudyCompleted
                                     orderby session.StudyDate, session.StartTime
                                    select session).Reverse().ToList();

            foreach (StudySession session in completeSessions)
            {
                ListViewItem item = new ListViewItem(session.StudyDescription);
                item.SubItems.Add(session.GetFormattedDuration());
                item.SubItems.Add(session.GetFormattedStudyDate());
                item.Tag = session;
                ListStudyLog.Items.Add(item);
            }
        }

        private void AddDummyData()
        {
            sessions.Add(new StudySession(DateTime.Today, new TimeSpan(11, 30, 0), new TimeSpan(0, 25, 0), "Work on flashcards"));
            sessions.Add(new StudySession(DateTime.Today.AddDays(2), new TimeSpan(20, 0, 0), new TimeSpan(1, 0, 0), "Study for quiz"));
            sessions.Add(new StudySession(DateTime.Today, new TimeSpan(13, 0, 0), new TimeSpan(0, 45, 0), "Work on assignment"));
            sessions.Add(new StudySession(DateTime.Today, new TimeSpan(14, 0, 0), new TimeSpan(1, 0, 0), "Do labs", true));
            sessions.Add(new StudySession(DateTime.Today.AddDays(1), new TimeSpan(14, 0, 0), new TimeSpan(1, 0, 0), "Do labs", true));
        }
        private void RefreshLists() 
        {
            SessionsInListStudySessions();
            SessionsInStudyLog();
        }

        private StudySession GetSelectedItem() 
        {
            if (ListStudySessions.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a session in the list", "Select a session", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }

            return (StudySession)ListStudySessions.SelectedItems[0].Tag;
        }

        private void BtnRemoveSession_Click(object sender, EventArgs e)
        {

            StudySession session = GetSelectedItem();
            if (session == null) { return;  }
            
            DialogResult result = MessageBox.Show("Do you want to remove this session?", "Remove session", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                sessions.Remove(session);
                RefreshLists();
                MessageBox.Show("Session removed", "Remove session", MessageBoxButtons.OK);
            }
        }

        private void BtnSessionCompleted_Click(object sender, EventArgs e)
        {
            StudySession session = GetSelectedItem();

            if (session == null) { return; }


            DialogResult result = MessageBox.Show("Did you complete the session?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                session.StudyCompleted = true;
                MessageBox.Show("Good Job! :)", "Session Completed", MessageBoxButtons.OK);
                RefreshLists();
            }

            else if (result == DialogResult.No)
            {
                return;
            }
        }

    }
}