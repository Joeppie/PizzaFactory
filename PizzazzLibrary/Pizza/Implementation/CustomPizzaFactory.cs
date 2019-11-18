using PizzazzLibrary.Ingredients.Interfaces;
using PizzazzLibrary.Interfaces;
using PizzazzLibrary.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzazzLibrary.Implementation
{
    public class CustomPizzaFactory : IPizzaFactory
    {
        public Pizza BasePizza { get; set; }
        private CustomPizaDecorator DecoratedPizza { get; set; }
        public List<Ingredient> ExtraIngredients { get; set; }

        public Pizza PreparePizza()
        {
            if (BasePizza == null) BasePizza = new Pizza(); //Didn't specify a pizza? Then start with one containing only dough.
            if (ExtraIngredients == null) ExtraIngredients = new List<Ingredient>();

            DecoratedPizza = new CustomPizaDecorator(BasePizza);

            foreach (var ingredient in ExtraIngredients)
            {
                DecoratedPizza.AddIngredient(ingredient);
            }

            DecoratedPizza.Prepare();

            return DecoratedPizza;
        }
    }
}
