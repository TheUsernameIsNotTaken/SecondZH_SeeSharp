//Extra Feladat

//Progcont: https://progcont.hu/progcont/100077/?pid=200639

using System;
using System.Collections.Generic;

namespace SecondZH
{
    class Hozzavalo : IComparable<Hozzavalo>
    {
        string anyag;
        int db;

        public Hozzavalo(string anyag, int db)
        {
            this.anyag = anyag;
            this.db = db;
        }

        //Két hozzávaló darabszámának összeadása
        public void AddDB(Hozzavalo other)
        {
            db += other.db;
        }

        public override string ToString()
        {
            return anyag + ";" + db;
        }

        public int CompareTo(Hozzavalo other)
        {
            if (db != other.db)
            {
                return other.db.CompareTo(db);
            }
            return anyag.CompareTo(other.anyag);
        }

        public override bool Equals(object obj)
        {
            return obj is Hozzavalo hozzavalo &&
                   anyag == hozzavalo.anyag;
        }

        public override int GetHashCode()
        {
            return 60720897 + EqualityComparer<string>.Default.GetHashCode(anyag);
        }
    }

    class Hozzavalok
    {
        //static void Main(string[] args)
        //{
        //    //Listába tárolom az elemeket.
        //    List<Hozzavalo> hozzavalok = new List<Hozzavalo>();
        //    string line;
        //    //Az összes sor beolvasása.
        //    while ((line = Console.ReadLine()) != null)
        //    {
        //        string[] data = line.Split(';');
        //        Hozzavalo hozzavalo = new Hozzavalo(data[0], int.Parse(data[1]));
        //        //Feltételes összeadás vagy hozzáadás a listához
        //        if (hozzavalok.Contains(hozzavalo))
        //        {
        //            hozzavalok[hozzavalok.IndexOf(hozzavalo)].AddDB(hozzavalo);
        //        }
        //        else
        //        {
        //            hozzavalok.Add(hozzavalo);
        //        }
        //    }
        //    //Rendezés. Csak List-nél van már implementálva, IList-nél nem.
        //    hozzavalok.Sort();
        //    //Elemek kiírása egyessével.
        //    foreach (Hozzavalo item in hozzavalok)
        //    {
        //        Console.WriteLine(item.ToString());
        //    }
        //}
    }
}
