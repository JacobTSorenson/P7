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
    public partial class FormCreateIssue : Form
    {
        public int newIssueID;
        public FakeIssueRepository formIssueRepo;
        public int selectedProject;
        public FormCreateIssue(int issueID, FakeIssueRepository issueRepo, int project)
        {
            InitializeComponent();

            newIssueID = issueID;
            formIssueRepo = issueRepo;
            selectedProject = project;
        }

        private void FormCreateIssue_Load(object sender, EventArgs e)
        {
            dateTimePicker.MaxDate = DateTime.Today;
            IssueIDBox.Text = newIssueID + "";
            FakeAppUserRepository userRepo = new FakeAppUserRepository();
            FakeIssueStatusRepository statusRepo = new FakeIssueStatusRepository();
            string fullName;

            foreach (AppUser user in userRepo.GetAll())
            {
                fullName = user.LastName + ", " + user.FirstName;
                DiscovererBox.Items.Add(fullName);
            }

            foreach (IssueStatus status in statusRepo.GetAll())
            {
                StatusBox.Items.Add(status.Value);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void CreateIssueButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TitleBox.Text))
            {
                MessageBox.Show("No issue title provided", "Attention", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(DiscovererBox.Text))
            {
                MessageBox.Show("No issue discoverer provided", "Attention", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(ComponentBox.Text))
            {
                MessageBox.Show("No issue component provided", "Attention", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(StatusBox.Text))
            {
                MessageBox.Show("No issue status provided", "Attention", MessageBoxButtons.OK);
                return;
            }

            Issue newIssue = new Issue();

            newIssue.ID = Int32.Parse(IssueIDBox.Text);
            newIssue.title = TitleBox.Text;
            newIssue.projectId = selectedProject;
            newIssue.discoveryDate = dateTimePicker.Value;
            newIssue.discoverer = DiscovererBox.Text;
            newIssue.initialDescription = DescriptionBox.Text;
            newIssue.component = ComponentBox.Text;

            FakeIssueStatusRepository formStatusRepo = new FakeIssueStatusRepository();
            foreach (IssueStatus s in formStatusRepo.GetAll())
            {
                if (s.Value == StatusBox.Text)
                {
                    newIssue.status = s.Id;
                }
            }

            foreach (Issue i in formIssueRepo.GetAll(selectedProject))
            {
                if (i.title == newIssue.title)
                {
                    MessageBox.Show("Duplicate issue names not allowed", "Attention", MessageBoxButtons.OK);
                    return;
                }
            }

            formIssueRepo.Add(newIssue);
            Dispose();
        }
    }
}
