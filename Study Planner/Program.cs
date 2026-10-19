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
            LoadSubjectData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(subjects));
            SaveSubjectData();
        }
        private static void LoadSubjectData()
        {
            subjects = new List<Subject>();
            Subject subject = null;
            Assignment assignment = null;
            StreamReader fileReader = new StreamReader("Data\\SubjectData.csv");
            while (!fileReader.EndOfStream)
            {
                string[] line = fileReader.ReadLine().Split(',');
                if (line[0] == "Subject")
                {
                    // ensures all subject elements are added correctly by only adding them to the subject after reading a new subject
                    if (assignment != null) { subject.assignments.Add(assignment); assignment = null; }
                    if (subject != null) { subjects.Add(subject); }
                    subject = new Subject(line[1], line[2], line[3], line[4]);
                } else if (line[0] == "Lecture")
                {
                    subject.AddLecture(line[1], line[2], line[3]);
                } else if (line[0] == "Class")
                {
                    subject.AddClass(line[1], line[2], line[3], line[4], line[5], line[6]);
                } else if (line[0] == "Assignment")
                {// ensures all milestones are added to the correct assignment by only adding the assingment once something other than milestone is read
                    if (assignment != null) {  subject.assignments.Add(assignment); assignment = null; }
                    assignment = new Assignment(line[1], line[2], line[3], subject);
                } else if (line[0] == "Milestone")
                {
                    assignment.AddMileStone(line[1], line[2], line[3], Convert.ToBoolean(line[4]));
                }
            }
            //adds the last subject and assignment from the csv file to their respective parents
            subject.assignments.Add(assignment);
            subjects.Add(subject);
            fileReader.Close();
        }
        private static void SaveSubjectData()
        {   //clears the current file
            StreamWriter fileWriter = new StreamWriter("Data\\SubjectData.csv");
            foreach (Subject subject in subjects)
            {   //converts each element of the subjects into a csv format that can be used by the project later
                fileWriter.WriteLine("Subject," + subject.subjectName + "," + subject.subjectID + "," + 
                    subject.subjectFaculty + "," + subject.teachingSession);
                foreach (Class lecture in subject.lectures)
                {
                    fileWriter.WriteLine("Lecture," + lecture.duration.ToString() + "," + lecture.startTime.ToString() + "," + lecture.classDay);
                }
                foreach (Class c in subject.classes)
                {
                    fileWriter.WriteLine("Class," + c.classType + "," + c.duration.ToString() + "," + 
                        c.startTime.ToString() + "," + c.classDay + "," + c.classLocation + "," + c.weeksRunning);
                }
                foreach (Assignment ass in subject.assignments)
                {
                    fileWriter.WriteLine("Assignment," + ass.assignmentType + "," + ass.dueDate.Date + "," + ass.assignmentDescription);
                    foreach(Milestone ms in ass.milestones)
                    {
                        fileWriter.WriteLine("Milestone," + ms.name + "," + ms.description + "," + ms.expectedDate.ToString() + "," + ms.isComplete);
                    }
                }
            }
            fileWriter.Close();
        }
    }
}
