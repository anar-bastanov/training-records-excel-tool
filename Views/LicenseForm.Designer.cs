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
        _acknowledgeButton = new Button();
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
        // _acknowledgeButton
        // 
        _acknowledgeButton.Location = new Point(340, 505);
        _acknowledgeButton.Name = "_acknowledgeButton";
        _acknowledgeButton.Size = new Size(90, 34);
        _acknowledgeButton.TabIndex = 2;
        _acknowledgeButton.Text = "OK";
        _acknowledgeButton.UseVisualStyleBackColor = true;
        _acknowledgeButton.Click += AcknowledgeButton_Click;
        // 
        // LicenseForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = _acknowledgeButton;
        ClientSize = new Size(768, 554);
        Controls.Add(_acknowledgeButton);
        Controls.Add(_overlay);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "LicenseForm";
        ShowIcon = false;
        Text = "License";
        ResumeLayout(false);
    }

    #endregion
    private Label _overlay;
    private Button _acknowledgeButton;
}