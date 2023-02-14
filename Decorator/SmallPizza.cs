namespace Decorator;

public class SmallPizza : IPizza
{
    public double calculatePrice()
    {
        return 15;
    }
}