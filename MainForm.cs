using ACadSharp;
using System.Diagnostics;

namespace CadDrawingLab;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void ExportButton_Click(object sender, EventArgs e)
    {
        // 幅と高さが1mm以上であることはプロパティで防御している。
        double width = (double)WidthNumericUpDown.Value;
        double height = (double)HeightNumericUpDown.Value;


        CadDocument document;
        try
        {
            document = RectangleDocumentFactory.Create(width, height);
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "DWG生成中にエラーが発生しました。" + ex.Message.ToString(),
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        string dwgPath;
        try
        {
            string outputDirectory = Path.Combine(AppContext.BaseDirectory, "Output");

            Directory.CreateDirectory(outputDirectory);

            dwgPath = Path.Combine(outputDirectory, "rectangle.dwg");

            DwgFileWriter.Write(dwgPath, document);
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "DWG書き出し中にエラーが発生しました。" + ex.Message.ToString(),
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = dwgPath,
                UseShellExecute = true
            });
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                this,
                $"DWGの保存は完了しましたが、既定アプリで開けませんでした。\n" +
                $"保存先: {dwgPath}\n" +
                $"詳細: {ex.Message}",
                "DWG表示エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}

