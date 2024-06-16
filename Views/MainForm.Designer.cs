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
        toolStripSeparator2 = new ToolStripSeparator();
        _stripMenuFileSave = new ToolStripMenuItem();
        _stripMenuFileSaveAs = new ToolStripMenuItem();
        _stripMenuFileSaveAsExcel = new ToolStripMenuItem();
        _stripMenuFileSaveAsPDF = new ToolStripMenuItem();
        _stripMenuFileSaveAsJson = new ToolStripMenuItem();
        _stripMenuFileSaveAsCSV = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        _stripMenuFileExit = new ToolStripMenuItem();
        _stripMenuHelp = new ToolStripMenuItem();
        _stripMenuLicense = new ToolStripMenuItem();
        _stripStatus = new StatusStrip();
        _stripStatusWatermark = new ToolStripStatusLabel();
        _projectEditor = new ProjectEditor();
        _startMenu = new StartMenu();
        _menuStrip.SuspendLayout();
        _stripStatus.SuspendLayout();
        SuspendLayout();
        // 
        // _menuStrip
        // 
        _menuStrip.ImageScalingSize = new Size(24, 24);
        _menuStrip.Items.AddRange(new ToolStripItem[] { _stripMenuFile, _stripMenuHelp, _stripMenuLicense });
        _menuStrip.Location = new Point(0, 0);
        _menuStrip.Name = "_menuStrip";
        _menuStrip.Size = new Size(1178, 33);
        _menuStrip.TabIndex = 0;
        _menuStrip.Text = "menuStrip1";
        // 
        // _stripMenuFile
        // 
        _stripMenuFile.DropDownItems.AddRange(new ToolStripItem[] { _stripMenuFileNew, _stripMenuFileOpen, _stripMenuFileClose, toolStripSeparator2, _stripMenuFileSave, _stripMenuFileSaveAs, toolStripSeparator1, _stripMenuFileExit });
        _stripMenuFile.Name = "_stripMenuFile";
        _stripMenuFile.Size = new Size(54, 29);
        _stripMenuFile.Text = "&File";
        // 
        // _stripMenuFileNew
        // 
        _stripMenuFileNew.Image = (Image)resources.GetObject("_stripMenuFileNew.Image");
        _stripMenuFileNew.Name = "_stripMenuFileNew";
        _stripMenuFileNew.ShortcutKeys = Keys.Control | Keys.N;
        _stripMenuFileNew.Size = new Size(270, 34);
        _stripMenuFileNew.Text = "&New";
        _stripMenuFileNew.Click += StripMenuFileNew_Click;
        // 
        // _stripMenuFileOpen
        // 
        _stripMenuFileOpen.Image = (Image)resources.GetObject("_stripMenuFileOpen.Image");
        _stripMenuFileOpen.Name = "_stripMenuFileOpen";
        _stripMenuFileOpen.ShortcutKeys = Keys.Control | Keys.O;
        _stripMenuFileOpen.Size = new Size(270, 34);
        _stripMenuFileOpen.Text = "&Open";
        _stripMenuFileOpen.Click += StripMenuFileOpen_Click;
        // 
        // _stripMenuFileClose
        // 
        _stripMenuFileClose.Enabled = false;
        _stripMenuFileClose.Image = (Image)resources.GetObject("_stripMenuFileClose.Image");
        _stripMenuFileClose.Name = "_stripMenuFileClose";
        _stripMenuFileClose.ShortcutKeys = Keys.Control | Keys.C;
        _stripMenuFileClose.Size = new Size(270, 34);
        _stripMenuFileClose.Text = "&Close";
        _stripMenuFileClose.Click += StripMenuFileClose_Click;
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new Size(267, 6);
        // 
        // _stripMenuFileSave
        // 
        _stripMenuFileSave.Enabled = false;
        _stripMenuFileSave.Image = (Image)resources.GetObject("_stripMenuFileSave.Image");
        _stripMenuFileSave.Name = "_stripMenuFileSave";
        _stripMenuFileSave.ShortcutKeys = Keys.Control | Keys.S;
        _stripMenuFileSave.Size = new Size(270, 34);
        _stripMenuFileSave.Text = "&Save";
        // 
        // _stripMenuFileSaveAs
        // 
        _stripMenuFileSaveAs.DropDownItems.AddRange(new ToolStripItem[] { _stripMenuFileSaveAsExcel, _stripMenuFileSaveAsPDF, _stripMenuFileSaveAsJson, _stripMenuFileSaveAsCSV });
        _stripMenuFileSaveAs.Enabled = false;
        _stripMenuFileSaveAs.Image = (Image)resources.GetObject("_stripMenuFileSaveAs.Image");
        _stripMenuFileSaveAs.Name = "_stripMenuFileSaveAs";
        _stripMenuFileSaveAs.Size = new Size(270, 34);
        _stripMenuFileSaveAs.Text = "Save &As";
        // 
        // _stripMenuFileSaveAsExcel
        // 
        _stripMenuFileSaveAsExcel.Name = "_stripMenuFileSaveAsExcel";
        _stripMenuFileSaveAsExcel.Size = new Size(355, 34);
        _stripMenuFileSaveAsExcel.Text = "Excel Workbook (*.xlsx)";
        // 
        // _stripMenuFileSaveAsPDF
        // 
        _stripMenuFileSaveAsPDF.Name = "_stripMenuFileSaveAsPDF";
        _stripMenuFileSaveAsPDF.Size = new Size(355, 34);
        _stripMenuFileSaveAsPDF.Text = "PDF (*.pdf)";
        // 
        // _stripMenuFileSaveAsJson
        // 
        _stripMenuFileSaveAsJson.Name = "_stripMenuFileSaveAsJson";
        _stripMenuFileSaveAsJson.Size = new Size(355, 34);
        _stripMenuFileSaveAsJson.Text = "JSON Format (*.json)";
        // 
        // _stripMenuFileSaveAsCSV
        // 
        _stripMenuFileSaveAsCSV.Name = "_stripMenuFileSaveAsCSV";
        _stripMenuFileSaveAsCSV.Size = new Size(355, 34);
        _stripMenuFileSaveAsCSV.Text = "CSV (Comma delimited) (*.csv)";
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(267, 6);
        // 
        // _stripMenuFileExit
        // 
        _stripMenuFileExit.Image = (Image)resources.GetObject("_stripMenuFileExit.Image");
        _stripMenuFileExit.Name = "_stripMenuFileExit";
        _stripMenuFileExit.ShortcutKeys = Keys.Alt | Keys.F4;
        _stripMenuFileExit.Size = new Size(270, 34);
        _stripMenuFileExit.Text = "&Exit";
        _stripMenuFileExit.Click += StripMenuFileExit_Click;
        // 
        // _stripMenuHelp
        // 
        _stripMenuHelp.Name = "_stripMenuHelp";
        _stripMenuHelp.ShortcutKeys = Keys.Control | Keys.H;
        _stripMenuHelp.Size = new Size(65, 29);
        _stripMenuHelp.Text = "&Help";
        _stripMenuHelp.Click += StripMenuHelp_Click;
        // 
        // _stripMenuLicense
        // 
        _stripMenuLicense.Name = "_stripMenuLicense";
        _stripMenuLicense.ShortcutKeys = Keys.Control | Keys.L;
        _stripMenuLicense.Size = new Size(84, 29);
        _stripMenuLicense.Text = "&License";
        _stripMenuLicense.Click += StripMenuLicense_Click;
        // 
        // _stripStatus
        // 
        _stripStatus.ImageScalingSize = new Size(24, 24);
        _stripStatus.Items.AddRange(new ToolStripItem[] { _stripStatusWatermark });
        _stripStatus.Location = new Point(0, 708);
        _stripStatus.Name = "_stripStatus";
        _stripStatus.Size = new Size(1178, 36);
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
        // _projectEditor
        // 
        _projectEditor.Dock = DockStyle.Fill;
        _projectEditor.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _projectEditor.Location = new Point(0, 0);
        _projectEditor.Margin = new Padding(0);
        _projectEditor.Name = "_projectEditor";
        _projectEditor.Size = new Size(1178, 744);
        _projectEditor.TabIndex = 6;
        // 
        // _startMenu
        // 
        _startMenu.Dock = DockStyle.Fill;
        _startMenu.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _startMenu.Location = new Point(0, 0);
        _startMenu.Margin = new Padding(5);
        _startMenu.Name = "_startMenu";
        _startMenu.Size = new Size(1178, 744);
        _startMenu.TabIndex = 7;
        _startMenu.NewFileClick += StartMenu_NewFileClick;
        _startMenu.OpenFileClick += StartMenu_OpenFileClick;
        _startMenu.HelpClick += StartMenu_HelpClick;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(20F, 48F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1178, 744);
        Controls.Add(_stripStatus);
        Controls.Add(_menuStrip);
        Controls.Add(_startMenu);
        Controls.Add(_projectEditor);
        Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        MainMenuStrip = _menuStrip;
        Margin = new Padding(6);
        MinimumSize = new Size(1200, 800);
        Name = "MainForm";
        Text = "Master Training Records";
        _menuStrip.ResumeLayout(false);
        _menuStrip.PerformLayout();
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
    private ToolStripMenuItem _stripMenuHelp;
    private StatusStrip _stripStatus;
    private ToolStripStatusLabel _stripStatusWatermark;
    private ToolStripMenuItem _stripMenuLicense;
    private ToolStripMenuItem _stripMenuFileSaveAs;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem _stripMenuFileSaveAsExcel;
    private ToolStripMenuItem _stripMenuFileSaveAsJson;
    private ToolStripMenuItem _stripMenuFileSaveAsCSV;
    private ToolStripMenuItem _stripMenuFileSaveAsPDF;
    private ToolStripMenuItem _stripMenuFileSave;
    private ProjectEditor _projectEditor;
    private StartMenu _startMenu;
}
