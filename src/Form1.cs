namespace LinescanPatternGenerator;

public partial class Form1 : Form
{
    readonly IPattern[] Patterns = System.Reflection.Assembly.GetExecutingAssembly()
        .GetTypes()
        .Where(x => x.IsClass)
        .Where(x => x.GetInterfaces().Contains(typeof(IPattern)))
        .Select(x => (IPattern)Activator.CreateInstance(x)!)
        .ToArray();

    IPattern SelectedPattern => Patterns[cbPattern.SelectedIndex];

    public Form1()
    {
        InitializeComponent();

        ScottPlot.AxisRules.SquareZoomOut squareRule = new(formsPlot1.Plot.Axes.Bottom, formsPlot1.Plot.Axes.Left);
        formsPlot1.Plot.Axes.Rules.Add(squareRule);

        foreach (IPattern pattern in Patterns)
        {
            cbPattern.Items.Add(pattern.Name);
        }
        cbPattern.SelectedIndex = 0;

        cbPattern.SelectedIndexChanged += (s, e) => UpdatePlot();
        nudPointCount.ValueChanged += (s, e) => UpdatePlot();
        nudWidthPercent.ValueChanged += (s, e) => UpdatePlot();
        nudOscillationCount.ValueChanged += (s, e) => UpdatePlot();
        nudAmplitudePercent.ValueChanged += (s, e) => UpdatePlot();
        nudRotation.ValueChanged += (s, e) => UpdatePlot();
        UpdatePlot();
    }

    private void UpdatePlot()
    {
        SelectedPattern.Points = (int)nudPointCount.Value;
        SelectedPattern.Oscillations = (int)nudOscillationCount.Value;
        SelectedPattern.WidthFrac = (int)nudWidthPercent.Value / 100.0;
        SelectedPattern.HeightFrac = (double)nudAmplitudePercent.Value / 100.0;
        SelectedPattern.RotationDegrees = (double)nudRotation.Value;

        (double[] xs, double[] ys) = SelectedPattern.GetPoints();
        lblPoints.Text = $"{xs.Length:N0}";

        formsPlot1.Plot.Clear();
        formsPlot1.Plot.Add.Scatter(xs, ys);
        formsPlot1.Plot.Axes.SetLimits(0, 1, 0, 1);
        formsPlot1.Refresh();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new()
        {
            FileName = SelectedPattern.Filename,
            Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*"
        };

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            PvXml.SaveXml(SelectedPattern, saveFileDialog.FileName);
        }
    }
}
