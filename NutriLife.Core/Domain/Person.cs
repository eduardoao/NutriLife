using System;

namespace NutriLife.Core.Domain
{
    public class Person : Base
    {
        public Person()
        {
        }

        public Person(string firtName, string lastName, int age, double weight, Guid userId)
        {
            FirtName = firtName;
            LastName = lastName;
            Age = age;
            Weight = weight;
            UserId = userId;
        }

        public string FirtName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public double Weight { get; private set; }
        public Guid UserId { get; private set; }

        public Guid GetId()
        {
            return Id;
        }
    }
}