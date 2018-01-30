using System;

namespace ArrayOperations
{
    internal class Program
    {
        private static void Main()
        {
            var am = new ArrayManipulator();
            am.Generate(10);
            am.Show();

            am.Add(18);
            am.Show();       
            Console.WriteLine(am.Contains(3));
            Console.WriteLine(am.GetByIndex(6));            

            var task = new FindSoloNumber();
            task.Fill();
            task.Show();
            Console.WriteLine("Single number is {0}", task.Find());
            Console.ReadLine();
        }        
    }
}
