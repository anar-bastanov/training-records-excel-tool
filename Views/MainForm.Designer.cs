namespace ExcelTool.Views;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        _menuStrip = new MenuStrip();
        _stripMenuFile = new ToolStripMenuItem();
        _stripMenuFileNew = new ToolStripMenuItem();
        _stripMenuFileOpen = new ToolStripMenuItem();
        _stripMenuFileClose = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        _stripMenuFileExit = new ToolStripMenuItem();
        _stripMenuEdit = new ToolStripMenuItem();
        _stripMenuEditConfigure = new ToolStripMenuItem();
        _stripMenuEditHistory = new ToolStripMenuItem();
        _stripMenuHelp = new ToolStripMenuItem();
        _stripMenuLicense = new ToolStripMenuItem();
        _startMenuNewButton = new StartMenuButton();
        _startMenuOpenButton = new StartMenuButton();
        _startMenuHelpButton = new StartMenuButton();
        _azercosmosLogo = new PictureBox();
        _stripStatus = new StatusStrip();
        _stripStatusWatermark = new ToolStripStatusLabel();
        _stripStatusProgramState = new ToolStripStatusLabel();
        _menuStrip.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_azercosmosLogo).BeginInit();
        _stripStatus.SuspendLayout();
        SuspendLayout();
        // 
        // _menuStrip
        // 
        _menuStrip.ImageScalingSize = new Size(24, 24);
        _menuStrip.Items.AddRange(new ToolStripItem[] { _stripMenuFile, _stripMenuEdit, _stripMenuHelp, _stripMenuLicense });
        _menuStrip.Location = new Point(0, 0);
        _menuStrip.Name = "_menuStrip";
        _menuStrip.Size = new Size(1184, 33);
        _menuStrip.TabIndex = 0;
        _menuStrip.Text = "menuStrip1";
        // 
        // _stripMenuFile
        // 
        _stripMenuFile.DropDownItems.AddRange(new ToolStripItem[] { _stripMenuFileNew, _stripMenuFileOpen, _stripMenuFileClose, toolStripSeparator1, _stripMenuFileExit });
        _stripMenuFile.Name = "_stripMenuFile";
        _stripMenuFile.Size = new Size(54, 29);
        _stripMenuFile.Text = "&File";
        // 
        // _stripMenuFileNew
        // 
        _stripMenuFileNew.Name = "_stripMenuFileNew";
        _stripMenuFileNew.Size = new Size(158, 34);
        _stripMenuFileNew.Text = "&New";
        _stripMenuFileNew.Click += StripMenuFileNew_Click;
        // 
        // _stripMenuFileOpen
        // 
        _stripMenuFileOpen.Name = "_stripMenuFileOpen";
        _stripMenuFileOpen.Size = new Size(158, 34);
        _stripMenuFileOpen.Text = "&Open";
        _stripMenuFileOpen.Click += StripMenuFileOpen_Click;
        // 
        // _stripMenuFileClose
        // 
        _stripMenuFileClose.Name = "_stripMenuFileClose";
        _stripMenuFileClose.Size = new Size(158, 34);
        _stripMenuFileClose.Text = "&Close";
        _stripMenuFileClose.Click += StripMenuFileClose_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(155, 6);
        // 
        // _stripMenuFileExit
        // 
        _stripMenuFileExit.Name = "_stripMenuFileExit";
        _stripMenuFileExit.Size = new Size(158, 34);
        _stripMenuFileExit.Text = "&Exit";
        _stripMenuFileExit.Click += StripMenuFileExit_Click;
        // 
        // _stripMenuEdit
        // 
        _stripMenuEdit.DropDownItems.AddRange(new ToolStripItem[] { _stripMenuEditConfigure, _stripMenuEditHistory });
        _stripMenuEdit.Name = "_stripMenuEdit";
        _stripMenuEdit.Size = new Size(58, 29);
        _stripMenuEdit.Text = "&Edit";
        // 
        // _stripMenuEditConfigure
        // 
        _stripMenuEditConfigure.Name = "_stripMenuEditConfigure";
        _stripMenuEditConfigure.Size = new Size(270, 34);
        _stripMenuEditConfigure.Text = "&Configure";
        // 
        // _stripMenuEditHistory
        // 
        _stripMenuEditHistory.Name = "_stripMenuEditHistory";
        _stripMenuEditHistory.Size = new Size(270, 34);
        _stripMenuEditHistory.Text = "&History";
        // 
        // _stripMenuHelp
        // 
        _stripMenuHelp.Name = "_stripMenuHelp";
        _stripMenuHelp.Size = new Size(65, 29);
        _stripMenuHelp.Text = "&Help";
        _stripMenuHelp.Click += StripMenuHelp_Click;
        // 
        // _stripMenuLicense
        // 
        _stripMenuLicense.Name = "_stripMenuLicense";
        _stripMenuLicense.Size = new Size(84, 29);
        _stripMenuLicense.Text = "&License";
        _stripMenuLicense.Click += StripMenuLicense_Click;
        // 
        // _startMenuNewButton
        // 
        _startMenuNewButton.Anchor = AnchorStyles.None;
        _startMenuNewButton.BackColor = SystemColors.ControlLight;
        _startMenuNewButton.BackgroundImageLayout = ImageLayout.Zoom;
        _startMenuNewButton.ButtonIcon = (Image)resources.GetObject("_startMenuNewButton.ButtonIcon");
        _startMenuNewButton.ButtonText = "New";
        _startMenuNewButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _startMenuNewButton.Location = new Point(253, 295);
        _startMenuNewButton.Margin = new Padding(6);
        _startMenuNewButton.MinimumSize = new Size(200, 275);
        _startMenuNewButton.Name = "_startMenuNewButton";
        _startMenuNewButton.Size = new Size(200, 275);
        _startMenuNewButton.TabIndex = 1;
        _startMenuNewButton.Click += StartMenuNewButton_Click;
        // 
        // _startMenuOpenButton
        // 
        _startMenuOpenButton.Anchor = AnchorStyles.None;
        _startMenuOpenButton.BackColor = SystemColors.ControlLight;
        _startMenuOpenButton.BackgroundImageLayout = ImageLayout.Zoom;
        _startMenuOpenButton.ButtonIcon = (Image)resources.GetObject("_startMenuOpenButton.ButtonIcon");
        _startMenuOpenButton.ButtonText = "Open";
        _startMenuOpenButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _startMenuOpenButton.Location = new Point(503, 295);
        _startMenuOpenButton.Margin = new Padding(6);
        _startMenuOpenButton.MinimumSize = new Size(200, 275);
        _startMenuOpenButton.Name = "_startMenuOpenButton";
        _startMenuOpenButton.Size = new Size(200, 275);
        _startMenuOpenButton.TabIndex = 2;
        _startMenuOpenButton.Click += StartMenuOpenButton_Click;
        // 
        // _startMenuHelpButton
        // 
        _startMenuHelpButton.Anchor = AnchorStyles.None;
        _startMenuHelpButton.BackColor = SystemColors.ControlLight;
        _startMenuHelpButton.BackgroundImageLayout = ImageLayout.Zoom;
        _startMenuHelpButton.ButtonIcon = (Image)resources.GetObject("_startMenuHelpButton.ButtonIcon");
        _startMenuHelpButton.ButtonText = "Help";
        _startMenuHelpButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _startMenuHelpButton.Location = new Point(753, 295);
        _startMenuHelpButton.Margin = new Padding(6);
        _startMenuHelpButton.MinimumSize = new Size(200, 275);
        _startMenuHelpButton.Name = "_startMenuHelpButton";
        _startMenuHelpButton.Size = new Size(200, 275);
        _startMenuHelpButton.TabIndex = 3;
        // 
        // _azercosmosLogo
        // 
        _azercosmosLogo.Anchor = AnchorStyles.None;
        _azercosmosLogo.BackgroundImage = (Image)resources.GetObject("_azercosmosLogo.BackgroundImage");
        _azercosmosLogo.BackgroundImageLayout = ImageLayout.Zoom;
        _azercosmosLogo.Location = new Point(403, 145);
        _azercosmosLogo.Margin = new Padding(0);
        _azercosmosLogo.Name = "_azercosmosLogo";
        _azercosmosLogo.Size = new Size(400, 100);
        _azercosmosLogo.TabIndex = 4;
        _azercosmosLogo.TabStop = false;
        // 
        // _stripStatus
        // 
        _stripStatus.ImageScalingSize = new Size(24, 24);
        _stripStatus.Items.AddRange(new ToolStripItem[] { _stripStatusWatermark, _stripStatusProgramState });
        _stripStatus.Location = new Point(0, 725);
        _stripStatus.Name = "_stripStatus";
        _stripStatus.Size = new Size(1184, 36);
        _stripStatus.TabIndex = 5;
        _stripStatus.Text = "statusStrip1";
        // 
        // _stripStatusWatermark
        // 
        _stripStatusWatermark.BorderSides = ToolStripStatusLabelBorderSides.Right;
        _stripStatusWatermark.BorderStyle = Border3DStyle.Etched;
        _stripStatusWatermark.Name = "_stripStatusWatermark";
        _stripStatusWatermark.Size = new Size(167, 29);
        _stripStatusWatermark.Text = "Powered by Silisoft";
        // 
        // _stripStatusProgramState
        // 
        _stripStatusProgramState.Name = "_stripStatusProgramState";
        _stripStatusProgramState.Size = new Size(29, 29);
        _stripStatusProgramState.Text = "Hi";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(20F, 48F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1184, 761);
        Controls.Add(_stripStatus);
        Controls.Add(_azercosmosLogo);
        Controls.Add(_startMenuHelpButton);
        Controls.Add(_startMenuOpenButton);
        Controls.Add(_startMenuNewButton);
        Controls.Add(_menuStrip);
        Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        MainMenuStrip = _menuStrip;
        Margin = new Padding(6);
        Name = "MainForm";
        Text = "Master Training Records";
        _menuStrip.ResumeLayout(false);
        _menuStrip.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)_azercosmosLogo).EndInit();
        _stripStatus.ResumeLayout(false);
        _stripStatus.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip _menuStrip;
    private ToolStripMenuItem _stripMenuFile;
    private ToolStripMenuItem _stripMenuFileNew;
    private ToolStripMenuItem _stripMenuFileOpen;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem _stripMenuFileExit;
    private ToolStripMenuItem _stripMenuFileClose;
    private ToolStripMenuItem _stripMenuEdit;
    private ToolStripMenuItem _stripMenuEditConfigure;
    private ToolStripMenuItem _stripMenuEditHistory;
    private ToolStripMenuItem _stripMenuHelp;
    private StartMenuButton _startMenuNewButton;
    private StartMenuButton _startMenuOpenButton;
    private StartMenuButton _startMenuHelpButton;
    private PictureBox _azercosmosLogo;
    private StatusStrip _stripStatus;
    private ToolStripStatusLabel _stripStatusProgramState;
    private ToolStripStatusLabel _stripStatusWatermark;
    private ToolStripMenuItem _stripMenuLicense;
}
