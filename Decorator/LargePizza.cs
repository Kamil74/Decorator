namespace Decorator;

public class LargePizza : IPizza
{
    public double calculatePrice()
    {
        return 30;
    }
}