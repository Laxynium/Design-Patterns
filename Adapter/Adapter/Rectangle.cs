using System.Security.Principal;

namespace Adapter
{
    //Adaptee
    class Square
    {
        
        public Point<float> LeftTopPoint { get; set; }
     
        public float LengthOfSide { get; set; }

        public string Parameters()
        {
            return $"Left edge: {LeftTopPoint.X}\nTop edge: {LeftTopPoint.Y}\n" +
                   $"Length of side: {LengthOfSide}";
        }

        public float CalculateArea()
        {
            return LengthOfSide * LengthOfSide;
        }

    }
}
