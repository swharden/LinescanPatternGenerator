using System.Text;

namespace LinescanPatternGenerator;

public static class PvXml
{
    public static string GetXml(double[] xs, double[] ys)
    {
        StringBuilder sb = new();
        sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
        sb.AppendLine("<PVLinescanDefinition scanContinuous=\"False\" mode=\"freeHand\">");
        for (int i = 0; i < xs.Length; i++)
            sb.AppendLine($"  <PVFreehand x=\"{xs[i]}\" y=\"{ys[i]}\" />");
        sb.AppendLine("</PVLinescanDefinition>");
        return sb.ToString();
    }
}
