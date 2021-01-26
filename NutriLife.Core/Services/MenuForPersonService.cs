using NutriLife.Core.Domain;
using System;
using System.Threading.Tasks;

namespace NutriLife.Core.Services
{
    public class MenuForPersonService : IMenuForPersonService
    {
        public MenuForPersonService()
        {
        }

        async Task<bool> IMenuForPersonService.Save(Person person, Meal meal)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person));
            }

            if (meal == null)
            {
                throw new ArgumentNullException(nameof(meal));
            }

            return  true;
        }
    }
}