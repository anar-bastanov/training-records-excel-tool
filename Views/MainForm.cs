using System;
using System.Diagnostics;

namespace ExcelTool.Views;

public sealed partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        ProjectManager.OnApplicationStateChanged += AdjustStripMenuItemsAndVisuals;
    }

    private void StripMenuFileNew_Click(object sender, EventArgs e)
    {
        ProjectManager.CreateNewProject();
    }

    private void StripMenuFileOpen_Click(object sender, EventArgs e)
    {
        ProjectManager.OpenProject();
    }

    private void StripMenuFileClose_Click(object sender, EventArgs e)
    {
        ProjectManager.CloseCurrentProject();
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

    private void AdjustStripMenuItemsAndVisuals(ApplicationState state)
    {
        if (state is ApplicationState.OnStartMenu)
            _startMenu.BringToFront();
        else
            _projectEditor.BringToFront();

        switch (state)
        {
            case ApplicationState.OnStartMenu:
                _stripMenuFileClose.Enabled = false;
                _stripMenuFileSave.Enabled = false;
                _stripMenuFileSaveAs.Enabled = false;
                break;
            case ApplicationState.NewFile:
                _stripMenuFileClose.Enabled = true;
                _stripMenuFileSave.Enabled = false;
                _stripMenuFileSaveAs.Enabled = true;
                break;
            case ApplicationState.OpenFile:
                _stripMenuFileClose.Enabled = true;
                _stripMenuFileSave.Enabled = false;
                _stripMenuFileSaveAs.Enabled = true;
                break;
            case ApplicationState.NewFileUnsavedChanges:
                _stripMenuFileClose.Enabled = false;
                _stripMenuFileSave.Enabled = false;
                _stripMenuFileSaveAs.Enabled = true;
                break;
            case ApplicationState.OpenFileUnsavedChanges:
                _stripMenuFileClose.Enabled = false;
                _stripMenuFileSave.Enabled = true;
                _stripMenuFileSaveAs.Enabled = true;
                break;
            default:
                throw new NotSupportedException("This is not supposed to happen.");
        }
    }

    private static void OpenWikiPageForHelp()
    {
        const string linkToWiki = "https://github.com/anar-bastanov/training-records-excel-tool/wiki";

        var choice = MessageBox.Show(
            $"""
            You are about to open a link in your default browser!

            Clicking `OK` will take you to:
            {linkToWiki}
            """,
            "External Link",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Asterisk,
            MessageBoxDefaultButton.Button1);

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
