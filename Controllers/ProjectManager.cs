using System.ComponentModel;

namespace ExcelTool.Controllers;

public sealed class ProjectManager : INotifyPropertyChanged
{
    private readonly MainForm _mainView;

    private ApplicationState _applicationState = ApplicationState.Idle;

    private ProjectModel? _currentProject;

    private string _sourceFilePath = "";

    private string _taskDatabasePath = "";

    public event PropertyChangedEventHandler? PropertyChanged;

    public ApplicationState State
    {
        get
        {
            return _applicationState;
        }
        // private
        set
        {
            if (_applicationState == value)
                return;

            _applicationState = value;
            _mainView.EnableEditor(value is not ApplicationState.Idle);
            _mainView.EnableStripMenuItems(value);
            _mainView.EnableTitleFilename(value, _sourceFilePath);
        }
    }

    public string TaskDatabasePath
    {
        get => _taskDatabasePath is "" ? "No database is selected" : _taskDatabasePath;
        set => this.SetProperty(ref _taskDatabasePath, value, PropertyChanged);
    }

    public ProjectManager(MainForm mainView)
    {
        _mainView = mainView;
        mainView.FileNewRequested += CreateNewProject;
        mainView.FileOpenRequested += OpenProject;
        mainView.FileCloseRequested += CloseCurrentProject;
        mainView.FileSaveRequested += () => SaveCurrentProject();
        mainView.TaskDatabaseSelectRequested += SelectTaskDatabase;
        mainView.TaskDatabaseFilePathCopyRequested += CopyTaskDatabaseFilePath;
        mainView.ApplicationExitRequested += ExitApplication;
        mainView.BindTaskDatabasePath(this);
    }

    public void CreateNewProject()
    {
        if (!CheckUnsavedChanges())
            return;

        _sourceFilePath = "";
        _currentProject = new ProjectModel();
        _currentProject.PropertyChanged += (_, _) => State = State.MarkUnsavedChanges();
        _mainView.BindProjectData(_currentProject);
        State = ApplicationState.NewFile;
    }

    public void OpenProject()
    {
        if (!CheckUnsavedChanges())
            return;

        if (!MainForm.TryPromptOpenFile(out string fullPath))
            return;

        _sourceFilePath = fullPath;
        _currentProject = new ProjectModel();
        FileProcessor.LoadFromExcel(_currentProject, fullPath);
        _currentProject.PropertyChanged += (_, _) => State = State.MarkUnsavedChanges();
        _mainView.BindProjectData(_currentProject);
        State = ApplicationState.OpenFile;
    }

    public void CloseCurrentProject()
    {
        if (!CheckUnsavedChanges())
            return;

        _currentProject = null;
        _sourceFilePath = "";
        State = ApplicationState.Idle;
    }

    public bool SaveCurrentProject()
    {
        if (State is ApplicationState.OpenFileUnsavedChanges)
        {
            FileProcessor.SaveToExcel(_currentProject!, _sourceFilePath);
        }
        else
        {
            if (!MainForm.TryPromptSaveFile(out string fullPath))
                return false;

            _sourceFilePath = fullPath;
            FileProcessor.SaveToExcel(_currentProject!, fullPath);
        }

        State = ApplicationState.OpenFile;
        return true;
    }

    public void SelectTaskDatabase()
    {
        if (!MainForm.TryPromptSelectTaskDatabase(out string fullPath))
            return;

        TaskDatabasePath = fullPath;
    }
    
    public void CopyTaskDatabaseFilePath()
    {
        if (_taskDatabasePath is "")
            return;

        Clipboard.SetText(_taskDatabasePath);
    }

    public bool CheckUnsavedChanges()
    {
        if (!State.HasUnsavedChanges())
            return true;

        var choice = MainForm.WarnUnsavedChanges();

        if (choice is DialogResult.Cancel)
            return false;

        if (choice is DialogResult.Yes)
            return SaveCurrentProject();

        return true;
    }

    public void ExitApplication(FormClosingEventArgs e)
    {
        e.Cancel = !CheckUnsavedChanges();
    }
}
