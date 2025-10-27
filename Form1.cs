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
        { "Kieliszek 50", 50 },
        { "Szklanka 250", 250 },
        { "Kufel 500", 500 }
    };

        private Dictionary<string, double> solutionTypes = new Dictionary<string, double>
    {
        { "Wódka 40%", 40 },
        { "Piwo 5.5%", 5.5 },
        { "Spirytus 96%", 96 }
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
