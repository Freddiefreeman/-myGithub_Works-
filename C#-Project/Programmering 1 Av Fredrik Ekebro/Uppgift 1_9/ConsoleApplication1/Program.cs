using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.Write("Skriv in din början/slut: ");
            input = Console.ReadLine();
            int x = Convert.ToInt32(input);

            Console.Write("Skriv in din början/slut: ");
            input = Console.ReadLine();
            int y = Convert.ToInt32(input);

            for (int i = x; i <= y; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = x; i >= y; i--)
            {
                Console.WriteLine(i);
            }


            Console.ReadLine();
        }
    }
}
