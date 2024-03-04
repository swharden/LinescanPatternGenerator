namespace LinescanPatternGenerator.Patterns;

public class Sine
{
    public int Points { get; set; } = 100;
    public int Oscillations { get; set; } = 10;
    public double WidthFrac { get; set; } = 0.5;
    public double HeightFrac { get; set; } = 0.1;
    public double RotationDegrees { get; set; } = 0;

    public (double[] xs, double[] ys) GetPoints()
    {
        double xStart = -WidthFrac / 2;
        double xEnd = WidthFrac / 2;
        double xSpan = xEnd - xStart;

        double[] fracs = Enumerable.Range(0, Points)
            .Select(i => (double)i / (Points - 1))
            .ToArray();

        double[] xs = fracs
            .Select(frac => xStart + frac * xSpan)
            .ToArray();

        double[] ys = fracs
            .Select(x => Math.Sin(x * Math.PI * 2 * Oscillations))
            .Select(x => HeightFrac * x / 2)
            .ToArray();

        (xs, ys) = RotatePoints(xs, ys, RotationDegrees);

        for (int i = 0; i < xs.Length; i++)
        {
            xs[i] += .5;
            ys[i] += .5;
        }

        return (xs, ys);
    }

    public static (double[], double[]) RotatePoints(double[] x, double[] y, double angle)
    {
        double radians = Math.PI * angle / 180;

        double[] newX = new double[x.Length];
        double[] newY = new double[y.Length];

        for (int i = 0; i < x.Length; i++)
        {
            double cosTheta = Math.Cos(radians);
            double sinTheta = Math.Sin(radians);

            newX[i] = x[i] * cosTheta - y[i] * sinTheta;
            newY[i] = x[i] * sinTheta + y[i] * cosTheta;
        }

        return (newX, newY);
    }
}
