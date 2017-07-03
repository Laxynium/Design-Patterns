namespace Decorator
{
    class BeverageWithLemone : BeverageWithAdditive
    {
        public BeverageWithLemone(Beverage beverage)
            : base(beverage)
        {
        }

        public override decimal Price => _beverage.Price + 0.4M;

        public override string ToString()
        {
            return _beverage.ToString() + " with suger";
        }
    }
}