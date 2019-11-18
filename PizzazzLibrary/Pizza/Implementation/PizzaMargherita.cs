using PizzazzLibrary.Ingredients.Implementation;
using PizzazzLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzazzLibrary.Implementation
{
    class PizzaMargherita : PizzaDecorator
    {
        public PizzaMargherita() : base(new Pizza()) { }

        public PizzaMargherita(Pizza pizzaToDecorate) : base(pizzaToDecorate) { }

        public override void Prepare()
        {
            base.Prepare();
            _ingredients.Add(new TomatoSauce());
            _ingredients.Add(new Cheese());
            _ingredients.Add(new Basil());
        }

        /// <summary>
        /// The Pizza Margherita is quite cheap, so costs less than the loose ingredients.
        /// </summary>
        public override double Price => base.Price * 0.80;
    }
}
