using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku > ");
            int luku = int.Parse(Console.ReadLine());
            int i, j;
            char star = {'*'};
            for (i = 0; i < luku; i++)
            {
                Console.WriteLine("*");

                for (j = 1; j < i; j++)
                {
                    i++;
                
                }
            }
        }
    }
}
