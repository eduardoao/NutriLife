using NutriLife.Core.Domain;

namespace NutriLife.Core.Result
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