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
    public partial class FormCreateRequirement : Form
    {
        private FakeRequirementRepository formRequirementRepo;
        private FakeFeatureRepository formFeatureRepo;
        private int selectedProject;
        private Requirement modifyRequirement;
        private int operationType;
        public FormCreateRequirement(FakeRequirementRepository reqRepo, FakeFeatureRepository featureRepo, int project, Requirement requirement, int type)
        {
            InitializeComponent();
            formRequirementRepo = reqRepo;
            formFeatureRepo = featureRepo;
            selectedProject = project;
            modifyRequirement = requirement;
            operationType = type;
        }

        private void FormCreateRequirement_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            if (operationType == 1)
            {
                Text = "Modify Requirement";
                CreateRequirementButton.Text = "Modify Requirement";

                label2.Enabled = true;
                StatementBox.Enabled = true;
                CreateRequirementButton.Enabled = true;

                StatementBox.Text = modifyRequirement.Statement;
            }

            foreach (Feature f in formFeatureRepo.GetAll(selectedProject))
            {
                FeatureSelectionBox.Items.Add(f.Title);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void CreateRequirementButton_Click(object sender, EventArgs e)
        {
            string errorMessage = "x";
            if (operationType == 0)
            {
                Requirement newRequirement = new Requirement();

                foreach (Feature f in formFeatureRepo.GetAll(selectedProject))
                {
                    if (f.Title == FeatureSelectionBox.Text)
                        newRequirement.FeatureId = f.Id;
                }
                newRequirement.Statement = StatementBox.Text;
                newRequirement.ProjectId = selectedProject;

                errorMessage = formRequirementRepo.Add(newRequirement);
            }

            else if (operationType == 1)
            {
                modifyRequirement.Statement = StatementBox.Text;
                foreach (Feature f in formFeatureRepo.GetAll(selectedProject))
                {
                    if (f.Title == FeatureSelectionBox.Text)
                        modifyRequirement.FeatureId = f.Id;

                    else
                        modifyRequirement.FeatureId = -1;
                }
                modifyRequirement.ProjectId = selectedProject;

                errorMessage = formRequirementRepo.Modify(modifyRequirement);
            }

            if (errorMessage != "")
                MessageBox.Show(errorMessage, "", MessageBoxButtons.OK);

            else
                Dispose();
        }

        private void FeatureSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Enabled = true;
            StatementBox.Enabled = true;
            CreateRequirementButton.Enabled = true;
        }
    }
}
