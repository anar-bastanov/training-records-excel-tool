﻿using System;
using System.ComponentModel;

namespace ExcelTool.Views;

public partial class StartMenu : UserControl
{
    [Browsable(true)]
    public event EventHandler? NewFileClick;

    [Browsable(true)]
    public event EventHandler? OpenFileClick;

    [Browsable(true)]
    public event EventHandler? HelpClick;

    public StartMenu()
    {
        InitializeComponent();
    }

    private void StartMenuNewFileButton_Click(object sender, EventArgs e)
    {
        NewFileClick?.Invoke(this, e);
    }

    private void StartMenuOpenFileButton_Click(object sender, EventArgs e)
    {
        OpenFileClick?.Invoke(this, e);
    }

    private void StartMenuHelpButton_Click(object sender, EventArgs e)
    {
        HelpClick?.Invoke(this, e);
    }
}
