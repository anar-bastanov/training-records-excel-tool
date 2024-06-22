using System;
using System.ComponentModel;

namespace ExcelTool.Views;

public partial class ProjectEditorUserControl : UserControl
{
    public RichTextBox HeaderInfoTrainee => _traineeRichTextBox;

    public RichTextBox HeaderInfoCourse => _courseRichTextBox;

    public RichTextBox HeaderInfoPosition => _positionRichTextBox;

    public RichTextBox HeaderInfoManager => _managerRichTextBox;

    public DataGridView AssignedTasks => _assignedTasksDataGridView;

    public DataGridView AvailableTasks => _availableTasksDataGridView;

    public Label TaskDatabasePath => _taskDatabasePathLabel;

    [Browsable(true)]
    public event EventHandler? SelectTaskDatabase;

    [Browsable(true)]
    public event EventHandler? CopyTaskDatabaseFilePath;

    [Browsable(true)]
    public event EventHandler<DataGridViewSelectedRowCollection>? AssignTaskFromDatabase;

    [Browsable(true)]
    public event EventHandler<int>? UnassignTask;

    public ProjectEditorUserControl()
    {
        InitializeComponent();
    }

    private void SelectTaskDatabaseButton_Click(object sender, EventArgs e)
    {
        SelectTaskDatabase?.Invoke(sender, e);
    }

    private void CopyTaskDatabaseFilePathButton_Click(object sender, EventArgs e)
    {
        CopyTaskDatabaseFilePath?.Invoke(sender, e);
    }

    private void AssignedTasksDataGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
    {
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
    }

    private void AssignedTasksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex is not 0)
            return;

        UnassignTask?.Invoke(sender, e.RowIndex);
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
}
