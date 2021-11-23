using System.Windows.Forms;
using System;

namespace P5
{
    public partial class FormMain : Form
    {
        private AppUser _CurrentAppUser = new AppUser();
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
            this.CenterToScreen();
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
            FormIssueDashboard form = new FormIssueDashboard(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesRecordToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormRecordIssue form = new FormRecordIssue(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesModifyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormSelectIssue form = new FormSelectIssue(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();

            if (form.DialogResult == DialogResult.OK)
            {
                FormModifyIssue form2 = new FormModifyIssue(_CurrentAppUser, form._selectedIssueID);
                form2.ShowDialog();
                form2.Dispose();
            }
        }

        private void issuesRemoveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormSelectIssue form = new FormSelectIssue(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();

            if( form.DialogResult == DialogResult.OK)
            {
                FakeIssueRepository issuesRepo = new FakeIssueRepository();
                DialogResult result = MessageBox.Show("Are you sure you want to remove?", "Confirmation" + issuesRepo.GetIssuesByID(form._selectedIssueID).Title, MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    issuesRepo.Remove(issuesRepo.GetIssuesByID(form._selectedIssueID));
                } else
                {
                    MessageBox.Show("Remove Canceled.");
                }
            }
        }

        private void createToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCreateFeature form = new FormCreateFeature(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void modifyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FakePreferenceRepository prefRepo = new FakePreferenceRepository();
            FormSelectFeature form = new FormSelectFeature(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();

            if (form.DialogResult == DialogResult.OK)
            {
                FakeFeatureRepositroy featureRepo = new FakeFeatureRepositroy();
                FormModifyFeature form2 = new FormModifyFeature(featureRepo.GetFeatureById(Convert.ToInt32(prefRepo.GetPreference(_CurrentAppUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID)), form._selectedFeature.Id));
                form2.ShowDialog();
                form2.Dispose();
            }
         
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectFeature form = new FormSelectFeature(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();

            if (form.DialogResult == DialogResult.OK)
            {
                FakeFeatureRepositroy featureRepo = new FakeFeatureRepositroy();
                FakeRequirementRepository requirementRepo = new FakeRequirementRepository();
                DialogResult result = MessageBox.Show("Are you sure you want to remove: " + featureRepo.GetFeatureById(form._selectedFeature.ProjectId, form._selectedFeature.Id).Title, "Confirmation" , MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes && requirementRepo.CountByFeatureId(form._selectedFeature.Id) != 0)
                {
                    result = MessageBox.Show("There are one or more requirements associated with this feature.  These requirements will be destroyed if you remove this feature.  Are you sure you want to remove " +
                        featureRepo.GetFeatureById(form._selectedFeature.ProjectId, form._selectedFeature.Id).Title, "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        featureRepo.Remove(featureRepo.GetFeatureById(form._selectedFeature.ProjectId, form._selectedFeature.Id));
                        requirementRepo.RemoveByFeatureId(form._selectedFeature.Id);
                    }
                    else
                    {
                        MessageBox.Show("Remove Canceled.");
                    }
                }
                else if(result == DialogResult.Yes)
                {
                    featureRepo.Remove(featureRepo.GetFeatureById(form._selectedFeature.ProjectId, form._selectedFeature.Id));

                    MessageBox.Show("Remove Canceled.");
                }
                else
                {
                    MessageBox.Show("Remove Canceled.");
                }
            }


        }
    }
}
