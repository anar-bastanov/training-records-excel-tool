namespace ExcelTool.Views;

partial class LicenseForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseForm));
        _mitLicense = new TextBox();
        SuspendLayout();
        // 
        // _mitLicense
        // 
        _mitLicense.BorderStyle = BorderStyle.None;
        _mitLicense.CausesValidation = false;
        _mitLicense.Enabled = false;
        _mitLicense.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _mitLicense.ImeMode = ImeMode.On;
        _mitLicense.Location = new Point(10, 10);
        _mitLicense.Margin = new Padding(0);
        _mitLicense.Multiline = true;
        _mitLicense.Name = "_mitLicense";
        _mitLicense.ReadOnly = true;
        _mitLicense.Size = new Size(750, 475);
        _mitLicense.TabIndex = 0;
        _mitLicense.TabStop = false;
        _mitLicense.Text = resources.GetString("_mitLicense.Text");
        _mitLicense.TextAlign = HorizontalAlignment.Center;
        // 
        // LicenseForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(768, 494);
        Controls.Add(_mitLicense);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MaximumSize = new Size(790, 550);
        MinimizeBox = false;
        MinimumSize = new Size(790, 550);
        Name = "LicenseForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "License";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox _mitLicense;
}