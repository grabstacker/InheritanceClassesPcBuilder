using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProtecionModifiers
{
    
    //Type of Techonology to confirgure
    public abstract class Computer
    {
        //Setup Configuration variables
        private String brand;
        private double version;
        private double budget;
        //Create a string used to keep track of the Computer build config
        private string buildConfigurationString;

        //Getters and Setters
        public string Brand { get => brand; set => brand = value; }
        public double Version { get => version; set => version = value; }
        public double Budget { get => budget; set => budget = value; }
        public string BuildConfigurationString { get => buildConfigurationString; set => buildConfigurationString = value; }
    }

    // Combines all information for processing and printing the order 
    // to screen for a PC build
    public class PcBuild : Computer
    {

        //Class variable for computer type
        private string computerType;
        //Geter seter ComputerType
        public string ComputerType { get => computerType; set => computerType = value; }

        //Construtor for new Pc
        public PcBuild()
        {
            computerType = "PC";
        }

        //Adds to the Configuration string in inheriated Computer class
        public void ConfigurationBuildAdd(string SavedConfigText)
        {
            BuildConfigurationString = BuildConfigurationString + SavedConfigText + ". \n ";
        }


        //Prints the entire Configuration to screen
        public void ConfigfurationPrint()
        {
            System.Windows.Forms.MessageBox.Show(BuildConfigurationString);
        }

        //Notifies the user of the Current status of their order
        public string CurrentStatus()
        {
            if (BuildConfigurationString == "" || BuildConfigurationString == null)
            {
                
                return "We are still waiting on your " + ComputerType + " parts selection";
            }
            else {
                return "Your " + ComputerType + " order has been received and is currently being shipped! " + "\n" + BuildConfigurationString;
            }
            
        }
    }


}
