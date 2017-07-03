namespace Decorator
{
    class BeverageWithSuger : BeverageWithAdditive
    {
        public BeverageWithSuger(Beverage beverage)
            : base(beverage)
        {
        }

        public override decimal Price => _beverage.Price + 0.7M;

        public override string ToString()
        {
            return _beverage.ToString() + " with lemon";
        }
    }
}