using NutriLife.Core.Domain;
using System;
using System.Threading.Tasks;
using Xunit;

namespace NutriLife.Services
{
    public class NutriLivePersonServiceTest
    {
        Person _person = null;

        public NutriLivePersonServiceTest()
        {
            CreatePerson();
        }       

        [Fact]
        public async Task ShouldCreatePersonCorrectWithValues()
        {
            //ACT
            var personService = new PersonService();
            Task<CreatePersonResult> result = personService.CreatePerson(_person);

            //Assert
            Assert.Equal("Sucess",  result.Result.ResultCode);
            Assert.Equal(_person.FirtName, result.Result.Person.FirtName);
        }


        [Fact]
        public async Task ShouldCreatePersonIsNull()
        {
            //Arrage 
            _person = null;

            //ACT
            var personService = new PersonService();
            Task<CreatePersonResult> result = personService.CreatePerson(_person);

            //ACT and Assert  
            var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => personService.CreatePerson(_person));

            Assert.Equal("Person", exception.ParamName);

        }


        // Arrage 
        private void CreatePerson()
        {
            _person = new Person("Eduardo", "Oliveira", 43, 95);
        }

    }
}
