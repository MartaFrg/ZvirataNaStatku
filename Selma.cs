using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZvirataNaStatku
{
    internal class Selma : Zvire, IJeUzitecne
    {
        Druh druh;
        internal bool samice;

        public Selma(Druh druh) : base()
        {
            this.druh = druh;
        }
        public Selma(Druh druh, string jmeno) : base(jmeno)
        {
            this.druh = druh;
        }
        public string Obydli()
        {
            return "s lidmi na statku";       
        }

        public string Uzitek()
        {
            if (this.druh == Druh.Pes)
            {
                return "hlídá statek";
            }
            else
            {
                if (this.druh == Druh.Kočka)
                {
                    return "chytá myši";
                }
                else return "nemá zadán užitek";
            }
        }

        public override string VypisZvire(Zvire zvire)
        {
            return $"{druh} {Uzitek()} a bydlí {Obydli()}.";
        }

        internal enum Druh
        {
            Kočka,
            Pes,
        }
    }
}
