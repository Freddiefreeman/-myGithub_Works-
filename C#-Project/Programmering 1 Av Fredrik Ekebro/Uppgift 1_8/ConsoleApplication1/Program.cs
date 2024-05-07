using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.Write("Skriv in det första talet: ");
            input = Console.ReadLine(); 
            int x = Convert.ToInt32(input);

            Console.Write("Skriv in det andra talet: ");
            input = Console.ReadLine();
            int y = Convert.ToInt32(input);


            Console.Write("Skriv in det tredje talet: ");
            input = Console.ReadLine();
            int z = Convert.ToInt32(input);

            int sum = (x * 2 + y * 3 + z * 4);

            //Jag ville lägga till en räkning som säger "det första talet gånger 2 blev" etc. och etc. men jag kunde inte komma på hur

            Console.WriteLine("summan av alla tal är: " + sum);

            Console.ReadLine();
        }
    }
}
