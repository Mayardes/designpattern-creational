// See https://aka.ms/new-console-template for more information
using FactoryMethod.Factory;

Console.WriteLine("Hello, World!");

Console.WriteLine("==========Pizzeria===========");
Console.WriteLine("Which local do you wish to order? (S) São Paulo (R) Rio de Janeiro");
string localChoosed = Console.ReadLine().ToUpper();

Console.WriteLine("Choose your pizza ('M'uzzarella), (C)alabreza");
var pizzaChoosed = Console.ReadLine().ToUpper();

try
{
    PizzaFactoryMethod pizzeria = PizzaSimpleFactory.CreatePizza(localChoosed);
    var pizza = pizzeria.MountPizza(pizzaChoosed);
    Console.WriteLine(pizza.ToPrepare());
    Console.WriteLine("Pizza complete sucessfully");

}catch(Exception e)
{
    Console.WriteLine("Error: " + e);
}