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
    public partial class FormModifyRequirement : Form
    {
        int RID;
        AppUser user;
        int PID;
        Requirement req;

        public FormModifyRequirement(int _RID, AppUser _user)
        {
            InitializeComponent();
            CenterToScreen();
            FakePreferenceRepository preferenceRepo = new FakePreferenceRepository();
            FakeFeatureRepositroy featureRepo = new FakeFeatureRepositroy();
            FakeRequirementRepository requirementRepo = new FakeRequirementRepository();


            RID = _RID;
            user = _user;
            PID = Convert.ToInt32(preferenceRepo.GetPreference(_user.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));
            req = requirementRepo.GetRequirementById(RID);

            comboBox1.Text = featureRepo.GetFeatureById(PID,req.FeatureId).Title;
            textBox1.Text = req.Statement;

            foreach (Feature f in featureRepo.GetAll(PID))
            {
                comboBox1.Items.Add(f.Title);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FakePreferenceRepository preferenceRepo = new FakePreferenceRepository();
            FakeFeatureRepositroy featureRepo = new FakeFeatureRepositroy();
            FakeRequirementRepository requirementRepo = new FakeRequirementRepository();
            Requirement rModify = new Requirement();

            rModify.Id = req.Id;
            rModify.ProjectId = PID;
            rModify.FeatureId = featureRepo.GetFeatureByTitle(PID, comboBox1.Text).Id;
            rModify.Statement = textBox1.Text;

            string Error = requirementRepo.Modify(rModify);

            DialogResult = DialogResult.OK;
            if (Error != FakeRequirementRepository.NO_ERROR)
            {
                MessageBox.Show(Error);
                DialogResult = DialogResult.Abort;
            }

            
            Close();


        }
    }
}
