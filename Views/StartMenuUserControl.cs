using System;
using System.ComponentModel;

namespace ExcelTool.Views;

/// <summary>
/// Represents the main page of the application shown to the user at the start.
/// </summary>
public partial class StartMenuUserControl : UserControl
{
    // The general design is to catch user interactions, and forward these events
    // for others to appropriately handle for themselves. For instance, If the
    // `New File` button was clicked on, the event handler raises another event,
    // which the Main Form can see. After that, the Main Form raises another event
    // too, but this time for the ProjectManager to see

    /// <summary>
    /// Occurs when the `New File` button was clicked.
    /// </summary>
    [Browsable(true)]
    public event EventHandler? NewFileClick;

    /// <summary>
    /// Occurs when the `Open File` button was clicked.
    /// </summary>
    [Browsable(true)]
    public event EventHandler? OpenFileClick;

    /// <summary>
    /// Occurs when the `Help` button was clicked.
    /// </summary>
    [Browsable(true)]
    public event EventHandler? HelpClick;

    /// <summary>
    /// Initializes a new instance of the <see cref="StartMenuUserControl"/> class.
    /// </summary>
    public StartMenuUserControl()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Handles the click event for the `New File` button.
    /// </summary>
    private void StartMenuNewFileButton_Click(object sender, EventArgs e)
    {
        NewFileClick?.Invoke(sender, e);
    }

    /// <summary>
    /// Handles the click event for the `Open File` button.
    /// </summary>
    private void StartMenuOpenFileButton_Click(object sender, EventArgs e)
    {
        OpenFileClick?.Invoke(sender, e);
    }

    /// <summary>
    /// Handles the click event for the `Help File` button.
    /// </summary>
    private void StartMenuHelpButton_Click(object sender, EventArgs e)
    {
        HelpClick?.Invoke(sender, e);
    }
}
