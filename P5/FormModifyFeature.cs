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
        Feature _feature;
        public FormModifyFeature(Feature feature)
        {
            InitializeComponent();
            _feature = feature;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FakeFeatureRepositroy featureRepo = new FakeFeatureRepositroy();
            _feature.Title = textBox1.Text;

            string Error = featureRepo.Modify(_feature);

            if( Error != FakeFeatureRepositroy.NO_ERROR)
            {
                MessageBox.Show(Error);
            }
        }
    }
}
