﻿using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExcelTool.Views;

public sealed partial class MainForm : Form
{
    private Regex? _assignedTaskSearchPattern;

    private int _assignedTaskSearchBy;

    private Regex? _availableTaskSearchPattern;

    private int _availableTaskSearchBy;

    public event Action? FileNewRequested;

    public event Action? FileOpenRequested;

    public event Action? FileCloseRequested;

    public event Action? FileSaveRequested;

    public event Action<FileType>? FileSaveAsRequested;

    public event Action? TaskDatabaseSelectRequested;

    public event Action? TaskDatabaseFilePathCopyRequested;

    public event Action<TaskModel>? AssignTaskFromDatabaseRequested;

    public event Action<int>? UnassignTaskRequested;

    public event Action<FormClosingEventArgs>? ApplicationExitRequested;

    private const string ApplicationName = "Master Training Records";

    private const string DefaultFileName = "TrainingRecords";

    private const string LinkToWiki = "https://github.com/anar-bastanov/training-records-excel-tool/wiki";

    private static readonly ProcessStartInfo OpenLinkProcessInfo = new()
    {
        FileName = LinkToWiki,
        UseShellExecute = true
    };

    private static readonly SaveFileDialog SaveFilePrompt = new()
    {
        Title = "Save Excel File",
        Filter = "Excel File (*.xlsx)|*.xlsx",
        DefaultExt = "xlsx",
        AddExtension = true,
        FileName = DefaultFileName,
    };

    private static readonly SaveFileDialog SaveAsFilePrompt = new()
    {
        Title = "Save File",
        Filter = "Excel File (*.xlsx)|*.xlsx|JSON (*.json)|*.json|XML (*.xml)|*.xml",
        DefaultExt = "xlsx",
        AddExtension = true
    };

    private static readonly OpenFileDialog OpenFilePrompt = new()
    {
        Title = "Open Excel File",
        Filter = "Excel File (*.xlsx)|*.xlsx",
        DefaultExt = "xlsx",
        AddExtension = true
    };

    private static readonly OpenFileDialog SelectTaskDatabasePrompt = new()
    {
        Title = "Select Task Database",
        Filter = "Excel File (*.xlsx)|*.xlsx",
        DefaultExt = "xlsx",
        AddExtension = true
    };

    public MainForm()
    {
        InitializeComponent();
    }

    private void StripMenuFileNew_Click(object sender, EventArgs e)
    {
        FileNewRequested?.Invoke();
        FilterAssignedTasks();
        FilterAvailableTasks();
    }

    private void StripMenuFileOpen_Click(object sender, EventArgs e)
    {
        FileOpenRequested?.Invoke();
        FilterAssignedTasks();
        FilterAvailableTasks();
    }

    private void StripMenuFileClose_Click(object sender, EventArgs e)
    {
        FileCloseRequested?.Invoke();
    }

    private void StripMenuFileSave_Click(object sender, EventArgs e)
    {
        FileSaveRequested?.Invoke();
    }

    private void StripMenuFileSaveAsExcel_Click(object sender, EventArgs e)
    {
        FileSaveAsRequested?.Invoke(FileType.Excel);
    }

    private void StripMenuFileSaveAsJson_Click(object sender, EventArgs e)
    {
        FileSaveAsRequested?.Invoke(FileType.Json);
    }

    private void StripMenuFileSaveAsXML_Click(object sender, EventArgs e)
    {
        FileSaveAsRequested?.Invoke(FileType.XML);
    }

    private void StripMenuFileExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void StripMenuHelp_Click(object sender, EventArgs e)
    {
        OpenWikiPageForHelp();
    }

    private void StripMenuLicense_Click(object sender, EventArgs e)
    {
        //
        LicenseForm license = new();
        license.ShowDialog();
    }

    private void StartMenu_NewFileClick(object sender, EventArgs e)
    {
        StripMenuFileNew_Click(sender, e);
    }

    private void StartMenu_OpenFileClick(object sender, EventArgs e)
    {
        StripMenuFileOpen_Click(sender, e);
    }

    private void StartMenu_HelpClick(object sender, EventArgs e)
    {
        StripMenuHelp_Click(sender, e);
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        ApplicationExitRequested?.Invoke(e);
    }

    private void ProjectEditor_SelectDatabase(object sender, EventArgs e)
    {
        TaskDatabaseSelectRequested?.Invoke();
        FilterAvailableTasks();
    }

    private void ProjectEditor_CopyTaskDatabaseFilePath(object sender, EventArgs e)
    {
        TaskDatabaseFilePathCopyRequested?.Invoke();
    }

    private void ProjectEditor_AssignTaskFromDatabase(object sender, DataGridViewSelectedRowCollection e)
    {
        var tasks = e[0].DataGridView!.DataSource as IList;

        foreach (DataGridViewRow row in e)
        {
            if (!row.Visible)
                continue;

            var task = tasks![row.Index] as TaskModel;
            AssignTaskFromDatabaseRequested?.Invoke(task!.Copy());
        }

        FilterAssignedTasks();
        FilterAvailableTasks();
    }

    private void ProjectEditor_UnassignTask(object sender, int e)
    {
        UnassignTaskRequested?.Invoke(e);
        FilterAssignedTasks();
        FilterAvailableTasks();
    }

    private void ProjectEditor_AssignedTasksSearchPatternBy(Regex regex, int searchBy)
    {
        _assignedTaskSearchPattern = regex;
        _assignedTaskSearchBy = searchBy + 1;
        FilterAssignedTasks();
    }

    private void ProjectEditor_AvailableTasksSearchPatternBy(Regex regex, int searchBy)
    {
        _availableTaskSearchPattern = regex;
        _availableTaskSearchBy = searchBy;
        FilterAvailableTasks();
    }

    public void EnableEditor(bool enable)
    {
        if (enable)
            _projectEditor.BringToFront();
        else
            _startMenu.BringToFront();
    }

    public void EnableStripMenuItems(ApplicationState state)
    {
        bool isEditing = state is not ApplicationState.Idle;
        _stripMenuFileClose.Enabled = isEditing;
        _stripMenuFileSave.Enabled = isEditing && state is not ApplicationState.OpenFile;
        _stripMenuFileSaveAs.Enabled = isEditing;
    }

    public void EnableTitleFileName(ApplicationState state, string fullPath)
    {
        if (state is ApplicationState.Idle)
        {
            Text = ApplicationName;
            return;
        }

        string title = ApplicationName + " - ";

        title += fullPath is "" ? $"{DefaultFileName}.xlsx" : Path.GetFileName(fullPath);

        if (state.HasUnsavedChanges())
            title += "*";

        Text = title;
    }

    public void BindProfileInfoData(ProfileModel profileInfo)
    {
        _projectEditor.HeaderInfoTrainee.DataBindings.Clear();
        _projectEditor.HeaderInfoTrainee.DataBindings.Add(
            propertyName: "Text",
            dataSource: profileInfo,
            dataMember: "Trainee",
            formattingEnabled: true,
            updateMode: DataSourceUpdateMode.OnPropertyChanged);

        _projectEditor.HeaderInfoCourse.DataBindings.Clear();
        _projectEditor.HeaderInfoCourse.DataBindings.Add(
            propertyName: "Text",
            dataSource: profileInfo,
            dataMember: "Course",
            formattingEnabled: true,
            updateMode: DataSourceUpdateMode.OnPropertyChanged);

        _projectEditor.HeaderInfoPosition.DataBindings.Clear();
        _projectEditor.HeaderInfoPosition.DataBindings.Add(
            propertyName: "Text",
            dataSource: profileInfo,
            dataMember: "Position",
            formattingEnabled: true,
            updateMode: DataSourceUpdateMode.OnPropertyChanged);

        _projectEditor.HeaderInfoManager.DataBindings.Clear();
        _projectEditor.HeaderInfoManager.DataBindings.Add(
            propertyName: "Text",
            dataSource: profileInfo,
            dataMember: "Manager",
            formattingEnabled: true,
            updateMode: DataSourceUpdateMode.OnPropertyChanged);
    }

    public void BindAssignedTasks(BindingList<TaskModel> tasks)
    {
        _projectEditor.AssignedTasks.DataSource = tasks;
    }

    public void BindAvailableTasks(BindingList<TaskModel> tasks)
    {
        _projectEditor.AvailableTasks.DataSource = tasks;
    }

    public void BindTaskDatabasePath(ProjectManager manager)
    {
        _projectEditor.TaskDatabasePath.DataBindings.Clear();
        _projectEditor.TaskDatabasePath.DataBindings.Add(
            propertyName: "Text",
            dataSource: manager,
            dataMember: "TaskDatabasePath",
            formattingEnabled: false,
            updateMode: DataSourceUpdateMode.OnPropertyChanged);
    }

    private void FilterAssignedTasks()
    {
        if (_projectEditor.AssignedTasks.DataSource is null)
            return;

        CurrencyManager currencyManager = (CurrencyManager)BindingContext![_projectEditor.AssignedTasks.DataSource];
        currencyManager.SuspendBinding();

        var regex = _assignedTaskSearchPattern;
        int searchIndex = _assignedTaskSearchBy;
        int itemCount = 0;
        int matchCount = 0;

        foreach (DataGridViewRow row in _projectEditor.AssignedTasks.Rows)
        {
            bool isMatch = regex is null ||
                regex.IsMatch(row.Cells[searchIndex].Value?.ToString() ?? "");

            ++itemCount;
            if (isMatch)
                ++matchCount;

            row.Visible = isMatch;
            row.Selected &= isMatch;
        }

        _projectEditor.AssignedTasksSearchCount.Text = GetSearchCountText(itemCount, matchCount);

        currencyManager.ResumeBinding();
    }

    private void FilterAvailableTasks()
    {
        if (_projectEditor.AvailableTasks.DataSource is null)
            return;

        CurrencyManager currencyManager = (CurrencyManager)BindingContext![_projectEditor.AvailableTasks.DataSource];
        currencyManager.SuspendBinding();

        var assignedTasks = _projectEditor.AssignedTasks.Rows.Cast<object>();
        var regex = _availableTaskSearchPattern;
        int searchIndex = _availableTaskSearchBy;
        int itemCount = 0;
        int matchCount = 0;

        foreach (DataGridViewRow row in _projectEditor.AvailableTasks.Rows)
        {
            bool isAssigned =
                assignedTasks.Any(t =>
                {
                    var rowDescription = row.Cells[0].Value;
                    var otherRowDescription = ((DataGridViewRow)t).Cells[1].Value;
                    return Equals(rowDescription, otherRowDescription);
                });

            if (isAssigned)
            {
                row.Visible = false;
                row.Selected = false;
                continue;
            }

            bool isMatch = regex is null ||
                regex.IsMatch(row.Cells[searchIndex].Value?.ToString() ?? "");

            ++itemCount;
            if (isMatch)
                ++matchCount;

            row.Visible = isMatch;
            row.Selected &= isMatch;
        }

        _projectEditor.AvailableTasksSearchCount.Text = GetSearchCountText(itemCount, matchCount);

        currencyManager.ResumeBinding();
    }

    private static string GetSearchCountText(int itemCount, int matchCount)
    {
        if (itemCount is 0)
            return "Out of Tasks";

        if (matchCount is 0)
            return "No Matches";

        if (itemCount is 1)
            return "1 Task";

        if (itemCount == matchCount)
            return $"{itemCount} Tasks";

        return $"{matchCount} / {itemCount} Matches";
    }

    public static void OpenWikiPageForHelp()
    {
        var choice = MessageBox.Show(
            text: $"""
            You are about to open a link in your default browser!

            Clicking `OK` will take you to:
            {LinkToWiki}
            """,
            caption: "External Link",
            buttons: MessageBoxButtons.OKCancel,
            icon: MessageBoxIcon.Asterisk,
            defaultButton: MessageBoxDefaultButton.Button1);

        if (choice is DialogResult.Cancel)
            return;

        Process.Start(OpenLinkProcessInfo);
    }

    public static bool TryPromptSaveFile(out string fullPath)
    {
        return TryPrompt(SaveFilePrompt, out fullPath);
    }

    public static bool TryPromptSaveFileAs(ref FileType fileType, out string fullPath)
    {
        return TryPromptSaveFileAs(ref fileType, DefaultFileName, out fullPath);
    }
    
    public static bool TryPromptSaveFileAs(ref FileType fileType, string fileName, out string fullPath)
    {
        SaveAsFilePrompt.FilterIndex = (int)fileType;
        SaveAsFilePrompt.FileName = IsValidFilename(fileName) ? fileName : DefaultFileName;
        bool success = TryPrompt(SaveAsFilePrompt, out fullPath);
        fileType = (FileType)SaveAsFilePrompt.FilterIndex;
        return success;

        static bool IsValidFilename(string filename)
        {
            try
            {
                File.OpenRead(filename).Close();
            }
            catch (ArgumentException)
            {
                return false;
            }
            catch (Exception) 
            {
            }
            return true;
        }
    }

    public static bool TryPromptOpenFile(out string fullPath)
    {
        return TryPrompt(OpenFilePrompt, out fullPath);
    }

    public static bool TryPromptSelectTaskDatabase(out string fullPath)
    {
        return TryPrompt(SelectTaskDatabasePrompt, out fullPath);
    }

    public static bool TryPrompt(FileDialog dialog, out string fullPath)
    {
        var choice = dialog.ShowDialog();
        fullPath = dialog.FileName;
        return choice is DialogResult.OK;
    }

    public static DialogResult WarnUnsavedChanges()
    {
        return MessageBox.Show(
            text: "Do you want to save your changes to a file?",
            caption: "Unsaved Changes",
            buttons: MessageBoxButtons.YesNoCancel,
            icon: MessageBoxIcon.Exclamation,
            defaultButton: MessageBoxDefaultButton.Button1);
    }

    public static bool WarnPackedNames()
    {
        return MessageBox.Show(
            text: "The field named `Trainee` contains packed names delimited with semicolons. In order to unpack this field and save files separately, use `Save As` instead. Do you want to continue saving to a single file?",
            caption: "Packed Names",
            buttons: MessageBoxButtons.YesNo,
            icon: MessageBoxIcon.Asterisk,
            defaultButton: MessageBoxDefaultButton.Button2) 
            is DialogResult.Yes;
    }
}
