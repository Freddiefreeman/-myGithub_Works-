using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Program 2-8");

            while (true)
            {
                int Level = EnterANumber("Vilken Svårighetsgrad Väljer du? Lätt = 1, Svårare = 2 och Svårt = 3?: ");

                if (Level == 1)
                {
                    Easy();
                }
                else if (Level == 2)
                {
                    Medium();
                }
                else if (Level == 3)
                {
                    Advanced();
                }
                else
                {
                    Console.WriteLine("Your too dumb to be taking on the big-boy questions, kiddo");
                }


                Console.WriteLine("Want to retry Yes or No? Press enter for Yes, Close the program for No");
                Console.WriteLine("=============================================================================");
                Console.ReadLine();
            }
        }

        private static int Easy()
        {
            int result;
            int result2;

            Random rng = new Random();

            //Random Number 1
            result = rng.Next(1, 10);
            Console.WriteLine(result);
            //Random Number 2
            result2 = rng.Next(1, 10);
            Console.WriteLine(result2);

            Console.WriteLine("Vad blev " + result + "+" + result2);
            Console.WriteLine("=============");
            string input;
            int x;
            input = Console.ReadLine();
            x = Convert.ToInt32(input);


            if (result + result2 == (x))
            {
                Console.WriteLine("Bingo you smartass you're a goddamn Einstein!");
            }
            else
            {
                Console.WriteLine("WAIT!wait wait... Are... Are you serious? Are you actually not joking? wow... your dumb...");
            }
            return 0;
        }

        private static int Medium()
        {
            int result;
            int result2;
            int result3;

            Random rng = new Random();

            //Random Number 1
            result = rng.Next(1, 100);
            //Random Number 2
            result2 = rng.Next(1, 100);
            //Random Number 3
            result3 = rng.Next(1, 100);

            Console.WriteLine("Vad blir " + result + "+" + result2 + "+" + result3 + "= ?");
            Console.WriteLine("=============");
            string input;
            int x;
            input = Console.ReadLine();
            x = Convert.ToInt32(input);


            if (result + result2 + result3 == (x))
            {
                Console.WriteLine("Bingo you smartass you're a goddamn Einstein!");
            }
            else
            {
                Console.WriteLine("WAIT!wait wait... Are... Are you serious? Are you actually not joking? wow... your dumb...");
            }
            return 0;
        }

        private static int Advanced()
        {
            int result;
            int result2;
            int result3;

            Random rng = new Random();

            //Random Number 1
            result = rng.Next(1, 1000);
            //Random Number 2
            result2 = rng.Next(1, 1000);
            //Random Number 3
            result3 = rng.Next(1, 1000);

            Console.WriteLine("Vad blir " + result + "+" + result2 + "+" + result3 + "= ?");
            Console.WriteLine("=============");
            string input;
            int x;
            input = Console.ReadLine();
            x = Convert.ToInt32(input);


            if (result + result2 + result3 == (x))
            {
                Console.WriteLine("Bingo you smartass you're a goddamn Einstein!");
            }
            else
            {
                Console.WriteLine("WAIT!wait wait... Are... Are you serious? Are you actually not joking? wow... your dumb...");
            }
            return 0;
        }

        private static int Intro(string Text)
        {
            Console.WriteLine("-------------");
            Console.WriteLine(" " + Text);
            Console.WriteLine("-------------");
            return 0;
        }

        private static int EnterANumber(string question)
        {
            while (true)
            {
                try
                {
                    Console.Write(question);
                    string input = Console.ReadLine();
                    int returnungInt = Convert.ToInt32(input);
                    return returnungInt;
                }
                catch
                {
                    Console.WriteLine("Please try again, invalid input");
                }
            }
        }
    }
}
