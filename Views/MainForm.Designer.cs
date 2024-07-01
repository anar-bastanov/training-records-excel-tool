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
        MenuStrip stripMenu;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        ToolStripSeparator stripMenuSeparator2;
        ToolStripSeparator stripMenuSeparator1;
        StatusStrip stripStatus;
        ToolStripStatusLabel stripStatusCompanyName;
        _stripMenuFile = new ToolStripMenuItem();
        _stripMenuFileNew = new ToolStripMenuItem();
        _stripMenuFileOpen = new ToolStripMenuItem();
        _stripMenuFileClose = new ToolStripMenuItem();
        _stripMenuFileSave = new ToolStripMenuItem();
        _stripMenuFileSaveAs = new ToolStripMenuItem();
        _stripMenuFileSaveAsExcel = new ToolStripMenuItem();
        _stripMenuFileSaveAsJson = new ToolStripMenuItem();
        _stripMenuFileSaveAsXML = new ToolStripMenuItem();
        _stripMenuFileExit = new ToolStripMenuItem();
        _stripMenuHelp = new ToolStripMenuItem();
        _stripMenuLicense = new ToolStripMenuItem();
        stripMenu = new MenuStrip();
        stripMenuSeparator2 = new ToolStripSeparator();
        stripMenuSeparator1 = new ToolStripSeparator();
        stripStatus = new StatusStrip();
        stripStatusCompanyName = new ToolStripStatusLabel();
        stripMenu.SuspendLayout();
        stripStatus.SuspendLayout();
        SuspendLayout();
        // 
        // stripMenu
        // 
        stripMenu.ImageScalingSize = new Size(24, 24);
        stripMenu.Items.AddRange(new ToolStripItem[] { _stripMenuFile, _stripMenuHelp, _stripMenuLicense });
        stripMenu.Location = new Point(0, 0);
        stripMenu.Name = "stripMenu";
        stripMenu.Size = new Size(1278, 33);
        stripMenu.TabIndex = 0;
        // 
        // _stripMenuFile
        // 
        _stripMenuFile.DropDownItems.AddRange(new ToolStripItem[] { _stripMenuFileNew, _stripMenuFileOpen, _stripMenuFileClose, stripMenuSeparator2, _stripMenuFileSave, _stripMenuFileSaveAs, stripMenuSeparator1, _stripMenuFileExit });
        _stripMenuFile.Name = "_stripMenuFile";
        _stripMenuFile.Size = new Size(54, 29);
        _stripMenuFile.Text = "&File";
        // 
        // _stripMenuFileNew
        // 
        _stripMenuFileNew.Image = (Image)resources.GetObject("_stripMenuFileNew.Image");
        _stripMenuFileNew.Name = "_stripMenuFileNew";
        _stripMenuFileNew.ShortcutKeys = Keys.Control | Keys.N;
        _stripMenuFileNew.Size = new Size(267, 34);
        _stripMenuFileNew.Text = "&New";
        _stripMenuFileNew.Click += StripMenuFileNew_Click;
        // 
        // _stripMenuFileOpen
        // 
        _stripMenuFileOpen.Image = (Image)resources.GetObject("_stripMenuFileOpen.Image");
        _stripMenuFileOpen.Name = "_stripMenuFileOpen";
        _stripMenuFileOpen.ShortcutKeys = Keys.Control | Keys.O;
        _stripMenuFileOpen.Size = new Size(267, 34);
        _stripMenuFileOpen.Text = "&Open";
        _stripMenuFileOpen.Click += StripMenuFileOpen_Click;
        // 
        // _stripMenuFileClose
        // 
        _stripMenuFileClose.Enabled = false;
        _stripMenuFileClose.Image = (Image)resources.GetObject("_stripMenuFileClose.Image");
        _stripMenuFileClose.Name = "_stripMenuFileClose";
        _stripMenuFileClose.ShortcutKeys = Keys.Control | Keys.Shift | Keys.C;
        _stripMenuFileClose.Size = new Size(267, 34);
        _stripMenuFileClose.Text = "&Close";
        _stripMenuFileClose.Click += StripMenuFileClose_Click;
        // 
        // stripMenuSeparator2
        // 
        stripMenuSeparator2.Name = "stripMenuSeparator2";
        stripMenuSeparator2.Size = new Size(264, 6);
        // 
        // _stripMenuFileSave
        // 
        _stripMenuFileSave.Enabled = false;
        _stripMenuFileSave.Image = (Image)resources.GetObject("_stripMenuFileSave.Image");
        _stripMenuFileSave.Name = "_stripMenuFileSave";
        _stripMenuFileSave.ShortcutKeys = Keys.Control | Keys.S;
        _stripMenuFileSave.Size = new Size(267, 34);
        _stripMenuFileSave.Text = "&Save";
        _stripMenuFileSave.Click += StripMenuFileSave_Click;
        // 
        // _stripMenuFileSaveAs
        // 
        _stripMenuFileSaveAs.DropDownItems.AddRange(new ToolStripItem[] { _stripMenuFileSaveAsExcel, _stripMenuFileSaveAsJson, _stripMenuFileSaveAsXML });
        _stripMenuFileSaveAs.Enabled = false;
        _stripMenuFileSaveAs.Image = (Image)resources.GetObject("_stripMenuFileSaveAs.Image");
        _stripMenuFileSaveAs.Name = "_stripMenuFileSaveAs";
        _stripMenuFileSaveAs.Size = new Size(267, 34);
        _stripMenuFileSaveAs.Text = "Save &As";
        // 
        // _stripMenuFileSaveAsExcel
        // 
        _stripMenuFileSaveAsExcel.Name = "_stripMenuFileSaveAsExcel";
        _stripMenuFileSaveAsExcel.ShortcutKeys = Keys.Control | Keys.S;
        _stripMenuFileSaveAsExcel.Size = new Size(357, 34);
        _stripMenuFileSaveAsExcel.Text = "Excel Workbook (*.xlsx)";
        _stripMenuFileSaveAsExcel.Click += StripMenuFileSaveAsExcel_Click;
        // 
        // _stripMenuFileSaveAsJson
        // 
        _stripMenuFileSaveAsJson.Name = "_stripMenuFileSaveAsJson";
        _stripMenuFileSaveAsJson.Size = new Size(357, 34);
        _stripMenuFileSaveAsJson.Text = "JSON Format (*.json)";
        _stripMenuFileSaveAsJson.Click += StripMenuFileSaveAsJson_Click;
        // 
        // _stripMenuFileSaveAsXML
        // 
        _stripMenuFileSaveAsXML.Name = "_stripMenuFileSaveAsXML";
        _stripMenuFileSaveAsXML.Size = new Size(357, 34);
        _stripMenuFileSaveAsXML.Text = "XML (*.xml)";
        _stripMenuFileSaveAsXML.Click += StripMenuFileSaveAsXML_Click;
        // 
        // stripMenuSeparator1
        // 
        stripMenuSeparator1.Name = "stripMenuSeparator1";
        stripMenuSeparator1.Size = new Size(264, 6);
        // 
        // _stripMenuFileExit
        // 
        _stripMenuFileExit.Image = (Image)resources.GetObject("_stripMenuFileExit.Image");
        _stripMenuFileExit.Name = "_stripMenuFileExit";
        _stripMenuFileExit.ShortcutKeys = Keys.Alt | Keys.F4;
        _stripMenuFileExit.Size = new Size(267, 34);
        _stripMenuFileExit.Text = "&Exit";
        _stripMenuFileExit.Click += StripMenuFileExit_Click;
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
        // stripStatus
        // 
        stripStatus.ImageScalingSize = new Size(24, 24);
        stripStatus.Items.AddRange(new ToolStripItem[] { stripStatusCompanyName });
        stripStatus.Location = new Point(0, 808);
        stripStatus.Name = "stripStatus";
        stripStatus.Size = new Size(1278, 36);
        stripStatus.TabIndex = 0;
        // 
        // stripStatusCompanyName
        // 
        stripStatusCompanyName.BorderSides = ToolStripStatusLabelBorderSides.Right;
        stripStatusCompanyName.BorderStyle = Border3DStyle.Etched;
        stripStatusCompanyName.Name = "stripStatusCompanyName";
        stripStatusCompanyName.Size = new Size(246, 29);
        stripStatusCompanyName.Text = "Developed by Anar Bastanov";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(20F, 48F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1278, 844);
        Controls.Add(stripStatus);
        Controls.Add(stripMenu);
        Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MainMenuStrip = stripMenu;
        Margin = new Padding(6);
        MinimumSize = new Size(1300, 900);
        Name = "MainForm";
        Text = "Master Training Records";
        FormClosing += MainForm_FormClosing;
        stripMenu.ResumeLayout(false);
        stripMenu.PerformLayout();
        stripStatus.ResumeLayout(false);
        stripStatus.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ToolStripMenuItem _stripMenuFile;
    private ToolStripMenuItem _stripMenuFileNew;
    private ToolStripMenuItem _stripMenuFileOpen;
    private ToolStripMenuItem _stripMenuFileExit;
    private ToolStripMenuItem _stripMenuFileClose;
    private ToolStripMenuItem _stripMenuHelp;
    private ToolStripMenuItem _stripMenuLicense;
    private ToolStripMenuItem _stripMenuFileSaveAs;
    private ToolStripMenuItem _stripMenuFileSaveAsExcel;
    private ToolStripMenuItem _stripMenuFileSaveAsJson;
    private ToolStripMenuItem _stripMenuFileSaveAsXML;
    private ToolStripMenuItem _stripMenuFileSave;
    private ProjectEditorUserControl _projectEditor;
    private StartMenuUserControl _startMenu;
}
