using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DankortAutomat
{
    internal class Transaktion
    {
        public Transaktion(int beloeb) {
            Beloeb = beloeb;
            DateTime = DateTime.Now;
        }

        public int Beloeb { get; private set; }

        public DateTime DateTime { get; private set; }

        public override string ToString() {
            return $"{DateTime} \t {Beloeb}";
        }
    }
}
