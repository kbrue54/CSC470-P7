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

    public partial class FormModifyIssue : Form
    {
        int PID;
        int IID;

        public FormModifyIssue(AppUser appUser, int ID)
        {
            InitializeComponent();
            this.CenterToScreen();
            FakePreferenceRepository preferances = new FakePreferenceRepository();
            FakeIssueRepository issuesRepo = new FakeIssueRepository();
            FakeAppUserRepository usersRepo = new FakeAppUserRepository();
            FakeIssueStatusRepository issueStatusRepo = new FakeIssueStatusRepository();

            PID = Convert.ToInt32(preferances.GetPreference(appUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));
            IID = ID;
            List<AppUser> allUsers = usersRepo.GetAll();
            List<IssueStatus> allIssueStatus = issueStatusRepo.GetAll();
            Issue issue = issuesRepo.GetIssuesByID(IID);

            foreach (AppUser user in allUsers)
            {
                Discoverer_cb.Items.Add(user.FirstName + " " + user.LastName);
            }

            foreach (IssueStatus i in allIssueStatus)
            {
                status_cb.Items.Add(i.Value);
            }

            ID_tb.Text = ID.ToString();
            Title_tb.Text = issue.Title;
            dateTimePicker1.Value = issue.DiscoveryDate;
            Discoverer_cb.SelectedItem = issue.Discoverer;
            component_tb.Text = issue.Component;
            status_cb.SelectedItem = issueStatusRepo.GetValueById(issue.IssueStatusId);
            desc_tb.Text = issue.InitialDescription;
        }

        private void FormModifyIssue_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Title_tb.Text == "" || dateTimePicker1.Value > DateTime.Now || Discoverer_cb.Text == "" || status_cb.Text == "")
            {
                MessageBox.Show("Please fill out the form entirely!");
            }
            else
            {
                FakeIssueStatusRepository issueStatusRepo = new FakeIssueStatusRepository();
                FakeIssueRepository issuesRepo = new FakeIssueRepository();
                issuesRepo.Modify(new Issue
                {
                    Id = Convert.ToInt32(ID_tb.Text),
                    Title = Title_tb.Text,
                    DiscoveryDate = dateTimePicker1.Value,
                    Discoverer = Discoverer_cb.SelectedItem.ToString(),
                    Component = component_tb.Text,
                    IssueStatusId = issueStatusRepo.GetIdByStatus(status_cb.Text),
                    InitialDescription = desc_tb.Text,
                    ProjectID = PID

                });

                Close();




            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
