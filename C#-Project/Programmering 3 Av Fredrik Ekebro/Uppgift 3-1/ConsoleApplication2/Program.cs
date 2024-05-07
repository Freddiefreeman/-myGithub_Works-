using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Program 3-1");
            string[] namn = new string[10];
            Console.WriteLine("Skriv in 10 namn");

            for (int i = 0; i < namn.Length; i++)
            {
                Console.Write("Namn nummer " + (i + 1) + ": ");
                namn[i] = Console.ReadLine();
            }
            Console.WriteLine("------------------");
            for (int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine(namn[i]);
            }
            Console.ReadLine();
        }
        private static int Intro(string Text)
        {
            Console.WriteLine("-------------");
            Console.WriteLine(" " + Text);
            Console.WriteLine("-------------");
            return 0;
        }
    }
}
