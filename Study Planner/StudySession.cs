using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Study_Planner
{
    public class StudySession
    {
        public DateTime startTime { get; set; }
        public DateTime studyDetails { get; set; }
        public TimeSpan sessionDuration { get; set; }
        public string studyDescription { get; set; }
        public bool studyCompleted { get; set; }
        public string studyLog { get; set; }

        public StudySession(DateTime details, string description="")
        {
            studyDetails = details;
            studyDescription = description;
            studyCompleted = false;
            studyLog = "";
        }
        public StudySession(string details, string description="")
        {
            studyDetails = DateTime.Parse(details);
            studyDescription = description;
            studyCompleted = false;
            studyLog = "";
        }
        public StudySession(int seconds, int minutes, int hours, int day, int month, int year, string description="")
        {
            studyDetails = new DateTime(year, month, day, hours, minutes, seconds);
            studyDescription = description;
            studyCompleted = false;
            studyLog = "";
        }
        public DateTime EndDetails
        {
            get
            {
                return startTime + sessionDuration;
            }
        }
        public TimeSpan EndTime
        {
            get
            {
                return studyDetails.TimeOfDay + sessionDuration;
            }
        }
        public TimeSpan GetTimeofDay()
        {
            return studyDetails.TimeOfDay;
        }
        public DayOfWeek GetDayofWeek()
        {
            return studyDetails.DayOfWeek;
        }
        public string GetDate()
        {
            return studyDetails.Day + "/" + studyDetails.Month + "/" + studyDetails.Year;
        }
    }
}
