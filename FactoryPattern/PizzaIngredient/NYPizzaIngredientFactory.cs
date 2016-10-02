﻿using FactoryPattern.PizzaIngredient.Ingredients;
using System.Collections.Generic;

namespace FactoryPattern.PizzaIngredient
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public List<IVeggie> CreateVeggies()
        {
            return new List<IVeggie>
            {
                new Garlic(),
                new Onion(),
                new Mushroom(),
                new RedPepper()
            };
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClams CreateClams()
        {
            return new FreshClams();
        }
    }
}
