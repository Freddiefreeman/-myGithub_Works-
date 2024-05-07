using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int result;
            int result2;

            Random rng = new Random();

            result = rng.Next(1, 99);
            Console.WriteLine(result);

            result2 = rng.Next(1, 99);
            Console.WriteLine(result2);

            int sum = result + result2;

            Console.WriteLine("Dem adderade talen blev: " + sum);

            Console.ReadLine();
        }
    }
}