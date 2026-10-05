using ACadSharp;
using ACadSharp.Entities;
using ACadSharp.IO;
using CSMath;
using System.Diagnostics;

namespace CadDrawingLab;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void exportButton_Click(object sender, EventArgs e)
    {
        double width = (double)widthNumericUpDown.Value;
        double height = (double)heightNumericUpDown.Value;

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

        string outputDirectory = Path.Combine(AppContext.BaseDirectory, "Output");

        Directory.CreateDirectory(outputDirectory);

        string dwgPath = Path.Combine(outputDirectory, "rectangle.dwg");

        using (var writer = new DwgWriter(dwgPath, document))
        {
            writer.Write();
        }

        Process.Start(new ProcessStartInfo
        {
            FileName = dwgPath,
            UseShellExecute = true
        });
    }
}

