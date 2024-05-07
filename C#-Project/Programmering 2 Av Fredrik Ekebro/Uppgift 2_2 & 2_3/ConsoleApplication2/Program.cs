using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2_2__2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            int result;

            Random rng = new Random();

            for (int i = 0; i < 2; i++)
            {
                result = rng.Next(1, 7);
                Console.WriteLine(result);
            }


                Console.ReadLine();
        }
    }
}
