using NutriLife.Core.Domain;
using NutriLife.Core.Result;
using NutriLife.Interfaces.Data;
using NutriLife.Interfaces.Services;
using System;
using System.Threading.Tasks;

namespace NutriLife.Services
{
    public class PersonService : IPersonService
    {
        private Person _person;
        private readonly IRepositoryPerson _repositoryPerson;

        public PersonService(IRepositoryPerson repositoryPerson)
        {
            _repositoryPerson = repositoryPerson;
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

            var result = _repositoryPerson.SaveAsync(person);

            var resultPerson = new PersonResult(person);
            resultPerson.ResultCode = "Sucess";

            return resultPerson;
        }
    }
}