using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("Skriv in det första talet");
            input = Console.ReadLine();
            int x = Convert.ToInt32(input);

            Console.WriteLine("Skriv in det andra talet");
            input = Console.ReadLine();
            int y = Convert.ToInt32(input);

            if (x > y)
            {
                Console.WriteLine("Det första är störst");
            }
            else if (x < y)
            {
                Console.WriteLine("De är andra är störst");
            }
            else
            {
                Console.WriteLine("De är lika stora");
            }

            Console.ReadLine();
        }
    }
}
