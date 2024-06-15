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
        _overlay = new Label();
        SuspendLayout();
        // 
        // _overlay
        // 
        _overlay.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _overlay.Location = new Point(10, 10);
        _overlay.MaximumSize = new Size(1200, 800);
        _overlay.Name = "_overlay";
        _overlay.Size = new Size(750, 475);
        _overlay.TabIndex = 1;
        _overlay.Text = resources.GetString("_overlay.Text");
        _overlay.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LicenseForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(768, 494);
        Controls.Add(_overlay);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MaximumSize = new Size(790, 550);
        MinimizeBox = false;
        MinimumSize = new Size(790, 550);
        Name = "LicenseForm";
        ShowIcon = false;
        Text = "License";
        ResumeLayout(false);
    }

    #endregion
    private Label _overlay;
}