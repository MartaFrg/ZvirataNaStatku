using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZvirataNaStatku
{
    internal abstract class Zvire
    {
        internal string jmeno;
        public Zvire()
        {

        }
        public Zvire(string jmeno)
        {
            this.jmeno = jmeno;
        }
        public abstract string VypisZvire(Zvire zvire);
    }
}
