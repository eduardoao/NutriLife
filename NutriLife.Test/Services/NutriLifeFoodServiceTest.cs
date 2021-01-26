using NutriLife.Core.Domain;
using NutriLife.Core.Services;
using NutriLife.Domain.Enums;
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
        private Food food;
        public NutriLifeFoodServiceTest()
        {
            _foodService = new FoodService();

            //Arrage 
            food = new Food("Atum", 50);

        }
        #endregion

        #region Public_Method
        [Fact]
        public void ShouldCreateFoodWithValues()
        {
            //Arrage 
            var food = new Food("Atum", 50);

            //ACT and Assert    
            var result = _foodService.CreateFood(food);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(FoodCreationResultCode.Success, result.Result.FoodCreationResultCode);
            Assert.Equal("Atum", result.Result.Food.Description);
        }

        [Fact]
        public async Task ShouldCreateFoodWithNullValuesAsync()
        {
            //ACT
            food = null;

            //ACT and Assert    
           
            var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => _foodService.CreateFood(food));

            Assert.Equal("Food", exception.ParamName);
        }
        #endregion
    }
}
