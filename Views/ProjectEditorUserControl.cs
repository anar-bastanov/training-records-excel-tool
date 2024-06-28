using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace ExcelTool.Views;

public partial class ProjectEditorUserControl : UserControl
{
    private Regex? _assignedTaskSearchPattern;

    private Regex? _availableTaskSearchPattern;

    public RichTextBox HeaderInfoTrainee => _traineeRichTextBox;

    public RichTextBox HeaderInfoCourse => _courseRichTextBox;

    public RichTextBox HeaderInfoPosition => _positionRichTextBox;

    public RichTextBox HeaderInfoManager => _managerRichTextBox;

    public DataGridView AssignedTasks => _assignedTasksDataGridView;

    public DataGridView AvailableTasks => _availableTasksDataGridView;

    public Label AssignedTasksSearchCount => _assignedTaskSearchCountLabel;

    public Label AvailableTasksSearchCount => _availableTaskSearchCountLabel;

    public Label TaskDatabasePath => _taskDatabasePathLabel;

    [Browsable(true)]
    public event EventHandler? SelectTaskDatabase;

    [Browsable(true)]
    public event EventHandler? CopyTaskDatabaseFilePath;

    [Browsable(true)]
    public event EventHandler<DataGridViewSelectedRowCollection>? AssignTaskFromDatabase;

    [Browsable(true)]
    public event EventHandler<int>? UnassignTask;

    [Browsable(true)]
    public event Action<Regex?, int>? AssignedTasksSearchPatternBy;

    [Browsable(true)]
    public event Action<Regex?, int>? AvailableTasksSearchPatternBy;

    public ProjectEditorUserControl()
    {
        InitializeComponent();
    }

    private void ProjectEditorUserControl_Load(object sender, EventArgs e)
    {
        _assignedTaskSearchByComboBox.SelectedIndex = 1;
        _availableTaskSearchByComboBox.SelectedIndex = 1;
    }

    private void SelectTaskDatabaseButton_Click(object sender, EventArgs e)
    {
        SelectTaskDatabase?.Invoke(sender, e);
    }

    private void CopyTaskDatabaseFilePathButton_Click(object sender, EventArgs e)
    {
        CopyTaskDatabaseFilePath?.Invoke(sender, e);
    }

    private void AssignedTasksDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
        _assignedTasksDataGridView.BeginEdit(true);
    }

    private void AssignedTasksDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (_assignedTasksDataGridView.Tag is not null)
            return;

        _assignedTasksDataGridView.Tag = this;

        var value = _assignedTasksDataGridView[e.ColumnIndex, e.RowIndex].Value;

        foreach (DataGridViewCell cell in _assignedTasksDataGridView.SelectedCells)
            if (!cell.ReadOnly)
                cell.Value = value;

        _assignedTasksDataGridView.Tag = null;
    }

    private void AssignedTasksDataGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
    {
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
    }

    private void AssignedTasksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex is not 0 || e.RowIndex is -1)
            return;

        UnassignTask?.Invoke(sender, e.RowIndex);
    }

    private void AssignedTasksDataGridView_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode is not Keys.Enter)
            return;

        foreach (DataGridViewCell selection in _assignedTasksDataGridView.SelectedCells)
            if (selection.ColumnIndex is not 0 || selection.RowIndex is -1)
                return;

        foreach (DataGridViewCell cell in _assignedTasksDataGridView.SelectedCells)
            UnassignTask?.Invoke(sender, cell.RowIndex);

        e.Handled = true;
    }

    private void AvailableTasksDataGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
    {
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
    }

    private void AvailableTasksDataGridView_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode is Keys.Enter)
            e.Handled = true;
        else if (e.KeyCode is not (Keys.Space or Keys.Insert))
            return;

        if (_availableTasksDataGridView.SelectedRows.Count is 0)
            return;

        AssignTaskFromDatabase?.Invoke(sender, _availableTasksDataGridView.SelectedRows);
    }

    private void AvailableTasksDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.RowIndex is -1)
            return;

        AssignTaskFromDatabase?.Invoke(sender, _availableTasksDataGridView.SelectedRows);
    }

    private void AssignedTaskSearchPatternRichTextBox_TextChanged(object sender, EventArgs e)
    {
        string pattern = _assignedTaskSearchPatternRichTextBox.Text;
        int searchBy = _assignedTaskSearchByComboBox.SelectedIndex;
        var regex = CreateRegex(pattern);

        _assignedTaskSearchPattern = regex;
        AssignedTasksSearchPatternBy?.Invoke(regex, searchBy);
    }

    private void AssignedTaskSearchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        int searchBy = _assignedTaskSearchByComboBox.SelectedIndex;
        var regex = _assignedTaskSearchPattern;

        AssignedTasksSearchPatternBy?.Invoke(regex, searchBy);
    }

    private void AvailableTaskSearchPatternRichTextBox_TextChanged(object sender, EventArgs e)
    {
        string pattern = _availableTaskSearchPatternRichTextBox.Text;
        int searchBy = _availableTaskSearchByComboBox.SelectedIndex;
        var regex = CreateRegex(pattern);

        _availableTaskSearchPattern = regex;
        AvailableTasksSearchPatternBy?.Invoke(regex, searchBy);
    }

    private void AvailableTaskSearchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        int searchBy = _availableTaskSearchByComboBox.SelectedIndex;
        var regex = _availableTaskSearchPattern;

        AvailableTasksSearchPatternBy?.Invoke(regex, searchBy);
    }

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
