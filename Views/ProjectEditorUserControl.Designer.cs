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
        Panel managerPanel;
        Panel coursePanel;
        Panel positionPanel;
        Panel traineePanel;
        Panel taskDatabasePathPanel;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectEditorUserControl));
        _managerTextBox = new TextBox();
        _positionTextBox = new TextBox();
        _traineeTextBox = new TextBox();
        _traineeLabel = new Label();
        _courseLabel = new Label();
        _positionLabel = new Label();
        _managerLabel = new Label();
        _taskDatabasePathLabel = new Label();
        _taskDatabaseLabel = new Label();
        _selectTaskDatabaseButton = new Button();
        _copyTaskDatabaseButtonFilePath = new Button();
        headerTableLayout = new TableLayoutPanel();
        managerPanel = new Panel();
        coursePanel = new Panel();
        positionPanel = new Panel();
        traineePanel = new Panel();
        taskDatabasePathPanel = new Panel();
        headerTableLayout.SuspendLayout();
        managerPanel.SuspendLayout();
        positionPanel.SuspendLayout();
        traineePanel.SuspendLayout();
        taskDatabasePathPanel.SuspendLayout();
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
        headerTableLayout.Controls.Add(managerPanel, 3, 1);
        headerTableLayout.Controls.Add(coursePanel, 1, 1);
        headerTableLayout.Controls.Add(positionPanel, 3, 0);
        headerTableLayout.Controls.Add(traineePanel, 1, 0);
        headerTableLayout.Controls.Add(_traineeLabel, 0, 0);
        headerTableLayout.Controls.Add(_courseLabel, 0, 1);
        headerTableLayout.Controls.Add(_positionLabel, 2, 0);
        headerTableLayout.Controls.Add(_managerLabel, 2, 1);
        headerTableLayout.Location = new Point(50, 50);
        headerTableLayout.Name = "headerTableLayout";
        headerTableLayout.RowCount = 2;
        headerTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        headerTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        headerTableLayout.Size = new Size(1095, 122);
        headerTableLayout.TabIndex = 13;
        // 
        // managerPanel
        // 
        managerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        managerPanel.BackColor = SystemColors.Window;
        managerPanel.BorderStyle = BorderStyle.FixedSingle;
        managerPanel.Controls.Add(_managerTextBox);
        managerPanel.Location = new Point(700, 64);
        managerPanel.Name = "managerPanel";
        managerPanel.Padding = new Padding(10, 5, 10, 0);
        managerPanel.Size = new Size(392, 55);
        managerPanel.TabIndex = 17;
        // 
        // _managerTextBox
        // 
        _managerTextBox.BorderStyle = BorderStyle.None;
        _managerTextBox.Dock = DockStyle.Fill;
        _managerTextBox.Location = new Point(10, 5);
        _managerTextBox.Name = "_managerTextBox";
        _managerTextBox.Size = new Size(370, 44);
        _managerTextBox.TabIndex = 12;
        _managerTextBox.TabStop = false;
        _managerTextBox.WordWrap = false;
        // 
        // coursePanel
        // 
        coursePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        coursePanel.BackColor = SystemColors.Window;
        coursePanel.BorderStyle = BorderStyle.FixedSingle;
        coursePanel.Location = new Point(143, 64);
        coursePanel.Name = "coursePanel";
        coursePanel.Padding = new Padding(10, 5, 10, 0);
        coursePanel.Size = new Size(391, 55);
        coursePanel.TabIndex = 16;
        // 
        // positionPanel
        // 
        positionPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        positionPanel.BackColor = SystemColors.Window;
        positionPanel.BorderStyle = BorderStyle.FixedSingle;
        positionPanel.Controls.Add(_positionTextBox);
        positionPanel.Location = new Point(700, 3);
        positionPanel.Name = "positionPanel";
        positionPanel.Padding = new Padding(10, 5, 10, 0);
        positionPanel.Size = new Size(392, 55);
        positionPanel.TabIndex = 15;
        // 
        // _positionTextBox
        // 
        _positionTextBox.BorderStyle = BorderStyle.None;
        _positionTextBox.Dock = DockStyle.Fill;
        _positionTextBox.Location = new Point(10, 5);
        _positionTextBox.Name = "_positionTextBox";
        _positionTextBox.Size = new Size(370, 44);
        _positionTextBox.TabIndex = 11;
        _positionTextBox.TabStop = false;
        _positionTextBox.WordWrap = false;
        // 
        // traineePanel
        // 
        traineePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        traineePanel.BackColor = SystemColors.Window;
        traineePanel.BorderStyle = BorderStyle.FixedSingle;
        traineePanel.Controls.Add(_traineeTextBox);
        traineePanel.Location = new Point(143, 3);
        traineePanel.Name = "traineePanel";
        traineePanel.Padding = new Padding(10, 5, 10, 0);
        traineePanel.Size = new Size(391, 55);
        traineePanel.TabIndex = 14;
        // 
        // _traineeTextBox
        // 
        _traineeTextBox.BorderStyle = BorderStyle.None;
        _traineeTextBox.Dock = DockStyle.Fill;
        _traineeTextBox.Location = new Point(10, 5);
        _traineeTextBox.Name = "_traineeTextBox";
        _traineeTextBox.Size = new Size(369, 44);
        _traineeTextBox.TabIndex = 7;
        _traineeTextBox.TabStop = false;
        _traineeTextBox.WordWrap = false;
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
        // _courseLabel
        // 
        _courseLabel.Location = new Point(5, 61);
        _courseLabel.Margin = new Padding(5, 0, 5, 0);
        _courseLabel.Name = "_courseLabel";
        _courseLabel.Size = new Size(130, 43);
        _courseLabel.TabIndex = 6;
        _courseLabel.Text = "Course";
        _courseLabel.TextAlign = ContentAlignment.MiddleCenter;
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
        _managerLabel.Location = new Point(546, 61);
        _managerLabel.Margin = new Padding(5, 0, 5, 0);
        _managerLabel.Name = "_managerLabel";
        _managerLabel.Size = new Size(142, 43);
        _managerLabel.TabIndex = 10;
        _managerLabel.Text = "Manager";
        _managerLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // taskDatabasePathPanel
        // 
        taskDatabasePathPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        taskDatabasePathPanel.BackColor = SystemColors.Control;
        taskDatabasePathPanel.BorderStyle = BorderStyle.FixedSingle;
        taskDatabasePathPanel.Controls.Add(_taskDatabasePathLabel);
        taskDatabasePathPanel.Location = new Point(279, 700);
        taskDatabasePathPanel.Margin = new Padding(3, 3, 0, 3);
        taskDatabasePathPanel.Name = "taskDatabasePathPanel";
        taskDatabasePathPanel.Padding = new Padding(10, 2, 10, 0);
        taskDatabasePathPanel.Size = new Size(623, 51);
        taskDatabasePathPanel.TabIndex = 17;
        // 
        // _taskDatabasePathLabel
        // 
        _taskDatabasePathLabel.AutoEllipsis = true;
        _taskDatabasePathLabel.Dock = DockStyle.Fill;
        _taskDatabasePathLabel.ForeColor = SystemColors.GrayText;
        _taskDatabasePathLabel.Location = new Point(10, 2);
        _taskDatabasePathLabel.Name = "_taskDatabasePathLabel";
        _taskDatabasePathLabel.Size = new Size(601, 47);
        _taskDatabasePathLabel.TabIndex = 18;
        // 
        // _taskDatabaseLabel
        // 
        _taskDatabaseLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        _taskDatabaseLabel.AutoSize = true;
        _taskDatabaseLabel.Location = new Point(50, 700);
        _taskDatabaseLabel.Margin = new Padding(5, 0, 5, 0);
        _taskDatabaseLabel.Name = "_taskDatabaseLabel";
        _taskDatabaseLabel.Size = new Size(221, 43);
        _taskDatabaseLabel.TabIndex = 0;
        _taskDatabaseLabel.Text = "Task Database";
        _taskDatabaseLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // _selectTaskDatabaseButton
        // 
        _selectTaskDatabaseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _selectTaskDatabaseButton.AutoSize = true;
        _selectTaskDatabaseButton.Location = new Point(959, 700);
        _selectTaskDatabaseButton.Name = "_selectTaskDatabaseButton";
        _selectTaskDatabaseButton.Size = new Size(186, 53);
        _selectTaskDatabaseButton.TabIndex = 1;
        _selectTaskDatabaseButton.Text = "Select File";
        _selectTaskDatabaseButton.UseVisualStyleBackColor = true;
        _selectTaskDatabaseButton.Click += SelectTaskDatabaseButton_Click;
        // 
        // _copyTaskDatabaseButtonFilePath
        // 
        _copyTaskDatabaseButtonFilePath.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _copyTaskDatabaseButtonFilePath.BackgroundImage = (Image)resources.GetObject("_copyTaskDatabaseButtonFilePath.BackgroundImage");
        _copyTaskDatabaseButtonFilePath.BackgroundImageLayout = ImageLayout.Zoom;
        _copyTaskDatabaseButtonFilePath.Location = new Point(902, 700);
        _copyTaskDatabaseButtonFilePath.Margin = new Padding(0, 3, 3, 3);
        _copyTaskDatabaseButtonFilePath.Name = "_copyTaskDatabaseButtonFilePath";
        _copyTaskDatabaseButtonFilePath.Size = new Size(51, 51);
        _copyTaskDatabaseButtonFilePath.TabIndex = 4;
        _copyTaskDatabaseButtonFilePath.UseVisualStyleBackColor = true;
        _copyTaskDatabaseButtonFilePath.Click += CopyTaskDatabaseFilePathButton_Click;
        // 
        // ProjectEditorUserControl
        // 
        AutoScaleDimensions = new SizeF(17F, 43F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        Controls.Add(taskDatabasePathPanel);
        Controls.Add(headerTableLayout);
        Controls.Add(_copyTaskDatabaseButtonFilePath);
        Controls.Add(_selectTaskDatabaseButton);
        Controls.Add(_taskDatabaseLabel);
        Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(5);
        Name = "ProjectEditorUserControl";
        Size = new Size(1200, 800);
        headerTableLayout.ResumeLayout(false);
        managerPanel.ResumeLayout(false);
        managerPanel.PerformLayout();
        positionPanel.ResumeLayout(false);
        positionPanel.PerformLayout();
        traineePanel.ResumeLayout(false);
        traineePanel.PerformLayout();
        taskDatabasePathPanel.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label _taskDatabaseLabel;
    private Button _selectTaskDatabaseButton;
    private Button _copyTaskDatabaseButtonFilePath;
    private Label _traineeLabel;
    private Label _courseLabel;
    private TextBox _traineeTextBox;
    private TextBox _courseTextBox;
    private TextBox _managerTextBox;
    private TextBox _positionTextBox;
    private Label _managerLabel;
    private Label _positionLabel;
    private Label _taskDatabasePathLabel;
}
