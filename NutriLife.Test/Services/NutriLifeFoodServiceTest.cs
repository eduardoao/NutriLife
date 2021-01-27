using Moq;
using NutriLife.Core.Domain;
using NutriLife.Core.Services;
using NutriLife.Domain.Enums;
using NutriLife.Interfaces.Data;
using NutriLife.Interfaces.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace NutriLife.Test.Services
{
    public class NutriLifeFoodServiceTest
    {
        #region Atributes
        private IFoodService _foodService;        
        private Food _food;
        public NutriLifeFoodServiceTest()
        {
            CreateFood();
            var repositoryFoodMock = new Mock<IRepositoryFood>();
            repositoryFoodMock.Setup(food => food.SaveAsync(_food))
                .ReturnsAsync(_food);
            _foodService = new FoodService(repositoryFoodMock.Object);          

        }

        private void CreateFood()
        {
            //Arrage 
            _food = new Food("Atum", 50);
        }
        #endregion

        #region Public_Method
        [Fact]
        public void ShouldCreateFoodWithValues()
        {           

            //ACT and Assert    
            var result = _foodService.CreateFood(_food);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(FoodCreationResultCode.Success, result.Result.FoodCreationResultCode);
            Assert.Equal("Atum", result.Result.Food.Description);
        }

        [Fact]
        public async Task ShouldCreateFoodWithNullValuesAsync()
        {
            //ACT and Assert 
            _food = null;
           
            var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => _foodService.CreateFood(_food));

            Assert.Equal("Food", exception.ParamName);
        }
        #endregion
    }
}
