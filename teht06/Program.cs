using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            double kulutus = 7.02;
            double bensa = 1.595;
            double matka;
            Console.Write("Anna matka > ");
            matka = int.Parse(Console.ReadLine());
       
            double litrat = matka / 100;

            
            Console.Write("Bensaa kuluu " + kulutus*litrat + " litraa, " + " kustannus " + bensa*(kulutus*litrat) + " euroa.");
        }
    }
}
