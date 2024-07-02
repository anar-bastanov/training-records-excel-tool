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
        Label licenseLabel;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseForm));
        Button acknowledgeButton;
        licenseLabel = new Label();
        acknowledgeButton = new Button();
        SuspendLayout();
        // 
        // licenseLabel
        // 
        licenseLabel.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        licenseLabel.Location = new Point(7, 6);
        licenseLabel.Margin = new Padding(2, 0, 2, 0);
        licenseLabel.Name = "licenseLabel";
        licenseLabel.Size = new Size(525, 300);
        licenseLabel.TabIndex = 1;
        licenseLabel.Text = resources.GetString("licenseLabel.Text");
        licenseLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // acknowledgeButton
        // 
        acknowledgeButton.Location = new Point(237, 316);
        acknowledgeButton.Margin = new Padding(2);
        acknowledgeButton.Name = "acknowledgeButton";
        acknowledgeButton.Size = new Size(63, 20);
        acknowledgeButton.TabIndex = 2;
        acknowledgeButton.Text = "OK";
        acknowledgeButton.UseVisualStyleBackColor = true;
        acknowledgeButton.Click += AcknowledgeButton_Click;
        // 
        // LicenseForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = acknowledgeButton;
        ClientSize = new Size(538, 347);
        Controls.Add(acknowledgeButton);
        Controls.Add(licenseLabel);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(2);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "LicenseForm";
        ShowIcon = false;
        Text = "License";
        ResumeLayout(false);
    }

    #endregion
}