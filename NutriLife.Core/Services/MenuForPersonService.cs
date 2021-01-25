using NutriLife.Core.Domain;
using System;

namespace NutriLife.Core.Services
{
    public class MenuForPersonService : IMenuForPersonService
    {
        public MenuForPersonService()
        {
        }

        public bool Save(Person person, Meal meal)
        {
            return true;
        }
    }
}