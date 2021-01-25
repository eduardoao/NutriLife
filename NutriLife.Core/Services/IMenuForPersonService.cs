using NutriLife.Core.Domain;

namespace NutriLife.Core.Services
{
    public interface IMenuForPersonService
    {
        bool Save(Person person, Meal meal);
    }
}