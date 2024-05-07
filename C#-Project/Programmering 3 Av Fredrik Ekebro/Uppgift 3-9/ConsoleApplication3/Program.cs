using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Program 3-9");
            string[] options = { "Sten", "Sax", "Påse", "Lizard", "Spock"  };
            Random rng = new Random();
            int Choice = 0;
            int Result;
            while (true)
            {
                Choice = 0;
                while (Choice < 1 || Choice > 5)
                {
                    Choice = EnterANumber("Välj Sten(1), Sax(2), Påse(3), Lizard(4), Spock(5) = ");
                }
                Choice--;
                //Computer's Choice
                Result = rng.Next(0, 5);

                Console.Write("Du valde " + options[Choice] + " och datorn valde " + options[Result]);

                if (Choice == Result)
                {
                    Console.WriteLine(", det blev oavgjort");
                }
                else if ((Choice == 0 && (Result == 1 || Result == 3)) ||
                    (Choice == 1 && (Result == 2 || Result == 3)) ||
                    (Choice == 2 && (Result == 0 || Result == 4)) ||
                    (Choice == 3 && (Result == 4 || Result == 2)) ||
                    (Choice == 4 && (Result == 1 || Result == 0)))
                {
                    Console.WriteLine(", du vann med den övre handen"); 
                }
                else
                {
                    Console.WriteLine(", datorn vann med den övre handen");
                }

                Console.WriteLine("=================================================================");
                Console.WriteLine("Tryck på Enter för att försöka igen, om inte stäng ner programmet");
                Console.ReadLine();
            }
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