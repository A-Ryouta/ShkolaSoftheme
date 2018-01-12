namespace Source
{
    public class Account
    {
        public int Id { get; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        
        public Account(int id)
        {
            Id = id;
        }

        public void AddInfo(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string GetInfo()
        {
            return string.Format("{0} {1} is {2} years old", Name, Surname, Age);
        }
    }
}
