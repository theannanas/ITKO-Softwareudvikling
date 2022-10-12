using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DankortAutomat
{
    internal class Kunde
    {
        public Kunde(string pin, string navn) {
            Pin = pin;
            Navn = navn;
        }
        public string Pin { get; private set; }
        public string Navn { get; private set; }

    }
}
