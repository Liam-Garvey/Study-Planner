using System;
using System.Collections.Generic;
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
        //private List<Assignment> assignments;
        public Subject(string name, string id, string faculty, string session)
        {
            subjectName = name;
            subjectID = id;
            subjectFaculty = faculty;
            teachingSession = session;
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
}
