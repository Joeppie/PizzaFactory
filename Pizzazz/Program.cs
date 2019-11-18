using PizzazzLibrary.Ingredients.Implementation;
using PizzazzLibrary.Ingredients.Interfaces;
using PizzazzLibrary;
using PizzazzLibrary.Implementation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzazz
{
    class Program
    {
        static void Main(string[] args)
        {
            //De PizzaMargheritaFactory is een singleton; er is er maar één; ze zijn allemaal toch precies hetzelfde.
            var rauwePizza = PizzaMargheritaFactory.Instance.PreparePizza();
            Console.WriteLine($"Vers uit de singleton: {rauwePizza}");
            Debugger.Break();

            GoedkopePizza();
            DurePizza();

            PizzaMargheritaMetSalami();

        }

        static void GoedkopePizza()
        {
            //Maak een goedkope pizza margherita.
            PizzaDelivery cheapDelivery = new PizzaDelivery();

            //We bepalen hier met een property welke pizza wordt gebruikt door onze delivery.
            cheapDelivery.factory = PizzaMargheritaFactory.Instance;
            Pizza goodDeal = cheapDelivery.DeliverPizza();

            Console.WriteLine();
            Console.WriteLine($"GoedkopePizza() \r\n\t {goodDeal}");
            Debugger.Break();
        }

        static void DurePizza()
        {
            //Maak een duurdere pizza margherita door zelf een eigen pizza samen te stellen vanaf het deeg (dom!)
            //Betere keuze is alleen toevoegen wat er nog op moet; omdat je anders per ingredient extra veel betaalt.
            var expensiveDelivery = new PizzaDelivery();
            var customFactory = new CustomPizzaFactory();
            customFactory.ExtraIngredients = new List<Ingredient>() { new TomatoSauce(), new Cheese(), new Basil() };
            expensiveDelivery.factory = customFactory;

            Pizza badDeal = expensiveDelivery.DeliverPizza();

            Console.WriteLine();
            Console.WriteLine($"DurePizza() \r\n\t {badDeal}");
            Debugger.Break();
        }


        static void PizzaMargheritaMetSalami()
        {
            var expensiveDelivery = new PizzaDelivery();
            var customFactory = new CustomPizzaFactory();

            //Geef aan welke Pizza als basis gebruikt moet gaan worden; dit levert aan beter prijs plaatje op.
            customFactory.BasePizza = PizzaMargheritaFactory.Instance.PreparePizza();

            //Het enige extra ingredient is salami.
            customFactory.ExtraIngredients = new List<Ingredient>() { new Salami()};
            expensiveDelivery.factory = customFactory;

            Pizza NotBadNotGreatDeal = expensiveDelivery.DeliverPizza();

            Console.WriteLine();
            Console.WriteLine($"PizzaMargheritaMetSalami() \r\n\t {NotBadNotGreatDeal}");
            Debugger.Break();
        }

    }
}
