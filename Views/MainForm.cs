using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExcelTool.Views;

/// <summary>
/// Represents the main window of the application.
/// </summary>
public sealed partial class MainForm : Form
{
    /// <summary>
    /// The search pattern to match and filter assigned tasks.
    /// </summary>
    /// <remarks>
    /// If the user did not provide a search input, this field is <see langword="null"/>.
    /// </remarks>
    private Regex? _assignedTaskSearchPattern;

    /// <summary>
    /// The index of the column in the grid of assigned tasks to search for a pattern.
    /// </summary>
    private int _assignedTaskSearchBy;

    /// <summary>
    /// The search pattern to match and filter available tasks.
    /// </summary>
    /// <remarks>
    /// If the user did not provide a search input, this field is <see langword="null"/>.
    /// </remarks>
    private Regex? _availableTaskSearchPattern;

    /// <summary>
    /// The index of the column in the grid of available tasks to search for a pattern.
    /// </summary>
    private int _availableTaskSearchBy;

    /// <summary>
    /// Occurs when the user requests to create a new project.
    /// </summary>
    public event Action? FileNewRequested;

    /// <summary>
    /// Occurs when the user requests to open an existing project.
    /// </summary>
    public event Action? FileOpenRequested;

    /// <summary>
    /// Occurs when the user requests to close the current project.
    /// </summary>
    public event Action? FileCloseRequested;

    /// <summary>
    /// Occurs when the user requests to save the current project.
    /// </summary>
    public event Action? FileSaveRequested;

    /// <summary>
    /// Occurs when the user requests to save the current project as one of
    /// the supported file formats.
    /// </summary>
    public event Action<FileFormat>? FileSaveAsRequested;

    /// <summary>
    /// Occurs when the user requests to select a database for available tasks.
    /// </summary>
    public event Action? TaskDatabaseSelectRequested;

    /// <summary>
    /// Occurs when the user requests to copy the absolute path to the task database.
    /// </summary>
    public event Action? TaskDatabaseFilePathCopyRequested;

    /// <summary>
    /// Occurs when the user requests to assign a specified task to a trainee.
    /// </summary>
    public event Action<TaskModel>? AssignTaskFromDatabaseRequested;

    /// <summary>
    /// Occurs when the user requests to unassign a task of a specified index
    /// from a trainee.
    /// </summary>
    public event Action<int>? UnassignTaskRequested;

    /// <summary>
    /// Occurs when the user requests to exit the application.
    /// </summary>
    public event Action<FormClosingEventArgs>? ApplicationExitRequested;

    /// <summary>
    /// The name of the application.
    /// </summary>
    public const string ApplicationName = "Master Training Records";

    /// <summary>
    /// Default file name for saved files.
    /// </summary>
    public const string DefaultFileName = "TrainingRecords";

    /// <summary>
    /// Link to the wiki page in the GitHub repository of this project.
    /// </summary>
    private const string LinkToWiki = "https://github.com/anar-bastanov/training-records-excel-tool/wiki";

    /// <summary>
    /// A cached instance of the <see cref="ProcessStartInfo"/> class that opens
    /// the <see cref="LinkToWiki"/> link in the user's default browser.
    /// </summary>
    private static readonly ProcessStartInfo OpenLinkProcessInfo = new()
    {
        FileName = LinkToWiki,
        UseShellExecute = true
    };

    /// <summary>
    /// A dialog box to save user projects.
    /// </summary>
    private static readonly SaveFileDialog SaveFilePrompt = new()
    {
        Title = "Save Excel File",
        Filter = "Excel File (*.xlsx)|*.xlsx",
        DefaultExt = "xlsx",
        AddExtension = true,
        FileName = DefaultFileName,
    };

    /// <summary>
    /// A dialog box to save user projects as one of the supported file formats.
    /// </summary>
    private static readonly SaveFileDialog SaveAsFilePrompt = new()
    {
        Title = "Save File",
        Filter = "Excel File (*.xlsx)|*.xlsx|JSON (*.json)|*.json|XML (*.xml)|*.xml",
        DefaultExt = "xlsx",
        AddExtension = true
    };

    /// <summary>
    /// A dialog box to open user projects.
    /// </summary>
    private static readonly OpenFileDialog OpenFilePrompt = new()
    {
        Title = "Open Excel File",
        Filter = "Excel File (*.xlsx)|*.xlsx",
        DefaultExt = "xlsx",
        AddExtension = true
    };

    /// <summary>
    /// A dialog box to select a task database.
    /// </summary>
    private static readonly OpenFileDialog SelectTaskDatabasePrompt = new()
    {
        Title = "Select Task Database",
        Filter = "Excel File (*.xlsx)|*.xlsx",
        DefaultExt = "xlsx",
        AddExtension = true
    };

    /// <summary>
    /// Initializes a new instance of the <see cref="MainForm"/> class.
    /// </summary>
    public MainForm()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Handles the <see cref="Control.Click"/> event of <see cref="_stripMenuFileNew"/>.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
    private void StripMenuFileNew_Click(object sender, EventArgs e)
    {
        FileNewRequested?.Invoke();

        FilterAssignedTasks();
        FilterAvailableTasks();
    }

    /// <summary>
    /// Handles the <see cref="Control.Click"/> event of <see cref="_stripMenuFileOpen"/>.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
    private void StripMenuFileOpen_Click(object sender, EventArgs e)
    {
        FileOpenRequested?.Invoke();

        FilterAssignedTasks();
        FilterAvailableTasks();
    }

    /// <summary>
    /// Handles the <see cref="Control.Click"/> event of <see cref="_stripMenuFileClose"/>.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
    private void StripMenuFileClose_Click(object sender, EventArgs e)
    {
        FileCloseRequested?.Invoke();
    }

    /// <summary>
    /// Handles the <see cref="Control.Click"/> event of <see cref="_stripMenuFileSave"/>.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
    private void StripMenuFileSave_Click(object sender, EventArgs e)
    {
        FileSaveRequested?.Invoke();
    }

    /// <summary>
    /// Handles the <see cref="Control.Click"/> event of <see cref="_stripMenuFileSaveAsExcel"/>.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
    private void StripMenuFileSaveAsExcel_Click(object sender, EventArgs e)
    {
        FileSaveAsRequested?.Invoke(FileFormat.Excel);
    }

    /// <summary>
    /// Handles the <see cref="Control.Click"/> event of <see cref="_stripMenuFileSaveAsJson"/>.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
    private void StripMenuFileSaveAsJson_Click(object sender, EventArgs e)
    {
        FileSaveAsRequested?.Invoke(FileFormat.Json);
    }

    /// <summary>
    /// Handles the <see cref="Control.Click"/> event of <see cref="_stripMenuFileSaveAsXML"/>.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
    private void StripMenuFileSaveAsXML_Click(object sender, EventArgs e)
    {
        FileSaveAsRequested?.Invoke(FileFormat.XML);
    }

    /// <summary>
    /// Invoked when the `Exit` button is clicked.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
    private void StripMenuFileExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    /// <summary>
    /// Handles the <see cref="Control.Click"/> event of <see cref="_stripMenuHelp"/>.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
    private void StripMenuHelp_Click(object sender, EventArgs e)
    {
        OpenWikiPageForHelp();
    }

    /// <summary>
    /// Handles the <see cref="Control.Click"/> event of <see cref="_stripMenuLicense"/>.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
    private void StripMenuLicense_Click(object sender, EventArgs e)
    {
        //
        LicenseForm license = new();
        license.ShowDialog();
    }

    /// <summary>
    /// Invoked when the `New File` button in the start menu was clicked.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
    private void StartMenu_NewFileClick(object sender, EventArgs e)
    {
        StripMenuFileNew_Click(sender, e);
    }

    /// <summary>
    /// Invoked when the `Open File` button in the start menu was clicked.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
    private void StartMenu_OpenFileClick(object sender, EventArgs e)
    {
        StripMenuFileOpen_Click(sender, e);
    }

    /// <summary>
    /// Invoked when the `Help` button in the start menu was clicked.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
    private void StartMenu_HelpClick(object sender, EventArgs e)
    {
        StripMenuHelp_Click(sender, e);
    }

    /// <summary>
    /// Handles the <see cref="Form.FormClosing"/> event of this form.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        ApplicationExitRequested?.Invoke(e);
    }

    /// <inheritdoc cref="ProjectEditorUserControl.SelectTaskDatabaseButton_Click(object, EventArgs)"/>
    private void ProjectEditor_SelectDatabase(object sender, EventArgs e)
    {
        TaskDatabaseSelectRequested?.Invoke();

        FilterAvailableTasks();
    }

    /// <inheritdoc cref="ProjectEditorUserControl.CopyTaskDatabaseFilePathButton_Click(object, EventArgs)"/>
    private void ProjectEditor_CopyTaskDatabaseFilePath(object sender, EventArgs e)
    {
        TaskDatabaseFilePathCopyRequested?.Invoke();
    }

    /// <summary>
    /// Invoked when the user assigns one or more of available tasks to a trainee.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="DataGridViewSelectedRowCollection"/> that contains the event data.</param>
    private void ProjectEditor_AssignTaskFromDatabase(object sender, DataGridViewSelectedRowCollection e)
    {
        var tasks = e[0].DataGridView!.DataSource as IList;

        foreach (DataGridViewRow row in e)
        {
            // Ignore if the row is filtered (which can mean it is already assigned)
            if (!row.Visible)
                continue;

            var task = tasks![row.Index] as TaskModel;
            var copy = new TaskModel(task!);

            // Use the copy in order not to modify the original task
            AssignTaskFromDatabaseRequested?.Invoke(copy);
        }

        FilterAssignedTasks();
        FilterAvailableTasks();
    }

    /// <summary>
    /// Invoked when the user unassigns a task of a specified index from a trainee.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="DataGridViewSelectedRowCollection"/> that contains the event data.</param>
    private void ProjectEditor_UnassignTask(object sender, int e)
    {
        UnassignTaskRequested?.Invoke(e);

        FilterAvailableTasks();
    }

    /// <inheritdoc cref="ProjectEditorUserControl.AssignedTaskSearchPatternRichTextBox_TextChanged(object, EventArgs)"/>
    private void ProjectEditor_AssignedTasksSearchPatternBy(Regex regex, int searchBy)
    {
        _assignedTaskSearchPattern = regex;
        _assignedTaskSearchBy = searchBy;

        FilterAssignedTasks();
    }

    /// <inheritdoc cref="ProjectEditorUserControl.AvailableTaskSearchPatternRichTextBox_TextChanged(object, EventArgs)"/>
    private void ProjectEditor_AvailableTasksSearchPatternBy(Regex regex, int searchBy)
    {
        _availableTaskSearchPattern = regex;
        _availableTaskSearchBy = searchBy;

        FilterAvailableTasks();
    }

    /// <summary>
    /// Enables or disables the editor page.
    /// </summary>
    /// <param name="enable">A boolean indicating whether or not to enable the editor page.</param>
    public void EnableEditor(bool enable)
    {
        if (enable)
            _projectEditor.BringToFront();
        else
            _startMenu.BringToFront();
    }

    /// <summary>
    /// Enables or disables certain items in the strip menu depending on whether or not they
    /// make sense given the current state of the application.
    /// </summary>
    /// <remarks>
    /// <list type="table">
    ///     <item>
    ///         <term>Save</term>
    ///         <description>Enabled if either a project is newly created or there are unsaved changes.</description>
    ///     </item>
    ///     <item>
    ///         <term>Save As</term>
    ///         <description>Enabled if there is an active project in the editor page.</description>
    ///     </item>
    ///     <item>
    ///         <term>Close</term>
    ///         <description>Enabled unless the state is <see cref="ApplicationState.Idle"/>.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    /// <param name="state">The current state of the application.</param>
    public void EnableStripMenuItems(ApplicationState state)
    {
        bool isEditing = state is not ApplicationState.Idle;
        _stripMenuFileClose.Enabled = isEditing;
        _stripMenuFileSaveAs.Enabled = isEditing;
        _stripMenuFileSave.Enabled = isEditing && state is not ApplicationState.OpenFile;
    }

    /// <summary>
    /// Enables or disables the file name in the title or the window.
    /// </summary>
    /// <remarks>
    /// An asterisk is appended to the file name if there are unsaved changes.
    /// </remarks>
    /// <param name="state">The current state of the application.</param>
    /// <param name="fullPath">Absolute path to the Excel file.</param>
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

    /// <summary>
    /// Binds the data in a <see cref="ProfileModel"/> object to their corresponding textboxes in
    /// the editor page.
    /// </summary>
    /// <param name="profileInfo">The model to bind.</param>
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

    /// <summary>
    /// Binds a collection of task models to the grid of assigned tasks.
    /// </summary>
    /// <param name="tasks">The model to bind.</param>
    public void BindAssignedTasks(BindingList<TaskModel> tasks)
    {
        _projectEditor.AssignedTasks.DataSource = tasks;
        // References to tasks are static
        _projectEditor.AssignedTasks.Columns[0].ReadOnly = true;
    }

    /// <summary>
    /// Binds a collection of task models to the grid of available tasks.
    /// </summary>
    /// <param name="tasks">The model to bind.</param>
    public void BindAvailableTasks(BindingList<TaskModel> tasks)
    {
        _projectEditor.AvailableTasks.DataSource = tasks;
    }

    /// <summary>
    /// Binds the absolute path to the current task database to its corresponding label.
    /// </summary>
    /// <param name="manager">An object containing the path.</param>
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

    /// <summary>
    /// Filters assigned tasks based on the user-provided search pattern and the selected field.
    /// </summary>
    /// <remarks>
    /// This method is to be called every time the associated grid changes.
    /// </remarks>
    private void FilterAssignedTasks()
    {
        if (_projectEditor.AssignedTasks.DataSource is null)
            return;

        // This is to prevent weird exceptions from being thrown
        // https://stackoverflow.com/a/18942430/22760966
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

            // Filter by making a row invisible and deselecting if it is selected
            row.Visible = isMatch;
            row.Selected &= isMatch;
        }

        // Update the counter text
        _projectEditor.AssignedTasksSearchCount.Text = GetSearchCountText(itemCount, matchCount);

        currencyManager.ResumeBinding();
    }

    /// <summary>
    /// Filters available tasks based on the user-provided search pattern, the selected field, and
    /// whether or not the task has already been assigned to a trainee.
    /// </summary>
    /// <remarks>
    /// This method is to be called every time the associated grid changes.
    /// </remarks>
    private void FilterAvailableTasks()
    {
        if (_projectEditor.AvailableTasks.DataSource is null)
            return;

        // See the FilterAssignedTasks method for an explanation
        CurrencyManager currencyManager = (CurrencyManager)BindingContext![_projectEditor.AvailableTasks.DataSource];
        currencyManager.SuspendBinding();

        var assignedTasks = _projectEditor.AssignedTasks.Rows.Cast<object>();
        var regex = _availableTaskSearchPattern;
        int searchIndex = _availableTaskSearchBy;
        int itemCount = 0;
        int matchCount = 0;

        foreach (DataGridViewRow row in _projectEditor.AvailableTasks.Rows)
        {
            // Search by task.Reference among assigned tasks
            bool isAssigned =
                assignedTasks.Any(t =>
                {
                    var rowReference = row.Cells[0].Value;
                    var otherRowReference = ((DataGridViewRow)t).Cells[0].Value;
                    return Equals(rowReference, otherRowReference);
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

            // Filter by making a row invisible and deselecting if it is selected
            row.Visible = isMatch;
            row.Selected &= isMatch;
        }

        // Update the counter text
        _projectEditor.AvailableTasksSearchCount.Text = GetSearchCountText(itemCount, matchCount);

        currencyManager.ResumeBinding();
    }

    /// <summary>
    /// Gets a formatted string for the number of all tasks and the matched ones.
    /// </summary>
    /// <param name="itemCount">The total number of tasks.</param>
    /// <param name="matchCount">The number of matched tasks.</param>
    /// <returns>A formatted string to display to a user.</returns>
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

    /// <summary>
    /// Opens a link to the wiki page in the user's default browser.
    /// </summary>
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

    /// <summary>
    /// Prompts the user to save a project.
    /// </summary>
    /// <param name="fullPath">The location where the project will be saved.</param>
    /// <returns>
    /// <see langword="true"/> if the project was successfully saved before
    /// the operation was cancelled; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool TryPromptSaveFile(out string fullPath)
    {
        return TryPrompt(SaveFilePrompt, out fullPath);
    }

    /// <summary>
    /// Prompts the user to save a project as one of the supported file formats with a default file name.
    /// </summary>
    /// <param name="fileFormat">The file format to save the project as.</param>
    /// <param name="fullPath">The location where the project will be saved.</param>
    /// <returns>
    /// <see langword="true"/> if the project was successfully saved before
    /// the operation was cancelled; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool TryPromptSaveFileAs(ref FileFormat fileFormat, out string fullPath)
    {
        return TryPromptSaveFileAs(ref fileFormat, DefaultFileName, out fullPath);
    }

    /// <summary>
    /// Prompts the user to save a project as one of the supported file formats.
    /// </summary>
    /// <param name="fileFormat">The file format to save the project as.</param>
    /// <param name="fileName">The file name to be given to the project.</param>
    /// <param name="fullPath">The location where the project will be saved.</param>
    /// <returns>
    /// <see langword="true"/> if the project was successfully saved before
    /// the operation was cancelled; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool TryPromptSaveFileAs(ref FileFormat fileFormat, string fileName, out string fullPath)
    {
        SaveAsFilePrompt.FilterIndex = (int)fileFormat;
        SaveAsFilePrompt.FileName = fileName;
        bool success = TryPrompt(SaveAsFilePrompt, out fullPath);
        fileFormat = (FileFormat)SaveAsFilePrompt.FilterIndex;
        return success;
    }

    /// <summary>
    /// Prompts the user to open a project.
    /// </summary>
    /// <param name="fullPath">Absolute path to the Excel file.</param>
    /// <returns>
    /// <see langword="true"/> if the project was successfully opened before
    /// the operation was cancelled; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool TryPromptOpenFile(out string fullPath)
    {
        return TryPrompt(OpenFilePrompt, out fullPath);
    }

    /// <summary>
    /// Prompts the user to select a task database.
    /// </summary>
    /// <param name="fullPath">Absolute path to the task database.</param>
    /// <returns>
    /// <see langword="true"/> if the database file was successfully opened before
    /// the operation was cancelled; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool TryPromptSelectTaskDatabase(out string fullPath)
    {
        return TryPrompt(SelectTaskDatabasePrompt, out fullPath);
    }

    /// <summary>
    /// Prompts the user a file dialog box.
    /// </summary>
    /// <param name="dialog">The dialog box to prompt.</param>
    /// <param name="fullPath">The result of the dialog.</param>
    /// <returns>
    /// <see langword="false"/> if the dialog was cancelled; otherwise, <see langword="true"/>.
    /// </returns>
    public static bool TryPrompt(FileDialog dialog, out string fullPath)
    {
        var choice = dialog.ShowDialog();
        fullPath = dialog.FileName;
        return choice is DialogResult.OK;
    }

    /// <summary>
    /// Warns the user about unsaved changes in a project before closing the project or exiting
    /// the application.
    /// </summary>
    /// <returns>
    /// The return value of a dialog box; <see cref="DialogResult.Yes"/> to save the project,
    /// <see cref="DialogResult.No"/> to discard changes, <see cref="DialogResult.Cancel"/>
    /// to keep the project open.
    /// </returns>
    public static DialogResult WarnUnsavedChanges()
    {
        return MessageBox.Show(
            text: "Do you want to save your changes to a file?",
            caption: "Unsaved Changes",
            buttons: MessageBoxButtons.YesNoCancel,
            icon: MessageBoxIcon.Exclamation,
            defaultButton: MessageBoxDefaultButton.Button1);
    }

    /// <summary>
    /// Warns the user about packed names to be saved separately.
    /// </summary>
    /// <returns>
    /// The return value of a dialog box; <see cref="DialogResult.Yes"/> to save the project
    /// as a single file, <see cref="DialogResult.No"/> to cancel.
    /// </returns>
    public static bool WarnPackedNames()
    {
        return MessageBox.Show(
            text: "The field named `Trainee` contains packed names delimited with semicolons. In order to unpack this field and save files separately, use `Save As` instead. Do you want to continue saving to a single file?",
            caption: "Packed Names",
            buttons: MessageBoxButtons.YesNo,
            icon: MessageBoxIcon.Question,
            defaultButton: MessageBoxDefaultButton.Button2) 
            is DialogResult.Yes;
    }
}
