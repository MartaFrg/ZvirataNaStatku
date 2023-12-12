using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZvirataNaStatku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Statek velkyStatek = new Statek();
            velkyStatek.zvirataNaStatku.Add(new Skot(Skot.Druh.Koza, "Líza") { samice = true, davaMleko = true});
            velkyStatek.zvirataNaStatku.Add(new Skot(Skot.Druh.Osel, "Toník"));
            velkyStatek.zvirataNaStatku.Add(new Selma(Selma.Druh.Kočka, "Elsa"));
            velkyStatek.zvirataNaStatku.Add(new Selma(Selma.Druh.Pes, "Baron"));
            velkyStatek.zvirataNaStatku.Add(new Skot(Skot.Druh.Kun, "Samuel"));
            velkyStatek.zvirataNaStatku.Add(new Skot(Skot.Druh.Krava));
            velkyStatek.zvirataNaStatku.Add(new Skot(Skot.Druh.Osel));
            velkyStatek.zvirataNaStatku.Add(new Drubez(Drubez.Druh.Slepice));
            velkyStatek.zvirataNaStatku.Add(new Drubez(Drubez.Druh.Husa));
            velkyStatek.zvirataNaStatku.Add(new Drubez(Drubez.Druh.Kachna));
            velkyStatek.zvirataNaStatku.Add(new Drubez(Drubez.Druh.Krocan));
            velkyStatek.zvirataNaStatku.Add(new Skudce("Potkan"));

            velkyStatek.lideNaStatku.Add(new Clovek("Libor", "spravuje traktory"));
            velkyStatek.lideNaStatku.Add(new Clovek("Hana", "pečuje o zvířata"));



            foreach (Zvire zvire in velkyStatek.zvirataNaStatku)
            {
                Console.WriteLine(zvire.VypisZvire(zvire));
            }
            Console.WriteLine();
            foreach (Clovek clovek in velkyStatek.lideNaStatku)
            {
                Console.WriteLine(clovek.VypisCloveka());
            }

        }
    }
}
