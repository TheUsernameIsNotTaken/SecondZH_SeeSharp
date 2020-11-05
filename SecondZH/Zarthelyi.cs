//Feladatok a múltból - 1

//Progcont: https://progcont.hu/progcont/100306/?pid=201391

using System;
using System.Collections.Generic;
using System.Linq;

namespace SecondZH
{
    class Zarthelyi
    {

        static void Main(string[] args)
        {

            IDictionary<string, ISet<int>> dict = new SortedDictionary<string, ISet<int>>();

            string row = Console.ReadLine();
            while (row != null)
            {
                string[] datas = row.Split(';');
                ISet<int> value;
                bool init = dict.TryGetValue(datas[0], out value);
                if (init == false)
                {
                    value = new SortedSet<int>();
                    dict[datas[0]] = value;
                }
                if (datas[2] == "PASS")
                {
                    value.Add(int.Parse(datas[1]));
                }
                row = Console.ReadLine();
            }
            
            //foreach (var entry in dict)                     // anonim tipizálás - a var kulcsszóval helyettesítjük a típust
            //{
            //    Console.WriteLine(entry.Key + ": " + (entry.Value.Count > 0 ? string.Join(", ", entry.Value) : "NOTHING"));
            //}

            dict.ToList().ForEach(p => Console.WriteLine(p.Key + ": " + (p.Value.Count > 0 ? string.Join(", ", p.Value) : "NOTHING")));
        }
    }
}
