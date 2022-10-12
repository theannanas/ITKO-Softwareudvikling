using System;
using System.Windows.Forms;

namespace SumBetween2Numbers
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void CmdBeregnSumAfTalMellem1Og200_Click(object sender, EventArgs e) {
            double sum = SumAfTalMellem1ogX(200);
            txtSumAfTalMellem1og200.Text = Convert.ToString(sum);
        }

        private void CmdBeregnSumAfTalMellem1ogX_Click(object sender, EventArgs e) {
            double x = Convert.ToDouble(txtX.Text);
            double sum = SumAfTalMellem1ogX(x);
            txtSumAfTalMellem1ogX.Text = Convert.ToString(sum);
        }

        private double SumAfTalMellem1ogX(double x) {
            // (x+1) * (x/2)
            /* Step 1 i video: beregn sum af par */
            double sumAfPar = x + 1;

            /* Step 2 i video: beregn antallet af par */
            double antalAfPar = x / 2;

            /* Step 3 i video: gang "sum af par" med "antal par" */
            return sumAfPar * antalAfPar;
        }

    }
}
