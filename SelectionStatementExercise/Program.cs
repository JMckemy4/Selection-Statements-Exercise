using Microsoft.VisualBasic;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;

namespace SelctionStatementExercise
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Try to guess my favorite number");
            int number = 4;
            var r = new Random();
            var favNumber = r.Next(1, 10);

            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case int _ when userInput == favNumber:
                    Console.WriteLine($"You got it, {favNumber} was it.");
                    break;
                case int _ when userInput > favNumber:
                    Console.WriteLine("That guess was too high");
                    break;
                case int _ when userInput < favNumber:
                    Console.WriteLine("That guess was too low");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
                    //    Console.WriteLine("Try to guess my favorite number");
                    //    int number = 4;
                    //    var r = new Random();
                    //    var favNumber = r.Next(1, 10);
                    //    int guessNbr = 0;

                    //    int userInput = int.Parse(Console.ReadLine());
                    //    if (userInput == favNumber)
                    //    {
                    //        Console.WriteLine($"You got it, {favNumber} was it.");
                    //    }
                    //    else if (userInput > favNumber)
                    //    {
                    //        Console.WriteLine($"That guess was too high");
                    //    }
                    //    else if (userInput < favNumber)
                    //    {
                    //        Console.WriteLine($"That guess was too low");
                    //    }

            }
        }
    }
}














