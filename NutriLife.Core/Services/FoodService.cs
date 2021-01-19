﻿using NutriLife.Core.Domain;
using System;
using System.Threading.Tasks;

namespace NutriLife.Core.Services
{
    public class FoodService : IFoodService
    {
        public async Task<FoodResult> CreateFood(Food food)
        {
            if (food == null)
            {
                throw new ArgumentNullException(nameof(Food));
            }

            var foodcreationresult = new FoodResult(FoodCreationResultCode.Success, food);
            return foodcreationresult;
        }
      
    }
}