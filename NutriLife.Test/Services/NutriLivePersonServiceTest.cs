using Moq;
using NutriLife.Core.Domain;
using NutriLife.Core.Result;
using NutriLife.Interfaces.Data;
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
        PersonService _personService; 
        #endregion

        #region Constructors
        public NutriLivePersonServiceTest()
        {
            CreatePerson();
            var repositoryPersonMock = new Mock<IRepositoryPerson>();
            repositoryPersonMock.Setup(person => person.SaveAsync(_person))
                .ReturnsAsync(_person);

            _personService = new PersonService(repositoryPersonMock.Object);
        }
        #endregion

        #region Public_Method
        [Fact]
        public async Task ShouldCreatePersonCorrectWithValues()
        {
            //ACT
          
            Task<PersonResult> result = _personService.CreatePerson(_person);

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
            Task<PersonResult> result = _personService.CreatePerson(_person);

            //ACT and Assert  
            var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => _personService.CreatePerson(_person));

            Assert.Equal("Person", exception.ParamName);

        }
        #endregion

        #region Private_Method
        // Arrage 
        private void CreatePerson()
        {
            _person = new Person("Eduardo", "Oliveira", 43, 95, Guid.NewGuid());
        }
        #endregion
    }
}
