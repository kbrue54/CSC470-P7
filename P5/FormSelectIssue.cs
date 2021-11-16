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
    public partial class FormSelectIssue : Form
    {
        public FormSelectIssue(AppUser appUser)
        {
            InitializeComponent();

            FakePreferenceRepository preferances = new FakePreferenceRepository();
            FakeIssueRepository issuesRepo = new FakeIssueRepository();
            string PID = preferances.GetPreference(appUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID);

            dataGridView1.DataSource = issuesRepo.GetAll(Convert.ToInt32(PID));


            foreach (Issue issue in issuesRepo.GetAll(Convert.ToInt32(PID)))
            {
            }
        }
    }
}
