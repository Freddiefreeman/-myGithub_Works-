using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bas
            Console.Write("Skriv in basen på din triangle: ");
            string input = Console.ReadLine();
            int bas = Convert.ToInt32(input);
            //Höjd
            Console.Write("Skriv in höjden på din triangle: ");
            input = Console.ReadLine();
            int height = Convert.ToInt32(input);

            int area = (bas * height) / 2;
            Console.WriteLine("Arean av din triangle är: " + area);

            Console.ReadLine();
        }
    }
}
