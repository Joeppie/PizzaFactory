using PizzazzLibrary.Ingredients.Interfaces;
using PizzazzLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PizzazzLibrary.Implementation
{
    /// <summary>
    /// A customized pizza based on another pizza.
    /// The customer pays 10 cents extra on top each ingredient added! $_$
    /// </summary>
    public class CustomPizaDecorator : PizzaDecorator
    {
        private List<Ingredient> _extraIngredients = new List<Ingredient>();


        private double _calculatedPrice;

        public CustomPizaDecorator(Pizza pizzaToDecorate) : base(pizzaToDecorate)
        {
        }

        public override void Prepare()
        {
            base.Prepare();
            _calculatedPrice = base.Price + _extraIngredients.Sum(e => e.Price) + _extraIngredients.Count * 0.1;
            base._ingredients.AddRange(_extraIngredients);
        }

        public override double Price => IsPrepared ? base.Price + _extraIngredients.Sum(e=>e.Price) + _extraIngredients.Count*0.1 : _calculatedPrice ;

        /// <summary>
        /// Defines extra ingredients that will be added to the pizza when it is prepared.
        /// </summary>
        /// <param name="ingredient"></param>
        public void AddIngredient(Ingredient ingredient)
        {
            _extraIngredients.Add(ingredient);
        }

    }
}
