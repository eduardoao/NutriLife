using Moq;
using NutriLife.Core.Domain;
using NutriLife.Core.Services;
using NutriLife.Core.ValueObject;
using NutriLife.Core.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace NutriLife.Test
{
    public class NutriLifeMenuServiceTest
    {
        Person _person = null;
        private readonly IMenuService _menuRequestService;
        private readonly IRepositoryPerson _repositoryPerson;

        public NutriLifeMenuServiceTest()
        {
            CreatePerson();
            var repositoryMenuMock = new Mock<IRepositoryMenu>();
            repositoryMenuMock.Setup(menu => menu.GetAllMenuByTypeMealByCustomerIdAsync(It.IsAny<int>(), It.IsAny<TypeMeal>()))
                .ReturnsAsync(GetFakeMenu());

            var repositoryPersonMock = new Mock<IRepositoryPerson>();
            repositoryPersonMock.Setup(menu => menu.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(_person);

            _menuRequestService = new MenuService(repositoryMenuMock.Object, repositoryPersonMock.Object);

        }    

        [Fact]
        public void ShouldReturnMenuResultWithValues()
        {
            //Arrage 
            var breakfest = new Meal(_person, TypeMeal.BreakFest);

            //ACT and Assert     
            var result = _menuRequestService.GetMenuResult(breakfest);

            //Assert
            Assert.NotNull(result);
            Assert.Single(result.Result.MenuItens);           

        }

        [Fact]
        public async Task ShouldReturnMenuResultIsNull()
        {
            var exception = await Assert.ThrowsAsync<ArgumentNullException>(()=> _menuRequestService.GetMenuResult(null));

            Assert.Equal("mealRequest", exception.ParamName);
        }

        [Fact]
        public async Task ShouldReturnMenuResultPersonIsNull()
        {
            //Arrage 
            _person = null;
            var breakfest = new Meal(_person, TypeMeal.BreakFest);
          
            //ACT and Assert  
            var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => _menuRequestService.GetMenuResult(breakfest));

            Assert.Equal("Person", exception.ParamName);

        }
              
        private void CreatePerson()
        {
            _person = new Person("Eduardo", "Oliveira", 43, 95);
        }

        private List<Menu> GetFakeMenu()
        {
            var result = new List<Menu>();
            var itemMenuResult = new Menu(TypeMeal.BreakFest, "Cereal", 1, TypeQuantityMeal.Unit);

            result.Add(itemMenuResult);

            return result;
        }

    }
}
