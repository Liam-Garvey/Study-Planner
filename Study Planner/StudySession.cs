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

        // properties

        public string StudyDescription {  get; set; }
        public DateTime StudyDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan SessionDuration { get; set; }
        public bool StudyCompleted { get; set; }

        public StudySession(DateTime date, TimeSpan start, TimeSpan duration, string description) {
            StartTime = start;
            StudyDate = date;
            SessionDuration = duration;
            StudyDescription = description;
            StudyCompleted = false;
        }



        // NEED TO CREATE A TOSTRING

        public override string ToString()
        {
            return StudyDescription + StudyDate + StartTime + SessionDuration;
        }
    }
}
