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
        PcBuild newBuild = new PcBuild();
       
        public btnStatus()
        {
            InitializeComponent();
        }

        //Changes the checked status of each box upon clicking either ither
        private void chkPC_CheckedChanged(object sender, EventArgs e)
        {
            chkMac.Checked = false;
            newBuild.ComputerType = "PC";
        }

        private void chkMac_CheckedChanged(object sender, EventArgs e)
        {
            chkPC.Checked = false;
            newBuild.ComputerType = "Mac";
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

                //assigns all of the values to the object which inherits from the Computer Class
                newBuild.ConfigurationBuildAdd(newBuild.ComputerType);

                newBuild.brand = txtBrand.Text;
                newBuild.ConfigurationBuildAdd(txtBrand.Text);

                newBuild.version = Convert.ToDouble(txtVersion.Text);
                newBuild.ConfigurationBuildAdd(txtVersion.Text);

                newBuild.budget = Convert.ToDouble(txtBudget.Text);
                newBuild.ConfigurationBuildAdd(txtBudget.Text);

                txtBuildInfo.Text = newBuild.buildConfigurationString.ToString();
            }
        }

        //calls current status method of the object we just created above and outputs to the textbox
        private void button1_Click(object sender, EventArgs e)
        {
            txtCurrentStatus.Text = newBuild.CurrentStatus();
        }

        private void txtVersion_TextChanged(object sender, EventArgs e)
        {


        }

        //check for double 
        private void txtBrand_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatting(sender,e);
        }
        private void txtBudget_KeyPress(object sender, KeyPressEventArgs e)
        {
            formatting(sender, e);
        }



        //Formatting method to check for double in both Brand and Version
        public void formatting(object sender, KeyPressEventArgs e)
        {
  
        }

 
    }
    }

