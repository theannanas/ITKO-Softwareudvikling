using System;
using System.Windows.Forms;

namespace BMIBeregner
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void cmdBeregnBMI_Click(object sender, EventArgs e) {
            /* Konverter hoejde og vægt fra tekst til tal */
            double hoejde = Convert.ToDouble(txtHoejde.Text);
            double vaegt = Convert.ToDouble(txtVaegt.Text);

            /* Beregn og vis BMI på skærmen */
            double bmi = vaegt / (hoejde * hoejde);
            txtBMI.Text = Convert.ToString(bmi);

            /* Beregn og vis min. vægt på skærmen */
            double minVaegt = MinVaegt(hoejde);
            txtMinVaegt.Text = Convert.ToString(minVaegt);

            /* Beregn og vis max. vægt på skærmen */
            double maxVaegt = MaxVaegt(hoejde);
            txtMaxVaegt.Text = Convert.ToString(maxVaegt);
        }

        private double MinVaegt(double hoejde) {
            double minBMI = 18.5;
            return BeregnVaegtForBmi(minBMI, hoejde);
        }

        private double MaxVaegt(double hoejde) {
            double maxVaegt = 25;
            return BeregnVaegtForBmi(maxVaegt, hoejde);
        }

        private double BeregnVaegtForBmi(double bmi, double hoejde) {
            return bmi * (hoejde * hoejde);
        }
    }
}
