using System;

namespace Humans
{
    internal class Human
    {
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; }

        public Human()
        {
            BirthDate = DateTime.Now;
            FirstName = "John";
            LastName = "Bravo";
            Age = DateTime.Now.Year - BirthDate.Year;
        }

        public Human(DateTime bDate, string fName, string lName, int age)
        {
            BirthDate = bDate;
            FirstName = fName;
            LastName = lName;
            Age = age;
        }

        public Human(Human human)
        {
            BirthDate = human.BirthDate;
            FirstName = human.FirstName;
            LastName = human.LastName;
            Age = human.Age;
        }

        public bool CompareTo(Human human)
        {
            bool result = BirthDate == human.BirthDate 
                          && FirstName == human.FirstName 
                          && LastName == human.LastName 
                          && Age == human.Age;

            return result;
        }

        public void ShowHuman()
        {
            Console.WriteLine("{0} {1} borned {2} and now he(she) is {3} years old"
                , FirstName, LastName, BirthDate, Age);
        }
    }
}
