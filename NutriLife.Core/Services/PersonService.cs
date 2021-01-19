using NutriLife.Core.Domain;
using System;
using System.Threading.Tasks;

namespace NutriLife.Services
{
    public class PersonService : IPersonService
    {
        private Person _person;

        public PersonService()
        {
        }

        public PersonService(Person person)
        {
            _person = person;
        }

        public async Task<PersonResult> CreatePerson(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(Person));
            }

            PersonResult result = new PersonResult(person);
            result.ResultCode = "Sucess";

            return result;
        }
    }
}