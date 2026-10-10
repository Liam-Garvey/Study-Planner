using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Planner
{
    internal static class Program
    {
        static List<Subject> subjects;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
            Console.WriteLine((new StudySession(52, 30, 8, 1, 5, 2008)).GetDate().ToString());
            LoadSubjectData();
            foreach (Subject subject in subjects)
            {
                //Console.WriteLine(subject.subjectName);
                foreach (Assignment c in subject.assignments)
                {
                    Console.WriteLine(c.dueDate);
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        private static void LoadSubjectData()
        {
            subjects = new List<Subject>();
            Subject subject = null;
            StreamReader fileReader = new StreamReader("Data\\SubjectData.csv");
            while (!fileReader.EndOfStream)
            {
                    string[] line = fileReader.ReadLine().Split(',');
                if (line[0] == "Subject")
                {
                    if (subject != null) { subjects.Add(subject); }
                    subject = new Subject(line[1], line[2], line[3], line[4]);
                } else if (line[0] == "Lecture")
                {
                    subject.AddLecture(line[1], line[2], line[3]);
                } else if (line[0] == "Class")
                {
                    subject.AddClass(line[1], line[2], line[3], line[4], line[5], line[6]);
                } else if (line[0] == "Assignment")
                {
                    subject.AddAssignment(line[1], line[2], line[3]);
                }
            }
        }
    }
}
