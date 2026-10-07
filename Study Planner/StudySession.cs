using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Planner
{
    public class StudySession
    {
        public DateTime startTime { get; set; }
        public DateTime studyDate { get; set; }
        public TimeSpan sessionDuration { get; set; }
        public string studyDescription { get; set; }
        public bool studyCompleted { get; set; }

        public DateTime endTime
        {
            get
            {
                return startTime + sessionDuration;
            }
        }
    }
}
