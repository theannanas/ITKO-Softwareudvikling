using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Måneder
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void btnStoarsteTal_Click(object sender, EventArgs e) {
            int max = InputMonths().Max();
            txtStoersteTal.Text = max.ToString();
        }

        private void btnMindsteTal_Click(object sender, EventArgs e) {
            int min = InputMonths().Min();
            txtMindsteTal.Text = min.ToString();
        }

        private void btnConvertToText_Click(object sender, EventArgs e) {
            bool success = int.TryParse(txtMaaned1.Text, out int month);
            if (success) {
                txtMaaned1.Text = MonthConverter.ConvertNumberToMonth(month);
            }
        }

        private void txtConvertToNumber_Click(object sender, EventArgs e) {
            bool success = int.TryParse(txtMaaned1.Text, out int month);
            if (!success) {
                int monthAsInt = MonthConverter.ConvertMonthToNumber(txtMaaned1.Text);
                txtMaaned1.Text = monthAsInt.ToString();
            }
        }

        private void btnMindstOgFrem_Click(object sender, EventArgs e) {
            int min = InputMonths().Min();

            List<string> months = new List<string>();
            for (int i = min+1; i <= 12; i++) {
                string month = MonthConverter.ConvertNumberToMonth(i);
                months.Add(month);
            }

            txtMindstOgFrem.Text = string.Join(", ", months);
        }

        private void btnStoerstOgTilbage_Click(object sender, EventArgs e) {
            int max = InputMonths().Max();

            List<string> months = new List<string>();
            for (int i = 1; i < max; i++) {
                string month = MonthConverter.ConvertNumberToMonth(i);
                months.Add(month);
            }

            txtStoerstOgTilbage.Text = string.Join(", ", months);
        }

        private int[] InputMonths() {
            return new int[] {
                Convert.ToInt32(txtMaaned1.Text),
                Convert.ToInt32(txtMaaned2.Text),
                Convert.ToInt32(txtMaaned3.Text),
                Convert.ToInt32(txtMaaned4.Text)
            };
        }

        private bool ValidateMonths(int[] months) {
            foreach (int m in months) {
                if (m < 0 || m < 12) return false; 
            }
            return true;
        }
    }
}
