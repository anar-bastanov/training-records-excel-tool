using System;
using System.ComponentModel;

namespace ExcelTool.Views;

public partial class ProjectEditorUserControl : UserControl
{
    public Label TaskDatabasePath => _taskDatabasePathLabel;

    public TextBox HeaderInfoTrainee => _traineeTextBox;

    public TextBox HeaderInfoCourse => _courseTextBox;

    public TextBox HeaderInfoPosition => _positionTextBox;

    public TextBox HeaderInfoManager => _managerTextBox;

    [Browsable(true)]
    public event EventHandler? SelectTaskDatabase;
    
    [Browsable(true)]
    public event EventHandler? CopyTaskDatabaseFilePath;

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
}
