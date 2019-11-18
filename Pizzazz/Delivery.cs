using PizzazzLibrary.Implementation;
using PizzazzLibrary.Interfaces;

namespace Pizzazz
{
    /// <summary>
    /// Someone who makes pizzas.
    /// The secret of this cook is that he uses a factory to do the hard work.
    /// </summary>
    public class PizzaDelivery
    {
        public IPizzaFactory factory { get; set; }

        /// <summary>
        /// Delivers a pizza which is optionally cut.
        /// </summary>
        /// <param name="cut"></param>
        /// <returns></returns>
        public Pizza DeliverPizza(bool cut = true)
        {

            var pizza = factory.PreparePizza();

            pizza.Bake();
            if (cut)
            {
                pizza.Cut();
            }
            pizza.Package();

            return pizza;
        }
    }
}
