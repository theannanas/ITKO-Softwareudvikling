using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DankortAutomat
{
    internal class Konto {
        public Konto(Kunde kunde) {
            Transaktioner = new List<Transaktion>();
            Kunde = kunde;
        }
        public Kunde Kunde { get; private set; }

        public List<Transaktion> Transaktioner { get; private set; }

        public int Saldo() {
            return Transaktioner.Select(t => t.Beloeb).Sum();
        }

        public Transaktion HaevBeloeb(int beloeb) {
            return AddTransaktion(beloeb * -1);
        }

        public Transaktion IndsaetBeloeb(int beloeb) {
            return AddTransaktion(beloeb);
        }

        private Transaktion AddTransaktion(int beloeb) {
            var transaktion = new Transaktion(beloeb);
            Transaktioner.Add(transaktion);
            return transaktion;
        }
    }
}
