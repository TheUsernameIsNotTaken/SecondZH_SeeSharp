using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondZH
{
    class Szotar
    {
        static void Main(string[] args)
        {
            
            //Ha IDictionary-t használok, akkor nincs ContainsValue, de a többi meglelhető mind.
            IDictionary<string, string> translate = new Dictionary<string, string>();
            translate.Add("alma", "apple");
            translate.Add("nagy", "big");
            translate.Add("finom", "delicious");
            Console.WriteLine("Van nagy? " + translate.ContainsKey("nagy"));
            if (translate.ContainsKey("nagy"))
            {
                translate["nagy"] = "huge";
            }
            string output;
            Console.WriteLine("nagy-" + translate.TryGetValue("nagy", out output));
            Console.WriteLine("Nagy angolul: " + output);
            Console.WriteLine("Kulcsok száma: " + translate.Count());
            //if (translate.ContainsValue("apple"))
            //{
            //	Console.WriteLine("Apple is present.");
            //}

            //Value lekérésének megpróbálása Key alapján
            //Ha sikeres, akkor az out változóba kerül. A sikeresség a visszatérési érték.
            output = "-semmi-";
            bool siker = translate.TryGetValue("kék", out output);
            Console.WriteLine("Kék: " + siker + " " + output);

            //Kiíratás
            Console.WriteLine(" - - A szótár: - - ");
            foreach (var item in translate)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}

