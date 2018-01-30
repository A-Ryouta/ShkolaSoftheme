using System;

namespace TypeOperations
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public User()
        {
        }

        public User(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void Clone(User value)
        {
            FirstName = value.FirstName;
            LastName = value.LastName;
            Age = value.Age;
        }

        public void Print()
        {
            Console.WriteLine("{0} {1} is {2} years old", FirstName, LastName, Age);
        }
    }
}
