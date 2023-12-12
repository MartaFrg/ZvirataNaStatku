using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZvirataNaStatku
{
    internal class Statek
    {
        internal List<Zvire> zvirataNaStatku;
        internal List<Clovek> lideNaStatku;
        public Statek()
        {
            zvirataNaStatku= new List<Zvire>();
            lideNaStatku=new List<Clovek>();
        }
    }
}
