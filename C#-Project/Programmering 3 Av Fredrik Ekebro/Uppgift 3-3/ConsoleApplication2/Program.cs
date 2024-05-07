using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Program 3-3")
            Console.WriteLine("Tryck på enter för att starta tiden");

            Console.ReadLine();

            DateTime Start = DateTime.Now;
            Console.WriteLine("Tryck på enter för att stoppa tiden");

            Console.ReadLine();

            DateTime Stop = DateTime.Now;
            Console.WriteLine("Du stannade vid " + (Stop - Start));

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
