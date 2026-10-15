using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Study_Planner
{
    public partial class StudySessionForm : Form
    {

        private List<StudySession> sessions = new List<StudySession>();

        public StudySessionForm()
        {
            InitializeComponent();
            AddDummyData();
            SessionsInListStudySessions();
        }

        private void BtnNewStudySession_Click(object sender, EventArgs e)
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

            StudySession newSession = new StudySession(SessionDate, StartTime, SessionDuration, TaskDescription);
            sessions.Add(newSession);
            SessionsInListStudySessions();

            // tester code
            testTxt.Text = newSession.ToString();
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

        // adding in the list
        private void SessionsInListStudySessions()
        {

            ListStudySessions.Items.Clear();

            foreach (StudySession session in sessions)
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

        private void AddDummyData()
        {
            sessions.Add(new StudySession(DateTime.Today, new TimeSpan(11, 30, 0), new TimeSpan(0, 25, 0), "Work on flashcards"));
            sessions.Add(new StudySession(DateTime.Today.AddDays(2), new TimeSpan(20, 0, 0), new TimeSpan(1, 0, 0), "Study for quiz"));
            sessions.Add(new StudySession(DateTime.Today, new TimeSpan(13, 0, 0), new TimeSpan(0, 45, 0), "Work on assignment"));
        }

        private void ListStudySessions_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            // get the session object from item
            StudySession session = (StudySession)e.Item.Tag;

            //get checked state
            bool isChecked = e.Item.Checked;
            // update the object's studycompleted property using =
            session.StudyCompleted = isChecked;

            // value test
            testTxt.Text = session.StudyDescription + " : " + session.StudyCompleted;

        }
    }
}