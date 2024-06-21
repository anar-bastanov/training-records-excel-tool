﻿using System;
using System.ComponentModel;
using System.Data;

namespace ExcelTool.Controllers;

public sealed class ProjectManager : INotifyPropertyChanged
{
    private readonly MainForm _mainView;

    private ApplicationState _applicationState = ApplicationState.Idle;

    private string _sourceFilePath = "";

    private string _taskDatabasePath = "";

    private ProjectModel? _currentProject;

    private readonly BindingList<TaskModel> _availableTasks = new()
    {
        RaiseListChangedEvents = true
    };

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
        set
        {
            _availableTasks.Clear();
            FileProcessor.LoadTaskDatabaseFromExcel(_availableTasks, value);
            this.SetProperty(ref _taskDatabasePath, value, PropertyChanged);
        }
    }

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
        mainView.ApplicationExitRequested += ExitApplication;
        mainView.BindTaskDatabasePath(this);
        mainView.BindAvailableTasks(_availableTasks);
    }

    public void CreateNewProject()
    {
        if (!CheckUnsavedChanges())
            return;

        _sourceFilePath = "";
        _currentProject = new ProjectModel();
        _currentProject.PropertyChanged += MarkUnsavedChanges;
        _mainView.BindProfileInfoData(_currentProject.ProfileInfo);
        _mainView.BindAssignedTasks(_currentProject.Tasks);
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
        FileProcessor.LoadProjectFromExcel(_currentProject, fullPath);
        _currentProject.PropertyChanged += MarkUnsavedChanges;
        _mainView.BindProfileInfoData(_currentProject.ProfileInfo);
        _mainView.BindAssignedTasks(_currentProject.Tasks);
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
            FileProcessor.SaveProjectToExcel(_currentProject!, _sourceFilePath);
        }
        else
        {
            if (!MainForm.TryPromptSaveFile(out string fullPath))
                return false;

            _sourceFilePath = fullPath;
            FileProcessor.SaveProjectToExcel(_currentProject!, fullPath);
        }

        State = ApplicationState.OpenFile;
        return true;
    }

    public void SaveCurrentProjectAs(FileType fileType)
    {
        if (!MainForm.TryPromptSaveFileAs(ref fileType, out string fullPath))
            return;

        switch (fileType)
        {
            case FileType.Excel:
                FileProcessor.SaveProjectToExcel(_currentProject!, fullPath);
                break;
            case FileType.Json:
                FileProcessor.SaveProjectToJson(_currentProject!, fullPath);
                break;
            case FileType.XML:
                FileProcessor.SaveProjectToXML(_currentProject!, fullPath);
                break;
            default:
                throw new NotSupportedException("This is not supposed to happen!");
        }
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

    public void AssignTask(TaskModel task)
    {
        _currentProject!.Tasks.Add(task);
    }

    public void MarkUnsavedChanges()
    {
        State = State.MarkUnsavedChanges();
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
