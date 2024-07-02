using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace ExcelTool.Views;

/// <summary>
/// Represents the editor page of the application in which the user can edit projects.
/// </summary>
public partial class ProjectEditorUserControl : UserControl
{
    /// <summary>
    /// The search pattern provided by the user used to match and filter assigned tasks.
    /// </summary>
    /// <remarks>
    /// If the user did not provide a search input, this field is <see langword="null"/>.
    /// </remarks>
    private Regex? _assignedTaskSearchPattern;

    /// <summary>
    /// The search pattern provided by the user used to match and filter available tasks.
    /// </summary>
    /// <remarks>
    /// If the user did not provide a search input, this field is <see langword="null"/>.
    /// </remarks>
    private Regex? _availableTaskSearchPattern;

    /// <summary>
    /// Gets the text box associated with a trainee's name.
    /// </summary>
    public RichTextBox HeaderInfoTrainee => _traineeRichTextBox;

    /// <summary>
    /// Gets the text box associated with a trainee's course.
    /// </summary>
    public RichTextBox HeaderInfoCourse => _courseRichTextBox;

    /// <summary>
    /// Gets the text box associated with a trainee's position.
    /// </summary>
    public RichTextBox HeaderInfoPosition => _positionRichTextBox;

    /// <summary>
    /// Gets the text box associated with a trainee's manager.
    /// </summary>
    public RichTextBox HeaderInfoManager => _managerRichTextBox;

    /// <summary>
    /// Gets the grid of tasks assigned to a trainee.
    /// </summary>
    public DataGridView AssignedTasks => _assignedTasksDataGridView;

    /// <summary>
    /// Gets the grid of tasks available to be assigned to a trainee.
    /// </summary>
    public DataGridView AvailableTasks => _availableTasksDataGridView;

    /// <summary>
    /// Gets the label that shows the number of search results for the assigned tasks.
    /// </summary>
    public Label AssignedTasksSearchCount => _assignedTaskSearchCountLabel;

    /// <summary>
    /// Gets the label that shows the number of search results for the available tasks.
    /// </summary>
    public Label AvailableTasksSearchCount => _availableTaskSearchCountLabel;

    /// <summary>
    /// Gets the label for the absolute path to the Excel file containing all available tasks.
    /// </summary>
    public Label TaskDatabasePath => _taskDatabasePathLabel;

    /// <summary>
    /// Occurs when the user selects a database for available tasks.
    /// </summary>
    [Browsable(true)]
    public event EventHandler? SelectTaskDatabase;

    /// <summary>
    /// Occurs when the user copies the absolute path to the Excel file
    /// containing all available tasks.
    /// </summary>
    [Browsable(true)]
    public event EventHandler? CopyTaskDatabaseFilePath;

    /// <summary>
    /// Occurs when the user assigns one or more of available tasks to a trainee.
    /// </summary>
    [Browsable(true)]
    public event EventHandler<DataGridViewSelectedRowCollection>? AssignTaskFromDatabase;

    /// <summary>
    /// Occurs when the user unassigns a task of a specified index from a trainee.
    /// </summary>
    [Browsable(true)]
    public event EventHandler<int>? UnassignTask;

    /// <summary>
    /// Occurs when the user searches for a pattern in a specified column in the
    /// assigned tasks grid.
    /// </summary>
    [Browsable(true)]
    public event Action<Regex?, int>? AssignedTasksSearchPatternBy;

    /// <summary>
    /// Occurs when the user searches for a pattern in a specified column in the
    /// available tasks grid.
    /// </summary>
    [Browsable(true)]
    public event Action<Regex?, int>? AvailableTasksSearchPatternBy;

    /// <summary>
    /// Initializes a new instance of the <see cref="ProjectEditorUserControl"/> class.
    /// </summary>
    public ProjectEditorUserControl()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Handles the <see cref="UserControl.Load"/> event of this user 
    /// control. Sets the default column to search the pattern in to 
    /// 'Description' at the start of the application.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    private void ProjectEditorUserControl_Load(object sender, EventArgs e)
    {
        // The default column to search the pattern in should be
        // `Description`, which is the second column, hence the index 1
        _assignedTaskSearchByComboBox.SelectedIndex = 1;
        _availableTaskSearchByComboBox.SelectedIndex = 1;
    }

    /// <summary>
    /// Invoked when the `select task database` button is clicked.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    private void SelectTaskDatabaseButton_Click(object sender, EventArgs e)
    {
        SelectTaskDatabase?.Invoke(sender, e);
    }

    /// <summary>
    /// Invoked when the `copy task database path` button is clicked.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    private void CopyTaskDatabaseFilePathButton_Click(object sender, EventArgs e)
    {
        CopyTaskDatabaseFilePath?.Invoke(sender, e);
    }

    /// <summary>
    /// Handles the <see cref="DataGridView.CellEnter"/> event of the
    /// <see cref="AssignedTasks"/> grid. Enables editing a selectedCell without
    /// needing to double click it first, which makes it easier to edit
    /// multiple cells.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="DataGridViewCellEventArgs"/> that contains the event data.</param>
    private void AssignedTasksDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
        // Normally, when the user first clicks a selectedCell, it selects that
        // selectedCell and gives it focus. After that, the user either needs to
        // press a key or double click the selectedCell in order to enter the
        // edit mode. This is just how DataGridViews in WinForms work
        // from what I could understand

        // For the user's convenience, we want to enter the edit mode
        // without needing to press a key or double click it. Simply
        // clicking it once should be enough. This will prove more
        // useful when the user tries to edit multiple cells at once
        // after selecting more than one selectedCell
        _assignedTasksDataGridView.BeginEdit(selectAll: true);
    }

    /// <summary>
    /// Handles the <see cref="DataGridView.CellValueChanged"/> event of
    /// the <see cref="AssignedTasks"/> grid. Implements multicell editing
    /// by setting the values of all selected cells to the new editedValue of the
    /// selectedCell that is being edited.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="DataGridViewCellEventArgs"/> that contains the event data.</param>
    private void AssignedTasksDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        // Since we change the values of other cells inside the CellValueChanged
        // event handler, recursion is on the way. One dirty and quick way of
        // avoiding recursive calls is to have a variable indicating whether
        // the current function call is the first time entering this method.
        // Normal and sane people would create a separate boolean field, but
        // I say why not use the `Tag` property if it already exists?

        // Do nothing if the tag was set during the first call to the method
        if (_assignedTasksDataGridView.Tag is not null)
            return;

        // Set the tag to ANYTHING other than null
        _assignedTasksDataGridView.Tag = this;

        var editedValue = _assignedTasksDataGridView[e.ColumnIndex, e.RowIndex].Value;

        foreach (DataGridViewCell selectedCell in _assignedTasksDataGridView.SelectedCells)
        {
            // Some columns, specifically the 'Reference' column, might be readonly
            if (!selectedCell.ReadOnly)
            {
                selectedCell.Value = editedValue;
            }
        }

        // Reset the tag
        _assignedTasksDataGridView.Tag = null;
    }

    /// <summary>
    /// Handles the <see cref="DataGridView.ColumnAdded"/> event of the
    /// <see cref="AssignedTasks"/> grid.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="DataGridViewColumnEventArgs"/> that contains the event data.</param>
    private void AssignedTasksDataGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
    {
        // Apparently we need this method to disable glyphs. Otherwise,
        // the text in the column headers will not be perfectly centered
        // https://stackoverflow.com/a/55010743/22760966
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;

        // Set colors
        e.Column.DefaultCellStyle.BackColor = e.Column.Index is 0 ? Color.IndianRed : Color.LightGreen;
    }

    /// <summary>
    /// Handles the <see cref="Control.KeyUp"/> event of the <see cref="AssignedTasks"/>
    /// grid. Unassigns selected tasks from a trainee on the user's appropriate key presses
    /// if the selection only consists of the cells in the first column of <see cref="AssignedTasks"/>.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="KeyEventArgs"/> that contains the event data.</param>
    private void AssignedTasksDataGridView_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode is not (Keys.Delete or Keys.Back))
            return;

        foreach (DataGridViewCell selection in _assignedTasksDataGridView.SelectedCells)
        {
            // The buttons are located in the first column, therefore ColumnIndex
            // must be 0. Additionally, the user might have clicked on the HEADER
            // instead of the actual buttons, which means RowIndex must not be -1
            if (selection.ColumnIndex is not 0 || selection.RowIndex is -1)
                return;
        }

        foreach (DataGridViewCell cell in _assignedTasksDataGridView.SelectedCells)
        {
            UnassignTask?.Invoke(sender, cell.RowIndex);
        }

        // Prevents a "bug" in which the last row gets automatically selected
        e.Handled = true;
    }

    /// <summary>
    /// Handles the <see cref="DataGridView.ColumnAdded"/> event of the
    /// <see cref="AvailableTasks"/> grid.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="DataGridViewColumnEventArgs"/> that contains the event data.</param>
    private void AvailableTasksDataGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
    {
        // See the AssignedTasksDataGridView_ColumnAdded method for an explanation
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;

        // Set colors
        e.Column.DefaultCellStyle.BackColor = e.Column.Index is 0 ? Color.IndianRed : Color.LightGreen;
    }

    /// <summary>
    /// Handles the <see cref="Control.KeyDown"/> event of the <see cref="AvailableTasks"/>
    /// grid. Assigns selected tasks to a trainee on the user's appropriate key presses.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="KeyEventArgs"/> that contains the event data.</param>
    private void AvailableTasksDataGridView_KeyDown(object sender, KeyEventArgs e)
    {
        // Prevents a "bug" in which the last row gets automatically selected
        if (e.KeyCode is Keys.Enter)
            e.Handled = true;

        if (e.KeyCode is not (Keys.Enter or Keys.Space or Keys.Insert))
            return;

        // Do nothing if nothing is selected
        if (_availableTasksDataGridView.SelectedRows.Count is 0)
            return;

        AssignTaskFromDatabase?.Invoke(sender, _availableTasksDataGridView.SelectedRows);
    }

    /// <summary>
    /// Handles the <see cref="DataGridView.CellDoubleClick"/> event of the
    /// <see cref="AvailableTasks"/> grid. Assigns a task to a trainee when
    /// the user double clicks on a row.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="DataGridViewCellMouseEventArgs"/> that contains the event data.</param>
    private void AvailableTasksDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        // Double clicked a header
        if (e.RowIndex is -1)
            return;

        AssignTaskFromDatabase?.Invoke(sender, _availableTasksDataGridView.SelectedRows);
    }

    /// <summary>
    /// Invoked when the user searches a pattern among assigned tasks.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
    private void AssignedTaskSearchPatternRichTextBox_TextChanged(object sender, EventArgs e)
    {
        string pattern = _assignedTaskSearchPatternRichTextBox.Text;
        int searchBy = _assignedTaskSearchByComboBox.SelectedIndex;
        var regex = CreateRegex(pattern);

        // Cache it for AssignedTaskSearchByComboBox_SelectedIndexChanged
        _assignedTaskSearchPattern = regex;
        AssignedTasksSearchPatternBy?.Invoke(regex, searchBy);
    }

    /// <summary>
    /// Invoked when the user changes the field that the patterns are matched against.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
    private void AssignedTaskSearchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        int searchBy = _assignedTaskSearchByComboBox.SelectedIndex;
        var regex = _assignedTaskSearchPattern;

        AssignedTasksSearchPatternBy?.Invoke(regex, searchBy);
    }

    /// <summary>
    /// Invoked when the user searches a pattern among available tasks.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
    private void AvailableTaskSearchPatternRichTextBox_TextChanged(object sender, EventArgs e)
    {
        string pattern = _availableTaskSearchPatternRichTextBox.Text;
        int searchBy = _availableTaskSearchByComboBox.SelectedIndex;
        var regex = CreateRegex(pattern);

        // Cache it for AvailableTaskSearchByComboBox_SelectedIndexChanged
        _availableTaskSearchPattern = regex;
        AvailableTasksSearchPatternBy?.Invoke(regex, searchBy);
    }

    /// <summary>
    /// Invoked when the user changes the field that the patterns are matched against.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
    private void AvailableTaskSearchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        int searchBy = _availableTaskSearchByComboBox.SelectedIndex;
        var regex = _availableTaskSearchPattern;

        AvailableTasksSearchPatternBy?.Invoke(regex, searchBy);
    }

    /// <summary>
    /// Creates and returns a <see cref="Regex"/> object for a specified regular expression.
    /// </summary>
    /// <remarks>
    /// The main objective of this method is to catch all exceptions that the
    /// <see cref="Regex(string, RegexOptions)"/> constructor might throw if the
    /// user input is an invalid regular expression.
    /// </remarks>
    /// <param name="pattern">The regular expression pattern to match.</param>
    /// <returns>
    /// A <see cref="Regex"/> object for a specified regular expression
    /// if <paramref name="pattern"/> is a valid non-empty pattern;
    /// otherwise, <see langword="null"/>.
    /// </returns>
    private static Regex? CreateRegex(string pattern)
    {
        if (pattern is "")
            return null;

        try
        {
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex;
        }
        catch
        {
            return null;
        }
    }
}
