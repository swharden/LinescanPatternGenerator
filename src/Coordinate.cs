namespace LinescanPatternGenerator;

public struct Coordinate(double x, double y)
{
    public double X { get; private set; } = x;
    public double Y { get; private set; } = y;

    public readonly double DistanceFrom(Coordinate other)
    {
        double dX = other.X - X;
        double dY = other.Y - Y;
        double dX2 = dX * dX;
        double dY2 = dY * dY;
        return Math.Sqrt(dX2 + dY2);
    }

    public void Translate(double x, double y)
    {
        X += x;
        Y += y;
    }

    public void Multiply(double x, double y)
    {
        X *= x;
        Y *= y;
    }

    public void Rotate(double degrees)
    {
        double radians = Math.PI * degrees / 180;
        double cosTheta = Math.Cos(radians);
        double sinTheta = Math.Sin(radians);
        double newX = X * cosTheta - Y * sinTheta;
        double newY = X * sinTheta + Y * cosTheta;
        X = newX;
        Y = newY;
    }

    public static void ShowDistances(Coordinate[] coordinates)
    {
        double[] distances = Enumerable
            .Range(1, coordinates.Length - 1)
            .Select(x => coordinates[x]
            .DistanceFrom(coordinates[x - 1]))
            .ToArray();
        double distanceMin = distances.Min();
        double distanceMax = distances.Max();
        double distanceMean = distances.Average();
        double distanceDiff = (distanceMax - distanceMin) / distanceMean;

        System.Diagnostics.Debug.WriteLine($"Coordinates: {coordinates.Length}");
        System.Diagnostics.Debug.WriteLine($"Min distance: {distanceMin}");
        System.Diagnostics.Debug.WriteLine($"Max distance: {distanceMax}");
        System.Diagnostics.Debug.WriteLine($"Diff: {distanceDiff * 100:N1}%");
    }
}