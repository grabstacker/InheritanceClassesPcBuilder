using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceProtecionModifiers
{
    public partial class btnStatus : Form
    {
        //Creates a new PcBuild which inherits from the Computer class all of the private variables through setters and getters
        PcBuild newBuild = new PcBuild("PC");

        public btnStatus()
        {
            InitializeComponent();
        }

        //Changes the checked status of each box upon clicking either ither
        private void chkPC_CheckedChanged(object sender, EventArgs e)
        {
            chkMac.Checked = false;
        }

        private void chkMac_CheckedChanged(object sender, EventArgs e)
        {
            chkPC.Checked = false;
        }


        //submiit button which checks for vaild info and sets the object data
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (txtBrand.Text == "" || txtVersion.Text == "" || txtBudget.Text == "")
            {
                MessageBox.Show("Please enter the required information");
            }
            else
            {
                
                newBuild.Brand = txtBrand.Text;
                newBuild.ConfigurationBuildAdd(txtBrand.Text);

                newBuild.Version = Convert.ToDouble(txtVersion.Text);
                newBuild.ConfigurationBuildAdd(txtVersion.Text);

                newBuild.Budget = Convert.ToDouble(txtBudget.Text);
                newBuild.ConfigurationBuildAdd(txtBudget.Text);

                txtBuildInfo.Text = newBuild.BuildConfigurationString;
            }
        }

        //calls current status method of the object we just created above and outputs to the textbox
        private void button1_Click(object sender, EventArgs e)
        {
            txtCurrentStatus.Text = newBuild.CurrentStatus();
        }
    }
}
