using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            float number1, number2, number3;
            Console.Write("Anna joku numero:  ");
            number1 = float.Parse(Console.ReadLine());

            Console.Write("Anna joku numero:  ");
            number2 = float.Parse(Console.ReadLine());

            Console.Write("Anna joku numero: ");
            number3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Numeroiden summa: " + (number1 + number2 + number3));
            Console.WriteLine("Numeroiden keskiarvo: " + ((number1 + number2 + number3) / 3));
        }
    }
}
