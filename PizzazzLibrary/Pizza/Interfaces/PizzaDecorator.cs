using System;
using System.Collections.Generic;
using System.Text;

namespace PizzazzLibrary.Pizza.Interfaces
{
    class PizzaDecorator : Pizza
    {
        public Pizza Pizza { get; private set; }


    }
}
