using NutriLife.Core.Data;
using NutriLife.Core.Domain;
using System;
using System.Threading.Tasks;

namespace NutriLife.Core.Services
{
    public class MenuForPersonService : IMenuForPersonService
    {
        private readonly IRepositoryMenu _repositoryMenu;
        public MenuForPersonService(IRepositoryMenu repositoryMenu)
        {
            _repositoryMenu = repositoryMenu;
        }

        public async Task<bool> Save(Person person, Meal meal)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person));
            }

            if (meal == null)
            {
                throw new ArgumentNullException(nameof(meal));
            }

            var idPerson = person.Id;
            var result = _repositoryMenu.SaveMealByPersonIdAsync(idPerson, meal);
            return result.Result;
            
        }
    }
}