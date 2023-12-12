using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ZvirataNaStatku
{
    internal class Drubez : Zvire, IJeUzitecne
    {
        public Druh druh;
        public Drubez(Druh druh) : base()
        {
            this.druh = druh;
        }
        public string Uzitek()
        {
            return uzitek[this.druh];
        }
        public string Obydli()
        {
            return "v kurníku";
        }

        public override string VypisZvire(Zvire zvire)
        {
            return $"{druh} {Uzitek()} a bydlí {Obydli()}.";
        }
        internal static Dictionary<Druh, string> uzitek = new Dictionary<Druh, string>
        {
            { Druh.Kachna, "dává maso, vejce, peří" },
            { Druh.Slepice, "dává vejce"},
            { Druh.Husa, "dává peří" },
            {Druh.Krocan, "dává maso"  },
        };
        internal enum Druh
        {
            Kachna,
            Slepice,
            Husa,
            Krocan,
        }
    }
}
