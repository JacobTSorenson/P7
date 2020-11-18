using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
    public partial class FormSelectRequirement : Form
    {
        private FakeFeatureRepository formFeatureRepo;
        private FakeRequirementRepository formRequirementRepo;
        private int selectedProject;
        private int operationType;
        public FormSelectRequirement(FakeFeatureRepository featureRepo, FakeRequirementRepository requirementRepo, int project, int type)
        {
            InitializeComponent();

            formFeatureRepo = featureRepo;
            formRequirementRepo = requirementRepo;
            selectedProject = project;
            operationType = type;
        }

        private void FormSelectRequirement_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            foreach (Feature f in formFeatureRepo.GetAll(selectedProject))
            {
                FeatureSelectionBox.Items.Add(f.Title);
            }
        }

        private void FeatureSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequirementsLabel.Enabled = true;
            RequirementsList.Enabled = true;
            SelectRequirementButton.Enabled = true;

            DataTable requirements = new DataTable("Requirements");
            DataColumn c0 = new DataColumn("ID");
            DataColumn c1 = new DataColumn("Requirement");
            requirements.Columns.Add(c0);
            requirements.Columns.Add(c1);

            DataRow row;

            foreach (Requirement r in formRequirementRepo.GetAll(selectedProject))
            {
                row = requirements.NewRow();
                row["ID"] = r.Id;
                row["Requirement"] = r.Statement;

                requirements.Rows.Add(row);
            }

            RequirementsList.DataSource = requirements;
            RequirementsList.Columns[1].Width = RequirementsList.Width - RequirementsList.Columns[0].Width - 43;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void SelectRequirementButton_Click(object sender, EventArgs e)
        {
            Requirement modifyRequirement = new Requirement();

            foreach (DataGridViewRow row in RequirementsList.SelectedRows)
            {
                modifyRequirement.Id = Int32.Parse(row.Cells[0].Value.ToString());
                foreach (Feature f in formFeatureRepo.GetAll(selectedProject))
                {
                    if (f.Title == FeatureSelectionBox.Text.ToString())
                        modifyRequirement.FeatureId = f.Id;
                }
                modifyRequirement.Statement = row.Cells[1].Value.ToString();
                modifyRequirement.ProjectId = selectedProject;
            }

            if (operationType == 0)
            {
                FormCreateRequirement modifyForm = new FormCreateRequirement(formRequirementRepo, formFeatureRepo, selectedProject, modifyRequirement, 1);
                modifyForm.ShowDialog();
                modifyForm.Dispose();
                Dispose();
            }

            else if (operationType == 1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove requirement: " + modifyRequirement.Id + "?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    formRequirementRepo.Remove(modifyRequirement);
                    Dispose();
                }

                else
                {
                    MessageBox.Show("Remove canceled", "Attention", MessageBoxButtons.OK);
                    Dispose();
                }
            }

        }
    }
}
