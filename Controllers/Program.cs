global using ExcelTool.Models;
global using ExcelTool.Views;
global using ExcelTool.Controllers;
global using System.Drawing;
global using System.Windows.Forms;
using System;
using OfficeOpenXml;

namespace ExcelTool;

/// <summary>
/// The application entry point.
/// </summary>
internal static partial class Program
{
    [STAThread]
    private static void Main()
    {
        // The source code of this software was supposed to follow a design pattern called MVC,
        // which means Model-View-Controller. But I might have been carried away or lost patience
        // at some point in the middle of the development process, hence I do not claim anything
        // about clean code or code architecture. It works in the end, and I am happy with it.

        ApplicationConfiguration.Initialize();
        

        // The library we use to process Excel files is not free for commercial uses.
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        var mainForm = new MainForm();
        _ = new ProjectManager(mainForm);

        // I know it is disgusting, but I had to disable all exceptions to prevent the program
        // from crashing due to dump WinForms bugs
        Application.ThreadException += delegate { };
        AppDomain.CurrentDomain.UnhandledException += delegate { };

        Application.Run(mainForm);
    }
}
