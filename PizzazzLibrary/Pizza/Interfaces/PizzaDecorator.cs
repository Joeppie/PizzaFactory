using System;
using System.Collections.Generic;
using System.Text;

namespace PizzazzLibrary.Implementation
{
    public abstract class PizzaDecorator : Pizza
    {
        protected Pizza decoratedPizza { get; private set; }

        public PizzaDecorator(Pizza pizzaToDecorate)
        {
            decoratedPizza = pizzaToDecorate;
        }
    }
}
