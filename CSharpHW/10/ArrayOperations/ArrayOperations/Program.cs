using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayManipulator am = new ArrayManipulator();
            //am.Generate(10);
            //am.Show();

            //am.Add(18);
            //am.Show();       
            //Console.WriteLine(am.Contains(3));
            //Console.WriteLine(am.GetByIndex(6));            

            FindTask task = new FindTask();
            task.Fill();
            task.Show();
            Console.WriteLine("Single number is {0}", task.Find());
            Console.ReadLine();
        }        
    }
}
