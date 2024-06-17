namespace ExcelTool.Views;

partial class ProjectEditorUserControl
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
        TableLayoutPanel headerTableLayout;
        _traineeLabel = new Label();
        _positionTextBox = new TextBox();
        _managerTextBox = new TextBox();
        _courseLabel = new Label();
        _courseTextBox = new TextBox();
        _positionLabel = new Label();
        _managerLabel = new Label();
        _traineeTextBox = new TextBox();
        _taskDatabaseLabel = new Label();
        _selectDatabaseButton = new Button();
        _taskDatabasePathTextBox = new TextBox();
        _copyPathToDatabaseButton = new Button();
        headerTableLayout = new TableLayoutPanel();
        headerTableLayout.SuspendLayout();
        SuspendLayout();
        // 
        // headerTableLayout
        // 
        headerTableLayout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        headerTableLayout.ColumnCount = 4;
        headerTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
        headerTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        headerTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
        headerTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        headerTableLayout.Controls.Add(_traineeLabel, 0, 0);
        headerTableLayout.Controls.Add(_positionTextBox, 3, 0);
        headerTableLayout.Controls.Add(_managerTextBox, 3, 1);
        headerTableLayout.Controls.Add(_courseLabel, 0, 1);
        headerTableLayout.Controls.Add(_courseTextBox, 1, 1);
        headerTableLayout.Controls.Add(_positionLabel, 2, 0);
        headerTableLayout.Controls.Add(_managerLabel, 2, 1);
        headerTableLayout.Controls.Add(_traineeTextBox, 1, 0);
        headerTableLayout.Location = new Point(50, 130);
        headerTableLayout.Name = "headerTableLayout";
        headerTableLayout.RowCount = 2;
        headerTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        headerTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        headerTableLayout.Size = new Size(1095, 120);
        headerTableLayout.TabIndex = 13;
        // 
        // _traineeLabel
        // 
        _traineeLabel.Location = new Point(5, 0);
        _traineeLabel.Margin = new Padding(5, 0, 5, 0);
        _traineeLabel.Name = "_traineeLabel";
        _traineeLabel.Size = new Size(130, 43);
        _traineeLabel.TabIndex = 5;
        _traineeLabel.Text = "Trainee";
        _traineeLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // _positionTextBox
        // 
        _positionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _positionTextBox.BorderStyle = BorderStyle.FixedSingle;
        _positionTextBox.Location = new Point(700, 3);
        _positionTextBox.Name = "_positionTextBox";
        _positionTextBox.Size = new Size(392, 51);
        _positionTextBox.TabIndex = 11;
        _positionTextBox.TabStop = false;
        _positionTextBox.WordWrap = false;
        // 
        // _managerTextBox
        // 
        _managerTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _managerTextBox.BorderStyle = BorderStyle.FixedSingle;
        _managerTextBox.Location = new Point(700, 63);
        _managerTextBox.Name = "_managerTextBox";
        _managerTextBox.Size = new Size(392, 51);
        _managerTextBox.TabIndex = 12;
        _managerTextBox.TabStop = false;
        _managerTextBox.WordWrap = false;
        // 
        // _courseLabel
        // 
        _courseLabel.Location = new Point(5, 60);
        _courseLabel.Margin = new Padding(5, 0, 5, 0);
        _courseLabel.Name = "_courseLabel";
        _courseLabel.Size = new Size(130, 43);
        _courseLabel.TabIndex = 6;
        _courseLabel.Text = "Course";
        _courseLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // _courseTextBox
        // 
        _courseTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _courseTextBox.BorderStyle = BorderStyle.FixedSingle;
        _courseTextBox.Location = new Point(143, 63);
        _courseTextBox.Name = "_courseTextBox";
        _courseTextBox.Size = new Size(391, 51);
        _courseTextBox.TabIndex = 8;
        _courseTextBox.TabStop = false;
        _courseTextBox.WordWrap = false;
        // 
        // _positionLabel
        // 
        _positionLabel.Anchor = AnchorStyles.Top;
        _positionLabel.Location = new Point(546, 0);
        _positionLabel.Margin = new Padding(5, 0, 5, 0);
        _positionLabel.Name = "_positionLabel";
        _positionLabel.Size = new Size(142, 43);
        _positionLabel.TabIndex = 9;
        _positionLabel.Text = "Position";
        _positionLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // _managerLabel
        // 
        _managerLabel.Anchor = AnchorStyles.Top;
        _managerLabel.Location = new Point(546, 60);
        _managerLabel.Margin = new Padding(5, 0, 5, 0);
        _managerLabel.Name = "_managerLabel";
        _managerLabel.Size = new Size(142, 43);
        _managerLabel.TabIndex = 10;
        _managerLabel.Text = "Manager";
        _managerLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // _traineeTextBox
        // 
        _traineeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _traineeTextBox.BorderStyle = BorderStyle.FixedSingle;
        _traineeTextBox.Location = new Point(143, 3);
        _traineeTextBox.Name = "_traineeTextBox";
        _traineeTextBox.Size = new Size(391, 51);
        _traineeTextBox.TabIndex = 7;
        _traineeTextBox.TabStop = false;
        _traineeTextBox.WordWrap = false;
        // 
        // _taskDatabaseLabel
        // 
        _taskDatabaseLabel.AutoSize = true;
        _taskDatabaseLabel.Location = new Point(50, 50);
        _taskDatabaseLabel.Margin = new Padding(5, 0, 5, 0);
        _taskDatabaseLabel.Name = "_taskDatabaseLabel";
        _taskDatabaseLabel.Size = new Size(221, 43);
        _taskDatabaseLabel.TabIndex = 0;
        _taskDatabaseLabel.Text = "Task Database";
        _taskDatabaseLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // _selectDatabaseButton
        // 
        _selectDatabaseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _selectDatabaseButton.AutoSize = true;
        _selectDatabaseButton.Location = new Point(959, 50);
        _selectDatabaseButton.Name = "_selectDatabaseButton";
        _selectDatabaseButton.Size = new Size(186, 53);
        _selectDatabaseButton.TabIndex = 1;
        _selectDatabaseButton.Text = "Select File";
        _selectDatabaseButton.UseVisualStyleBackColor = true;
        // 
        // _taskDatabasePathTextBox
        // 
        _taskDatabasePathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _taskDatabasePathTextBox.BorderStyle = BorderStyle.FixedSingle;
        _taskDatabasePathTextBox.Enabled = false;
        _taskDatabasePathTextBox.Location = new Point(279, 50);
        _taskDatabasePathTextBox.Margin = new Padding(3, 3, 0, 3);
        _taskDatabasePathTextBox.Name = "_taskDatabasePathTextBox";
        _taskDatabasePathTextBox.PlaceholderText = "C:User\\Folder\\ExcelFile.xlsx";
        _taskDatabasePathTextBox.ReadOnly = true;
        _taskDatabasePathTextBox.Size = new Size(623, 51);
        _taskDatabasePathTextBox.TabIndex = 3;
        _taskDatabasePathTextBox.TabStop = false;
        _taskDatabasePathTextBox.WordWrap = false;
        // 
        // _copyPathToDatabaseButton
        // 
        _copyPathToDatabaseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _copyPathToDatabaseButton.Location = new Point(902, 50);
        _copyPathToDatabaseButton.Margin = new Padding(0, 3, 3, 3);
        _copyPathToDatabaseButton.Name = "_copyPathToDatabaseButton";
        _copyPathToDatabaseButton.Size = new Size(51, 51);
        _copyPathToDatabaseButton.TabIndex = 4;
        _copyPathToDatabaseButton.UseVisualStyleBackColor = true;
        // 
        // ProjectEditorUserControl
        // 
        AutoScaleDimensions = new SizeF(17F, 43F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(headerTableLayout);
        Controls.Add(_copyPathToDatabaseButton);
        Controls.Add(_taskDatabasePathTextBox);
        Controls.Add(_selectDatabaseButton);
        Controls.Add(_taskDatabaseLabel);
        Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(5);
        Name = "ProjectEditorUserControl";
        Size = new Size(1200, 800);
        headerTableLayout.ResumeLayout(false);
        headerTableLayout.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label _taskDatabaseLabel;
    private Button _selectDatabaseButton;
    private TextBox _taskDatabasePathTextBox;
    private Button _copyPathToDatabaseButton;
    private Label _traineeLabel;
    private Label _courseLabel;
    private TextBox _traineeTextBox;
    private TextBox _courseTextBox;
    private TextBox _managerTextBox;
    private TextBox _positionTextBox;
    private Label _managerLabel;
    private Label _positionLabel;
}
