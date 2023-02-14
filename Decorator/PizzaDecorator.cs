namespace Decorator;

public class PizzaDecorator : IPizza
{
    private IPizza _pizza;

    protected PizzaDecorator(IPizza pizza)
    {
        _pizza = pizza;
    }
    public virtual double calculatePrice()
    {
        return _pizza.calculatePrice();
    }


    
}