namespace ExcelTool.Views;

partial class StartMenuButtonUserControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenuButtonUserControl));
        _buttonText = new Label();
        _buttonIcon = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)_buttonIcon).BeginInit();
        SuspendLayout();
        // 
        // _buttonText
        // 
        _buttonText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _buttonText.BackColor = SystemColors.ButtonHighlight;
        _buttonText.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _buttonText.Location = new Point(16, 135);
        _buttonText.Name = "_buttonText";
        _buttonText.Size = new Size(104, 34);
        _buttonText.TabIndex = 0;
        _buttonText.Text = "Button";
        _buttonText.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // _buttonIcon
        // 
        _buttonIcon.BackColor = SystemColors.ButtonHighlight;
        _buttonIcon.BackgroundImage = (Image)resources.GetObject("_buttonIcon.BackgroundImage");
        _buttonIcon.BackgroundImageLayout = ImageLayout.Zoom;
        _buttonIcon.Location = new Point(16, 16);
        _buttonIcon.Name = "_buttonIcon";
        _buttonIcon.Size = new Size(104, 104);
        _buttonIcon.TabIndex = 1;
        _buttonIcon.TabStop = false;
        // 
        // StartMenuButtonUserControl
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLight;
        BackgroundImageLayout = ImageLayout.Zoom;
        Controls.Add(_buttonIcon);
        Controls.Add(_buttonText);
        Cursor = Cursors.Hand;
        Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(6);
        MinimumSize = new Size(136, 183);
        Name = "StartMenuButtonUserControl";
        Size = new Size(136, 183);
        ((System.ComponentModel.ISupportInitialize)_buttonIcon).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label _buttonText;
    private PictureBox _buttonIcon;
}
