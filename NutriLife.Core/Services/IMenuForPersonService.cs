using NutriLife.Core.Domain;
using System.Threading.Tasks;

namespace NutriLife.Core.Services
{
    public interface IMenuForPersonService
    {
        Task<bool> Save(Person person, Meal meal);
    }
}
