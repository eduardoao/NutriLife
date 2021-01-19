using NutriLife.Core.Domain;
using NutriLife.Core.ValueObject;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NutriLife.Core.Data
{
    public interface IRepositoryMenu : IRepository<Menu>
    {
        Task <IList<Menu>> GetAllMenuByTypeMealByCustomerIdAsync(int customerId, TypeMeal typeMeal);
    }
}
