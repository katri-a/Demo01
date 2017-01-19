using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask number
            int number;
            Console.Write("Anna pistemäärä > ");
            number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 0:
                    Console.WriteLine("Arvosana 0"); break;
                case 1:
                    Console.WriteLine("Arvosana 0"); break;
                case 2:
                    Console.WriteLine("Arvosana 1"); break;
                case 3:
                    Console.WriteLine("Arvosana 1"); break;
                case 4:
                    Console.WriteLine("Arvosana 2"); break;
                case 5:
                    Console.WriteLine("Arvosana 2"); break;
                case 6:
                    Console.WriteLine("Arvosana 3"); break;
                case 7:
                    Console.WriteLine("Arvosana 3"); break;
                case 8:
                    Console.WriteLine("Arvosana 4"); break;
                case 9:
                    Console.WriteLine("Arvosana 4"); break;
                case 10:
                    Console.WriteLine("Arvosana 5"); break;
                case 11:
                    Console.WriteLine("Arvosana 5"); break;
                case 12:
                    Console.WriteLine("Arvosana 5"); break;

                default: Console.WriteLine("Väärä pistemäärä."); break;
            }
        }
    }
}
