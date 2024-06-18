using System.IO;

namespace ExcelTool.Controllers;

public static class FileProcessor
{
    public static void SaveAsText(ProjectModel model, string fullPath)
    {
        using var file = File.CreateText(fullPath);
        file.WriteLine(model.ProfileInfo.Trainee);
        file.WriteLine(model.ProfileInfo.Course);
        file.WriteLine(model.ProfileInfo.Position);
        file.WriteLine(model.ProfileInfo.Manager);
    }

    public static void LoadFromText(ProjectModel model, string fullPath)
    {
        using var file = File.OpenText(fullPath);
        model.ProfileInfo.Trainee = file.ReadLine() ?? "";
        model.ProfileInfo.Course = file.ReadLine() ?? "";
        model.ProfileInfo.Position = file.ReadLine() ?? "";
        model.ProfileInfo.Manager = file.ReadLine() ?? "";
    }
}
