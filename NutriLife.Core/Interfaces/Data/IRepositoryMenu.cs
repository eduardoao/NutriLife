using NutriLife.Core.Domain;
using NutriLife.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NutriLife.Interfaces.Data
{
    public interface IRepositoryMenu : IRepository<Menu>
    {
        Task <IList<Menu>> GetAllMenuByTypeMealByPersonIdAsync(Guid customerId, TypeMeal typeMeal);

        Task<bool> SaveMealByPersonIdAsync(Guid customerId, Meal meal);
    }
}
