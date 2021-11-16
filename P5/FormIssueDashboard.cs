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
    public partial class FormIssueDashboard : Form
    {
        public FormIssueDashboard(AppUser appUser)
        {
            InitializeComponent();

           

            FakePreferenceRepository preferances = new FakePreferenceRepository();
            FakeIssueRepository issuesRepo = new FakeIssueRepository();
            string PID = preferances.GetPreference(appUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID);


            foreach (string issue in issuesRepo.GetIssuesByDiscoverer(Convert.ToInt32(PID)))
            {
                issuesByDiscoverer_listB.Items.Add(issue);
            }

            foreach (string issue in issuesRepo.GetIssuesByMonth(Convert.ToInt32(PID)))
            {
                IssuesByMonth_listB.Items.Add(issue);
            }

            totalIssues_lb.Text = "Total Number of Issues:     "  + issuesRepo.GetTotalNumberOfIssues(1).ToString();
        }

        




        private void close_bt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
