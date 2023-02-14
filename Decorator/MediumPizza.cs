namespace Decorator;

public class MediumPizza : IPizza
{
    public double calculatePrice()
    {
        return 20;
    }
}