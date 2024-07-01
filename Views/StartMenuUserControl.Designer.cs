namespace ExcelTool.Views;

partial class StartMenuUserControl
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
        PictureBox azercosmosLogo;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenuUserControl));
        StartMenuButtonUserControl startMenuHelpButton;
        StartMenuButtonUserControl startMenuOpenButton;
        StartMenuButtonUserControl startMenuNewButton;
        azercosmosLogo = new PictureBox();
        startMenuHelpButton = new StartMenuButtonUserControl();
        startMenuOpenButton = new StartMenuButtonUserControl();
        startMenuNewButton = new StartMenuButtonUserControl();
        ((System.ComponentModel.ISupportInitialize)azercosmosLogo).BeginInit();
        SuspendLayout();
        // 
        // azercosmosLogo
        // 
        azercosmosLogo.Anchor = AnchorStyles.None;
        azercosmosLogo.BackgroundImage = (Image)resources.GetObject("azercosmosLogo.BackgroundImage");
        azercosmosLogo.BackgroundImageLayout = ImageLayout.Zoom;
        azercosmosLogo.Location = new Point(302, 150);
        azercosmosLogo.Margin = new Padding(0);
        azercosmosLogo.Name = "azercosmosLogo";
        azercosmosLogo.Size = new Size(266, 66);
        azercosmosLogo.TabIndex = 8;
        azercosmosLogo.TabStop = false;
        // 
        // startMenuHelpButton
        // 
        startMenuHelpButton.Anchor = AnchorStyles.None;
        startMenuHelpButton.BackColor = SystemColors.ControlLight;
        startMenuHelpButton.BackgroundImageLayout = ImageLayout.Zoom;
        startMenuHelpButton.ButtonIcon = (Image)resources.GetObject("startMenuHelpButton.ButtonIcon");
        startMenuHelpButton.ButtonText = "Help";
        startMenuHelpButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        startMenuHelpButton.Location = new Point(535, 250);
        startMenuHelpButton.Margin = new Padding(6);
        startMenuHelpButton.MinimumSize = new Size(136, 183);
        startMenuHelpButton.Name = "startMenuHelpButton";
        startMenuHelpButton.Size = new Size(136, 183);
        startMenuHelpButton.TabIndex = 0;
        startMenuHelpButton.TabStop = false;
        startMenuHelpButton.Click += StartMenuHelpButton_Click;
        // 
        // startMenuOpenButton
        // 
        startMenuOpenButton.Anchor = AnchorStyles.None;
        startMenuOpenButton.BackColor = SystemColors.ControlLight;
        startMenuOpenButton.BackgroundImageLayout = ImageLayout.Zoom;
        startMenuOpenButton.ButtonIcon = (Image)resources.GetObject("startMenuOpenButton.ButtonIcon");
        startMenuOpenButton.ButtonText = "Open";
        startMenuOpenButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        startMenuOpenButton.Location = new Point(367, 250);
        startMenuOpenButton.Margin = new Padding(6);
        startMenuOpenButton.MinimumSize = new Size(136, 183);
        startMenuOpenButton.Name = "startMenuOpenButton";
        startMenuOpenButton.Size = new Size(136, 183);
        startMenuOpenButton.TabIndex = 0;
        startMenuOpenButton.TabStop = false;
        startMenuOpenButton.Click += StartMenuOpenFileButton_Click;
        // 
        // startMenuNewButton
        // 
        startMenuNewButton.Anchor = AnchorStyles.None;
        startMenuNewButton.BackColor = SystemColors.ControlLight;
        startMenuNewButton.BackgroundImageLayout = ImageLayout.Zoom;
        startMenuNewButton.ButtonIcon = (Image)resources.GetObject("startMenuNewButton.ButtonIcon");
        startMenuNewButton.ButtonText = "New";
        startMenuNewButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        startMenuNewButton.Location = new Point(199, 250);
        startMenuNewButton.Margin = new Padding(6);
        startMenuNewButton.MinimumSize = new Size(136, 183);
        startMenuNewButton.Name = "startMenuNewButton";
        startMenuNewButton.Size = new Size(136, 183);
        startMenuNewButton.TabIndex = 0;
        startMenuNewButton.TabStop = false;
        startMenuNewButton.Click += StartMenuNewFileButton_Click;
        // 
        // StartMenuUserControl
        // 
        AutoScaleDimensions = new SizeF(11F, 29F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(azercosmosLogo);
        Controls.Add(startMenuHelpButton);
        Controls.Add(startMenuOpenButton);
        Controls.Add(startMenuNewButton);
        Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(5);
        Name = "StartMenuUserControl";
        Size = new Size(870, 600);
        ((System.ComponentModel.ISupportInitialize)azercosmosLogo).EndInit();
        ResumeLayout(false);
    }

    #endregion
}
