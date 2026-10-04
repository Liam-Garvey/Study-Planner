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
        private int maxSize;
        private int currentSize;
        private List<Class> lectures;
        private List<Class> classes;
        public Subject(string name, string id, string faculty, string session, int max, int current)
        {
            subjectName = name;
            subjectID = id;
            subjectFaculty = faculty;
            teachingSession = session;
            maxSize = max;
            currentSize = current;
        }
    }
    public class Class
    {
        private string classType { get; }
        private string duration { get; }
        private int maxSize;
        private List<Activity> classDetails;
        private string startTime { get; }
        public Class(string type, string length, int size, List<Activity> activities)
        {
            classType = type;
            duration = length;
            maxSize = size;
            classDetails = activities;
        }
        public Class(string type, string length, int size)
        {
            classType = type;
            duration = length;
            maxSize = size;
            classDetails.Add(CreateActivity());
        }
        public Class (string time, string length)
        {
            classType = "lecture";
            startTime = time;
            duration = length;
            maxSize = 0;
        }
        private Activity CreateActivity()
        {
            //would prompt user
            string day = "";
            string location = "";
            string startTime = "";
            int size = 0;
            return (new Activity(day, location, startTime, size));
        }
        public bool HasSpace(int size)
        {
            return (maxSize > size);
        }
        public bool HasSpace(int size, Activity activity)
        {
            return activity.HasSpace(size);
        }
    }
    public struct Activity
    {
        public Activity(string newDay, string newLocation, string newTime, int size)
        {
            day = newDay;
            location = newLocation;
            startTime = newTime;
            currentSize = size;
        }
        public string day { get; }
        public string location { get; }
        public string startTime { get; }
        public int currentSize { get; }
        public bool HasSpace(int size)
        {
            return (currentSize < size);
        }
    }
}
