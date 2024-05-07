using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3_6__3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Program 3-6");
            double Tries = 0;
            double CorrectAns = 0;
            string Resp;
            bool Quit = false;
            while (!Quit)
            {
                int Level = EnterANumber("Vilken Svårighetsgrad Väljer du? Lätt = 1, Svårare = 2 och Svårt = 3?: ");
                Tries += 1;
                if (Level == 1)
                {
                    CorrectAns += Easy();
                }
                else if (Level == 2)
                {
                    CorrectAns += Medium();
                }
                else if (Level == 3)
                {
                    CorrectAns += Advanced();
                }
                else
                {
                    Console.WriteLine("Your too dumb to be taking on the big-boy questions, kiddo");
                }


                Console.WriteLine("Press enter to retry, Respond with No to show result and quit");
                Console.WriteLine("==============================================================");
                Resp = Console.ReadLine();
                if (Resp == "No")
                    Quit = true;
            }
            Console.WriteLine("Du fick " + (int)((CorrectAns / Tries) * 100) + "% Av 100% på " + Tries + " försök");
            Console.ReadLine();
        }

        private static int Easy()
        {
            int result;
            int result2;
            int CorrectResult = 0;

            Random rng = new Random();

            //Random Number 1
            result = rng.Next(1, 11);
            Console.WriteLine(result);
            //Random Number 2
            result2 = rng.Next(1, 11);
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
                CorrectResult++;
            }
            else
            {
                Console.WriteLine("WAIT!wait wait... Are... Are you serious? Are you actually not joking? wow... your dumb...");
            }
            return CorrectResult;
        }

        private static int Medium()
        {
            int result;
            int result2;
            int result3;
            int op1, op2;
            int CorrectResult = 0;


            Random rng = new Random();

            //Random Number 1
            result = rng.Next(1, 100);
            //Random Number 2
            result2 = rng.Next(1, 100);
            //Random Number 3
            result3 = rng.Next(1, 100);
            //Random Equation 1
            op1 = rng.Next(1, 3);
            //Random Equation 2
            op2 = rng.Next(1, 3);

            Console.WriteLine("Vad blir " + result + OperatorToString(op1) + result2 + OperatorToString(op2) + result3 + "= ?");
            Console.WriteLine("=============");
            string input;
            int x;
            input = Console.ReadLine();
            x = Convert.ToInt32(input);

            int result4 = EvaluateOp(result, result2, op1);
            int result5 = EvaluateOp(result4, result3, op2);

            if (result5 == (x))
            {
                Console.WriteLine("Bingo you smartass you're a goddamn Einstein!");
                CorrectResult++;
            }
            else
            {
                Console.WriteLine("WAIT!wait wait... Are... Are you serious? Are you actually not joking? wow... your dumb...");
            }
            return CorrectResult;
        }

        private static int Advanced()
        {
            int result;
            int result2;
            int result3;
            int op1, op2;
            int CorrectResult = 0;

            Random rng = new Random();

            //Random Number 1
            result = rng.Next(1, 1000);
            //Random Number 2
            result2 = rng.Next(1, 1000);
            //Random Number 3
            result3 = rng.Next(1, 1000);
            //Random Equation 1
            op1 = rng.Next(1, 4);
            //Random Equation 2
            op2 = rng.Next(1, 4);

            Console.WriteLine("Vad blir " + result + OperatorToString(op1) + result2 + OperatorToString(op2) + result3 + "= ?");
            Console.WriteLine("=============");
            string input;
            int x;
            input = Console.ReadLine();
            x = Convert.ToInt32(input);

            int result4;
            int result5;

            if (op1 >= op2)
            {
                result4 = EvaluateOp(result, result2, op1);
                result5 = EvaluateOp(result4, result3, op2);
            }
            else
            {
                result4 = EvaluateOp(result2, result3, op2);
                result5 = EvaluateOp(result, result4, op1);
            }

            if (result5 == (x))
            {
                Console.WriteLine("Bingo you smartass you're a goddamn Einstein!");
                CorrectResult++;
            }
            else
            {
                Console.WriteLine("WAIT!wait wait... Are... Are you serious? Are you actually not joking? wow... your dumb...");
            }
            return CorrectResult;
        }

        private static string OperatorToString(int op)
        {
            if (op == 1)
            {
                return "+";
            }
            else if (op == 2)
            {
                return "-";
            }
            else
            {
                return "*";
            }
        }

        private static int EvaluateOp(int term1, int term2, int op)
        {
            if (op == 1)
            {
                return term1 + term2;
            }
            else if (op == 2)
            {
                return term1 - term2;
            }
            else
            {
                return term1 * term2;
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
