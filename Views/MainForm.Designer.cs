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
        _menuStrip.SuspendLayout();
        SuspendLayout();
        // 
        // _menuStrip
        // 
        _menuStrip.ImageScalingSize = new Size(24, 24);
        _menuStrip.Items.AddRange(new ToolStripItem[] { _stripMenuFile, _stripMenuEdit, _stripMenuHelp });
        _menuStrip.Location = new Point(0, 0);
        _menuStrip.Name = "_menuStrip";
        _menuStrip.Size = new Size(1172, 33);
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
        // 
        // _stripMenuFileOpen
        // 
        _stripMenuFileOpen.Name = "_stripMenuFileOpen";
        _stripMenuFileOpen.Size = new Size(158, 34);
        _stripMenuFileOpen.Text = "&Open";
        // 
        // _stripMenuFileClose
        // 
        _stripMenuFileClose.Name = "_stripMenuFileClose";
        _stripMenuFileClose.Size = new Size(158, 34);
        _stripMenuFileClose.Text = "&Close";
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
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(20F, 48F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1172, 723);
        Controls.Add(_menuStrip);
        Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        MainMenuStrip = _menuStrip;
        Margin = new Padding(6);
        Name = "MainForm";
        Text = "Master Training Records";
        _menuStrip.ResumeLayout(false);
        _menuStrip.PerformLayout();
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
}
