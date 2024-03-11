using System.Text;

namespace LinescanPatternGenerator;

internal static class PvXml
{
    public static void SaveXml(IPattern pattern, string path)
    {
        string xml = GetXml(pattern);
        File.WriteAllText(path, xml);
        Console.WriteLine("Saved:" + Path.GetFullPath(path));
    }

    public static string GetXml(IPattern pattern)
    {
        (double[] xs, double[] ys) = pattern.GetPoints();
        return GetXml(xs, ys);
    }

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
