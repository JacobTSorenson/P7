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
    public partial class FormCreateFeature : Form
    {
        private FakeFeatureRepository formFeatureRepo;
        private int selectedProject;
        private int operationType;
        private Feature modifyFeature;
        public FormCreateFeature(FakeFeatureRepository featureRepo, int project, int type, Feature feature)
        {
            InitializeComponent();

            formFeatureRepo = featureRepo;
            selectedProject = project;
            operationType = type;
            modifyFeature = feature;
        }

        private void FormCreateFeature_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            if (operationType == 1)
            {
                Text = "Modify Feature";
                CreateFeatureButton.Text = "Modify Feature";
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void CreateFeatureButton_Click(object sender, EventArgs e)
        {
            string errorMessage = "x";

            if (operationType == 0)
            {
                Feature newFeature = new Feature();

                newFeature.ProjectId = selectedProject;
                newFeature.Title = FeatureTitleBox.Text;
                errorMessage = formFeatureRepo.Add(newFeature);
            }

            else if (operationType == 1)
            {
                modifyFeature.Title = FeatureTitleBox.Text;
                errorMessage = formFeatureRepo.Modify(modifyFeature);
            }

            if (errorMessage != "")
                MessageBox.Show(errorMessage, "", MessageBoxButtons.OK);

            else
                Dispose();
        }
    }
}
