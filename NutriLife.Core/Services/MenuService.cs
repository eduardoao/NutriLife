using NutriLife.Core.Data;
using NutriLife.Core.Domain;
using NutriLife.Core.Result;
using System;
using System.Threading.Tasks;

namespace NutriLife.Core.Services
{
    public class MenuService : IMenuService
    {
        private readonly IRepositoryMenu _repositoryMenu;
        private readonly IRepositoryPerson _repositoryPerson;

        public MenuService(IRepositoryMenu repositoryMenu, IRepositoryPerson repositoryPerson)
        {
            _repositoryMenu = repositoryMenu;
            _repositoryPerson = repositoryPerson;
        }
        public async Task<MenuResult> GetMenuResult(Meal mealRequest)
        {
            if (mealRequest == null)
            {
                throw new ArgumentNullException(nameof(mealRequest));
            }

            if (mealRequest.Person == null)
            {
                throw new ArgumentNullException(nameof(Person));
            }

            var listMenuResult = _repositoryMenu.GetAllMenuByTypeMealByPersonIdAsync(mealRequest.Person.Id, mealRequest.TypeMeal);

            if (listMenuResult == null)
                throw new Exception($"Sem informações cadastradas para o cliente(a): {mealRequest.Person.FirtName}" );

            var personInformation = _repositoryPerson.GetByIdAsync(mealRequest.Person.Id).Result;

            var result = new MenuResult(DateTime.Now, personInformation);            
            result.AddMenuList(listMenuResult.Result);

            return result;

        }      
    }
}