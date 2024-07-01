using System;

namespace ExcelTool.Views;

/// <summary>
/// Represents a window to display the full license of the application.
/// </summary>
public partial class LicenseForm : Form
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LicenseForm"/> class.
    /// </summary>
    public LicenseForm()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Invoked when the `OK` button at the bottom of the form is clicked.
    /// Closes the form once the user is done reading the license.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    private void AcknowledgeButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}
