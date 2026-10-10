using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace Study_Planner
{
    public class Subject
    {
        private string subjectName;
        private string subjectID;
        private string subjectFaculty;
        private string teachingSession;
        private List<Class> lectures;
        private List<Class> classes;
        private List<Assignment> assignments;
        public Subject(string name, string id, string faculty, string session)
        {
            subjectName = name;
            subjectID = id;
            subjectFaculty = faculty;
            teachingSession = session;
        }
        public void addAssigment(string type, DateTime date, string description, List<Milestone> milestone = null)
        {
            assignments.Add(new Assignment(type, date, description, milestone));
        }
        public void addAssignment(string type, string date, string description, List<Milestone> milestone = null)
        {
            assignments.Add(new Assignment(type, date, description, milestone));
        }
        public void addLecture()
        {
            string duration = "";
            string startTime = "";
            string classDay = "";
            string classDescription = "";
            lectures.Add(new Class(duration, startTime, classDay, classDescription));
        }
        public void addClass(string type, string length, string time, string day, string location, string description = "", string weeks = "All")
        {
            string classType = "";
            string duration = "";
            string startTime = "";
            string classDay = "";
            string classLocation = "";
            string classDescription = "";
            string weeksRunning = "";
            classes.Add(new Class(classType, duration, startTime, classDay, classLocation, classDescription, weeksRunning));
        }
    }
    public class Class
    {
        private string classType { get; }
        private string duration { get; }
        private string startTime { get; }
        private string classDay { get; }
        private string classLocation { get; }
        private string classDescription {  get; }
        private string weeksRunning { get; }
        public Class(string type, string length, string time, string day, string location, string description="", string weeks="All")
        {
            classType = type;
            duration = length;
            startTime = time;
            classDay = day;
            classLocation = location;
            classDescription = description;
            weeksRunning = weeks;
        }
        public Class(string length, string time, string day, string description="Attendance not required")
        {
            classType = "lecture";
            duration = length;
            startTime = time;
            classDay= day;
            classLocation = "Online";
            classDescription = description;
            weeksRunning = "All";
        }
    }
    public class Assignment
    {
        private string assignmentType { get; }
        private DateTime dueDate { get; }
        private string assignmentDescription { get; }
        private List<Milestone> milestones { get; }
        public Assignment(string type, DateTime date, string description, List<Milestone> milestone=null)
        {
            assignmentType = type;
            dueDate = date;
            assignmentDescription = description;
            if (milestone != null) { milestones = milestone; }
            else { milestones = new List<Milestone>(); }
        }
        public Assignment(string type, string date, string description, List<Milestone> milestone=null)
        {
            assignmentType = type;
            dueDate = DateTime.Parse(date);
            assignmentDescription = description;
            if (milestone != null) { milestones = milestone; }
            else { milestones = new List<Milestone>(); }
        }
        public void AddMileStone(string milestoneName, string milestoneDescription, string date)
        {
            milestones.Add(new Milestone(milestoneName, milestoneDescription, date));
        }

    }
    public struct Milestone
    {
        public Milestone(string milestoneName, string milestoneDescription, string date)
        {
            name = milestoneName;
            description = milestoneDescription;
            expectedDate = DateTime.Parse(date);
            isComplete = false;
        }
        public string name { get; }
        public string description { get; }
        public DateTime expectedDate { get; }
        public bool isComplete { get; }

    }
}
