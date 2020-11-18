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
    public partial class FormIssueDashboard : Form
    {
        public int totalIssues;
        public FakeIssueRepository formIssueRepo;
        public int selectedProject;
        public FormIssueDashboard(int numOfIssues, FakeIssueRepository issueRepo, int project)
        {
            InitializeComponent();

            totalIssues = numOfIssues;
            formIssueRepo = issueRepo;
            selectedProject = project;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void FormIssueDashboard_Load(object sender, EventArgs e)
        {
            NumIssuesLabel.Text = formIssueRepo.GetTotalNumberOfIssues(selectedProject) + "";

            List<string> monthList = formIssueRepo.GetIssuesByMonth(selectedProject);
            foreach (string month in monthList)
            {
                IssueByMonthBox.Items.Add(month);
            }

            List<string> discovererList = formIssueRepo.GetIssuesByDiscoverer(selectedProject);
            foreach (string disc in discovererList)
            {
                IssueByDiscovererBox.Items.Add(disc);
            }

        }
    }
}
