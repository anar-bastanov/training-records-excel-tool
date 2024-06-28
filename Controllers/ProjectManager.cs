using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ExcelTool.Controllers;

/// <summary>
/// Provides methods to control and manage user projects throughout the application.
/// </summary>
public sealed class ProjectManager : INotifyPropertyChanged
{
    /// <summary>
    /// The singleton reference to the application form.
    /// </summary>
    private readonly MainForm _mainView;

    /// <summary>
    /// Determines which features should be enabled at a time, such as saving a project only and only if a file 
    /// is open and has unsaved changes or changing the title of the application window every time the user
    /// chooses a new source file.
    /// </summary>
    private ApplicationState _applicationState = ApplicationState.Idle;

    /// <summary>
    /// The absolute path to the Excel file where <see cref="ProjectModel"/> data is read from and written to.
    /// </summary>
    private string _sourceFilePath = "";

    /// <summary>
    /// The absolute path to the Excel file from where all available tasks are accessed as <see cref="TaskModel"/>.
    /// </summary>
    private string _taskDatabasePath = "";

    /// <summary>
    /// Data that the user can directly modify and save to <see cref="_sourceFilePath"/>.
    /// </summary>
    /// <remarks>
    /// User inputs are synched with this object model instance via "two-way databinding".
    /// </remarks>
    private ProjectModel? _currentProject;

    /// <summary>
    /// A list of tasks accessed from <see cref="_taskDatabasePath"/> that the user can assign to "trainees".
    /// </summary>
    /// <remarks>
    /// This list is created once and repopulated every time the user chooses another task database and <see cref="_taskDatabasePath"/> changes.
    /// </remarks>
    private readonly BindingList<TaskModel> _availableTasks = new()
    {
        RaiseListChangedEvents = true
    };

    /// <summary>
    /// Notifies all listeners about a change in value to implement two-way databinding with <see cref="INotifyPropertyChanged"/>.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Gets or sets the current state that the application is in.
    /// </summary>
    /// <returns>
    /// The current state of the application.
    /// </returns>
    public ApplicationState State
    {
        get
        {
            return _applicationState;
        }
        private set
        {
            // No need to do anything if the state did not change. But we
            // must also add the second condition for the title to update
            // the file name properly whenever a user opens a new project,
            // as the state would change from OpenFile to OpenFile again
            if (_applicationState == value && value.HasUnsavedChanges())
                return;

            _applicationState = value;
            // The editor should be enabled only if a project is created or opened.
            _mainView.EnableEditor(value is not ApplicationState.Idle);
            _mainView.EnableStripMenuItems(value);
            _mainView.EnableTitleFileName(value, _sourceFilePath);
        }
    }

    /// <summary>
    /// Gets or sets the absolute path to the Excel file containing all available tasks.
    /// </summary>
    /// <returns>
    /// The absolute path to the Excel file containing all available tasks.
    /// </returns>
    public string TaskDatabasePath
    {
        // Display this message instead of blank
        get => _taskDatabasePath is "" ? "No database is selected" : _taskDatabasePath;
        set
        {
            _availableTasks.Clear();
            FileProcessor.LoadTaskDatabaseFromExcel(_availableTasks, value);
            this.SetProperty(ref _taskDatabasePath, value, PropertyChanged);
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ProjectManager"/> class and links it to <paramref name="mainView"/>.
    /// </summary>
    /// <param name="mainView">A reference to the application form.</param>
    public ProjectManager(MainForm mainView)
    {
        _mainView = mainView;
        mainView.FileNewRequested += CreateNewProject;
        mainView.FileOpenRequested += OpenProject;
        mainView.FileCloseRequested += CloseCurrentProject;
        mainView.FileSaveRequested += () => SaveCurrentProject();
        mainView.FileSaveAsRequested += SaveCurrentProjectAs;
        mainView.TaskDatabaseSelectRequested += SelectTaskDatabase;
        mainView.TaskDatabaseFilePathCopyRequested += CopyTaskDatabaseFilePath;
        mainView.AssignTaskFromDatabaseRequested += AssignTask;
        mainView.UnassignTaskRequested += UnassignTask;
        mainView.ApplicationExitRequested += OnApplicationExit;
        // These fields can be databound once at the start, whereas other fields need to be
        // rebound every time a new object with the desired fields are created
        mainView.BindTaskDatabasePath(this);
        mainView.BindAvailableTasks(_availableTasks);
    }

    /// <summary>
    /// Creates a new project with no initial data.
    /// </summary>
    public void CreateNewProject()
    {
        if (!CheckUnsavedChanges())
            return;

        // The location that this project will be saved to is not specified yet
        _sourceFilePath = "";
        _currentProject = new ProjectModel();
        _currentProject.PropertyChanged += MarkUnsavedChanges;
        _mainView.BindProfileInfoData(_currentProject.ProfileInfo);
        _mainView.BindAssignedTasks(_currentProject.Tasks);
        State = ApplicationState.NewFile;
    }

    /// <summary>
    /// Creates a project with the data loaded from an Excel file at a user-specified location.
    /// </summary>
    public void OpenProject()
    {
        if (!CheckUnsavedChanges())
            return;

        if (!MainForm.TryPromptOpenFile(out string fullPath))
            return;

        _sourceFilePath = fullPath;
        _currentProject = new ProjectModel();
        FileProcessor.LoadProjectFromExcel(_currentProject, fullPath);
        _currentProject.PropertyChanged += MarkUnsavedChanges;
        _mainView.BindProfileInfoData(_currentProject.ProfileInfo);
        _mainView.BindAssignedTasks(_currentProject.Tasks);
        State = ApplicationState.OpenFile;
    }

    /// <summary>
    /// Closes the project that the user has either created or opened.
    /// </summary>
    public void CloseCurrentProject()
    {
        if (!CheckUnsavedChanges())
            return;

        _currentProject = null;
        _sourceFilePath = "";
        State = ApplicationState.Idle;
    }

    /// <summary>
    /// Saves the project that the user has either created or opened to an Excel file.
    /// </summary>
    /// <returns>
    /// <see langword="true"/> if the project was successfully saved before
    /// the operation was cancelled; otherwise, <see langword="false"/>.
    /// </returns>
    public bool SaveCurrentProject()
    {
        string packedNames = _currentProject!.ProfileInfo.Trainee;
        var trainees = GetUnpackedNames(packedNames);

        // If the field `Trainee` does indeed contain more than one name, the user is likely
        // to want to save them in separate files, which is done with `Save As` instead
        if (trainees.Length > 1 && !MainForm.WarnPackedNames())
            return false;

        if (State is ApplicationState.OpenFileUnsavedChanges)
        {
            FileProcessor.SaveProjectToExcel(_currentProject!, _sourceFilePath);
        }
        else
        {
            if (!MainForm.TryPromptSaveFile(out string fullPath))
                return false;

            _sourceFilePath = fullPath;
            FileProcessor.SaveProjectToExcel(_currentProject!, fullPath);
        }

        // After saving to a file, the project still stays open, therefore the state is
        // going to be OpenFile in any case
        State = ApplicationState.OpenFile;
        return true;
    }

    /// <summary>
    /// Saves the project that the user has either created or opened as one of the available
    /// file formats.
    /// </summary>
    /// <param name="fileFormat">The format of the file to convert to.</param>
    /// <exception cref="NotSupportedException">Thrown if <paramref name="fileFormat"/> is not supported.</exception>
    public void SaveCurrentProjectAs(FileFormat fileFormat)
    {
        string packedNames = _currentProject!.ProfileInfo.Trainee;
        var trainees = GetUnpackedNames(packedNames);
        var state = State; // Restore the value later

        foreach (string trainee in trainees)
        {
            // Here we temporarily modify the project, which inevitably changes the State
            // That is why we need to restore it at the end of the loop
            _currentProject!.ProfileInfo.Trainee = trainee;

            if (!MainForm.TryPromptSaveFileAs(ref fileFormat, trainee, out string fullPath))
                continue;

            switch (fileFormat)
            {
                case FileFormat.Excel:
                    FileProcessor.SaveProjectToExcel(_currentProject!, fullPath);
                    break;
                case FileFormat.Json:
                    FileProcessor.SaveProjectToJson(_currentProject!, fullPath);
                    break;
                case FileFormat.XML:
                    FileProcessor.SaveProjectToXML(_currentProject!, fullPath);
                    break;
                default:
                    throw new NotSupportedException("This is not supposed to happen! Somehow you have chosen an unsupported file format.");
            }
        }

        _currentProject!.ProfileInfo.Trainee = packedNames;
        State = state;
    }

    /// <summary>
    /// Selects an Excel file requested by the user as a source database to available tasks.
    /// </summary>
    public void SelectTaskDatabase()
    {
        if (!MainForm.TryPromptSelectTaskDatabase(out string fullPath))
            return;

        TaskDatabasePath = fullPath;
    }

    /// <summary>
    /// Copies the absolute path of the currently chosen task database to clipboard.
    /// </summary>
    /// <remarks>
    /// If no database is selected by the user at the time, this method does nothing.
    /// </remarks>
    public void CopyTaskDatabaseFilePath()
    {
        if (_taskDatabasePath is "")
            return;

        Clipboard.SetText(_taskDatabasePath);
    }

    /// <summary>
    /// Assigns <paramref name="task"/> to a "trainee".
    /// </summary>
    /// <param name="task">The task to be assigned.</param>
    public void AssignTask(TaskModel task)
    {
        _currentProject!.Tasks.Add(task);
    }

    /// <summary>
    /// Removes the task at the specified index from a "trainee".
    /// </summary>
    /// <param name="index">The zero-based index of the task to be unassigned.</param>
    public void UnassignTask(int index)
    {
        _currentProject!.Tasks.RemoveAt(index);
    }

    /// <summary>
    /// Marks the current project as having unsaved changes.
    /// </summary>
    private void MarkUnsavedChanges()
    {
        State = State.MarkUnsavedChanges();
    }

    /// <summary>
    /// Checks whether the current project has unsaved changes, and if so, tries to prevent 
    /// the user from accidentally losing data.
    /// </summary>
    /// <returns><see langword="true"/> if there are no more unsaved changes left; otherwise, <see langword="false"/>.</returns>
    private bool CheckUnsavedChanges()
    {
        if (!State.HasUnsavedChanges())
            return true;

        var choice = MainForm.WarnUnsavedChanges();

        if (choice is DialogResult.Cancel)
            return false;

        if (choice is DialogResult.Yes)
            return SaveCurrentProject();

        // if the user's choice is DialogResult.No, i.e. they do not want to save changes,
        // assume everything is already saved
        return true;
    }

    /// <summary>
    /// Cancels exiting the application if it is not safe to do so.
    /// </summary>
    /// <param name="e">The data for the <see cref="Form.FormClosing"/> event.</param>
    private void OnApplicationExit(FormClosingEventArgs e)
    {
        e.Cancel = !CheckUnsavedChanges();
    }

    /// <summary>
    /// A cached array to return instead of an array with no elements.
    /// </summary>
    /// <remarks>
    /// This array is not supposed to be mutated although a more appropriate type such as
    /// <see cref="ReadOnlyCollection{T}"/> whose generic type argument is <see cref="string"/>
    /// could have been used instead. The reason why an array of strings is more preferred is
    /// to keep it simple and also to avoid a layer of indirection while accessing an element.
    /// </remarks>
    private static readonly string[] EmptyStringInArray = [""];

    /// <summary>
    /// Unpacks the names of "trainees" delimited by semicolons and returns them in an array.
    /// </summary>
    /// <remarks>
    /// All whitespaces around each name are trimmed.
    /// </remarks>
    /// <param name="packedNames">The names to be unpacked.</param>
    /// <returns>An array of strings representing each trainee.</returns>
    private static string[] GetUnpackedNames(string packedNames)
    {
        // If the user provided multiple names separated with a semicolon as `Trainee`,
        // it is a "packed name", which means that it consists of a number of trainees
        // who share the same tasks and profile information. We make this distinction to
        // allow the user to save multiple files all at once that only differ in trainees

        var mode = StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries;
        var trainees = packedNames.Split(';', mode);
        return trainees.Length is 0 ? EmptyStringInArray : trainees;
    }
}
