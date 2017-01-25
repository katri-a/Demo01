using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht16
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rand = new Random();

            int sLuku = rand.Next(0, 101);
            int arvaus = 0;
           
            while (sLuku != arvaus) {

                Console.WriteLine("Arvaa luku: ");
                 arvaus = int.Parse(Console.ReadLine());
                if (arvaus > sLuku)
                {
                    Console.Write("Luku on pienempi."); continue;
                }
                else if (arvaus < sLuku)
                {
                    Console.Write("Luku on suurempi."); continue;
                }
                else if (arvaus == sLuku)
                {
                    Console.Write("Arvasin oikein.");
                }
            }
        }
    }
}
