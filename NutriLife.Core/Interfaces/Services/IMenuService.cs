using NutriLife.Core.Domain;
using NutriLife.Core.Result;
using System.Threading.Tasks;

namespace NutriLife.Interfaces.Services
{
    public interface IMenuService
    {
        Task<MenuResult> GetMenuResult(Meal mealRequest);
    }
}