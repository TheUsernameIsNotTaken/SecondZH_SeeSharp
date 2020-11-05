//Feladatok a múltból - 2

//Progcont: https://progcont.hu/progcont/100317/?pid=201428

using System;
using System.Collections.Generic;

namespace SecondZH
{
    class Tartozasok
    {
        static void Main(string[] args)
        {
            //Tárolás módja: Dupla táblázat
            IDictionary<string, IDictionary<string, int>> tartozások = new SortedDictionary<string, IDictionary<string, int>>();
            //Sorok beolvasása
            string sor;
            while ((sor = Console.ReadLine()) != null)
            {
                //Sor Összes elemének feldolgozása
                string[] adat = sor.Split(';');
                string hitelező = adat[0];
                int összeg = int.Parse(adat[1]);
                for (int i = 2; i < adat.Length; i++)
                {
                    string tartozó = adat[i];
                    //Az adóshoz tartozó tartozások lekérése
                    IDictionary<string, int> tartozóAdatai;
                    if (!tartozások.TryGetValue(tartozó, out tartozóAdatai))
                    {
                        tartozóAdatai = new SortedDictionary<string, int>();
                        tartozások[tartozó] = tartozóAdatai;
                    }
                    //Az adott hitelező felé vonatkozó tartozás.
                    int tartozás;
                    if (!tartozóAdatai.TryGetValue(hitelező, out tartozás))
                    {
                        tartozás = 0;
                    }
                    //A tartozás növelése.
                    tartozóAdatai[hitelező] = tartozás + összeg;
                }
            }

            //Kiíratás
            foreach (var f_l_item in tartozások)
            {
                foreach (var s_l_item in f_l_item.Value)
                {
                    Console.WriteLine(f_l_item.Key + " => " + s_l_item.Key + ": " + s_l_item.Value);
                }
            }
        }
    }
}
