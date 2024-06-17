namespace ExcelTool.Views;

public partial class ProjectEditorUserControl : UserControl
{
    public TextBox HeaderInfoTrainee => _traineeTextBox;

    public TextBox HeaderInfoCourse => _courseTextBox;

    public TextBox HeaderInfoPosition => _positionTextBox;

    public TextBox HeaderInfoManager => _managerTextBox;

    public ProjectEditorUserControl()
    {
        InitializeComponent();
    }
}
