namespace Decorator
{
    abstract class BeverageWithAdditive : Beverage
    {
        protected Beverage _beverage;

        protected BeverageWithAdditive(Beverage beverage)
        {
            _beverage = beverage;
        }
    }
}