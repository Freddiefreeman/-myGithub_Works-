using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Program 2-7");
            Random rng = new Random();
            int LoopVariable = EnterANumber("Hur många tärningar vill du slå?: ");
            int Total = 0;

            for (int i = 0; i < LoopVariable; i++)
            {
                int result;
                //TÄRNING
                result = rng.Next(1, 6);
                Console.WriteLine(result);
                Total = Total + result;
            }
            Double Avarage = (Double)Total / (Double)LoopVariable;
            Console.WriteLine("medelvärdet av alla tal är: " + Avarage);

            Console.ReadLine();
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
