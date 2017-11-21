using System;

namespace Lotery
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a ticket number. Each number from 1 to 9");

            try
            {
                Console.WriteLine((WinCheck(Guess())) ? "Congratulations! You won the game!" : "You`ve lost.");
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

        static int[] Guess()
        {
            int[] numbers = new int[6];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} number: ", (Count)i);
                numbers[i] = Int32.Parse(Console.ReadLine());
                if (numbers[i] > 9 || numbers[i] < 1)
                {
                    throw new InputExeption("Number must be from 1 to 9 only!");
                }
            }
            return numbers;
        }

        static bool WinCheck(int[] numbers)
        {
            var ticket = new Ticket();

            /********** Only fo testing *********/
            //Console.WriteLine("Winning combination is:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(ticket[i].number);
            //}
            //Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != ticket[i].number)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
