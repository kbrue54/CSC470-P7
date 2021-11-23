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
    public partial class FormSelectFeature : Form
    {
        public Feature _selectedFeature;
        AppUser _user;

        public FormSelectFeature(AppUser user)
        {
            InitializeComponent();
            _user = user;
            CenterToScreen();

            FakePreferenceRepository prefRepo = new FakePreferenceRepository();
            FakeFeatureRepositroy featureRepo = new FakeFeatureRepositroy();
            dataGridView1.DataSource = featureRepo.GetAll(Convert.ToInt32(prefRepo.GetPreference(_user.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID)));



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FakePreferenceRepository prefRepo = new FakePreferenceRepository();
            FakeFeatureRepositroy featureRepo = new FakeFeatureRepositroy();



            _selectedFeature = featureRepo.GetFeatureById(Convert.ToInt32(prefRepo.GetPreference(_user.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID)),
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
