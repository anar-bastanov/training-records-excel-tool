global using TaskScore = (string TaskReference, string RequiredScore);
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using System.Xml;
using System.ComponentModel;
using System;
using System.Collections.Generic;

namespace ExcelTool.Controllers;

/// <summary>
/// A <see langword="static"/> class that contains methods for <see cref="ProjectModel"/> to save to and load
/// from a few files formats such as Excel (.xlsx), JSON (.json), and XML (.xml).
/// </summary>
public static class FileProcessor
{
    /// <summary>
    /// A cached instance used to determine the style of output JSON files.
    /// </summary>
    private static readonly JsonSerializerOptions JsonSerializerConfiguration = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true
    };

    /// <summary>
    /// A cached instance used to determine the style of output XML files.
    /// </summary>
    private static readonly XmlWriterSettings XmlSerializerConfiguration = new()
    {
        Indent = true,
        OmitXmlDeclaration = true,
        NewLineOnAttributes = true
    };

    /// <summary>
    /// A cached instance used to avoid generating other unnecessary lines in output XML files.
    /// </summary>
    private static readonly XmlSerializerNamespaces XmlEmptyNamespaces = new([XmlQualifiedName.Empty]);

    /// <summary>
    /// Opens an Excel file at a location specified by <paramref name="fullPath"/> and modifies
    /// <paramref name="project"/> with values extracted from cells representing <see cref="ProjectModel"/>.
    /// </summary>
    /// <param name="project">The project to write to.</param>
    /// <param name="fullPath">Absolute path to the Excel file.</param>
    public static void LoadProjectFromExcel(ProjectModel project, string fullPath)
    {
        using var package = new ExcelPackage(fullPath);

        // For some reason, you can have Excel files with no worksheets...
        if (package.Workbook.Worksheets.Count is 0)
            return;

        var worksheet = package.Workbook.Worksheets[0];

        ImportProfileInfo(worksheet, project.ProfileInfo);
        ImportTasks(worksheet, project.Tasks);

        static void ImportProfileInfo(ExcelWorksheet ws, ProfileModel profile)
        {
            profile.Trainee = ws.Cells["B1"].Value?.ToString() ?? "";
            profile.Course = ws.Cells["B2"].Value?.ToString() ?? "";
            profile.Position = ws.Cells["E1"].Value?.ToString() ?? "";
            profile.Manager = ws.Cells["E2"].Value?.ToString() ?? "";
        }

        static void ImportTasks(ExcelWorksheet ws, BindingList<TaskModel> tasks)
        {
            // `Dimension` returns null if the worksheet contains no cells
            int rowCount = ws.Dimension?.Rows ?? 0;

            for (int i = 4; i <= rowCount; ++i)
            {
                var task = new TaskModel()
                {
                    Reference = ws.Cells[i, 1].Value?.ToString() ?? "",
                    Description = ws.Cells[i, 2].Value?.ToString() ?? "",
                    TrainingCategory = ws.Cells[i, 3].Value?.ToString() ?? "",
                    Type = ws.Cells[i, 4].Value?.ToString() ?? "",
                    TrainingStarted = ws.Cells[i, 5].Value?.ToString() ?? "",
                    TrainingCompleted = ws.Cells[i, 6].Value?.ToString() ?? "",
                    TrainerInitials = ws.Cells[i, 7].Value?.ToString() ?? "",
                    CertifierInitials = ws.Cells[i, 8].Value?.ToString() ?? "",
                    CertifyingScore = ws.Cells[i, 9].Value?.ToString() ?? "",
                    RequiredScore = ws.Cells[i, 10].Value?.ToString() ?? "",
                };

                tasks.Add(task);
            }
        }
    }

    /// <summary>
    /// Opens an Excel file at a location specified by <paramref name="fullPath"/> and adds rows of
    /// tasks from the file to <paramref name="tasks"/>.
    /// </summary>
    /// <param name="tasks">The collection to populate.</param>
    /// <param name="fullPath">Absolute path to the Excel file.</param>
    public static void LoadTaskDatabaseFromExcel(BindingList<TaskModel> tasks, string fullPath)
    {
        using var package = new ExcelPackage(fullPath);

        // For some reason, you can have Excel files with no worksheets...
        if (package.Workbook.Worksheets.Count is 0)
            return;

        var worksheet = package.Workbook.Worksheets[0];

        ImportTasks(worksheet, tasks);

        static void ImportTasks(ExcelWorksheet ws, BindingList<TaskModel> tasks)
        {
            // `Dimension` returns null if the worksheet contains no cells
            int rowCount = ws.Dimension?.Rows ?? 0;

            for (int i = 2; i <= rowCount; ++i)
            {
                var task = new TaskModel()
                {
                    Reference = ws.Cells[i, 1].Value?.ToString() ?? "",
                    Description = ws.Cells[i, 2].Value?.ToString() ?? "",
                    TrainingCategory = ws.Cells[i, 3].Value?.ToString() ?? "",
                    Type = ws.Cells[i, 4].Value?.ToString() ?? "",
                    TrainingStarted = ws.Cells[i, 5].Value?.ToString() ?? "",
                    TrainingCompleted = ws.Cells[i, 6].Value?.ToString() ?? "",
                    TrainerInitials = ws.Cells[i, 7].Value?.ToString() ?? "",
                    CertifierInitials = ws.Cells[i, 8].Value?.ToString() ?? "",
                    CertifyingScore = ws.Cells[i, 9].Value?.ToString() ?? "",
                    RequiredScore = ws.Cells[i, 10].Value?.ToString() ?? "",
                };

                tasks.Add(task);
            }
        }
    }

    /// <summary>
    /// Opens an Excel file at a location specified by <paramref name="fullPath"/> and extracts
    /// category labels from the first row of the sheet.
    /// </summary>
    /// <param name="fullPath">Absolute path to the Excel file.</param>
    /// <returns>An <see cref="IEnumerable{T}"/> of category names.</returns>
    public static IEnumerable<string> LoadRequiredScoreCategoriesFromExcel(string fullPath)
    {
        using var package = new ExcelPackage(fullPath);

        if (package.Workbook.Worksheets.Count is 0)
            return [];

        var worksheet = package.Workbook.Worksheets[0];

        return ImportCategories(worksheet);

        static IEnumerable<string> ImportCategories(ExcelWorksheet ws)
        {
            var categories = new List<string>();
            int columnCount = ws.Dimension?.Columns ?? 0;

            for (int i = 2; i <= columnCount; i++)
            {
                string category = ws.Cells[1, i].Value?.ToString() ?? "";
                categories.Add(category);
            }

            return categories;
        }
    }

    /// <summary>
    /// Opens an Excel file at a location specified by <paramref name="fullPath"/> and populates
    /// the list <paramref name="scores"/> with required scores extracted from a selected column.
    /// </summary>
    /// <param name="scores">A list to populate.</param>
    /// <param name="fullPath">Absolute path to the Excel file.</param>
    /// <param name="categoryIndex">A zero-based index of a column of required scores.</param>
    public static void LoadRequiredScoresFromExcel(List<TaskScore> scores, string fullPath, int categoryIndex)
    {
        using var package = new ExcelPackage(fullPath);

        if (package.Workbook.Worksheets.Count is 0)
            return;

        var worksheet = package.Workbook.Worksheets[0];

        if (categoryIndex < 0 || categoryIndex >= (worksheet.Dimension?.Rows ?? 1) - 1)
            return;

        ImportScores(worksheet, scores, categoryIndex);

        static void ImportScores(ExcelWorksheet ws, List<TaskScore> scores, int categoryIndex)
        {
            int rowCount = ws.Dimension?.Rows ?? 0;

            for (int i = 2; i <= rowCount; ++i)
            {
                string reference = ws.Cells[i, 1].Value?.ToString() ?? "";
                string score = ws.Cells[i, 2 + categoryIndex].Value?.ToString() ?? "";

                scores.Add(new TaskScore(reference, score));
            }
        }
    }

    /// <summary>
    /// Creates or replaces an Excel file at a location specified by <paramref name="fullPath"/> and
    /// writes all necessary data from <paramref name="project"/> to the Excel file after formatting it.
    /// </summary>
    /// <param name="project">The project to read from.</param>
    /// <param name="fullPath">Absolute path to the Excel file.</param>
    public static void SaveProjectToExcel(ProjectModel project, string fullPath)
    {
        // Update the file by replacing it with a new one if it already exists
        File.Delete(fullPath);

        using var package = new ExcelPackage(fullPath);
        var worksheet = package.Workbook.Worksheets.Add("Main");

        ConfigureTemplate(worksheet, project.Tasks.Count);
        ExportProfileInfo(worksheet, project.ProfileInfo);
        ExportTasks(worksheet, project.Tasks);

        package.Save();

        static void ConfigureTemplate(ExcelWorksheet ws, int taskCount)
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

            // Set background color
            var blue = Color.FromArgb(0x538DD5);
            //  var green = Color.FromArgb(0x00B050);
            //  var yellow = Color.FromArgb(0xFFFF00);
            //  var red = Color.FromArgb(0xFF0000);
            ws.Cells["A1:J3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["A1:J3"].Style.Fill.BackgroundColor.SetColor(blue);

            // Set borders
            ws.Cells[1, 1, 3 + taskCount, 10].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            ws.Cells[1, 1, 3 + taskCount, 10].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            ws.Cells[1, 1, 3 + taskCount, 10].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells[1, 1, 3 + taskCount, 10].Style.Border.Left.Style = ExcelBorderStyle.Thin;

            // Adjust font
            ws.Cells.Style.Font.Name = "Arial";
            ws.Cells.Style.Font.Size = 9;
            ws.Rows[3].Style.Font.Bold = true;
            ws.Cells["A1:A2"].Style.Font.Bold = true;
            ws.Cells["C1:C2"].Style.Font.Bold = true;

            // Adjust text alignment
            ws.Cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            ws.Columns[1, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            ws.Columns[3, 10].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Rows[1, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            ws.Cells["A3:J3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            // Enable world wrap
            ws.Columns.Style.WrapText = true;
            ws.Columns.BestFit = true;

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

        static void ExportTasks(ExcelWorksheet ws, BindingList<TaskModel> tasks)
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

            // Write data
            int row = 4;

            foreach (var task in tasks)
            {
                // If we just set `Value` to our string values, Excel will not automatically
                // format numbers or dates but will treat them as plain text, which causes
                // warnings in the worksheet for cells containing numbers that are written as strings
                ws.Cells[row, 1].Value = ParseType(task.Reference);
                ws.Cells[row, 2].Value = ParseType(task.Description);
                ws.Cells[row, 3].Value = ParseType(task.TrainingCategory);
                ws.Cells[row, 4].Value = ParseType(task.Type);
                ws.Cells[row, 5].Value = ParseType(task.TrainingStarted);
                ws.Cells[row, 6].Value = ParseType(task.TrainingCompleted);
                ws.Cells[row, 7].Value = ParseType(task.TrainerInitials);
                ws.Cells[row, 8].Value = ParseType(task.CertifierInitials);
                ws.Cells[row, 9].Value = ParseType(task.CertifyingScore);
                ws.Cells[row, 10].Value = ParseType(task.RequiredScore);

                ++row;
            }
        }

        static object ParseType(string value)
        {
            // If you did not understand what this is for, delete this method and run
            // the program without it. After saving the Excel file, try to open it and
            // you will see warnings on cells that contain "potentially integer" values
            if (int.TryParse(value, out int a))
                return a;

            if (double.TryParse(value, out var b))
                return b;

            if (DateOnly.TryParse(value, out var c))
                return c;

            return value;
        }
    }

    /// <summary>
    /// Writes all necessary data from <paramref name="project"/> to a newly created JSON file
    /// at a location specified by <paramref name="fullPath"/>.
    /// </summary>
    /// <param name="project">The project to read from.</param>
    /// <param name="fullPath">Absolute path to the JSON file.</param>
    public static void SaveProjectToJson(ProjectModel project, string fullPath)
    {
        using var file = File.CreateText(fullPath);
        string data = JsonSerializer.Serialize(project, JsonSerializerConfiguration);
        file.WriteLine(data);
    }

    /// <summary>
    /// Writes all necessary data from <paramref name="project"/> to a newly created XML file
    /// at a location specified by <paramref name="fullPath"/>.
    /// </summary>
    /// <param name="project">The project to read from.</param>
    /// <param name="fullPath">Absolute path to the XML file.</param>
    public static void SaveProjectToXML(ProjectModel project, string fullPath)
    {
        // Don't bother reading it, I just copied it from the internet and it works
        using var file = File.CreateText(fullPath);
        var serializer = new XmlSerializer(typeof(ProjectModel));
        using var stringWriter = new StringWriter();
        using XmlWriter writer = XmlWriter.Create(stringWriter, XmlSerializerConfiguration);
        serializer.Serialize(writer, project, XmlEmptyNamespaces);
        string data = stringWriter.ToString();
        file.WriteLine(data);
    }
}
