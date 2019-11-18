# PizzaFactory
Uses some patterns and OO principles to provide an example of some patterns.
These are detailed below, and a pretty huge SVG image of the class diagram is below.

**Disclaimer; I am a programmer, therefore I make mistakes.**

## Patterns used

### Factory (method) pattern
The factory method pattern is used to produce different implementations of a factory

### Decorator pattern
Pizzas can be decorated by a decorator to add new ingredients.
* These are added after the base ingredients in the prepare() method of the DecoratedPizza.
* DecoratedPizzas can be decorated again, adding more ingredients.

A special factory is responsible for creating decorated pizzas.
* A decorated pizza is more expensive than a 'normal' one; Margherita pizzas constructed via your own list of ingredients cost more!

### Singleton pattern
The margherita factory only produces one kind of pizza and no instance variables are required.
It is a shame to create more than one.
* The specific implementation is thread safe.


## Diagram

Use the zoom functionality on your browser to navigate an isolate specific parts of the diagram.
![Class Diagram](https://raw.githubusercontent.com/Joeppie/PizzaFactory/master/PizzaFactory.svg?sanitize=true)

Can you spot all the patterns above?

## License: MIT License.
