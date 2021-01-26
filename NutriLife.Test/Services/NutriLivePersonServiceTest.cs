using NutriLife.Core.Domain;
using NutriLife.Core.Result;
using NutriLife.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace NutriLife.Test.Services
{
    public class NutriLivePersonServiceTest
    {
        #region Atributes
        Person _person = null;
        #endregion

        #region Constructors
        public NutriLivePersonServiceTest()
        {
            CreatePerson();
        }
        #endregion

        #region Public_Method
        [Fact]
        public async Task ShouldCreatePersonCorrectWithValues()
        {
            //ACT
            var personService = new PersonService();
            Task<PersonResult> result = personService.CreatePerson(_person);

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
            Task<PersonResult> result = personService.CreatePerson(_person);

            //ACT and Assert  
            var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => personService.CreatePerson(_person));

            Assert.Equal("Person", exception.ParamName);

        }
        #endregion

        #region Private_Method
        // Arrage 
        private void CreatePerson()
        {
            _person = new Person("Eduardo", "Oliveira", 43, 95);
        }
        #endregion
    }
}
