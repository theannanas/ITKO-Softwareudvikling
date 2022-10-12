using System;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Regnemaskine
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        // Ulempe: afhængig af design fra UI
        private void btn_Click(object sender, EventArgs e) {
            Button btn = sender as Button;
            switch (btn.Text) {
                case "+":
                    CalculateAndShow((x, y) => x + y);
                    break;
                case "-":
                    CalculateAndShow((x, y) => x - y);
                    break;
                case "*":
                    CalculateAndShow((x, y) => x * y);
                    break;
                case "/":
                    CalculateAndShow((x, y) => x / y);
                    break;
                case "%":
                    CalculateAndShow((x, y) => x / 100 * y);
                    break;
                default:
                    throw new InvalidDataException();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e) {
            CalculateAndShow((x, y) => x + y);
        }

        private void btnSub_Click(object sender, EventArgs e) {
            CalculateAndShow((x, y) => x - y);
        }

        private void btnDiv_Click(object sender, EventArgs e) {
            CalculateAndShow((x, y) => x / y);
        }

        private void btnMul_Click(object sender, EventArgs e) {
            CalculateAndShow((x, y) => x * y);
        }

        private void btnProcent_Click(object sender, EventArgs e) {
            CalculateAndShow((x, y) => x/100 * y);
        }

        private void CalculateAndShow(Func<double, double, double> f) {
            double tal1 = Convert.ToDouble(txtTal1.Text);
            double tal2 = Convert.ToDouble(txtTal2.Text);
            double res = f(tal1, tal2); // tal1 = x, tal2 = y -> x*y
            lblRes.Text = res.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            txtTal1.Text = "";
            txtTal2.Text = "";
            lblRes.Text = "";
        }
    }
}
