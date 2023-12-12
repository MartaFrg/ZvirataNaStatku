using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZvirataNaStatku
{
    internal class Skudce : Zvire, ISkodi
    {
        public Skudce(string jmeno):base(jmeno) { }

        public string CimSkodi()
        {
            return "škodí";
        }

        public override string VypisZvire(Zvire zvire)
        {
            return $"{jmeno} {CimSkodi()}.";
        }
    }
}
