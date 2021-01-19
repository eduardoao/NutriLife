using NutriLife.Core.Domain;

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


    public enum FoodCreationResultCode
    {
        Success,
        Error
    }
}
