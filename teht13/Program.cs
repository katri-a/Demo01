using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna pisteet > ");
            int pisteet1 = int.Parse(Console.ReadLine());
            Console.Write("Anna pisteet > ");
            int pisteet2 = int.Parse(Console.ReadLine());
            Console.Write("Anna pisteet > ");
            int pisteet3 = int.Parse(Console.ReadLine());
            Console.Write("Anna pisteet > ");
            int pisteet4 = int.Parse(Console.ReadLine());
            Console.Write("Anna pisteet > ");
            int pisteet5 = int.Parse(Console.ReadLine());

            int[] kaikki_pisteet = { pisteet1, pisteet2, pisteet3, pisteet4, pisteet5 };

            int max = kaikki_pisteet.Max();
            int min = kaikki_pisteet.Min();
            int yhteensa = kaikki_pisteet.Sum();
            int kokonaispisteet = yhteensa - max - min;
            Console.WriteLine("Kokonaispisteet ovat: " + kokonaispisteet);
        }
    }
}
