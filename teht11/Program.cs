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
            for (int i = 0; i <= luku; i++)
            {
                
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
               
                }
                Console.Write('\n'); //muuten tulostaa samalle riville
            }
        }
    }
}


