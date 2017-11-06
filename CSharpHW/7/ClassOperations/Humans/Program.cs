using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class Program
    {
        static void Main(string[] args)
        {
            Human john = new Human();
            Human sally = new Human(new DateTime(1993, 4, 12), "Sally", "Donavan", 24);
            Human peter = new Human(new DateTime(2000, 5, 5), "Peter", "Parker", 17);
            Human clone = new Human(sally);

            john.ShowHuman();
            sally.ShowHuman();
            peter.ShowHuman();
            clone.ShowHuman();

            Console.WriteLine(john.CompareHumans(peter));
            Console.WriteLine(sally.CompareHumans(clone));

            Console.ReadLine();
        }
    }

    internal class Human
    {
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; }

        public Human()
        {
            BirthDate = new DateTime(1995, 11, 10);
            FirstName = "John";
            LastName = "Yankovich";
            Age = 11;
        }
        public Human(DateTime bDate, string fName, string lName, int a)
        {
            BirthDate = bDate;
            FirstName = fName;
            LastName = lName;
            Age = a;
        }
        public Human(Human h)
        {
            BirthDate = h.BirthDate;
            FirstName = h.FirstName;
            LastName = h.LastName;            
            Age = h.Age;
        }
        public bool CompareHumans(Human h)
        {
            bool result = this.BirthDate != h.BirthDate
                || this.FirstName != h.FirstName || this.LastName != h.LastName || this.Age != h.Age ? false : true;
            return result;
            
        }
        public void ShowHuman()
        {
            Console.WriteLine("{0} {1} borned {2} and now he(she) is {3} years old"
                , FirstName, LastName, BirthDate, Age);
        }
    }
}
