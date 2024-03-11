namespace LinescanPatternGenerator.Patterns;

internal class SineEven : IPattern
{
    public int Points { get; set; } = 100;
    public int Oscillations { get; set; } = 10;
    public double WidthFrac { get; set; } = 0.5;
    public double HeightFrac { get; set; } = 0.1;
    public double RotationDegrees { get; set; } = 0;

    public string Name => $"Sine (even X/Y distances)";
    public string Filename => $"linescan-sineEven-{Points}pt-{Oscillations}osc-{RotationDegrees}deg.xml";

    public (double[] xs, double[] ys) GetPoints()
    {
        Coordinate[] coordinates = GetPointsEven_Traverse();

        Coordinate.ShowDistances(coordinates);

        double[] xs = coordinates.Select(x => x.X).ToArray();
        double[] ys = coordinates.Select(x => x.Y).ToArray();
        return (xs, ys);
    }

    Coordinate[] GetPointsEven_Traverse()
    {
        double targetDistance = 2.0 / Points;

        Coordinate[] smooth = new Coordinate[100_000];
        for (int i = 0; i < smooth.Length; i++)
        {
            double x = (double)i / (smooth.Length - 1);
            double y = Math.Sin(x * Math.PI * 2 * Oscillations);
            smooth[i] = new(x, y);
            smooth[i].Rotate(RotationDegrees);
            smooth[i].Multiply(WidthFrac, HeightFrac / 2);
            smooth[i].Translate((1 - WidthFrac) / 2, .5);
        }

        List<Coordinate> coordinates = [smooth.First()];

        for (int i = 0; i < smooth.Length; i++)
        {
            double distance = smooth[i].DistanceFrom(coordinates.Last());
            distance = Math.Abs(distance);
            if (distance >= targetDistance)
            {
                coordinates.Add(smooth[i]);
            }
        }

        return coordinates.ToArray();
    }
}
