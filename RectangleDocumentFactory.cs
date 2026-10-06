using ACadSharp;
using ACadSharp.Entities;
using CSMath;

namespace CadDrawingLab;

internal static class RectangleDocumentFactory
{
    public static CadDocument Create(double width, double height)
    {
        var document = new CadDocument();

        document.Header.Version = ACadVersion.AC1032;
        document.Header.ShowModelSpace = true;

        var bottomLine = new Line(
            new XYZ(0, 0, 0),
            new XYZ(width, 0, 0));
        var rightLine = new Line(
            new XYZ(width, 0, 0),
            new XYZ(width, height, 0));
        var topLine = new Line(
            new XYZ(width, height, 0),
            new XYZ(0, height, 0));
        var leftLine = new Line(
            new XYZ(0, height, 0),
            new XYZ(0, 0, 0));

        document.Entities.Add(bottomLine);
        document.Entities.Add(rightLine);
        document.Entities.Add(topLine);
        document.Entities.Add(leftLine);

        return document;
    }
}
