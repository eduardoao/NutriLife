using NutriLife.Core.Domain;
using NutriLife.Domain.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NutriLife.Interfaces.Data
{
    public interface IRepositoryMenu : IRepository<Menu>
    {
        Task <IList<Menu>> GetAllMenuByTypeMealByPersonIdAsync(int customerId, TypeMeal typeMeal);

        Task<bool> SaveMealByPersonIdAsync(int customerId, Meal meal);
    }
}
