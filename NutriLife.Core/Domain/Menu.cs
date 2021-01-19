using NutriLife.Core.ValueObject;
using System;

namespace NutriLife.Core.Domain
{
    public class Menu: Base
    {
        public Menu(TypeMeal typeMeal, string meal, int quantity, TypeQuantityMeal typeQuantityMeal)
        {
            TypeMeal = typeMeal;
            Meal = meal;
            Quantity = quantity;
            TypeQuantityMeal = typeQuantityMeal;           
        }

        public TypeMeal TypeMeal { get; private set; }
        public string Meal { get; private set; }
        public int Quantity { get; set; }
        public TypeQuantityMeal TypeQuantityMeal { get; private set; }        
       
    }
}