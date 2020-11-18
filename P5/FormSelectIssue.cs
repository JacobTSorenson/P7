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
    public partial class FormSelectIssue : Form
    {
        public FakeIssueRepository formIssueRepo;
        public int selectedProject;
        public int operationType;
        public FormSelectIssue(FakeIssueRepository issueRepo, int projectId, int type)
        {
            InitializeComponent();
            formIssueRepo = issueRepo;
            selectedProject = projectId;
            operationType = type;
        }

        private void FormSelectIssue_Load(object sender, EventArgs e)
        {
            DataTable issues = new DataTable("Issues");
            DataColumn c0 = new DataColumn("ID");
            DataColumn c1 = new DataColumn("Title");
            DataColumn c2 = new DataColumn("DiscoveryDate");
            DataColumn c3 = new DataColumn("Discoverer");
            DataColumn c4 = new DataColumn("InitialDescription");
            DataColumn c5 = new DataColumn("Component");
            DataColumn c6 = new DataColumn("Status");

            issues.Columns.Add(c0);
            issues.Columns.Add(c1);
            issues.Columns.Add(c2);
            issues.Columns.Add(c3);
            issues.Columns.Add(c4);
            issues.Columns.Add(c5);
            issues.Columns.Add(c6);

            DataRow row;

            FakeIssueStatusRepository formStatusRepo = new FakeIssueStatusRepository();
            foreach (Issue i in formIssueRepo.GetAll(selectedProject))
            {
                row = issues.NewRow();
                row["ID"] = i.ID;
                row["Title"] = i.title;
                row["DiscoveryDate"] = i.discoveryDate;
                row["Discoverer"] = i.discoverer;
                row["InitialDescription"] = i.initialDescription;
                row["Component"] = i.component;

                foreach (IssueStatus s in formStatusRepo.GetAll())
                {
                    if (s.Id == i.ID)
                    {
                        row["Status"] = s.Value;
                    }
                }

                issues.Rows.Add(row);
            }
            dataGridView.DataSource = issues;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            FakeIssueStatusRepository formStatusRepo = new FakeIssueStatusRepository();
            Issue modifyIssue = new Issue();
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                modifyIssue.ID = Int32.Parse(row.Cells[0].Value.ToString());
                modifyIssue.title = row.Cells[1].Value.ToString();
                modifyIssue.discoveryDate = DateTime.Parse(row.Cells[2].Value.ToString());
                modifyIssue.discoverer = row.Cells[3].Value.ToString();
                modifyIssue.initialDescription = row.Cells[4].Value.ToString();
                modifyIssue.component = row.Cells[5].Value.ToString();

                foreach (IssueStatus s in formStatusRepo.GetAll())
                {
                    if (s.Value == row.Cells[6].Value.ToString())
                    {
                        modifyIssue.status = s.Id;
                    }
                }
            }

            if (operationType == 0)
            {
                DialogResult = DialogResult.OK;
                FormModifyIssue modifyForm = new FormModifyIssue(modifyIssue, selectedProject);
                modifyForm.ShowDialog();
                modifyForm.Dispose();
            }

            else if (operationType == 1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove: " + modifyIssue.title + "?", "Confirmation", MessageBoxButtons.YesNo);
                
                if (result == DialogResult.Yes)
                    formIssueRepo.Remove(modifyIssue);

                else
                {
                    MessageBox.Show("Remove canceled", "Attention", MessageBoxButtons.OK);
                    Dispose();
                }
            }
            Dispose();
        }
    }
}
