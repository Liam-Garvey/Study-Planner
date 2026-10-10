using System;
using System.Collections.Generic;
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
        public void AddAssigment(string type, DateTime date, string description, List<Milestone> milestone = null)
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
        public string startTime { get; private set; }
        public string classDay { get; private set; }
        public string classLocation { get; private set; }
        public string classDescription { get; private set; }
        public string weeksRunning { get; private set; }
        public Class(string type, string length, string time, string day, string location, string weeks="All", string description = "")
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
            classType = "Lecture";
            duration = length;
            startTime = time;
            classDay= day;
            classLocation = "Online";
            classDescription = description;
            weeksRunning = "All";
        }
        public string ClassInfo()
        {
            return classType + " " + startTime + " " + duration + " " + classDay + " " + classLocation;
        }
    }
    public class Assignment
    {
        public string assignmentType { get; private set; }
        public DateTime dueDate { get; private set; }
        public string assignmentDescription { get; private set; }
        public List<Milestone> milestones { get; private set; }
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
