namespace Decorator
{
    abstract class Beverage
    {
        public virtual decimal Price { get; set; }

        public override string ToString()
        {
            return "Napój";
        }
    }
}