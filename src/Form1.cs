using System.Text;

namespace LinescanPatternGenerator;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        nudPointCount.ValueChanged += (s, e) => UpdatePlot();
        nudWidthPercent.ValueChanged += (s, e) => UpdatePlot();
        nudOscillationCount.ValueChanged += (s, e) => UpdatePlot();
        nudAmplitudePercent.ValueChanged += (s, e) => UpdatePlot();
        UpdatePlot();
    }

    private (double[] xs, double[] ys) GetPoints()
    {
        int points = (int)nudPointCount.Value;
        double xWidth = (double)nudWidthPercent.Value / 100.0;
        double xPad = (1 - xWidth) / 2;
        double xStart = xPad;
        double xEnd = 1 - xPad;
        double xSpan = xEnd - xStart;

        double oscillations = (double)nudOscillationCount.Value;
        double amplitude = (double)nudAmplitudePercent.Value / 100;

        double[] fracs = Enumerable.Range(0, points)
            .Select(i => (double)i / (points - 1))
            .ToArray();

        double[] xs = fracs
            .Select(frac => xStart + frac * xSpan)
            .ToArray();

        double[] ys = fracs
            .Select(x => Math.Sin(x * Math.PI * 2 * oscillations))
            .Select(x => amplitude * x / 2 + .5)
            .ToArray();

        return (xs, ys);
    }

    private void UpdatePlot()
    {
        (double[] xs, double[] ys) = GetPoints();

        formsPlot1.Plot.Clear();
        formsPlot1.Plot.AddScatter(xs, ys);
        formsPlot1.Plot.SetAxisLimits(0, 1, 0, 1);
        formsPlot1.Refresh();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        SaveFileDialog savefile = new()
        {
            FileName = $"linescan.xml",
            Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*"
        };

        if (savefile.ShowDialog() == DialogResult.OK)
        {
            SaveXML(savefile.FileName);
        }
    }

    private void SaveXML(string path)
    {
        (double[] xs, double[] ys) = GetPoints();

        StringBuilder sb = new();
        sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
        sb.AppendLine("<PVLinescanDefinition scanContinuous=\"False\" mode=\"freeHand\">");
        for (int i = 0; i < xs.Length; i++)
            sb.AppendLine($"  <PVFreehand x=\"{xs[i]}\" y=\"{ys[i]}\" />");
        sb.AppendLine("</PVLinescanDefinition>");

        File.WriteAllText(path, sb.ToString());
    }
}
