using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ZvirataNaStatku
{
    internal class Skot:Zvire, IJeUzitecne
    {
        internal bool davaMleko;
        internal Druh druh;
        internal bool samice;
        public Skot(Druh druh)
        {
            this.druh = druh;
        }

        public Skot(Druh druh, string jmeno) : base(jmeno)
        {
            this.druh = druh;
        }

        public string Obydli()
        {
            if (this.druh == Druh.Krava || this.druh == Druh.Koza || this.druh == Druh.Ovce) return "v chlévě";
            if (this.druh == Druh.Kun || this.druh == Druh.Osel) return "ve stáji";
            return "neznámo kde";
        }

        public string Uzitek()
        {
            return uzitek[this.druh];
        }

        public override string VypisZvire(Zvire zvire)
        {
            return $"{druh} {Uzitek()} a bydlí {Obydli()}.";
        }

        internal static Dictionary<Druh, string> uzitek = new Dictionary<Druh, string> 
        {
            { Druh.Krava, "dává mléko" }, 
            { Druh.Koza, "dává sýry"}, 
            { Druh.Kun, "slouží k ježdění" },
            {Druh.Ovce, "dává vlnu"  },
            { Druh.Osel, "slouží k ježdění" }
        };
        internal enum Druh
        {
            Krava,
            Koza,
            Kun,
            Ovce,
            Osel
        }
    }
}
