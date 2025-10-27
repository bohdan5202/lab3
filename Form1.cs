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
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double capacity;
                double persentage;

                if (!double.TryParse(TxtCapasity.Text, out capacity) || capacity <= 0)
                {
                    throw new FormatException("Please enter a valid positive number for capacity.");
                }

                if (!double.TryParse(Txt_pr.Text, out persentage) || persentage < 0 || persentage > 100)
                {
                    throw new FormatException("Please enter a valid percentage between 0 and 100.");
                }
                int itemCount = (int)Count.Value;

                double totalVolume = capacity * itemCount;
                double substanseVolume = totalVolume * (persentage / 100);

                lb_volume.Text = totalVolume.ToString("F2");
                lb_clearproduct.Text =substanseVolume.ToString("F2");

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Data Format Error");
            }
            catch (ArgumentOutOfRangeException ex)
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
