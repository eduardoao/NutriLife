using NutriLife.Core.Domain;

namespace NutriLife.Services
{
    public class CreatePersonResult
    {
        public CreatePersonResult(Person person)
        {
            Person = person;
        }

        public string ResultCode { get; internal set; }
        public Person Person { get; private set; }

    }
}