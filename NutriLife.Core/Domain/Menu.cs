using NutriLife.Core.ValueObject;
using NutriLife.Services;
using System;

namespace NutriLife.Core.Domain
{
    public class Menu: Base
    {
        public Menu(TypeMeal typeMeal, Food food, int quantity, TypeQuantityMeal typeQuantityMeal)
        {
            TypeMeal = typeMeal;
            Food = food;
            Quantity = quantity;
            TypeQuantityMeal = typeQuantityMeal;           
        }

        public TypeMeal TypeMeal { get; private set; }
        public Food Food { get; private set; }
        public int Quantity { get; set; }
        public TypeQuantityMeal TypeQuantityMeal { get; private set; }        
       
    }
}