using NutriLife.Core.Domain;
using NutriLife.Core.Result;
using NutriLife.Domain.Enums;
using NutriLife.Interfaces.Data;
using NutriLife.Interfaces.Services;
using System;
using System.Threading.Tasks;

namespace NutriLife.Core.Services
{
    public class FoodService : IFoodService
    {
        private readonly IRepositoryFood _repositoryFood;

        public FoodService(IRepositoryFood repositoryFood)
        {
            _repositoryFood = repositoryFood;
        }
        public async Task<FoodResult> CreateFood(Food food)
        {
            if (food == null)
            {
                throw new ArgumentNullException(nameof(Food));
            }

            var result = _repositoryFood.SaveAsync(food);

            var foodcreationresult = new FoodResult(FoodCreationResultCode.Success, result.Result);
            return foodcreationresult;
        }
      
    }
}