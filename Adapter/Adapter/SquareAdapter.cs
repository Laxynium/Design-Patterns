namespace Adapter
{
    class SquareAdapter : RegularPolygon
    {
        private Square _square;

        private static Point<float> CenterOfSquare(Square square)
        {
            return new Point<float>(square.LeftTopPoint.X+square.LengthOfSide,
                square.LeftTopPoint.Y+square.LengthOfSide);
        }
        public SquareAdapter(Square square):
            base(CenterOfSquare(square),4,square.LengthOfSide)
        {
            _square = square;
        }

        public override string Name()
        {
            return "Square";
        }
        public override float CalculateArea()
        {
            return _square.LengthOfSide * _square.LengthOfSide;
        }
    }
}
