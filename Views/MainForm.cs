using System;

namespace ExcelTool.Views;

public sealed partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void StripMenuFileNew_Click(object sender, EventArgs e)
    {
        ProjectManager.CreateNewProject();
        _stripStatusProgramState.Text = "New";
    }

    private void StripMenuFileOpen_Click(object sender, EventArgs e)
    {
        ProjectManager.OpenProject();
        _stripStatusProgramState.Text = "Open";
    }

    private void StripMenuFileClose_Click(object sender, EventArgs e)
    {
        ProjectManager.CloseCurrentProject();
        _stripStatusProgramState.Text = "Close";
    }

    private void StripMenuFileExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void StripMenuHelp_Click(object sender, EventArgs e)
    {

    }

    private void StripMenuLicense_Click(object sender, EventArgs e)
    {
        LicenseForm license = new();
        license.ShowDialog();
    }

    private void StartMenuNewButton_Click(object sender, EventArgs e)
    {
        ProjectManager.CreateNewProject();
        _stripStatusProgramState.Text = "New";
    }

    private void StartMenuOpenButton_Click(object sender, EventArgs e)
    {
        ProjectManager.OpenProject();
        _stripStatusProgramState.Text = "Open";
    }
}
