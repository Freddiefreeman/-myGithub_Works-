using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Program 3-8");
            int[] BinaryDigits = { 1, 0, 0, 1, 0, 0, 0, 0 };
            int result = BinaryToDecimal(BinaryDigits);
            bool Quit = false;
            string Resp;
            while (!Quit)
            {
                int Choice = EnterANumber2("1.Decimalt => Binärt  2.Binärt => Decimalt : ", 1, 2);
                if (Choice == 1)
                {
                    result = EnterANumber2("Skriv ett tal mellan 0-255 ", 0, 255);
                    BinaryDigits = DecimalToBinary(result);
                    string BinStr = new string(MakeBinaryString(BinaryDigits));
                    Console.WriteLine("Talet är " + BinStr);
                }
                else
                {
                    BinaryDigits = EnterABinaryNumber("Skriv in 8 binära ");
                    Console.WriteLine("Talet är " + BinaryToDecimal(BinaryDigits));
                }
                Console.WriteLine("Press enter to retry, Respond with No to quit");
                Console.WriteLine("==============================================================");
                Resp = Console.ReadLine();
                if (Resp == "No")
                    Quit = true;
            }
        }

        private static int EnterANumber2(string question, int MinRange, int MaxRange)
        {
            int Choice = 0;
            bool not_found = true;
            while (not_found)
            {
                Choice = EnterANumber(question);
                if (Choice < MinRange || Choice > MaxRange)
                {
                    Console.WriteLine("!ERROR! EN HACKER HAR TAGIT ÖVER DATORN... nej jag skojar bara");
                }
                else
                {
                    not_found = false;
                }
            }
            return Choice;
        }

        private static int BinaryToDecimal(int[] BinaryDigits)
        {
            return BinaryDigits[7] * 1 +
                BinaryDigits[6] * 2 +
                BinaryDigits[5] * 4 +
                BinaryDigits[4] * 8 +
                BinaryDigits[3] * 16 +
                BinaryDigits[2] * 32 +
                BinaryDigits[1] * 64 +
                BinaryDigits[0] * 128;
        }

        private static int[] DecimalToBinary(int N)
        {
            int[] BinaryDigits = new int[8];

            BinaryDigits[7] = N / 1 % 2;
            BinaryDigits[6] = N / 2 % 2;
            BinaryDigits[5] = N / 4 % 2;
            BinaryDigits[4] = N / 8 % 2;
            BinaryDigits[3] = N / 16 % 2;
            BinaryDigits[2] = N / 32 % 2;
            BinaryDigits[1] = N / 64 % 2;
            BinaryDigits[0] = N / 128 % 2;
            return BinaryDigits;
        }

        private static char[] MakeBinaryString(int[] BinaryDigits)
        {
            char[] result = new char[8];
            for (int i = 0; i < 8; i++)
            {
                if (BinaryDigits[i] == 1)
                {
                    result[i] = '1';
                }
                else
                {
                    result[i] = '0';
                }
            }
            return result;
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

        private static int[] EnterABinaryNumber(string question)
        {
            int[] Result = new int[8];
            bool Found = false;
            while (Found == false)
            {
                try
                {
                    Console.Write(question);
                    string input = Console.ReadLine();
                    if (CheckBinaryInput(input) == true)
                    {
                        Result = MakeBinaryDigits(input);
                        Found = true;
                    }
                    else
                    {
                        Console.WriteLine("Wrong entry. Please try again");
                    }
                }
                catch
                {
                    Console.WriteLine("Please try again, invalid input");
                }
            }
            return Result;
        }

        private static bool CheckBinaryInput(string input)
        {
            if (input.Length < 8)
            {
                Console.WriteLine("DU HAR BLIVIT SUPER HACKA- ok förlåt...");
                return false;
            }
            else if (input.Length > 8)
            {
                Console.WriteLine("NU HAR DU BLIVIT MEGA HACK- Ok Ok! jag ska sluta...kanske...");
                return false;
            }
            else
            {
                int i;
                for (i = 0; i < 8; i++)
                {
                    if (is_one_or_zero(input[i]) == false)
                    {
                        Console.WriteLine("Talet innehåller det som var inte specifierat");
                        return false;
                    }
                }
            }
            return true;
        }

        private static int[] MakeBinaryDigits(string input)
        {
            int[] BinaryDigits = new int[8];
            for (int i = 0; i < 8; i++)
            {
                BinaryDigits[i] = input[i] - '0';
            }
            return BinaryDigits;
        }

        private static bool is_one_or_zero(char ch)
        {
            return ch == '0' || ch == '1';
        }
    }
}
