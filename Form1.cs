using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        private Dictionary<string, double> vesselTypes = new Dictionary<string, double>
    {
        { "Shot Glass (30ml)", 30 },
        { "Small Can (250ml)", 250 },
        { "Standard Can (330ml)", 330 },
        { "US Pint Glass (473ml)", 473 },
        { "UK Pint Glass (568ml)", 568 },
        { "Wine Glass (150ml)", 150 },
        { "Wine Bottle (750ml)", 750 },
        { "Spirit Bottle (1000ml)", 1000 },
        { "Tablespoon (15ml)", 15 }
    };

        private Dictionary<string, double> solutionTypes = new Dictionary<string, double>
    {
        { "Light Beer (4.2%)", 4.2 },
        { "Standard Beer (5.0%)", 5.0 },
        { "Craft IPA (7.5%)", 7.5 },
        { "Table Wine (13.5%)", 13.5 },
        { "Fortified Wine (e.g. Port) (20%)", 20 },
        { "Whiskey/Gin/Rum (40%)", 40 },
        { "Cask Strength Whiskey (60%)", 60 },
        { "Hand Sanitizer (70%)", 70 },
        { "Rubbing Alcohol (91%)", 91 }, 
        { "Saline Solution (0.9%)", 0.9 }
    };
        public Form1()
        {
            InitializeComponent();
            foreach (string vesselName in vesselTypes.Keys)
            {
                cBox_capasity.Items.Add(vesselName);
            }
            if (cBox_capasity.Items.Count > 0)
                cBox_capasity.SelectedIndex = 0;


            foreach (string solutionName in solutionTypes.Keys)
            {
                cBox_pr.Items.Add(solutionName);
            }
            if (cBox_pr.Items.Count > 0)
                cBox_pr.SelectedIndex = 0;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double capacity = vesselTypes[cBox_capasity.Text];
                double persentage = solutionTypes[cBox_pr.Text];
                ;

                //if (!double.TryParse(TxtCapasity.Text, out capacity) || capacity <= 0)
                //{
                //    throw new FormatException("Please enter a valid positive number for capacity.");
                //}

                //if (!double.TryParse(Txt_pr.Text, out persentage) || persentage < 0 || persentage > 100)
                //{
                //    throw new FormatException("Please enter a valid percentage between 0 and 100.");
                //}

                int itemCount = (int)Count.Value;
                if (itemCount <= 0)
                {
                    throw new ArgumentNullException("Please choose a valid number > 0");
                }

                double totalVolume = capacity * itemCount;
                double substanseVolume = totalVolume * (persentage / 100);

                lb_volume.Text = totalVolume.ToString("F2");
                lb_clearproduct.Text = substanseVolume.ToString("F2");

            }
            //catch (FormatException ex)
            //{
            //    MessageBox.Show(ex.Message, "Data Format Error");
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    MessageBox.Show(ex.Message, "Value Range Error");
            //}
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Value Range Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error Application");
            }
        }
    }
}
