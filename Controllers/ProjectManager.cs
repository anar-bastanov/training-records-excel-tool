using System;

namespace ExcelTool.Controllers;

public static class ProjectManager
{
    private static ApplicationState _applicationState = ApplicationState.OnStartMenu;

    private static Project? _currentProject;

    public static event Action<ApplicationState>? OnApplicationStateChanged;

    public static ApplicationState State
    {
        get
        {
            return _applicationState;
        }
        set
        {
            _applicationState = value;
            OnApplicationStateChanged?.Invoke(value);
        }
    }

    public static void CreateNewProject()
    {
        State = ApplicationState.NewFile;
    }

    public static void OpenProject()
    {
        State = ApplicationState.OpenFile;
    }

    public static void CloseCurrentProject()
    {
        State = ApplicationState.OnStartMenu;
    }
}
