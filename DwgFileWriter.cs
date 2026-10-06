using ACadSharp;
using ACadSharp.IO;

namespace CadDrawingLab;

internal static class DwgFileWriter
{
    public static void Write(string filePath, CadDocument document)
    {
        using var writer = new DwgWriter(filePath, document);
        writer.Write();
    }
}
