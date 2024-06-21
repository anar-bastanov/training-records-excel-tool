using System;
using System.ComponentModel;

namespace ExcelTool.Models;

public sealed class ProjectModel
{
    public ProfileModel ProfileInfo { get; set; } = new();

    public BindingList<TaskModel> Tasks { get; set; } = new()
    {
        RaiseListChangedEvents = true
    };

    public ProjectModel()
    {
        ProfileInfo.PropertyChanged += (_, _) => PropertyChanged?.Invoke();
        Tasks.ListChanged += (_, _) => PropertyChanged?.Invoke();
    }

    public event Action? PropertyChanged;
}
