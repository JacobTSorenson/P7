using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P5;

namespace Builder
{
    public partial class FormModifyIssue : Form
    {
        public Issue modifyIssue;
        public int selectedProject;
        public FormModifyIssue(Issue issue, int projectId)
        {
            InitializeComponent();
            modifyIssue = issue;
            selectedProject = projectId;
        }

        private void FormModifyIssue_Load(object sender, EventArgs e)
        {
            IssueIdBox.Text = modifyIssue.ID + "";
            IssueTitleBox.Text = modifyIssue.title;
            dateTimePicker.Value = modifyIssue.discoveryDate;
            discovererBox.Text = modifyIssue.discoverer;
            componentBox.Text = modifyIssue.component;

            FakeIssueStatusRepository formStatusRepo = new FakeIssueStatusRepository();
            foreach (IssueStatus s in formStatusRepo.GetAll())
            {
                if (s.Id == modifyIssue.ID)
                {
                    statusBox.Text = s.Value;
                }
            }

            descriptionBox.Text = modifyIssue.initialDescription;

            dateTimePicker.MaxDate = DateTime.Today;
            FakeAppUserRepository userRepo = new FakeAppUserRepository();
            FakeIssueStatusRepository statusRepo = new FakeIssueStatusRepository();
            string fullName;

            foreach (AppUser user in userRepo.GetAll())
            {
                fullName = user.LastName + ", " + user.FirstName;
                discovererBox.Items.Add(fullName);
            }

            foreach (IssueStatus status in statusRepo.GetAll())
            {
                statusBox.Items.Add(status.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IssueTitleBox.Text))
            {
                MessageBox.Show("No issue title provided", "Attention", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(discovererBox.Text))
            {
                MessageBox.Show("No issue discoverer provided", "Attention", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(componentBox.Text))
            {
                MessageBox.Show("No issue component provided", "Attention", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(statusBox.Text))
            {
                MessageBox.Show("No issue status provided", "Attention", MessageBoxButtons.OK);
                return;
            }


            modifyIssue.ID = Int32.Parse(IssueIdBox.Text);
            modifyIssue.title = IssueTitleBox.Text;
            modifyIssue.projectId = selectedProject;
            modifyIssue.discoveryDate = dateTimePicker.Value;
            modifyIssue.discoverer = discovererBox.Text;
            modifyIssue.initialDescription = descriptionBox.Text;
            modifyIssue.component = componentBox.Text;

            FakeIssueStatusRepository formStatusRepo = new FakeIssueStatusRepository();
            foreach (IssueStatus s in formStatusRepo.GetAll())
            {
                if (s.Value == statusBox.Text)
                {
                    modifyIssue.status = s.Id;
                }
            }

            FakeIssueRepository issueRepo = new FakeIssueRepository();

            foreach (Issue i in issueRepo.GetAll(selectedProject))
            {
                if (i.title == modifyIssue.title)
                {
                    MessageBox.Show("Duplicate issue names not allowed", "Attention", MessageBoxButtons.OK);
                    return;
                }
            }

            issueRepo.Modify(modifyIssue);
            Dispose();
        }
    }
}
