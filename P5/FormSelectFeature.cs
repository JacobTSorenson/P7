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
    public partial class FormSelectFeature : Form
    {
        private FakeFeatureRepository formFeatureRepo;
        private int selectedProject;
        private int operationType;
        private FakeRequirementRepository formRequirementRepo = new FakeRequirementRepository();
        public FormSelectFeature(FakeFeatureRepository featureRepo, int projectId, int type)
        {
            InitializeComponent();

            formFeatureRepo = featureRepo;
            selectedProject = projectId;
            operationType = type;
        }

        private void FormSelectFeature_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            DataTable features = new DataTable("Features");
            DataColumn c0 = new DataColumn("ID");
            DataColumn c1 = new DataColumn("Feature");
            features.Columns.Add(c0);
            features.Columns.Add(c1);

            DataRow row;

            foreach (Feature f in formFeatureRepo.GetAll(selectedProject))
            {
                row = features.NewRow();
                row["ID"] = f.Id;
                row["Feature"] = f.Title;

                features.Rows.Add(row);
            }

            FeatureList.DataSource = features;
            FeatureList.Columns[1].Width = FeatureList.Width - FeatureList.Columns[0].Width - 43;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void SelectFeatureButton_Click(object sender, EventArgs e)
        {
            Feature modifyFeature = new Feature();

            foreach (DataGridViewRow row in FeatureList.SelectedRows)
            {
                modifyFeature.Id = Int32.Parse(row.Cells[0].Value.ToString());
                modifyFeature.ProjectId = selectedProject;
                modifyFeature.Title = row.Cells[1].Value.ToString();
            }

            if (operationType == 0)
            {
                FormCreateFeature modifyForm = new FormCreateFeature(formFeatureRepo, selectedProject, 1, modifyFeature);
                modifyForm.ShowDialog();
                modifyForm.Dispose();
                Dispose();
            }

            else if (operationType == 1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove: " + modifyFeature.Title + "?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (Requirement r in formRequirementRepo.GetAll(selectedProject))
                    {
                        if (r.FeatureId == modifyFeature.Id)
                        {
                            DialogResult confirmResult = MessageBox.Show("There are one or more requirements associated with this feature.\nThese requirements will be destroyed if you remove this feature.\nAre you sure you want to remove: " + modifyFeature.Title + "?", "Confirmation", MessageBoxButtons.YesNo);
                            if (confirmResult == DialogResult.Yes)
                                formFeatureRepo.Remove(modifyFeature);

                            Dispose();
                        }
                    }

                    formFeatureRepo.Remove(modifyFeature);
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
