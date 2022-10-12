using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kodemaskine
{
    public partial class Form1 : Form
    {
        private readonly char[] alphaUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅ".ToCharArray();
        private readonly char[] alphaLower = "abcdefghijklmnopqrstuvwxyzæøå".ToCharArray();
        public Form1() {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e) {
            txtOutput.Text = Code(Encode, txtInput.Text);
        }

        private void btnDecode_Click(object sender, EventArgs e) {
            txtOutput.Text = Code(Decode, txtInput.Text);
        }

        private string Code(Func<char[], char, char> kod, string text) {
            StringBuilder sb = new StringBuilder();
            foreach (char c in text) {
                if (alphaLower.Contains(c)) {
                    sb.Append(kod(alphaLower, c));
                } else if (alphaUpper.Contains(c)) {
                    sb.Append(kod(alphaUpper, c));
                } else {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private char Encode(char[] arr, char c) {
            int tal = Convert.ToInt32(txtTal.Text);
            var index = Array.IndexOf(arr, c);
            var newIndex = (index + tal) % arr.Length;
            return arr[newIndex];
        }
        private char Decode(char[] arr, char c) {
            int tal = Convert.ToInt32(txtTal.Text);
            var index = Array.IndexOf(arr, c);
            var newIndex = (index - tal) % arr.Length;
            if (newIndex < 0 )
                newIndex = arr.Length - (newIndex * -1);
            return arr[newIndex];
        }
    }
}
