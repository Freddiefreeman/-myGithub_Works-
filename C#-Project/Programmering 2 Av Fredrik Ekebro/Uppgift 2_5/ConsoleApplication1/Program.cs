using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2_5
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int result;
                int result2;

                Random rng = new Random();

                //Random Number 1
                result = rng.Next(1, 99);
                Console.WriteLine(result);
                //Random Number 2
                result2 = rng.Next(1, 99);
                Console.WriteLine(result2);

                Console.WriteLine("Vad blev " + result +"+" + result2);
                Console.WriteLine("=============");
                string input;
                int x;
                input = Console.ReadLine();
                x = Convert.ToInt32(input);


                if (result + result2 == (x))
                {
                    Console.WriteLine("Bingo you smartass you are a goddamn Einstein!");
                    Console.WriteLine("Want to retry Yes or No? Press enter for Yes, Close the program for No");
                    Console.WriteLine("=============================================================================");
                }
                else if (result + result2 != (x))
                {
                    Console.WriteLine("WAIT!wait wait... Are... Are you serious? Are you actually not joking? wow... your dumb...");
                    Console.WriteLine("Want to retry Yes or No? Press enter for Yes, Close the program for No");
                    Console.WriteLine("=============================================================================");
                }

                Console.ReadLine();
            }
        }
    }
}
