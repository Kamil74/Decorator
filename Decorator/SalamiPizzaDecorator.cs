namespace Decorator;

public class SalamiPizzaDecorator : PizzaDecorator
{
    public SalamiPizzaDecorator(IPizza pizza) : base(pizza)
    {
    }

    public override double calculatePrice()
    {
        return base.calculatePrice() + 6.5;
    }
}