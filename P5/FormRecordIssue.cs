using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5
{
    public partial class FormRecordIssue : Form
    {
        int PID;
        public FormRecordIssue(AppUser appUser)
        {
            InitializeComponent();
            FakePreferenceRepository preferances = new FakePreferenceRepository();
            FakeIssueRepository issuesRepo = new FakeIssueRepository();
            FakeAppUserRepository usersRepo = new FakeAppUserRepository();
            FakeIssueStatusRepository issueStatusRepo = new FakeIssueStatusRepository();

            PID = Convert.ToInt32(preferances.GetPreference(appUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));
            List<AppUser> allUsers =usersRepo.GetAll();
            List<Issue> allIssues = issuesRepo.GetAll(PID);
            List<IssueStatus> allIssueStatus = issueStatusRepo.GetAll();
            

            Id_tb.Text = Convert.ToString(allIssues[allIssues.Count - 1].Id + 1);

            foreach(AppUser user in allUsers)
            {
                Discoverer_dd.Items.Add(user.FirstName + " " + user.LastName);
            }



            foreach(IssueStatus i in allIssueStatus)
            {
                status_dd.Items.Add(i.Value);
            }


        }


        private void FormRecordIssue_Load(object sender, System.EventArgs e)
        {
         

        }

        private void Cancel_bt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(title_tb.Text == "" || dateTimePicker1.Value > DateTime.Now || Discoverer_dd.Text == "" || status_dd.Text == "")
            {
                MessageBox.Show("Please fill out the form entirely!");  
            } else
            {
                FakeIssueStatusRepository issueStatusRepo = new FakeIssueStatusRepository();
                FakeIssueRepository issuesRepo = new FakeIssueRepository();
                issuesRepo.Add(new Issue
                {
                    Id = Convert.ToInt32(Id_tb.Text),
                    Title = title_tb.Text,
                    DiscoveryDate = dateTimePicker1.Value,
                    Discoverer = Discoverer_dd.SelectedItem.ToString(),
                    Component = Component_tb.Text,
                    IssueStatusId = issueStatusRepo.GetIdByStatus(status_dd.Text),
                    InitialDescription = Desc_tb.Text,
                    ProjectID = PID

                });

                Close();

            }
        }
    }
}
