using NutriLife.Core.Domain;

namespace NutriLife.Services
{
    public class PersonResult
    {
        public PersonResult(Person person)
        {
            Person = person;
        }

        public string ResultCode { get; internal set; }
        public Person Person { get; private set; }

    }
}