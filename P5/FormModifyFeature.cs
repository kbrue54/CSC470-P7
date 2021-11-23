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
    public partial class FormModifyFeature : Form
    {
        Feature f = new Feature();
        public FormModifyFeature(Feature feature)
        {
            InitializeComponent();
            CenterToScreen();
            f = feature;
            textBox1.Text = feature.Title;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Feature temp = new Feature();
            temp.Title = textBox1.Text;
            temp.Id = f.Id;
            temp.ProjectId = f.ProjectId;
            FakeFeatureRepositroy featureRepo = new FakeFeatureRepositroy();
            

            string Error =  featureRepo.Modify(temp);
            DialogResult = DialogResult.OK;

            if (Error != FakeFeatureRepositroy.NO_ERROR)
            {
                MessageBox.Show(Error);
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
