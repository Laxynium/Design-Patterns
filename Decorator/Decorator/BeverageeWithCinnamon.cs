namespace Decorator
{
    class BeverageeWithCinnamon : BeverageWithAdditive
    {
        public BeverageeWithCinnamon(Beverage beverage)
            : base(beverage)
        {
        }

        public override decimal Price => _beverage.Price + 1.1M;

        public override string ToString()
        {
            return _beverage.ToString() + " with cinnamon";

        }
        
    }
}