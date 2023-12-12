using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZvirataNaStatku
{
    internal class Clovek : IJeUzitecne
    {
        string uzitek;
        string jmeno;
        public Clovek(string jmeno, string uzitek)
        {
            this.jmeno = jmeno;
            this.uzitek = uzitek;
        }
        public string VypisCloveka()
        {
            return $"{this.jmeno} {this.uzitek} a bydlí {Obydli()}.";
        }

        public string Obydli()
        {
            return "na statku";
        }

        public string Uzitek()
        {
           return uzitek;
        }
    }
}
