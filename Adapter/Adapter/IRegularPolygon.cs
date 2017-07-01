namespace Adapter
{
    interface IRegularPolygon
    {
        Point<float> Center { get; }

        int NumberOfSides { get; }

        float LengthOfSide { get; }

        string Parameters();
        string Name();

        float CalculateCircuit();

        float CalculateArea();
    }
}
