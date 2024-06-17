namespace ExcelTool.Controllers;

public sealed class ProjectManager
{
    private readonly MainForm _mainView;

    private ApplicationState _applicationState = ApplicationState.Idle;

    private ProjectModel? _currentProject;

    private string _sourceFilePath = "";

    public ApplicationState State
    {
        get
        {
            return _applicationState;
        }
        set
        {
            if (_applicationState == value)
                return;

            _applicationState = value;
            _mainView.AdjustStripMenuItemsAndVisuals(value);
        }
    }

    public ProjectManager(MainForm mainView)
    {
        _mainView = mainView;
        mainView.FileNewRequested += CreateNewProject;
        mainView.FileOpenRequested += OpenProject;
        mainView.FileCloseRequested += CloseCurrentProject;
        mainView.FileSaveRequested += () => SaveCurrentProject();
        mainView.ApplicationExitRequested += ExitApplication;
    }

    public void CreateNewProject()
    {
        if (!CheckUnsavedChanges())
            return;

        State = ApplicationState.NewFile;
        _currentProject = new ProjectModel();
        _currentProject.PropertyChanged += (_, _) => State = State.MarkUnsavedChanges();
        _mainView.BindProjectData(_currentProject);
    }

    public void OpenProject()
    {
        if (!CheckUnsavedChanges())
            return;

        if (!MainForm.TryPromptOpenFile(out string fullPath))
            return;

        State = ApplicationState.OpenFile;
        _sourceFilePath = fullPath;
        _currentProject = new ProjectModel();
        FileConverter.LoadFromText(_currentProject, fullPath);
        _currentProject.PropertyChanged += (_, _) => State = State.MarkUnsavedChanges();
        _mainView.BindProjectData(_currentProject);
    }

    public void CloseCurrentProject()
    {
        if (!CheckUnsavedChanges())
            return;

        State = ApplicationState.Idle;
        _currentProject = null;
        _sourceFilePath = "";
    }

    public bool SaveCurrentProject()
    {
        if (State is ApplicationState.OpenFileUnsavedChanges)
        {
            FileConverter.SaveAsText(_currentProject!, _sourceFilePath);
        }
        else
        {
            if (!MainForm.TryPromptSaveFile(out string fullPath))
                return false;

            _sourceFilePath = fullPath;
            FileConverter.SaveAsText(_currentProject!, fullPath);
        }

        State = ApplicationState.OpenFile;
        return true;
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
