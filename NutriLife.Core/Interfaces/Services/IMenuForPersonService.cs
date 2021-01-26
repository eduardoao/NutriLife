using NutriLife.Core.Domain;
using System.Threading.Tasks;

namespace NutriLife.Interfaces.Services
{
    public interface IMenuForPersonService
    {
        Task<bool> Save(Person person, Meal meal);
    }
}
