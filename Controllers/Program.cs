global using ExcelTool.Models;
global using ExcelTool.Views;
global using ExcelTool.Controllers;
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

        var mainForm = new MainForm();
        _ = new ProjectManager(mainForm);

        Application.Run(mainForm);
    }
}
