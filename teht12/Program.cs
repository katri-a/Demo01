using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht12
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Anna luku > ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku 2 > ");
            int luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku 3 > ");
            int luku3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku 4 > ");
            int luku4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku 5 > ");
            int luku5 = int.Parse(Console.ReadLine());

            int[] luvut = { luku1, luku2, luku3, luku4, luku5 };

            for (int i = 4; i < luvut.Length; i--) Console.WriteLine("Luvut ovat: " + (luvut[i]));
          
        }
    }
}
