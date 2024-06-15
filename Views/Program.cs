// global using ExcelTool.Models;
global using ExcelTool.Views;
// global using ExcelTool.Controls;
global using System.Drawing;
global using System.Windows.Forms;
using System;

namespace ExcelTool;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}
