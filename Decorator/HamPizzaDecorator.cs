namespace Decorator;

public class HamPizzaDecorator : PizzaDecorator
{
    protected HamPizzaDecorator(IPizza pizza) : base(pizza)
    {
    }

    public override double calculatePrice()
    {
        return base.calculatePrice() + 5;
    }
}