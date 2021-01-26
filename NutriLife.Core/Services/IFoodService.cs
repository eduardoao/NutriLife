using NutriLife.Core.Domain;
using NutriLife.Core.Result;
using System.Threading.Tasks;

namespace NutriLife.Core.Services
{
    public interface IFoodService
    {
       Task<FoodResult> CreateFood(Food food);
    }
}