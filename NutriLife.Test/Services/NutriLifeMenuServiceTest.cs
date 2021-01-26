using Moq;
using NutriLife.Core.Domain;
using NutriLife.Core.Services;
using NutriLife.Core.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using NutriLife.Domain.Enums;

namespace NutriLife.Test
{
    public class NutriLifeMenuServiceTest
    {
        #region Atributes
        Person _person = null;
        Meal _meal = null;
        private readonly IMenuService _menuRequestService;
        private readonly IMenuForPersonService _menurFoPersonService;
        #endregion

        #region Constructors
        public NutriLifeMenuServiceTest()
        {
            CreatePerson();
            var repositoryMenuMock = new Mock<IRepositoryMenu>();
            repositoryMenuMock.Setup(menu => menu.GetAllMenuByTypeMealByCustomerIdAsync(It.IsAny<int>(), It.IsAny<TypeMeal>()))
                .ReturnsAsync(GetFakeMenu());

            var repositoryPersonMock = new Mock<IRepositoryPerson>();
            repositoryPersonMock.Setup(menu => menu.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(_person);

            _menuRequestService = new MenuService(repositoryMenuMock.Object, repositoryPersonMock.Object);

            _menurFoPersonService = new MenuForPersonService();
            
        }
        #endregion

        #region Public_Method
        [Fact]
        public void ShouldReturnMenuResultWithValues()
        {
            //Arrage 
            CreateMeal();

            //ACT and Assert     
            var result = _menuRequestService.GetMenuResult(_meal);

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

        [Fact]
        public async Task ShouldCreateMenuForPersonWhePersonIsNull()
        {
            _person = null;
            var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => _menurFoPersonService.Save(_person, _meal));

            Assert.Equal("person", exception.ParamName);
        }

        [Fact]
        public async Task ShouldCreateMenuForPersonWheMealIsNull()
        {
            _meal = null;
            var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => _menurFoPersonService.Save(_person, _meal));

            Assert.Equal("meal", exception.ParamName);
        }

        [Fact]
        public async Task ShouldCreateMenuForPerson()
        {
            CreateMeal();
            //ACT 
            var result = _menurFoPersonService.Save(_person, _meal);

            //Assert
            Assert.True(result.Result);
        }
        #endregion

        #region Privaty_Method
        private void CreateMeal()
        {
            _meal = new Meal(_person, TypeMeal.BreakFest);
        }
        private void CreatePerson()
        {
            _person = new Person("Eduardo", "Oliveira", 43, 95);
        }
        private List<Menu> GetFakeMenu()
        {
            var food = new Food("Cereal", 50);
            var result = new List<Menu>();
            var itemMenuResult = new Menu(TypeMeal.BreakFest, food, 1, TypeQuantityMeal.Unit);

            result.Add(itemMenuResult);

            return result;
        }

        #endregion
    }
}
