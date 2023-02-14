namespace Decorator;

public class CheesePizzaDecorator : PizzaDecorator
{
    protected internal CheesePizzaDecorator(IPizza pizza) : base(pizza)
    {
    }

    public override double calculatePrice()
    {
        return base.calculatePrice() + 4.5;
    }
}