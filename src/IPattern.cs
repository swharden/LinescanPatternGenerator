namespace LinescanPatternGenerator;

internal interface IPattern
{
    string Name { get; }
    string Filename { get; }
    int Points { get; set; }
    int Oscillations { get; set; }
    double WidthFrac { get; set; }
    double HeightFrac { get; set; }
    double RotationDegrees { get; set; }
    (double[] xs, double[] ys) GetPoints();
}
