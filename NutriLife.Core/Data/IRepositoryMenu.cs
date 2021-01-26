using NutriLife.Core.Domain;
using NutriLife.Domain.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NutriLife.Core.Data
{
    public interface IRepositoryMenu : IRepository<Menu>
    {
        Task <IList<Menu>> GetAllMenuByTypeMealByPersonIdAsync(int customerId, TypeMeal typeMeal);

        Task<bool> SaveMealByPersonIdAsync(int customerId, Meal meal);
    }
}
