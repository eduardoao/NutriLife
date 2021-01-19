
using NutriLife.Domain.Enums;

namespace NutriLife.Core.Domain
{
    public class Meal
    {
        public Meal(Person person, TypeMeal typeMeal)
        {
            Person = person;
            TypeMeal = typeMeal;
        }

        public Person Person { get; internal set; }
        public TypeMeal TypeMeal { get; internal set; }
    }
}