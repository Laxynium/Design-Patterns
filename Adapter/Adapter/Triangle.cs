using System;
using System.Threading;

namespace Adapter
{
    class Triangle : RegularPolygon
    {
        public Triangle(Point<float>center,float lengthOfSide)
            :base(center,3,lengthOfSide)
        {
        }
        public override string Name()
        {
           return "Regular Triangle";
        }

        public override float CalculateArea()
        {
            return (LengthOfSide * LengthOfSide) / 4*(float)Math.Sqrt(3);
        }
    }
}