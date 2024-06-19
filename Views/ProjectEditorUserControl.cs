using System;
using System.ComponentModel;

namespace ExcelTool.Views;

public partial class ProjectEditorUserControl : UserControl
{
    public Label TaskDatabasePath => _taskDatabasePathLabel;

    public RichTextBox HeaderInfoTrainee => _traineeRichTextBox;

    public RichTextBox HeaderInfoCourse => _courseRichTextBox;

    public RichTextBox HeaderInfoPosition => _positionRichTextBox;

    public RichTextBox HeaderInfoManager => _managerRichTextBox;

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
