using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DankortAutomat
{
    public partial class Form1 : Form
    {
        private readonly List<Kunde> kunder;
        private readonly List<Konto> konti;
        public Form1() {
            InitializeComponent();

            kunder = new List<Kunde> {
                new Kunde("1111", "Anja Andersen"),
                new Kunde("2222", "Bent Bentsen"),
                new Kunde("3333", "Chris Christensen"),
                new Kunde("4444", "Dan Dennissen"),
                new Kunde("5555", "Eva Estaldo")
            };

            konti = new List<Konto> {
                new Konto(kunder.Single(x => x.Pin == "1111")),
                new Konto(kunder.Single(x => x.Pin == "2222")),
                new Konto(kunder.Single(x => x.Pin == "3333")),
                new Konto(kunder.Single(x => x.Pin == "4444")),
                new Konto(kunder.Single(x => x.Pin == "5555")),
            };

            Random rnd = new Random();
            konti.ForEach(k => {
                int beloeb = rnd.Next(2500, 5600);
                k.IndsaetBeloeb(beloeb);
            });

        }

        private void btnTjekPin_Click(object sender, EventArgs e) {
            Kunde kunde = GetKundeBasedOnPin();
            if (kunde != null) {
                DisplayKunde(kunde);
            } else {
                ClearDisplay();
                MessageBox.Show("Pin er ikke korrekt");
            }
        }

        private void btn100_Click(object sender, EventArgs e) {
            UpdateBeloeb(100);
        }

        private void btn200_Click(object sender, EventArgs e) {
            UpdateBeloeb(200);
        }

        private void btn500_Click(object sender, EventArgs e) {
            UpdateBeloeb(500);
        }

        private void btn1000_Click(object sender, EventArgs e) {
            UpdateBeloeb(1000);
        }

        private void btnGodkend_Click(object sender, EventArgs e) {
            int beloeb = txtBeloeb.Text == string.Empty ? 
                0 : Convert.ToInt32(txtBeloeb.Text);
            Kunde kunde = GetKundeBasedOnPin();
            Konto konto = GetKundesKonto(kunde);

            konto.HaevBeloeb(beloeb);

            DisplayKunde(kunde);
            txtBeloeb.Text = string.Empty;

            MessageBox.Show($"Der er blevet hævet {beloeb} fra {kunde.Navn}s konto");
        }

        private void btnNulstil_Click(object sender, EventArgs e) {
            txtBeloeb.Text = string.Empty;
        }

        private void btnVisBevaegelser_Click(object sender, EventArgs e) {
            Kunde kunde = GetKundeBasedOnPin();
            DisplayKontoBevaegelser(kunde);
        }

        private void DisplayKunde(Kunde kunde) {
            DisplayKontoBevaegelser(kunde);
            DisplayKundesSaldo(kunde);
            txtNavn.Text = kunde.Navn;
        }

        private void DisplayKontoBevaegelser(Kunde kunde) {
            Konto konto = GetKundesKonto(kunde);

            var transOrdered = konto.Transaktioner.OrderByDescending(t => t.DateTime);
            txtKontobevaegelser.Text = string.Join(Environment.NewLine, transOrdered);
        }

        private void UpdateBeloeb(int kroner) {
            string old = txtBeloeb.Text;
            int oldBeloeb = old == string.Empty ? 0 : Convert.ToInt32(old);
            int newBeloeb = oldBeloeb + kroner;
            txtBeloeb.Text = newBeloeb.ToString();
        }

        private Kunde GetKundeBasedOnPin() {
            string pin = txtPin.Text;
            Kunde kunde = kunder.SingleOrDefault(x => x.Pin == pin);
            return kunde;
        }
        private Konto GetKundesKonto(Kunde kunde) {
            return konti.SingleOrDefault(ko => ko.Kunde == kunde);
        }

        private void DisplayKundesSaldo(Kunde kunde) {
            var kundesKonto = GetKundesKonto(kunde);
            var saldo = kundesKonto.Saldo();
            txtSaldo.Text = saldo.ToString();
        }

        private void ClearDisplay() {
            txtSaldo.Text = string.Empty;
            txtNavn.Text = string.Empty;
            txtBeloeb.Text = string.Empty;
            txtKontobevaegelser.Text = string.Empty;
            txtPin.Text = string.Empty;
        }
    }
}
