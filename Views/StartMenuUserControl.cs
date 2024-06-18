using System;
using System.ComponentModel;

namespace ExcelTool.Views;

public partial class StartMenuUserControl : UserControl
{
    [Browsable(true)]
    public event EventHandler? NewFileClick;

    [Browsable(true)]
    public event EventHandler? OpenFileClick;

    [Browsable(true)]
    public event EventHandler? HelpClick;

    public StartMenuUserControl()
    {
        InitializeComponent();
    }

    private void StartMenuNewFileButton_Click(object sender, EventArgs e)
    {
        NewFileClick?.Invoke(sender, e);
    }

    private void StartMenuOpenFileButton_Click(object sender, EventArgs e)
    {
        OpenFileClick?.Invoke(sender, e);
    }

    private void StartMenuHelpButton_Click(object sender, EventArgs e)
    {
        HelpClick?.Invoke(sender, e);
    }
}
