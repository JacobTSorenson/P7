using System.Windows.Forms;
using Builder;

namespace P5
{
    public partial class FormMain : Form
    {
        private AppUser _CurrentAppUser = new AppUser();
        private int projectSelection;
        private FakeIssueRepository issueRepository = new FakeIssueRepository();
        private FakeFeatureRepository featureRepository = new FakeFeatureRepository();
        private FakeRequirementRepository requirementRepository = new FakeRequirementRepository();
        public FormMain()
        {
            InitializeComponent();
        }

        private void preferencesCreateProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCreateProject form = new FormCreateProject();
            form.ShowDialog();
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            CenterToScreen();
            // Force the user to login successfully or abort the application
            DialogResult isOK = DialogResult.OK;
            while (!_CurrentAppUser.IsAuthenticated && isOK == DialogResult.OK)
            {
                FormLogin login = new FormLogin();
                isOK = login.ShowDialog();
                _CurrentAppUser = login._CurrentAppUser;
                login.Dispose();
            }
            if (isOK != DialogResult.OK)
            {
                Close();
                return;
            }
            this.Text = "Main - No Project Selected";
            while (selectAProject() == "")
            {
                DialogResult result = MessageBox.Show("A project must be selected.", "Attention", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    Close();
                    return;
                }
            }
        }

        private void preferencesSelectProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            selectAProject();
        }

        private string selectAProject()
        {
            string selectedProject = "";
            FormSelectProject form = new FormSelectProject();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
                preferenceRepository.SetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_NAME,
                                                   form._SelectedProjectName);
                int selectedProjectId = form._SelectedProjectId;
                preferenceRepository.SetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_ID,
                                                   selectedProjectId.ToString());
                this.Text = "Main - " + form._SelectedProjectName;
                selectedProject = form._SelectedProjectName;
                projectSelection = form._SelectedProjectId;
            }
            form.Dispose();
            return selectedProject;
        }

        private void preferencesModifyProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormModifyProject form = new FormModifyProject(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void preferencesRemoveProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormRemoveProject form = new FormRemoveProject(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesDashboardToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            int issues = issueRepository.GetTotalNumberOfIssues(projectSelection);
            FormIssueDashboard form = new FormIssueDashboard(issues, issueRepository, projectSelection);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesRecordToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            int issues = issueRepository.GetNextId();
            FormCreateIssue form = new FormCreateIssue(issues, issueRepository, projectSelection);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesModifyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormSelectIssue form = new FormSelectIssue(issueRepository, projectSelection, 0);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesRemoveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormSelectIssue form = new FormSelectIssue(issueRepository, projectSelection, 1);
            form.ShowDialog();
            form.Dispose();
        }

        private void FeatureCreate_Click(object sender, System.EventArgs e)
        {
            FormCreateFeature form = new FormCreateFeature(featureRepository, projectSelection, 0, null);
            form.ShowDialog();
            form.Dispose();
        }

        private void FeatureModify_Click(object sender, System.EventArgs e)
        {
            FormSelectFeature form = new FormSelectFeature(featureRepository, projectSelection, 0);
            form.ShowDialog();
            form.Dispose();
        }

        private void FeatureRemove_Click(object sender, System.EventArgs e)
        {
            FormSelectFeature form = new FormSelectFeature(featureRepository, projectSelection, 1);
            form.ShowDialog();
            form.Dispose();
        }

        private void RequirementCreate_Click(object sender, System.EventArgs e)
        {
            FormCreateRequirement form = new FormCreateRequirement(requirementRepository, featureRepository, projectSelection, null, 0);
            form.ShowDialog();
            form.Dispose();
        }

        private void RequirementModify_Click(object sender, System.EventArgs e)
        {
            FormSelectRequirement form = new FormSelectRequirement(featureRepository, requirementRepository, projectSelection, 0);
            form.ShowDialog();
            form.Dispose();
        }

        private void RequirementRemove_Click(object sender, System.EventArgs e)
        {
            FormSelectRequirement form = new FormSelectRequirement(featureRepository, requirementRepository, projectSelection, 1);
            form.ShowDialog();
            form.Dispose();
        }
    }
}
