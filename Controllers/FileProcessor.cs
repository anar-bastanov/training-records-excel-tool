using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using System.Xml;
using System.ComponentModel;

namespace ExcelTool.Controllers;

public static class FileProcessor
{
    private static readonly JsonSerializerOptions JsonSerializerConfiguration = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true
    };
    
    private static readonly XmlWriterSettings XmlSerializerConfiguration = new()
    {
        Indent = true,
        OmitXmlDeclaration = true,
        NewLineOnAttributes = true
    };

    private static readonly XmlSerializerNamespaces XmlEmptyNamespaces = new([XmlQualifiedName.Empty]);

    public static void LoadProjectFromExcel(ProjectModel project, string fullPath)
    {
        using var package = new ExcelPackage(fullPath);
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
            int rowCount = ws.Dimension.Rows;

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

    public static void LoadTaskDatabaseFromExcel(BindingList<TaskModel> tasks, string fullPath)
    {
        using var package = new ExcelPackage(fullPath);
        var worksheet = package.Workbook.Worksheets[0];

        ImportTasks(worksheet, tasks);

        static void ImportTasks(ExcelWorksheet ws, BindingList<TaskModel> tasks)
        {
            int rowCount = ws.Dimension.Rows;

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

    public static void SaveProjectToExcel(ProjectModel project, string fullPath)
    {
        File.Delete(fullPath);

        using var package = new ExcelPackage(fullPath);
        var worksheet = package.Workbook.Worksheets.Add("Main");

        ConfigureTemplate(worksheet);
        ExportProfileInfo(worksheet, project.ProfileInfo);
        ExportTasks(worksheet, project.Tasks);

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
                ws.Cells[row, 1].Value = task.Reference;
                ws.Cells[row, 2].Value = task.Description;
                ws.Cells[row, 3].Value = task.TrainingCategory;
                ws.Cells[row, 4].Value = task.Type;
                ws.Cells[row, 5].Value = task.TrainingStarted;
                ws.Cells[row, 6].Value = task.TrainingCompleted;
                ws.Cells[row, 7].Value = task.TrainerInitials;
                ws.Cells[row, 8].Value = task.CertifierInitials;
                ws.Cells[row, 9].Value = task.CertifyingScore;
                ws.Cells[row, 10].Value = task.RequiredScore;

                ++row;
            }
        }
    }

    public static void SaveProjectToJson(ProjectModel project, string fullPath)
    {
        using var file = File.CreateText(fullPath);
        string data = JsonSerializer.Serialize(project, JsonSerializerConfiguration);
        file.WriteLine(data);
    }

    public static void SaveProjectToXML(ProjectModel project, string fullPath)
    {
        using var file = File.CreateText(fullPath);
        var serializer = new XmlSerializer(typeof(ProjectModel));
        using var stringWriter = new StringWriter();
        using XmlWriter writer = XmlWriter.Create(stringWriter, XmlSerializerConfiguration);
        serializer.Serialize(writer, project, XmlEmptyNamespaces);
        string data = stringWriter.ToString();
        file.WriteLine(data);
    }
}
