namespace ExcelTool.Controllers;

public sealed class ProjectManager
{
    private readonly MainForm _mainView;

    private ApplicationState _applicationState = ApplicationState.Idle;

    private ProjectModel? _currentProject;

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
    }

    public void CreateNewProject()
    {
        State = ApplicationState.NewFile;

        _currentProject = new ProjectModel();
        _currentProject.PropertyChanged += (_, _) => State = State.MarkUnsavedChanges();
        _mainView.BindProjectData(_currentProject);
    }

    public void OpenProject()
    {
        State = ApplicationState.OpenFile;

        _currentProject = new ProjectModel();
        _currentProject.PropertyChanged += (_, _) => State = State.MarkUnsavedChanges();
        _mainView.BindProjectData(_currentProject);
    }

    public void CloseCurrentProject()
    {
        State = ApplicationState.Idle;

        _currentProject = null;
    }
}
