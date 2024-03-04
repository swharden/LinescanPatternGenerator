namespace LinescanPatternGenerator;

public partial class Form1 : Form
{
    readonly Patterns.Sine Pattern = new();

    public Form1()
    {
        InitializeComponent();

        ScottPlot.AxisRules.SquareZoomOut squareRule = new(formsPlot1.Plot.Axes.Bottom, formsPlot1.Plot.Axes.Left);
        formsPlot1.Plot.Axes.Rules.Add(squareRule);

        nudPointCount.ValueChanged += (s, e) => UpdatePlot();
        nudWidthPercent.ValueChanged += (s, e) => UpdatePlot();
        nudOscillationCount.ValueChanged += (s, e) => UpdatePlot();
        nudAmplitudePercent.ValueChanged += (s, e) => UpdatePlot();
        nudRotation.ValueChanged += (s, e) => UpdatePlot();
        UpdatePlot();
    }

    private void UpdatePlot()
    {
        Pattern.Points = (int)nudPointCount.Value;
        Pattern.Oscillations = (int)nudOscillationCount.Value;
        Pattern.WidthFrac = (int)nudWidthPercent.Value / 100.0;
        Pattern.HeightFrac = (double)nudAmplitudePercent.Value / 100.0;
        Pattern.RotationDegrees = (double)nudRotation.Value;

        (double[] xs, double[] ys) = Pattern.GetPoints();

        formsPlot1.Plot.Clear();
        formsPlot1.Plot.Add.Scatter(xs, ys);
        formsPlot1.Plot.Axes.SetLimits(0, 1, 0, 1);
        formsPlot1.Refresh();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        SaveFileDialog savefile = new()
        {
            FileName = Pattern.Filename,
            Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*"
        };

        if (savefile.ShowDialog() == DialogResult.OK)
        {
            Pattern.SaveXml(savefile.FileName);
        }
    }
}
