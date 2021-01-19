namespace NutriLife.Core.Domain
{
    public class Person : Base
    {
        public Person()
        {
        }

        public Person(string firtName, string lastName, int age, double weight)
        {
            FirtName = firtName;
            LastName = lastName;
            Age = age;
            Weight = weight;
        }

        public string FirtName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public double Weight { get; private set; }

        public int GetId()
        {
            return Id;
        }
    }
}