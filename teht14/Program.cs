using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht14
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku0 = 0;
            int luku1 = 0;
            int luku2 = 0;
            int luku3 = 0;
            int luku4 = 0;
            int luku5 = 0;
            int arvosana = 0;


            while (arvosana < 6)
            {
                Console.Write("Anna arvosana 0-5 (lopeta ohjelma painamalla muuta) > ");
                arvosana = int.Parse(Console.ReadLine());


                switch (arvosana)
                {
                    case 0:
                        luku0++;
                        break;

                    case 1:
                        luku1++;
                        break;

                    case 2:
                        luku2++;
                        break;

                    case 3:
                        luku3++;
                        break;

                    case 4:
                        luku4++;
                        break;

                    case 5:
                        luku5++;
                        break;

                    default:
                        Console.WriteLine("--Loppu-- ");
                        break;
                }
            }

            Console.WriteLine("Arvosanat:");
            for (int i = 0; i < 6; i++)
            {
                int[] jakauma = { luku0, luku1, luku2, luku3, luku4, luku5 };
                Console.WriteLine(i + " : " + String.Concat(Enumerable.Repeat("*", jakauma[i])));

            }
        }
    }
}
