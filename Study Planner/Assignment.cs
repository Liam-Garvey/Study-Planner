using System;
using System.Collections.Generic;
using System.Globalization;

namespace Study_Planner
{
    public class Assignment
    {
        public string assignmentId { get; private set; }
        public string assignmentType { get; private set; }
        public DateTime dueDate { get; private set; }
        public string assignmentDescription { get; private set; }
        public List<Milestone> milestones { get; private set; }
        public Subject subject { get; private set; }

        public int progress
        {
            get
            {
                if (milestones.Count == 0)
                {
                    return 0;
                }
                //count completed milestones using LINQ and a lambda to calculate progress
                int completed = milestones.Count(milestone => milestone.isComplete);

                return (int)(completed * 100L / milestones.Count);
            }
        }

        public Assignment(string type, DateTime date, string description,
            Subject relatedSubject, List<Milestone> milestone = null)
        {
            if (relatedSubject == null)
                throw new ArgumentNullException(nameof(relatedSubject));

            subject = relatedSubject;
            UpdateDetails(type, date, description);
            milestones = CopyMilestones(milestone ?? new List<Milestone>());
        }

        public Assignment(string type, string date, string description,
            Subject relatedSubject, List<Milestone> milestone = null)
            : this(type, DateTime.Parse(date), description, relatedSubject, milestone)
        {
        }

        public void UpdateDetails(string type, DateTime date, string description)
        {
            if (string.IsNullOrWhiteSpace(type))
                throw new ArgumentException("Enter an assignment type.", nameof(type));
            assignmentType = type.Trim();
            dueDate = date.Date;
            assignmentDescription = description ?? "";
        }

        public void AddMileStone(string name, string description, DateTime date, bool complete=false)
        {
            milestones.Add(new Milestone(name, description, date.Date, complete));
        }

        public void AddMileStone(string name, string description, string date, bool complete=false)
        {
            AddMileStone(name, description, DateTime.Parse(date), complete);
        }

        public void SetMilestoneCompletion(int index, bool complete = true)
        {
            if (index < 0 || index >= milestones.Count)
                throw new ArgumentOutOfRangeException(nameof(index));
            milestones[index].SetComplete(complete);
        }

        public Assignment CreateEditCopy()
        {
            return new Assignment(assignmentType, dueDate, assignmentDescription,
                subject, milestones);
        }

        public void ApplyDetailsFrom(Assignment edited)
        {
            if (edited == null) throw new ArgumentNullException(nameof(edited));
            if (edited.subject != subject)
                throw new ArgumentException("This edit belongs to another subject.");

            List<Milestone> replacement = CopyMilestones(edited.milestones);
            UpdateDetails(edited.assignmentType, edited.dueDate,
                edited.assignmentDescription);
            milestones = replacement;
        }

        //create separate milestone objects so discarded edits cannot affect the originals
        private static List<Milestone> CopyMilestones(List<Milestone> source)
        {
            List<Milestone> result = new List<Milestone>();
            foreach (Milestone item in source)
            {
                if (item == null)
                    throw new ArgumentException("A milestone cannot be null.");
                Milestone copy = new Milestone(item.name, item.description,
                    item.expectedDate.Date);
                copy.SetComplete(item.isComplete);
                result.Add(copy);
            }
            return result;
        }

        public string AssignmentInfo()
        {
            return assignmentType + " " + dueDate.ToString("dd/MM/yyyy")
                + " " + progress + "%";
        }
    }
}