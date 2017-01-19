using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Anna ikä: ");
            age = int.Parse(Console.ReadLine());

            if (age < 18)
                Console.WriteLine("Alaikäinen");
            else if (age >= 18 && age <= 65)
                Console.WriteLine("Aikuinen");
          
            else Console.WriteLine("Seniori");
           
        }
    }
}
