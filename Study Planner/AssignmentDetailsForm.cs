using System;
using System.Windows.Forms;

namespace Study_Planner
{
    public partial class AssignmentDetailsForm : Form
    {
        private Assignment assignment;
        private bool loadingMilestones;

        public AssignmentDetailsForm()
        {
            InitializeComponent();

            SaveAssignmentButton.Click += SaveAssignmentButton_Click;
            AddMilestoneButton.Click += AddMilestoneButton_Click;
            UpdateMilestoneButton.Click += UpdateMilestoneButton_Click;

            MilestonesList.SelectedIndexChanged +=
                MilestonesList_SelectedIndexChanged;

            MilestonesList.ItemCheck += MilestonesList_ItemCheck;

            UpdateMilestoneButton.Enabled = false;
        }

        public AssignmentDetailsForm(Assignment selectedAssignment)
            : this()
        {
            if (selectedAssignment == null)
            {
                throw new ArgumentNullException(nameof(selectedAssignment));
            }

            assignment = selectedAssignment;

            AssignmentTypeBox.Text = assignment.assignmentType;
            AssignmentDate.Value = assignment.dueDate;
            AssignmentDescriptionBox.Text =
                assignment.assignmentDescription;

            Text = assignment.assignmentType + " - Details";

            ReloadMilestones();
        }

        private void SaveAssignmentButton_Click(object sender, EventArgs e)
        {
            if (assignment == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(AssignmentTypeBox.Text))
            {
                MessageBox.Show("Enter an assignment type or title.");
                AssignmentTypeBox.Focus();
                return;
            }

            assignment.UpdateDetails(
                AssignmentTypeBox.Text,
                AssignmentDate.Value,
                AssignmentDescriptionBox.Text);

            Text = assignment.assignmentType + " - Details";

            MessageBox.Show("Assignment details updated.");
        }

        private bool ValidateMilestoneName()
        {
            if (!string.IsNullOrWhiteSpace(MilestoneNameBox.Text))
            {
                return true;
            }

            MessageBox.Show("Enter a milestone name.");
            MilestoneNameBox.Focus();
            return false;
        }

        private void AddMilestoneButton_Click(object sender, EventArgs e)
        {
            if (assignment == null || !ValidateMilestoneName())
            {
                return;
            }

            assignment.AddMileStone(
                MilestoneNameBox.Text,
                MilestoneDescriptionBox.Text,
                MilestoneDate.Value.Date);

            ReloadMilestones();
            MilestoneNameBox.Focus();
        }

        private void UpdateMilestoneButton_Click(object sender, EventArgs e)
        {
            int index = MilestonesList.SelectedIndex;

            if (assignment == null || index < 0)
            {
                return;
            }

            if (!ValidateMilestoneName())
            {
                return;
            }

            assignment.milestones[index].UpdateDetails(
                MilestoneNameBox.Text,
                MilestoneDescriptionBox.Text,
                MilestoneDate.Value.Date);

            ReloadMilestones();
            MilestonesList.SelectedIndex = index;
        }

        private void MilestonesList_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            int index = MilestonesList.SelectedIndex;

            UpdateMilestoneButton.Enabled = index >= 0;

            if (assignment == null || index < 0)
            {
                return;
            }

            Milestone milestone = assignment.milestones[index];

            MilestoneNameBox.Text = milestone.name;
            MilestoneDescriptionBox.Text = milestone.description;
            MilestoneDate.Value = milestone.expectedDate;
        }

        private void MilestonesList_ItemCheck(
            object sender, ItemCheckEventArgs e)
        {
            if (assignment == null || loadingMilestones)
            {
                return;
            }

            // The event fires before the checkbox changes visually.
            assignment.SetMilestoneCompletion(
                e.Index, e.NewValue == CheckState.Checked);

            RefreshProgress();
        }

        private void ReloadMilestones()
        {
            loadingMilestones = true;

            try
            {
                MilestonesList.Items.Clear();

                foreach (Milestone milestone in assignment.milestones)
                {
                    string text = milestone.name + " - "
                        + milestone.expectedDate.ToString("dd/MM/yyyy");

                    MilestonesList.Items.Add(text, milestone.isComplete);
                }
            }
            finally
            {
                loadingMilestones = false;
            }

            MilestoneNameBox.Clear();
            MilestoneDescriptionBox.Clear();
            MilestoneDate.Value = assignment.dueDate.Date;
            UpdateMilestoneButton.Enabled = false;

            RefreshProgress();
        }

        private void RefreshProgress()
        {
            int completed = 0;

            foreach (Milestone milestone in assignment.milestones)
            {
                if (milestone.isComplete)
                {
                    completed++;
                }
            }

            AssignmentProgress.Value = assignment.progress;

            ProgressLabel.Text = assignment.progress + "% complete ("
                + completed + " of " + assignment.milestones.Count
                + " milestones)";
        }
    }
}