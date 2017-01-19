using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Anna luku > ");
                int luku = int.Parse(Console.ReadLine());


                if (luku != 0) ;
                int summa = int.Parse(Console.ReadLine());
                summa = luku + luku;

                Console.Write("Lukujen summa on " + summa + "\n");
            }
        }
    }
}
