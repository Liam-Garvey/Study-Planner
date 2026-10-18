using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Study_Planner
{
    public partial class StudySessionForm : Form
    {
        private bool refreshingView;
        private List<StudySession> sessions = new List<StudySession>();

        public StudySessionForm()
        {
            InitializeComponent();
            AddDummyData();
            SessionsInListStudySessions();
            SessionsInStudyLog();
        }

        // ADDS NEW SESSIONS
        private void BtnNewStudySession_Click(object sender, EventArgs e)
        {

            // IMPORTANT TO DO
            // MAKE SURE THERE IS A CONFIRM THE STUDY SESSION BUTTON
            // MAKE SURE THERE IS INPUT VALIDATION for the task description

            string TaskDescription = txtStudyDescription.Text; 
            DateTime SessionDate = dtpSessionDate.Value.Date;
            TimeSpan StartTime = dtpStartTime .Value.TimeOfDay;

            // time duration
            int hours = (int)numHours.Value;
            int minutes = (int)numMinutes.Value;
            TimeSpan SessionDuration = new TimeSpan(hours, minutes, 0);

            StudySession newSession = new StudySession(SessionDate, StartTime, SessionDuration, TaskDescription);
            sessions.Add(newSession);

            SessionsInListStudySessions();
            SessionsInStudyLog();

            // tester code
            //testTxt.Text = newSession.ToString();
            
            ClearInputs();
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
                item.Checked = session.StudyCompleted;
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
                item.Checked = session.StudyCompleted;
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

        private void ListStudySessions_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (refreshingView) { return; } // refreshing view

            StudySession session = (StudySession)e.Item.Tag;

            bool isChecked = e.Item.Checked;
            session.StudyCompleted = isChecked;

            BeginInvoke(new Action(RefreshLists));

        }

        private void RefreshLists() 
        {
            refreshingView = true;

            try
            {
                SessionsInListStudySessions();
                SessionsInStudyLog();
            }
            finally { refreshingView = false; } 
        }
    }
}