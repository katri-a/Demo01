using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            int sekunnit;
            Console.Write("Anna sekunnit: ");
            sekunnit = int.Parse(Console.ReadLine());

            int tunti = sekunnit / 3600;
            int min = sekunnit / 60 - tunti*60;
            int sek = sekunnit % 60;
                Console.WriteLine("Antamasi sekuntimäärä voidaan ilmaista muodossa: " + tunti + " tuntia " + min + " minuuttia " + sek + " sekuntia");
            }
            
        }

        }
