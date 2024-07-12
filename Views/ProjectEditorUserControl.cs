using System;
using System.ComponentModel;
using System.Diagnostics;
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
    /// Occurs when the user selects databases for available tasks.
    /// </summary>
    [Browsable(true)]
    public event EventHandler? SelectTaskDatabases;

    /// <summary>
    /// Occurs when the user copies the absolute paths to the Excel files
    /// containing all available tasks.
    /// </summary>
    [Browsable(true)]
    public event EventHandler? CopyTaskDatabaseFilePaths;

    /// <summary>
    /// Occurs when the user loads required scores from an Excel file into assigned tasks.
    /// </summary>
    [Browsable(true)]
    public event EventHandler? LoadRequiredScores;

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

        AssignedTasks.AutoGenerateColumns = false;
        BindTasks(AvailableTasks.Columns);

        AvailableTasks.AutoGenerateColumns = false;
        BindTasks(AssignedTasks.Columns);
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
    private void SelectTaskDatabasesButton_Click(object sender, EventArgs e)
    {
        SelectTaskDatabases?.Invoke(sender, e);
    }

    /// <summary>
    /// Invoked when the `copy task database path` button is clicked.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    private void CopyTaskDatabaseFilePathsButton_Click(object sender, EventArgs e)
    {
        CopyTaskDatabaseFilePaths?.Invoke(sender, e);
    }

    /// <summary>
    /// Invoked when the `load required scores` button is clicked.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    private void LoadRequiredScoresButton_Click(object sender, EventArgs e)
    {
        LoadRequiredScores?.Invoke(sender, e);
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

    private static void BindTasks(DataGridViewColumnCollection columns)
    {
        // References to tasks are static, therefore the first column is readonly.
        // Set the SortMode to DataGridViewColumnSortMode.NotSortable; otherwise,
        // the text in the column headers will not be perfectly centered
        // https://stackoverflow.com/a/55010743/22760966
        columns.AddRange(
        [
            new DataGridViewWrappingTextBoxColumn
            {
                DataPropertyName = "Reference",
                Name = "Reference",
                HeaderText = "Reference",
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable,
            },
            new DataGridViewWrappingTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Description",
                Name = "Description",
                SortMode = DataGridViewColumnSortMode.NotSortable
            },
            new DataGridViewWrappingTextBoxColumn
            {
                DataPropertyName = "TrainingCategory",
                HeaderText = "Training Category",
                Name = "Training Category",
                SortMode = DataGridViewColumnSortMode.NotSortable
            },
            new DataGridViewWrappingTextBoxColumn
            {
                DataPropertyName = "Type",
                HeaderText = "Type",
                Name = "Type",
                SortMode = DataGridViewColumnSortMode.NotSortable
            },
            new DataGridViewWrappingTextBoxColumn
            {
                DataPropertyName = "TrainingStarted",
                HeaderText = "Training Started",
                Name = "Training Started",
                SortMode = DataGridViewColumnSortMode.NotSortable
            },
            new DataGridViewWrappingTextBoxColumn
            {
                DataPropertyName = "TrainingCompleted",
                HeaderText = "Training Completed",
                Name = "Training Completed",
                SortMode = DataGridViewColumnSortMode.NotSortable
            },
            new DataGridViewWrappingTextBoxColumn
            {
                DataPropertyName = "TrainerInitials",
                HeaderText = "Trainer Initials",
                Name = "Trainer Initials",
                SortMode = DataGridViewColumnSortMode.NotSortable
            },
            new DataGridViewWrappingTextBoxColumn
            {
                DataPropertyName = "CertifierInitials",
                HeaderText = "Certifier Initials",
                Name = "Certifier Initials",
                SortMode = DataGridViewColumnSortMode.NotSortable
            },
            new DataGridViewWrappingTextBoxColumn
            {
                DataPropertyName = "CertifyingScore",
                HeaderText = "Certifying Score",
                Name = "Certifying Score",
                SortMode = DataGridViewColumnSortMode.NotSortable
            },
            new DataGridViewWrappingTextBoxColumn
            {
                DataPropertyName = "RequiredScore",
                HeaderText = "Required Score",
                Name = "Required Score",
                SortMode = DataGridViewColumnSortMode.NotSortable
            }
        ]);

        // Set colors
        // Only the first column (References) is readonly and should be colored red
        for (int i = 0; i < columns.Count; i++)
        {
            columns[i].DefaultCellStyle.BackColor = i is 0 ? Color.IndianRed : Color.LightGreen;
        }
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

public class DataGridViewWrappingTextBoxCell : DataGridViewTextBoxCell
{
    protected override Size GetPreferredSize(Graphics graphics,
        DataGridViewCellStyle cellStyle, int rowIndex, Size constraintSize)
    {
        if (cellStyle.WrapMode is DataGridViewTriState.True && RowIndex >= 0)
        {
            string value = string.Format("{0}", FormattedValue);
            using var g = OwningColumn.DataGridView!.CreateGraphics();
            var r = g.MeasureString(value, cellStyle.Font, OwningColumn.Width).ToSize();

            //  r.Width += cellStyle.Padding.Left + cellStyle.Padding.Right;
            //  r.Height += cellStyle.Padding.Top + cellStyle.Padding.Bottom;
            r.Height += 4;
            return r;
        }
        else
        {
            return base.GetPreferredSize(graphics, cellStyle, rowIndex, constraintSize);
        }
    }

    protected override void Paint(Graphics graphics, Rectangle clipBounds,
        Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState,
        object value, object formattedValue, string errorText,
        DataGridViewCellStyle cellStyle,
        DataGridViewAdvancedBorderStyle advancedBorderStyle,
        DataGridViewPaintParts paintParts)
    {
        base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value,
            formattedValue, errorText, cellStyle, advancedBorderStyle,
            paintParts & ~DataGridViewPaintParts.ContentForeground);

        //Rectangle borderWidths = BorderWidths(advancedBorderStyle);
        //Rectangle valBounds = cellBounds;
        //valBounds.Offset(borderWidths.X, borderWidths.Y);
        //valBounds.Width -= borderWidths.Left;
        //valBounds.Height -= borderWidths.Bottom;

        //  cellBounds.Y += cellStyle.Font.Height;

        //bool cellSelected = (cellState & DataGridViewElementStates.Selected) != 0;
        //TextRenderer.DrawText(graphics,
        //    string.Format("{0}", formattedValue),
        //    cellStyle.Font,
        //    cellBounds,
        //    cellSelected ? cellStyle.SelectionForeColor : cellStyle.ForeColor,
        //    TextFormatFlags.Left | TextFormatFlags.Top);

        graphics.DrawString(string.Format("{0}", formattedValue),
            cellStyle.Font, Brushes.Black, cellBounds);
    }
}

public class DataGridViewWrappingTextBoxColumn : DataGridViewColumn
{
    public DataGridViewWrappingTextBoxColumn()
    {
        CellTemplate = new DataGridViewWrappingTextBoxCell();
    }
}
