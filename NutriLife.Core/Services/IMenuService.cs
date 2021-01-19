using NutriLife.Core.Domain;
using System.Threading.Tasks;

namespace NutriLife.Core.Services
{
    public interface IMenuService
    {
        Task<MenuResult> GetMenuResult(Meal mealRequest);
    }
}