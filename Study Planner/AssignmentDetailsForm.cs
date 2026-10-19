using System;
using System.Windows.Forms;

namespace Study_Planner
{
    public partial class AssignmentDetailsForm : Form
    {
        private Assignment assignment; // Working copy.
        private Action<Assignment> saveAssignment;
        private bool loadingControls;
        private bool dirty;
        private bool milestoneEditorDirty;
        private int selectedMilestoneIndex = -1;
        private string loadedMilestoneName = "";
        private string loadedMilestoneDescription = "";
        private DateTime loadedMilestoneDate;

        public AssignmentDetailsForm()
        {
            InitializeComponent();

            CancelAssignmentButton.Click += (sender, e) => Close();
            SaveAssignmentButton.Click += SaveAssignmentButton_Click;
            AddMilestoneButton.Click += AddMilestoneButton_Click;
            UpdateMilestoneButton.Click += UpdateMilestoneButton_Click;
            MilestonesList.SelectedIndexChanged += MilestonesList_SelectedIndexChanged;
            MilestonesList.ItemCheck += MilestonesList_ItemCheck;
            FormClosing += AssignmentDetailsForm_FormClosing;

            AssignmentTypeBox.TextChanged += AssignmentFieldChanged;
            AssignmentDescriptionBox.TextChanged += AssignmentFieldChanged;
            AssignmentDate.ValueChanged += AssignmentFieldChanged;
            MilestoneNameBox.TextChanged += MilestoneFieldChanged;
            MilestoneDescriptionBox.TextChanged += MilestoneFieldChanged;
            MilestoneDate.ValueChanged += MilestoneFieldChanged;

            SaveAssignmentButton.Enabled = false;
            AddMilestoneButton.Enabled = false;
            UpdateMilestoneButton.Enabled = false;
        }

        public AssignmentDetailsForm(Assignment selectedAssignment)
            : this(selectedAssignment, null)
        {
        }

        public AssignmentDetailsForm(Assignment selectedAssignment,
            Action<Assignment> saveAssignment) : this()
        {
            if (selectedAssignment == null)
                throw new ArgumentNullException(nameof(selectedAssignment));

            //keep edits separate from original assignment until user saves
            assignment = selectedAssignment.CreateEditCopy();
            //can provide an Add action, otherwise save udates the original
            this.saveAssignment = saveAssignment
                ?? new Action<Assignment>(selectedAssignment.ApplyDetailsFrom);
            
            loadingControls = true;
            try
            {
                AssignmentTypeBox.Text = assignment.typeName;
                AssignmentDate.Value = assignment.dueDate;
                AssignmentDescriptionBox.Text = assignment.assignmentDescription;
                Text = assignment.typeName + " - Details";

                Control[] labels = Controls.Find("SubjectLabel", true);
                if (labels.Length > 0)
                    labels[0].Text = assignment.subject.subjectID + " - "
                        + assignment.subject.subjectName;
            }
            finally { loadingControls = false; }

            ReloadMilestones();
            SaveAssignmentButton.Enabled = true;
            AddMilestoneButton.Enabled = true;
            dirty = false;
        }

        private void AssignmentFieldChanged(object sender, EventArgs e)
        {
            if (!loadingControls && assignment != null) dirty = true;
        }

        private void MilestoneFieldChanged(object sender, EventArgs e)
        {
            if (loadingControls || assignment == null) return;
            milestoneEditorDirty = MilestoneNameBox.Text != loadedMilestoneName
                || MilestoneDescriptionBox.Text != loadedMilestoneDescription
                || MilestoneDate.Value.Date != loadedMilestoneDate;
        }

        private void SaveAssignmentButton_Click(object sender, EventArgs e)
        {
            if (!TrySave()) return;
            DialogResult = DialogResult.OK;
            Close();
        }

        private bool TrySave()
        {
            if (assignment == null) return false;

            if (string.IsNullOrWhiteSpace(AssignmentTypeBox.Text))
            {
                MessageBox.Show(this, "Enter an assignment type or title.");
                AssignmentTypeBox.Focus();
                return false;
            }

            //milestone fields must be added or updated in the list before saving the assignment
            if (milestoneEditorDirty)
            {
                MessageBox.Show(this,
                    "Click Add Milestone or Update Selected Milestone "
                    + "to apply the milestone fields before saving.");
                return false;
            }

            try
            {
                assignment.UpdateDetails(AssignmentTypeBox.Text,
                    AssignmentDate.Value.Date, AssignmentDescriptionBox.Text);
                saveAssignment(assignment);
                dirty = false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Assignment could not be saved.\n\n" + ex.Message,
                    "Save failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void AssignmentDetailsForm_FormClosing(object sender,
            FormClosingEventArgs e)
        {
            if (!dirty && !milestoneEditorDirty) return;

            DialogResult result = MessageBox.Show(this,
                "Save changes before closing?\n\n"
                + "Yes: save changes\nNo: discard changes\nCancel: keep editing",
                "Unsaved assignment", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

            if (result == DialogResult.Cancel
                || (result == DialogResult.Yes && !TrySave()))
                e.Cancel = true;
        }

        private bool ValidateMilestoneName()
        {
            if (!string.IsNullOrWhiteSpace(MilestoneNameBox.Text)) return true;
            MessageBox.Show(this, "Enter a milestone name.");
            MilestoneNameBox.Focus();
            return false;
        }

        private void AddMilestoneButton_Click(object sender, EventArgs e)
        {
            if (assignment == null || !ValidateMilestoneName()) return;
            assignment.AddMileStone(MilestoneNameBox.Text,
                MilestoneDescriptionBox.Text, MilestoneDate.Value.Date);
            dirty = true;
            ReloadMilestones();
            MilestoneNameBox.Focus();
        }

        private void UpdateMilestoneButton_Click(object sender, EventArgs e)
        {
            int index = MilestonesList.SelectedIndex;
            if (assignment == null || index < 0 || !ValidateMilestoneName()) return;
            assignment.milestones[index].UpdateDetails(MilestoneNameBox.Text,
                MilestoneDescriptionBox.Text, MilestoneDate.Value.Date);
            dirty = true;
            ReloadMilestones();
            MilestonesList.SelectedIndex = index;
        }

        private void MilestonesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (assignment == null || loadingControls) return;
            int index = MilestonesList.SelectedIndex;

            if (milestoneEditorDirty && MessageBox.Show(this,
                "Discard the unapplied milestone fields and change selection?",
                "Milestone fields", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                != DialogResult.Yes)
            {
                loadingControls = true;
                try { MilestonesList.SelectedIndex = selectedMilestoneIndex; }
                finally { loadingControls = false; }
                return;
            }

            loadingControls = true;
            try { LoadMilestoneEditor(index); }
            finally { loadingControls = false; }
        }

        // Call while loadingControls is true so loading fields is not an edit.
        private void LoadMilestoneEditor(int index)
        {
            selectedMilestoneIndex = index;
            UpdateMilestoneButton.Enabled = index >= 0;
            Milestone milestone = index < 0 ? null : assignment.milestones[index];
            MilestoneNameBox.Text = milestone == null ? "" : milestone.name;
            MilestoneDescriptionBox.Text = milestone == null ? "" : milestone.description;
            MilestoneDate.Value = milestone == null
                ? AssignmentDate.Value.Date : milestone.expectedDate;

            loadedMilestoneName = MilestoneNameBox.Text;
            loadedMilestoneDescription = MilestoneDescriptionBox.Text;
            loadedMilestoneDate = MilestoneDate.Value.Date;
            milestoneEditorDirty = false;
        }

        private void MilestonesList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (assignment == null || loadingControls) return;
            assignment.SetMilestoneCompletion(e.Index, e.NewValue == CheckState.Checked);
            dirty = true;
            RefreshProgress();
        }

        private void ReloadMilestones()
        {
            loadingControls = true;
            try
            {
                MilestonesList.Items.Clear();
                foreach (Milestone milestone in assignment.milestones)
                {
                    string text = milestone.name + " - "
                        + milestone.expectedDate.ToString("dd/MM/yyyy");
                    MilestonesList.Items.Add(text, milestone.isComplete);
                }
                LoadMilestoneEditor(-1);
            }
            finally { loadingControls = false; }
            RefreshProgress();
        }

        private void RefreshProgress()
        {
            int completed = 0;
            foreach (Milestone milestone in assignment.milestones)
                if (milestone.isComplete) completed++;
            AssignmentProgress.Value = assignment.progress;
            ProgressLabel.Text = assignment.progress + "% complete (" + completed
                + " of " + assignment.milestones.Count + " milestones)";
        }
    }
}
