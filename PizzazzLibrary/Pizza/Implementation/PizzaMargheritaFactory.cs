using PizzazzLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzazzLibrary.Implementation
{
    /// <summary>
    /// Singleton implementation Margherita pizza only producing factory.
    /// taken from/inspired by.: <seealso cref="https://csharpindepth.com/articles/singleton"/>
    /// </summary>
    public class PizzaMargheritaFactory : IPizzaFactory
    {
        private static readonly PizzaMargheritaFactory instance = new PizzaMargheritaFactory();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static PizzaMargheritaFactory()
        {
        }

        private PizzaMargheritaFactory()
        {
        }

        public static PizzaMargheritaFactory Instance
        {
            get
            {
                return instance;
            }
        }

        public Pizza PreparePizza()
        {
            var pizza = new PizzaMargherita();                                              

            pizza.Prepare();
            
            return pizza;
        }
    }
}
