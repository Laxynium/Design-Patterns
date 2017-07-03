namespace Decorator
{
    class Coffy : Beverage
    {
        public override string ToString()
        {
            return "Coffy";
        }

        public override decimal Price => 8.0M;
    }
}