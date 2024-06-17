using System;
using System.Diagnostics;

namespace ExcelTool.Views;

public sealed partial class MainForm : Form
{
    public event Action? FileNewRequested;

    public event Action? FileOpenRequested;

    public event Action? FileCloseRequested;

    public MainForm()
    {
        InitializeComponent();
    }

    private void StripMenuFileNew_Click(object sender, EventArgs e)
    {
        FileNewRequested?.Invoke();
    }

    private void StripMenuFileOpen_Click(object sender, EventArgs e)
    {
        FileOpenRequested?.Invoke();
    }

    private void StripMenuFileClose_Click(object sender, EventArgs e)
    {
        FileCloseRequested?.Invoke();
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

    public void AdjustStripMenuItemsAndVisuals(ApplicationState state)
    {
        if (state is ApplicationState.Idle)
            _startMenu.BringToFront();
        else
            _projectEditor.BringToFront();

        _debugStatus.Text = state.ToString();

        switch (state)
        {
            case ApplicationState.Idle:
                _stripMenuFileClose.Enabled = false;
                _stripMenuFileSave.Enabled = false;
                _stripMenuFileSaveAs.Enabled = false;
                break;
            case ApplicationState.NewFile:
                _stripMenuFileClose.Enabled = false;
                _stripMenuFileSave.Enabled = true;
                _stripMenuFileSaveAs.Enabled = true;
                break;
            case ApplicationState.OpenFile:
                _stripMenuFileClose.Enabled = true;
                _stripMenuFileSave.Enabled = false;
                _stripMenuFileSaveAs.Enabled = true;
                break;
            case ApplicationState.NewFileUnsavedChanges:
                _stripMenuFileClose.Enabled = true;
                _stripMenuFileSave.Enabled = true;
                _stripMenuFileSaveAs.Enabled = true;
                break;
            case ApplicationState.OpenFileUnsavedChanges:
                _stripMenuFileClose.Enabled = true;
                _stripMenuFileSave.Enabled = true;
                _stripMenuFileSaveAs.Enabled = true;
                break;
            default:
                throw new NotSupportedException("This is not supposed to happen.");
        }
    }

    public void BindProjectData(ProjectModel project)
    {
        _projectEditor.HeaderInfoTrainee.DataBindings.Clear();
        _projectEditor.HeaderInfoTrainee.DataBindings.Add(
            propertyName: "Text",
            dataSource: project.ProfileInfo,
            dataMember: "Trainee",
            formattingEnabled: false,
            updateMode: DataSourceUpdateMode.OnPropertyChanged);

        _projectEditor.HeaderInfoCourse.DataBindings.Clear();
        _projectEditor.HeaderInfoCourse.DataBindings.Add(
            propertyName: "Text",
            dataSource: project.ProfileInfo,
            dataMember: "Course",
            formattingEnabled: false,
            updateMode: DataSourceUpdateMode.OnPropertyChanged);

        _projectEditor.HeaderInfoPosition.DataBindings.Clear();
        _projectEditor.HeaderInfoPosition.DataBindings.Add(
            propertyName: "Text",
            dataSource: project.ProfileInfo,
            dataMember: "Position",
            formattingEnabled: false,
            updateMode: DataSourceUpdateMode.OnPropertyChanged);

        _projectEditor.HeaderInfoManager.DataBindings.Clear();
        _projectEditor.HeaderInfoManager.DataBindings.Add(
            propertyName: "Text",
            dataSource: project.ProfileInfo,
            dataMember: "Manager",
            formattingEnabled: false,
            updateMode: DataSourceUpdateMode.OnPropertyChanged);
    }

    private static void OpenWikiPageForHelp()
    {
        const string linkToWiki = "https://github.com/anar-bastanov/training-records-excel-tool/wiki";

        var choice = MessageBox.Show(
            text: $"""
            You are about to open a link in your default browser!

            Clicking `OK` will take you to:
            {linkToWiki}
            """,
            caption: "External Link",
            buttons: MessageBoxButtons.OKCancel,
            icon: MessageBoxIcon.Asterisk,
            defaultButton: MessageBoxDefaultButton.Button1);

        if (choice is DialogResult.Cancel)
            return;

        // Open the default browser with the link to GitHub wiki:
        ProcessStartInfo psInfo = new()
        {
            FileName = linkToWiki,
            UseShellExecute = true
        };

        Process.Start(psInfo);
    }
}
