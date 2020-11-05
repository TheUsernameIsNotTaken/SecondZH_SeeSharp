//Extra Feladat

//Progcont: https://progcont.hu/progcont/100077/?pid=200639

using System;
using System.Collections.Generic;

namespace SecondZH
{
    //Hozzávaló segédosztály. Az azonos osztály példányai összehasonlíthatóak egymással.
    class Hozzavalo : IComparable<Hozzavalo>
    {
        string Anyag;
        int DB;

        //Egy hozzávaló egy anyagból és annak a mennyiségéből áll.
        public Hozzavalo(string anyag, int db)
        {
            this.Anyag = anyag;
            this.DB = db;
        }

        //Két hozzávaló darabszámának összeadása
        public void AddDB(Hozzavalo other)
        {
            DB += other.DB;
        }

        //Szöveggé alakítás a kívánt formában.
        public override string ToString()
        {
            return Anyag + ";" + DB;
        }

        //Összahasonlítás -> Rendezés mennyiség szerint fordítva, és név szerint növekvő sorrendben.
        public int CompareTo(Hozzavalo other)
        {
            if (DB != other.DB)
            {
                return other.DB.CompareTo(DB);
            }
            return Anyag.CompareTo(other.Anyag);
        }

        //2 hozzávaló egyenlősége - Contains használja.
        public override bool Equals(object obj)
        {
            return obj is Hozzavalo hozzavalo &&
                   Anyag == hozzavalo.Anyag;
        }
    }

    class Hozzavalok
    {
        static void Main(string[] args)
        {
            //Listába tárolom az elemeket.
            List<Hozzavalo> hozzavalok = new List<Hozzavalo>();
            string line;
            //Az összes sor beolvasása.
            while ((line = Console.ReadLine()) != null)
            {
                string[] data = line.Split(';');
                Hozzavalo hozzavalo = new Hozzavalo(data[0], int.Parse(data[1]));
                //Feltételes összeadás vagy hozzáadás a listához
                if (hozzavalok.Contains(hozzavalo))
                {
                    hozzavalok[hozzavalok.IndexOf(hozzavalo)].AddDB(hozzavalo);
                }
                else
                {
                    hozzavalok.Add(hozzavalo);
                }
            }
            //Rendezés. Csak List-nél van már implementálva, IList-nél nem.
            hozzavalok.Sort();
            //Elemek kiírása egyessével.
            foreach (Hozzavalo item in hozzavalok)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
