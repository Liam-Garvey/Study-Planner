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
        public void AddAssignment(string type, DateTime date, string description, List<Milestone> milestone = null)
        {
            assignments.Add(new Assignment(type, date, description, milestone));
        }
        public void AddAssignment(string type, string date, string description, List<Milestone> milestone = null)
        {
            assignments.Add(new Assignment(type, date, description, milestone));
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
    public class Class
    {
        public string classType { get; private set; }
        public string duration { get; private set; }
        public TimeSpan startTime { get; private set; }
        public string classDay { get; private set; }
        public string classLocation { get; private set; }
        public string classDescription { get; private set; }
        public string weeksRunning { get; private set; }
        public Class(string type, string length, string time, string day, string location, string weeks="All", string description = "")
        {
            classType = type;
            duration = length;
            startTime = TimeSpan.Parse(time);
            classDay = day;
            classLocation = location;
            classDescription = description;
            weeksRunning = weeks;
        }
        public Class(string length, string time, string day, string description="Attendance not required")
        {
            classType = "Lecture";
            duration = length;
            startTime = TimeSpan.Parse(time);
            classDay= day;
            classLocation = "Online";
            classDescription = description;
            weeksRunning = "All";
        }
        public string ClassInfo()
        {
            return classType + " " + startTime.ToString() + " " + duration + " " + classDay + " " + classLocation;
        }
    }
    public class Assignment
    {
        public string assignmentType { get; private set; }
        public DateTime dueDate { get; private set; }
        public string assignmentDescription { get; private set; }
        public List<Milestone> milestones { get; private set; }

        public int progress
        {
            get
            {
                if (milestones.Count == 0)
                {
                    return 0;
                }

                int completed = 0;

                foreach (Milestone milestone in milestones)
                {
                    if (milestone.isComplete)
                    {
                        completed++;
                    }
                }

                return (int)(completed * 100L / milestones.Count);
            }
        }

        public Assignment(string type, DateTime date, string description,
            List<Milestone> milestone = null)
        {
            UpdateDetails(type, date, description);
            milestones = milestone ?? new List<Milestone>();
        }

        public Assignment(string type, string date, string description,
            List<Milestone> milestone = null)
            : this(type,
                DateTime.Parse(date, CultureInfo.GetCultureInfo("en-AU")),
                description, milestone)
        {
        }

        public void UpdateDetails(string type, DateTime date,
            string description)
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                throw new ArgumentException(
                    "Enter an assignment type or title.", nameof(type));
            }

            assignmentType = type.Trim();
            dueDate = date;
            assignmentDescription = description ?? "";
        }

        public void AddMileStone(string milestoneName,
            string milestoneDescription, DateTime date)
        {
            milestones.Add(new Milestone(
                milestoneName, milestoneDescription, date));
        }

        public void AddMileStone(string milestoneName,
            string milestoneDescription, string date)
        {
            AddMileStone(milestoneName, milestoneDescription,
                DateTime.Parse(date, CultureInfo.GetCultureInfo("en-AU")));
        }

        public void SetMilestoneCompletion(int index, bool complete = true)
        {
            if (index < 0 || index >= milestones.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            milestones[index].SetComplete(complete);
        }

        public string AssignmentInfo()
        {
            return assignmentType + " " + dueDate.ToString("dd/MM/yyyy")
                + " " + progress + "%";
        }
    }

    public class Milestone
    {
        public string name { get; private set; }
        public string description { get; private set; }
        public DateTime expectedDate { get; private set; }
        public bool isComplete { get; private set; }

        public Milestone(string milestoneName,
            string milestoneDescription, DateTime date)
        {
            UpdateDetails(milestoneName, milestoneDescription, date);
            isComplete = false;
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
            {
                throw new ArgumentException(
                    "Enter a milestone name.", nameof(milestoneName));
            }

            name = milestoneName.Trim();
            description = milestoneDescription ?? "";
            expectedDate = date;
        }

        public void SetComplete(bool complete = true)
        {
            isComplete = complete;
        }
    }
}
