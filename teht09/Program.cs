using System;
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
            int summa = 0;
            int luku = 1;

                Console.WriteLine("Anna luku > ");
                luku = int.Parse(Console.ReadLine());


                while (luku != 0) ;
                summa = int.Parse(Console.ReadLine());
                summa = summa + luku;

                Console.Write("Lukujen summa on " + summa + "\n");
            }
        }
    }

