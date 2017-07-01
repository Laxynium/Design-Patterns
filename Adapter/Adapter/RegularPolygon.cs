using System;
namespace Adapter
{
    abstract class RegularPolygon : IRegularPolygon
    {

        protected RegularPolygon(Point<float> center,int numberOfSides,float lengthOfSide)
        {
            Center = center;
            NumberOfSides = numberOfSides;
            LengthOfSide = lengthOfSide;
        }
        public Point<float> Center { get; private set; }
        public int NumberOfSides { get; private set; }
        public float LengthOfSide { get; private set; }


        public string Parameters()
        {
            return $"Center: {Center.ToString()}\nNumber of sides: {NumberOfSides}\nLength of Side: {LengthOfSide}";
        }

        public abstract string Name();

        public  float CalculateCircuit()
        {
            return NumberOfSides * LengthOfSide;
        }

        public abstract float CalculateArea();
    }
}