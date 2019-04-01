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
        public string brand { get; set; }
        
        public double version { get; set; }
      
        public double budget { get; set; }
        //Create a string used to keep track of the Computer build config
       public StringBuilder buildConfigurationString = new StringBuilder();
    

        //Getters and Setters

        
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
             buildConfigurationString.Append(SavedConfigText + ". \n ");
        }


        //Prints the entire Configuration to screen
        public void ConfigfurationPrint()
        {
            System.Windows.Forms.MessageBox.Show(buildConfigurationString.ToString());
        }

        //Notifies the user of the Current status of their order
        public string CurrentStatus()
        {
            if (buildConfigurationString.ToString() == "" || buildConfigurationString == null)
            {
                
                return "We are still waiting on your " + ComputerType + " parts selection";
            }
            else {
                return "Your " + ComputerType + " order has been received and is currently being shipped! " + "\n" + buildConfigurationString;
            }
            
        }
    }


}
