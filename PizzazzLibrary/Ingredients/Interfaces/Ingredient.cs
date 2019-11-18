using System;
using System.Collections.Generic;
using System.Text;

namespace PizzazzLibrary.Ingredients.Interfaces
{
   public abstract class Ingredient
    {
        
        public abstract string Name { get; }
        public abstract double CostPrice { get; }
        
        /// <summary>
        /// The price of the ingredient that is charged to customers.
        /// </summary>
        public virtual double Price { get { return CostPrice * 2 + 0.15; } }

        /// <summary>
        /// Describe the ingredient.
        /// </summary>
        public abstract string Description { get;  }

        public bool Baked { get; private set; }

        /// <summary>
        /// Bake the ingredient; this cannot be done except by the PizzazzLibrary.
        /// </summary>
        internal void Bake()
        {
            Baked = true;
        }

        public override string ToString()
        {
            return Description;
        }

    }
}
