namespace Decorator
{
    class Tee : Beverage
    {
        public override string ToString()
        {
            return "Tee";
        }

        public override decimal Price => 5.0M;
    }
}