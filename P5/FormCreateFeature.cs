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
    public partial class FormCreateFeature : Form
    {
        AppUser _user = new AppUser();


        public FormCreateFeature(AppUser user)
        {
            InitializeComponent();
            _user = user;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FakeFeatureRepositroy featureRepo = new FakeFeatureRepositroy();
            FakePreferenceRepository preferenceRepo = new FakePreferenceRepository();

            Feature feature = new Feature();
            feature.ProjectId = Convert.ToInt32(preferenceRepo.GetPreference(_user.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));
            feature.Title = textBox1.Text;
            feature.Id = featureRepo.GetAll(feature.ProjectId).Last().Id + 1;

            string Error = featureRepo.Add(feature);
            if (Error != FakeFeatureRepositroy.NO_ERROR)
            {
                MessageBox.Show(Error);
            }


        }
    }
}
