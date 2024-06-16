using System;

namespace ExcelTool.Views;

public partial class LicenseForm : Form
{
    public LicenseForm()
    {
        InitializeComponent();
    }

    private void AcknowledgeButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}
