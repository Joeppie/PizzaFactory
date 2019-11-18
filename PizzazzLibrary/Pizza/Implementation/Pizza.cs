using PizzazzLibrary.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PizzazzLibrary.Ingredients.Implementation;

namespace PizzazzLibrary.Implementation
{

    /// <summary>
    /// A generic pizza
    /// </summary>
    public class Pizza
    {

        /// <summary>
        /// The list of ingredients which can be modified by inheritors.
        /// </summary>
        protected List<Ingredient> _ingredients = new List<Ingredient>();

        public bool IsPrepared { get; private set; }
        public bool IsCut { get; private set; }
        public bool IsBaked { get; private set; }
        public bool IsPackaged { get; private set; }

        /// <summary>
        /// Gets the price of the pizza.
        /// </summary>
        public virtual double Price => Ingredients.Sum(i=>i.Price);

        /// <summary>
        /// The ingredients the pizza has. Creates a duplicate list.
        /// </summary>
        public IEnumerable<Ingredient> Ingredients => _ingredients.ToList();

        
        public virtual void Prepare()
        {
            if(IsPrepared)
            {
                throw new InvalidOperationException("Cannot prepare the same pizza twice");
            }
            _ingredients.Add(new Dough());
            IsPrepared = true;
        }

        public void Bake()
        {
            foreach (var ingredient in _ingredients)
            {
                ingredient.Bake();
            }
            IsBaked = true;
        }

        public void Cut()
        {
            IsCut = true;
        }

        public void Package()
        {
            IsPackaged = true;
        }

        /// <summary>
        /// Provide a culinary description of the pizza.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            List<string> descriptions = new List<string>();

            if (IsPrepared) descriptions.Add("fully prepared");
            if (IsBaked) descriptions.Add("freshly Baked");
            if (IsCut) descriptions.Add("neatly cut");
            if (IsPackaged) descriptions.Add("delicately packaged");

           string description = String.Join(", ", descriptions);
           string ingredients = String.Join(", ", Ingredients);

            return $"A {description} pizza with {ingredients} for just ${Price}.";
        }

    }
}
