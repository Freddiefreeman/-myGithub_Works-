using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Program 3-4");
            Console.WriteLine("Tryck enter för att Börja räkningen med Writeline");
            Console.ReadLine();
            int max = 100000;
            DateTime Start1 = DateTime.Now;

            for (int i = 0; i < max; i++)
            {
                Console.WriteLine(" " + i);
            }
            DateTime Stop1 = DateTime.Now;
            Console.WriteLine("\nWriteLine tog " + (Stop1 - Start1));

            Console.WriteLine("Tryck enter för att Börja räkningen med Write");
            Console.ReadLine();
            DateTime Start2 = DateTime.Now;

            for (int i = 0; i < max; i++)
            {
                Console.Write(" " + i);
            }
            DateTime Stop2 = DateTime.Now;

            Console.WriteLine("\nWrite tog " + (Stop2 - Start2));

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
