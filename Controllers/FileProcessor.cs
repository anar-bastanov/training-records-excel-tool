using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;

namespace ExcelTool.Controllers;

public static class FileProcessor
{
    public static void LoadFromText(ProjectModel project, string fullPath)
    {
        using var file = File.OpenText(fullPath);
        project.ProfileInfo.Trainee = file.ReadLine() ?? "";
        project.ProfileInfo.Course = file.ReadLine() ?? "";
        project.ProfileInfo.Position = file.ReadLine() ?? "";
        project.ProfileInfo.Manager = file.ReadLine() ?? "";
    }

    public static void SaveToText(ProjectModel project, string fullPath)
    {
        using var file = File.CreateText(fullPath);
        file.WriteLine(project.ProfileInfo.Trainee);
        file.WriteLine(project.ProfileInfo.Course);
        file.WriteLine(project.ProfileInfo.Position);
        file.WriteLine(project.ProfileInfo.Manager);
    }

    public static void LoadFromExcel(ProjectModel project, string fullPath)
    {
        using var package = new ExcelPackage(fullPath);
        var worksheet = package.Workbook.Worksheets[0];

        ImportProfileInfo(worksheet, project.ProfileInfo);

        static void ImportProfileInfo(ExcelWorksheet ws, ProfileModel profile)
        {
            profile.Trainee = ws.Cells["B1"].Value?.ToString() ?? "";
            profile.Course = ws.Cells["B2"].Value?.ToString() ?? "";
            profile.Position = ws.Cells["E1"].Value?.ToString() ?? "";
            profile.Manager = ws.Cells["E2"].Value?.ToString() ?? "";
        }
    }

    public static void SaveToExcel(ProjectModel project, string fullPath)
    {
        File.Delete(fullPath);

        using var package = new ExcelPackage(fullPath);
        var worksheet = package.Workbook.Worksheets.Add("Main");

        ConfigureTemplate(worksheet);
        ExportProfileInfo(worksheet, project.ProfileInfo);
        ExportTasks(worksheet);

        package.Save();

        static void ConfigureTemplate(ExcelWorksheet ws)
        {
            // Define merged cells
            ws.Cells["C1:D1"].Merge = true;
            ws.Cells["C2:D2"].Merge = true;
            ws.Cells["E1:J1"].Merge = true;
            ws.Cells["E2:J2"].Merge = true;

            // Adjust size
            ws.Columns[1].Width = 31.0;
            ws.Columns[2].Width = 44.0;
            ws.Columns[3, 4].Width = 5.0;
            ws.Columns[5, 10].Width = 10.0;
            ws.Rows[3].Height = 45.0;

            // Adjust font
            ws.Rows[3].Style.Font.Size = 9;
            ws.Cells["A1"].Style.Font.Bold = true;
            ws.Cells["A2"].Style.Font.Bold = true;
            ws.Cells["C1"].Style.Font.Bold = true;
            ws.Cells["C2"].Style.Font.Bold = true;
            ws.Rows[3].Style.Font.Bold = true;

            // Adjust text alignment
            ws.Cells["A1:J3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            ws.Cells["A3:J3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            
            // Enable world wrap
            ws.Cells["C3:J3"].Style.WrapText = true;

            // Adjust orientation
            ws.Cells["C3:D3"].Style.TextRotation = 90;
        }

        static void ExportProfileInfo(ExcelWorksheet ws, ProfileModel profile)
        {
            // Define static labels
            ws.Cells["A1"].Value = "Trainee:";
            ws.Cells["A2"].Value = "Course:";
            ws.Cells["C1"].Value = "Position:";
            ws.Cells["C2"].Value = "Manager:";

            // Write data
            ws.Cells["B1"].Value = profile.Trainee;
            ws.Cells["B2"].Value = profile.Course;
            ws.Cells["E1"].Value = profile.Position;
            ws.Cells["E2"].Value = profile.Manager;
        }

        static void ExportTasks(ExcelWorksheet ws)
        {
            // Define static labels
            ws.Cells["A3"].Value = "Reference";
            ws.Cells["B3"].Value = "Tasks, Knowledges, and Technical References";
            ws.Cells["C3"].Value = "Training Category";
            ws.Cells["D3"].Value = "Type";
            ws.Cells["E3"].Value = "Training Started";
            ws.Cells["F3"].Value = "Training Completed";
            ws.Cells["G3"].Value = "Trainer Initials";
            ws.Cells["H3"].Value = "Certifier Initials";
            ws.Cells["I3"].Value = "Certifying Score";
            ws.Cells["J3"].Value = "Required Score";
        }
    }
}
