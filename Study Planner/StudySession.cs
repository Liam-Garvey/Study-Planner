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

        public string GetFormattedDuration()
        {
            return SessionDuration.ToString(@"hh' hr 'mm' min'");
        }

        public string GetFormattedStartTime()
        {
            return (StudyDate + StartTime).ToString("hh:mm tt");
        }

        public string GetFormattedStudyDate() 
        {
            return StudyDate.ToString("dd/MM/yyyy");
        }

        public override string ToString()
        {
            DateTime start = StudyDate + StartTime;

            return $"{StudyDate:dd/MM/yyyy}, {start:hh:mm tt}, {SessionDuration}, {StudyDescription}";
        }
    }
}
