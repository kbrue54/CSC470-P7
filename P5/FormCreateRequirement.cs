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
    public partial class FormCreateRequirement : Form
    {
        AppUser _user = new AppUser();


        public FormCreateRequirement(AppUser user)
        {
            InitializeComponent();
            CenterToScreen();
            _user = user;
            FakeFeatureRepositroy featureRepo = new FakeFeatureRepositroy();
            FakePreferenceRepository preferenceRepo = new FakePreferenceRepository();

            int PID = Convert.ToInt32(preferenceRepo.GetPreference(_user.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));

            foreach(Feature f in featureRepo.GetAll(PID))
            {
                comboBox1.Items.Add(f.Title);
            }

            label2.Enabled = false;
            textBox1.Enabled = false;
            button1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FakePreferenceRepository preferenceRepo = new FakePreferenceRepository();
            FakeRequirementRepository requirementRepo = new FakeRequirementRepository();
            FakeFeatureRepositroy featureRepo = new FakeFeatureRepositroy();
            Requirement requirement = new Requirement();
            int PID = Convert.ToInt32(preferenceRepo.GetPreference(_user.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));

            requirement.Id = requirementRepo.GetAll(PID).Count + 1;
            requirement.ProjectId = PID;
            requirement.FeatureId = featureRepo.GetFeatureByTitle(PID,comboBox1.SelectedItem.ToString()).Id;
            requirement.Statement = textBox1.Text;


            string Error = requirementRepo.Add(requirement);


            if (Error != FakeRequirementRepository.NO_ERROR)
            {
                MessageBox.Show(Error);
            }
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text != "")
            {
                label2.Enabled = true;
                textBox1.Enabled = true;
                button1.Enabled = true;
            }
        }
    }
}
