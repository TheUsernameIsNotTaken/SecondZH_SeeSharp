//A jelenlegi gyakorló feladatsor feladata

//Progcont: https://progcont.hu/progcont/100355/?pid=201302

using System;
using System.Collections.Generic;
using System.Linq;

namespace SecondZH
{
    class Lego
    {
        //A szükséges propery-k
        public int Termékkód { get; set; }
        public string Szett_neve { get; set; }
        public string Téma_neve { get; set; }
        public int Elemek_száma { get; set; }

        //Egy új szett példányosítása.
        public Lego(int termékkód, string szett_neve, string téma_neve, int elemek_száma)
        {
            Termékkód = termékkód;
            Szett_neve = szett_neve;
            Téma_neve = téma_neve;
            Elemek_száma = elemek_száma;
        }

        //A példány szöveggé alakítva a kívánt formátumban.
        public override string ToString()
        {
            return Szett_neve + " (" + Termékkód + "): " + Elemek_száma + " - " + Téma_neve;
        }
    }

    class LegoKeszletek
    {
        static void Main(string[] args)
        {
            //Beolvasandó sorok száma
            int n = int.Parse(Console.ReadLine());
            IList<Lego> készletek = new List<Lego>();
            //Sorok beolvasása
            for (int i = 0; i < n; i++)
            {
                string[] adat = Console.ReadLine().Split(';');
                készletek.Add(new Lego(int.Parse(adat[0]), adat[1], adat[2], int.Parse(adat[3])));
            }
            //Kiíratás az első rendezéssel
            foreach (var készlet in készletek.OrderByDescending(x => x.Elemek_száma)
                .ThenBy(x => x.Téma_neve)
                .ThenBy(x => x.Szett_neve)
                .ThenBy(x => x.Termékkód))
            {
                Console.WriteLine(készlet.ToString());
            }
            //Üres sor
            Console.WriteLine();
            //Kiíratás a 2. rendezéssel
            foreach (var készlet in készletek.OrderBy(x => x.Téma_neve)
                .ThenBy(x => x.Szett_neve)
                .ThenBy(x => x.Termékkód))
            {
                Console.WriteLine(készlet.ToString());
            }
        }
    }
}
