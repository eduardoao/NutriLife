using NutriLife.Core.Domain;
using System;
using System.Threading.Tasks;

namespace NutriLife.Services
{
    public class PersonService
    {
        private Person _person;

        public PersonService()
        {
        }

        public PersonService(Person person)
        {
            _person = person;
        }

        public async Task<CreatePersonResult> CreatePerson(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(Person));
            }

            CreatePersonResult result = new CreatePersonResult(person);
            result.ResultCode = "Sucess";

            return result;
        }
    }
}