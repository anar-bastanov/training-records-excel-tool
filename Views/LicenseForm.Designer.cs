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
        licenseLabel.Location = new Point(10, 10);
        licenseLabel.MaximumSize = new Size(1200, 800);
        licenseLabel.Name = "licenseLabel";
        licenseLabel.Size = new Size(750, 475);
        licenseLabel.TabIndex = 1;
        licenseLabel.Text = resources.GetString("licenseLabel.Text");
        licenseLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // acknowledgeButton
        // 
        acknowledgeButton.Location = new Point(340, 505);
        acknowledgeButton.Name = "acknowledgeButton";
        acknowledgeButton.Size = new Size(90, 34);
        acknowledgeButton.TabIndex = 2;
        acknowledgeButton.Text = "OK";
        acknowledgeButton.UseVisualStyleBackColor = true;
        acknowledgeButton.Click += AcknowledgeButton_Click;
        // 
        // LicenseForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = acknowledgeButton;
        ClientSize = new Size(768, 554);
        Controls.Add(acknowledgeButton);
        Controls.Add(licenseLabel);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "LicenseForm";
        ShowIcon = false;
        Text = "License";
        ResumeLayout(false);
    }

    #endregion
}