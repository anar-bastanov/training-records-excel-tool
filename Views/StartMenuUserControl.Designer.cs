﻿namespace ExcelTool.Views;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenuUserControl));
        _azercosmosLogo = new PictureBox();
        _startMenuHelpButton = new StartMenuButtonUserControl();
        _startMenuOpenButton = new StartMenuButtonUserControl();
        _startMenuNewButton = new StartMenuButtonUserControl();
        ((System.ComponentModel.ISupportInitialize)_azercosmosLogo).BeginInit();
        SuspendLayout();
        // 
        // _azercosmosLogo
        // 
        _azercosmosLogo.Anchor = AnchorStyles.None;
        _azercosmosLogo.BackgroundImage = (Image)resources.GetObject("_azercosmosLogo.BackgroundImage");
        _azercosmosLogo.BackgroundImageLayout = ImageLayout.Zoom;
        _azercosmosLogo.Location = new Point(450, 238);
        _azercosmosLogo.Margin = new Padding(0);
        _azercosmosLogo.Name = "_azercosmosLogo";
        _azercosmosLogo.Size = new Size(400, 100);
        _azercosmosLogo.TabIndex = 8;
        _azercosmosLogo.TabStop = false;
        // 
        // _startMenuHelpButton
        // 
        _startMenuHelpButton.Anchor = AnchorStyles.None;
        _startMenuHelpButton.BackColor = SystemColors.ControlLight;
        _startMenuHelpButton.BackgroundImageLayout = ImageLayout.Zoom;
        _startMenuHelpButton.ButtonIcon = (Image)resources.GetObject("_startMenuHelpButton.ButtonIcon");
        _startMenuHelpButton.ButtonText = "Help";
        _startMenuHelpButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _startMenuHelpButton.Location = new Point(800, 388);
        _startMenuHelpButton.Margin = new Padding(6);
        _startMenuHelpButton.MinimumSize = new Size(200, 275);
        _startMenuHelpButton.Name = "_startMenuHelpButton";
        _startMenuHelpButton.Size = new Size(200, 275);
        _startMenuHelpButton.TabIndex = 7;
        _startMenuHelpButton.Click += StartMenuHelpButton_Click;
        // 
        // _startMenuOpenButton
        // 
        _startMenuOpenButton.Anchor = AnchorStyles.None;
        _startMenuOpenButton.BackColor = SystemColors.ControlLight;
        _startMenuOpenButton.BackgroundImageLayout = ImageLayout.Zoom;
        _startMenuOpenButton.ButtonIcon = (Image)resources.GetObject("_startMenuOpenButton.ButtonIcon");
        _startMenuOpenButton.ButtonText = "Open";
        _startMenuOpenButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _startMenuOpenButton.Location = new Point(550, 388);
        _startMenuOpenButton.Margin = new Padding(6);
        _startMenuOpenButton.MinimumSize = new Size(200, 275);
        _startMenuOpenButton.Name = "_startMenuOpenButton";
        _startMenuOpenButton.Size = new Size(200, 275);
        _startMenuOpenButton.TabIndex = 6;
        _startMenuOpenButton.Click += StartMenuOpenFileButton_Click;
        // 
        // _startMenuNewButton
        // 
        _startMenuNewButton.Anchor = AnchorStyles.None;
        _startMenuNewButton.BackColor = SystemColors.ControlLight;
        _startMenuNewButton.BackgroundImageLayout = ImageLayout.Zoom;
        _startMenuNewButton.ButtonIcon = (Image)resources.GetObject("_startMenuNewButton.ButtonIcon");
        _startMenuNewButton.ButtonText = "New";
        _startMenuNewButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _startMenuNewButton.Location = new Point(300, 388);
        _startMenuNewButton.Margin = new Padding(6);
        _startMenuNewButton.MinimumSize = new Size(200, 275);
        _startMenuNewButton.Name = "_startMenuNewButton";
        _startMenuNewButton.Size = new Size(200, 275);
        _startMenuNewButton.TabIndex = 5;
        _startMenuNewButton.Click += StartMenuNewFileButton_Click;
        // 
        // StartMenuUserControl
        // 
        AutoScaleDimensions = new SizeF(17F, 43F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(_azercosmosLogo);
        Controls.Add(_startMenuHelpButton);
        Controls.Add(_startMenuOpenButton);
        Controls.Add(_startMenuNewButton);
        Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(5);
        Name = "StartMenuUserControl";
        Size = new Size(1300, 900);
        ((System.ComponentModel.ISupportInitialize)_azercosmosLogo).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private PictureBox _azercosmosLogo;
    private StartMenuButtonUserControl _startMenuHelpButton;
    private StartMenuButtonUserControl _startMenuOpenButton;
    private StartMenuButtonUserControl _startMenuNewButton;
}
