using System;

namespace Humans
{
    class Program
    {
        static void Main()
        {
            Human john = new Human();
            Human sally = new Human(new DateTime(1993, 4, 12), "Sally", "Donavan", 24);
            Human peter = new Human(new DateTime(2000, 5, 5), "Peter", "Parker", 17);
            Human clone = new Human(sally);

            john.ShowHuman();
            sally.ShowHuman();
            peter.ShowHuman();
            clone.ShowHuman();

            Console.WriteLine(john.CompareTo(peter));
            Console.WriteLine(sally.CompareTo(clone));

            Console.ReadLine();
        }
    }
}
