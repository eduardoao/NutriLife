using NutriLife.Core.Domain;
using NutriLife.Domain.Enums;

namespace NutriLife.Core.Services
{
    public class FoodResult
    {
        public FoodResult(FoodCreationResultCode foodCreationResultCode, Food food)
        {
            FoodCreationResultCode = foodCreationResultCode;
            Food = food;
        }

        public FoodCreationResultCode FoodCreationResultCode { get; private set; }
        public Food Food { get; private set; }

    }
   
}
