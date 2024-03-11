namespace LinescanPatternGenerator.Patterns;

public class Sine : IPattern
{
    public int Points { get; set; } = 100;
    public int Oscillations { get; set; } = 10;
    public double WidthFrac { get; set; } = 0.8;
    public double HeightFrac { get; set; } = 0.1;
    public double RotationDegrees { get; set; } = 0;

    public string Name => $"Sine (even X distances)";
    public string Filename => $"linescan-sine-{Points}pt-{Oscillations}osc-{RotationDegrees}deg.xml";

    public (double[] xs, double[] ys) GetPoints()
    {
        Coordinate[] coordinates = new Coordinate[Points];
        for (int i = 0; i < Points; i++)
        {
            double x = (double)i / (Points - 1);
            double y = Math.Sin(x * Math.PI * 2 * Oscillations);
            coordinates[i] = new(x, y);
            coordinates[i].Rotate(RotationDegrees);
            coordinates[i].Multiply(WidthFrac, HeightFrac / 2);
            coordinates[i].Translate((1 - WidthFrac) / 2, .5);
        }

        Coordinate.ShowDistances(coordinates);

        double[] xs = coordinates.Select(x => x.X).ToArray();
        double[] ys = coordinates.Select(x => x.Y).ToArray();

        return (xs, ys);
    }

}
