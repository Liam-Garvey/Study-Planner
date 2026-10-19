using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
namespace Study_Planner
{
    public class Subject
    {
        public string subjectName { get; private set; }
        public string subjectID { get; private set; }
        public string subjectFaculty { get; private set; }
        public string teachingSession { get; private set; }
        public List<Class> lectures { get; private set; }
        public List<Class> classes { get; private set; }
        public List<Assignment> assignments { get; private set; }
        public Subject(string name, string id, string faculty, string session)
        {
            subjectName = name;
            subjectID = id;
            subjectFaculty = faculty;
            teachingSession = session;
            lectures = new List<Class>();
            classes = new List<Class>();
            assignments = new List<Assignment>();
        }
        //Multiple AddAssignment methods for user-created and csv data
        public void AddAssignment(string type, DateTime date, string description, List<Milestone> milestone = null)
        {
            assignments.Add(new Assignment(type, date, description, this, milestone));
        }
        public void AddAssignment(string type, string date, string description, List<Milestone> milestone = null)
        {
            assignments.Add(new Assignment(type, date, description, this, milestone));
        }
        public void AddLecture(string length, string time, string day, string description = "Attendance not required")
        {
            lectures.Add(new Class(length, time, day, description));
        }
        public void AddClass(string type, string length, string time, string day, string location, string description = "", string weeks = "All")
        {
            classes.Add(new Class(type, length, time, day, location, description, weeks));
        }
    }
    public class Class : Type
    {
        public string typeName { get; set; }
        public TimeSpan duration { get; private set; }
        public TimeSpan startTime { get; private set; }
        public string classDay { get; private set; }
        public string classLocation { get; private set; }
        public string typeDetails { get; set; }
        public string weeksRunning { get; private set; }
        //Different constructors allow for creation of class subtypes (lectures/other classes)
        public Class(string type, string length, string time, string day, string location, string weeks="All", string description = "")
        {
            typeName = type;
            duration = TimeSpan.Parse(length);
            startTime = TimeSpan.Parse(time);
            classDay = day;
            classLocation = location;
            typeDetails = description;
            weeksRunning = weeks;
        }
        public Class(string length, string time, string day, string description="Attendance not required")
        {
            typeName = "Lecture";
            duration = TimeSpan.Parse(length);
            startTime = TimeSpan.Parse(time);
            classDay= day;
            classLocation = "Online";
            typeDetails = description;
            weeksRunning = "All";
        }
        public string ClassInfo()
        {
            return typeName + " " + startTime.ToString() + " " + duration + " " + classDay + " " + classLocation;
        }
    }

    public class Milestone : Type, Date
    {
        public string typeName { get; set; }
        public string typeDetails { get; set; }
        public DateTime finishDate { get; set; }
        public bool isComplete { get; private set; }
        //Milestones default to incomplete due to being new
        public Milestone(string milestoneName,
            string milestoneDescription, DateTime date, bool complete=false)
        {
            UpdateDetails(milestoneName, milestoneDescription, date);
            isComplete = complete;
        }

        public Milestone(string milestoneName,
            string milestoneDescription, string date)
            : this(milestoneName, milestoneDescription,
                DateTime.Parse(date, CultureInfo.GetCultureInfo("en-AU")))
        {
        }

        public void UpdateDetails(string milestoneName,
            string milestoneDescription, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(milestoneName))
            {   //Prevents empty input/accidental interaction with add milestone button
                throw new ArgumentException(
                    "Enter a milestone name.", nameof(milestoneName));
            }

            typeName = milestoneName.Trim();
            typeDetails = milestoneDescription ?? "";
            finishDate = date;
        }

        public void SetComplete(bool complete = true)
        {
            isComplete = complete;
        }
    }
    interface Type
    {
        string typeName { get; set; }
        string typeDetails {  get; set; }
    }
    interface Date
    {
        DateTime finishDate { get; set; }
    }
}
