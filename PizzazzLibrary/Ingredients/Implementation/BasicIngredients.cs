using PizzazzLibrary.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzazzLibrary.Ingredients.Implementation
{
    public class Dough : Ingredient
    {
        public override string Name => "Pizza Dough";
        public override string Description => (Baked ? "Crusty Pizza Dough" : "Raw dough");
        public override double Price => CostPrice + 7; //basisprijs voor pizza's.
        public override double CostPrice => 0.15;
    }

    public class Tomato : Ingredient
    {
        public override string Name => "Tomato Slices";

        public override string Description => (!Baked ? "Raw tasteless tomato" : "Nice Juicy tomato slices.");
        public override double CostPrice => 0.05;
    }

    public class TomatoSauce : Ingredient
    {
        public override string Name => "Tomato Sauce";
        public override string Description => (!Baked ? "Chunky raw tomato sauce" : "Smooth tomato sauce");
        public override double CostPrice => 0.10;
    }

    public class SpicyTomatoSauce : TomatoSauce
    {
        public override string Name => "Spicy Tomato Sauce";
        public override string Description => (!Baked ? "Chunky raw, spicy tomato sauce" : "Smooth and spicy tomato sauce");
    }

    public class Salami : Ingredient
    {
        public override string Name => "Salami Slices";
        public override string Description => (!Baked ? "Cold Salami slices" : "Scorching hot salami slices");
        public override double CostPrice => 0.35;
    }

    public class Cheese : Ingredient
    {
        public override string Name => "Cheese";
        public override string Description => (!Baked ? "Cold cheese flakes" : "Molten golden cheese");
        public override double CostPrice => 0.15;
    }

    public class Basil : Ingredient
    {
        public override string Name => "Basil";
        public override string Description => (!Baked ? "Fresh raw basil" : "Fresh, cooked basil");
        public override double CostPrice => 0.10;
    }
}
