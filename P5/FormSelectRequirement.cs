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
    public partial class FormSelectRequirement : Form
    {
        AppUser _user = new AppUser();
        int FID;
        int PID;
        List<Requirement> reqs = new List<Requirement>();
        int _requirementID;

        public FormSelectRequirement()
        {
            InitializeComponent();
            CenterToScreen();

            FakePreferenceRepository preferenceRepo = new FakePreferenceRepository();
            FakeFeatureRepositroy featureRepo = new FakeFeatureRepositroy();
            PID = Convert.ToInt32(preferenceRepo.GetPreference(_user.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));
           

            foreach(Feature f in featureRepo.GetAll(PID))
            {
                comboBox1.Items.Add(f.Title);
            }

            label2.Enabled = false;
            dataGridView1.Enabled = false;
            button1.Enabled = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FakeRequirementRepository requirementRepo = new FakeRequirementRepository();

            reqs.Clear();

            foreach (Requirement r in requirementRepo.GetAll(PID))
            {
                if (r.FeatureId == FID)
                {
                    reqs.Add(r);
                }
            }

            dataGridView1.DataSource = reqs;

            if(comboBox1.Text != "<Make Selection>")
            {
                label2.Enabled = true;
                dataGridView1.Enabled = true;
                button1.Enabled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _requirementID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
