// See https://aka.ms/new-console-template for more information

using Decorator;

Console.WriteLine("Hello, World!");
var pizzaBase = new MediumPizza();

var mediumPizzaWithCheese = new CheesePizzaDecorator(pizzaBase);
Console.WriteLine($"mediumPizzaWithCheese: {mediumPizzaWithCheese.calculatePrice()}");

var p2 = new SalamiPizzaDecorator(mediumPizzaWithCheese);
Console.WriteLine($"mediumPizzaWithCheese and salami : {p2.calculatePrice()}");

var doubleSalamiCheesePizza = new SalamiPizzaDecorator(p2);
Console.WriteLine($"doubleSalamiCheesePizza: {doubleSalamiCheesePizza.calculatePrice()}");

