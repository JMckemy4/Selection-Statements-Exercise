using Microsoft.VisualBasic;
using System.Net.WebSockets;

namespace SelctionStatementExercise
{
    public class Program
    {
        static void buess()
        {
            var r = new Random();
            var favNumber = r.Next(1, 10);
            int guessNbr = 0;

            Console.WriteLine("Try to guess my favorite number");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput == favNumber)
            {
                Console.WriteLine($"You got it, {favNumber} was it.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"That guess was too high");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine($"That guess was too low");
            }
        }
    }
}














