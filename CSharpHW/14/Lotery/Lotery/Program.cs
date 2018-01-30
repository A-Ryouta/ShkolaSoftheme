using System;
using System.Linq;

namespace Lotery
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Enter a ticket number. Each number from 1 to 9");

            try
            {
                Console.WriteLine((WinCheck(GuessNumber())) ? "Congratulations! You won the game!" : "You`ve lost.");
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch (InputExeption ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }

        private static int[] GuessNumber()
        {
            var numbers = new int[6];

            for (var i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} number: ", (Count)i);

                numbers[i] = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                if (numbers[i] > 9 || numbers[i] < 1)
                {
                    throw new InputExeption("Number must be from 1 to 9 only!");
                }
            }

            return numbers;
        }

        private static bool WinCheck(int[] numbers)
        {
            var ticket = new Ticket();
            
            return !numbers.Where((t, i) => t != ticket[i].number).Any();
        }
    }
}
