global using ExcelTool.Models;
global using ExcelTool.Views;
global using ExcelTool.Controllers;
global using System.Drawing;
global using System.Windows.Forms;
using System;
using OfficeOpenXml;
using System.IO;

namespace ExcelTool;

/* TODO

 + TextBox offset/pad text inside
 + Display open filename and unsaved change asterisk in title
 + Detect unsaved changes
 - Better data binding
 - Better EnableStripMenuItems implementation
 - Rethink architecture
 - Should you prefer expression-bodied members and one-line if statements
 - Exception handling everywhere
 - Better error messages for asserts and throws
 - Reconfigure TabStop for all elements
 - Do not generate unnecessary fields
 - Set appropriate cursors for everything

*/

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        var mainForm = new MainForm();
        _ = new ProjectManager(mainForm);

        Application.Run(mainForm);
    }
}
