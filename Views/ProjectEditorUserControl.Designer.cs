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
        TableLayoutPanel tasksTableLayoutPanel;
        TableLayoutPanel tableLayoutPanel1;
        Panel _availableTaskSearchPatternPanel;
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        TableLayoutPanel assignedTaskSearchTableLayoutPanel;
        Panel _assignedTaskSearchPatternPanel;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectEditorUserControl));
        _managerRichTextBox = new RichTextBox();
        _courseRichTextBox = new RichTextBox();
        _positionRichTextBox = new RichTextBox();
        _traineeRichTextBox = new RichTextBox();
        _traineeLabel = new Label();
        _courseLabel = new Label();
        _positionLabel = new Label();
        _managerLabel = new Label();
        _taskDatabasePathLabel = new Label();
        _availableTaskSearchPatternRichTextBox = new RichTextBox();
        _availableTaskSearchPatternLabel = new Label();
        _availableTaskSearchByLabel = new Label();
        _availableTaskSearchByComboBox = new ComboBox();
        _assignedTasksDataGridView = new DataGridView();
        UnassignButtons = new DataGridViewButtonColumn();
        _availableTasksDataGridView = new DataGridView();
        _assignedTaskSearchPatternRichTextBox = new RichTextBox();
        _assignedTaskSearchPatternLabel = new Label();
        _assignedTaskSearchByLabel = new Label();
        _assignedTaskSearchByComboBox = new ComboBox();
        _taskDatabaseLabel = new Label();
        _selectTaskDatabaseButton = new Button();
        _copyTaskDatabaseButtonFilePath = new Button();
        headerTableLayout = new TableLayoutPanel();
        managerPanel = new Panel();
        coursePanel = new Panel();
        positionPanel = new Panel();
        traineePanel = new Panel();
        taskDatabasePathPanel = new Panel();
        tasksTableLayoutPanel = new TableLayoutPanel();
        tableLayoutPanel1 = new TableLayoutPanel();
        _availableTaskSearchPatternPanel = new Panel();
        assignedTaskSearchTableLayoutPanel = new TableLayoutPanel();
        _assignedTaskSearchPatternPanel = new Panel();
        headerTableLayout.SuspendLayout();
        managerPanel.SuspendLayout();
        coursePanel.SuspendLayout();
        positionPanel.SuspendLayout();
        traineePanel.SuspendLayout();
        taskDatabasePathPanel.SuspendLayout();
        tasksTableLayoutPanel.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        _availableTaskSearchPatternPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_assignedTasksDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_availableTasksDataGridView).BeginInit();
        assignedTaskSearchTableLayoutPanel.SuspendLayout();
        _assignedTaskSearchPatternPanel.SuspendLayout();
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
        headerTableLayout.Location = new Point(25, 25);
        headerTableLayout.Name = "headerTableLayout";
        headerTableLayout.RowCount = 2;
        headerTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        headerTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        headerTableLayout.Size = new Size(1235, 122);
        headerTableLayout.TabIndex = 13;
        // 
        // managerPanel
        // 
        managerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        managerPanel.BackColor = SystemColors.Window;
        managerPanel.BorderStyle = BorderStyle.FixedSingle;
        managerPanel.Controls.Add(_managerRichTextBox);
        managerPanel.Location = new Point(770, 64);
        managerPanel.Name = "managerPanel";
        managerPanel.Padding = new Padding(10, 5, 10, 0);
        managerPanel.Size = new Size(462, 55);
        managerPanel.TabIndex = 17;
        // 
        // _managerRichTextBox
        // 
        _managerRichTextBox.BorderStyle = BorderStyle.None;
        _managerRichTextBox.DetectUrls = false;
        _managerRichTextBox.Dock = DockStyle.Fill;
        _managerRichTextBox.Location = new Point(10, 5);
        _managerRichTextBox.Multiline = false;
        _managerRichTextBox.Name = "_managerRichTextBox";
        _managerRichTextBox.ScrollBars = RichTextBoxScrollBars.None;
        _managerRichTextBox.Size = new Size(440, 48);
        _managerRichTextBox.TabIndex = 21;
        _managerRichTextBox.Text = "";
        _managerRichTextBox.WordWrap = false;
        // 
        // coursePanel
        // 
        coursePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        coursePanel.BackColor = SystemColors.Window;
        coursePanel.BorderStyle = BorderStyle.FixedSingle;
        coursePanel.Controls.Add(_courseRichTextBox);
        coursePanel.Location = new Point(143, 64);
        coursePanel.Name = "coursePanel";
        coursePanel.Padding = new Padding(10, 5, 10, 0);
        coursePanel.Size = new Size(461, 55);
        coursePanel.TabIndex = 16;
        // 
        // _courseRichTextBox
        // 
        _courseRichTextBox.BorderStyle = BorderStyle.None;
        _courseRichTextBox.DetectUrls = false;
        _courseRichTextBox.Dock = DockStyle.Fill;
        _courseRichTextBox.Location = new Point(10, 5);
        _courseRichTextBox.Multiline = false;
        _courseRichTextBox.Name = "_courseRichTextBox";
        _courseRichTextBox.ScrollBars = RichTextBoxScrollBars.None;
        _courseRichTextBox.Size = new Size(439, 48);
        _courseRichTextBox.TabIndex = 18;
        _courseRichTextBox.Text = "";
        _courseRichTextBox.WordWrap = false;
        // 
        // positionPanel
        // 
        positionPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        positionPanel.BackColor = SystemColors.Window;
        positionPanel.BorderStyle = BorderStyle.FixedSingle;
        positionPanel.Controls.Add(_positionRichTextBox);
        positionPanel.Location = new Point(770, 3);
        positionPanel.Name = "positionPanel";
        positionPanel.Padding = new Padding(10, 5, 10, 0);
        positionPanel.Size = new Size(462, 55);
        positionPanel.TabIndex = 15;
        // 
        // _positionRichTextBox
        // 
        _positionRichTextBox.BorderStyle = BorderStyle.None;
        _positionRichTextBox.DetectUrls = false;
        _positionRichTextBox.Dock = DockStyle.Fill;
        _positionRichTextBox.Location = new Point(10, 5);
        _positionRichTextBox.Multiline = false;
        _positionRichTextBox.Name = "_positionRichTextBox";
        _positionRichTextBox.ScrollBars = RichTextBoxScrollBars.None;
        _positionRichTextBox.Size = new Size(440, 48);
        _positionRichTextBox.TabIndex = 20;
        _positionRichTextBox.Text = "";
        _positionRichTextBox.WordWrap = false;
        // 
        // traineePanel
        // 
        traineePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        traineePanel.BackColor = SystemColors.Window;
        traineePanel.BorderStyle = BorderStyle.FixedSingle;
        traineePanel.Controls.Add(_traineeRichTextBox);
        traineePanel.Location = new Point(143, 3);
        traineePanel.Name = "traineePanel";
        traineePanel.Padding = new Padding(10, 5, 10, 0);
        traineePanel.Size = new Size(461, 55);
        traineePanel.TabIndex = 14;
        // 
        // _traineeRichTextBox
        // 
        _traineeRichTextBox.BorderStyle = BorderStyle.None;
        _traineeRichTextBox.DetectUrls = false;
        _traineeRichTextBox.Dock = DockStyle.Fill;
        _traineeRichTextBox.Location = new Point(10, 5);
        _traineeRichTextBox.Multiline = false;
        _traineeRichTextBox.Name = "_traineeRichTextBox";
        _traineeRichTextBox.ScrollBars = RichTextBoxScrollBars.None;
        _traineeRichTextBox.Size = new Size(439, 48);
        _traineeRichTextBox.TabIndex = 19;
        _traineeRichTextBox.Text = "";
        _traineeRichTextBox.WordWrap = false;
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
        _positionLabel.Location = new Point(616, 0);
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
        _managerLabel.Location = new Point(616, 61);
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
        taskDatabasePathPanel.Location = new Point(254, 825);
        taskDatabasePathPanel.Margin = new Padding(3, 3, 0, 3);
        taskDatabasePathPanel.Name = "taskDatabasePathPanel";
        taskDatabasePathPanel.Padding = new Padding(10, 2, 10, 0);
        taskDatabasePathPanel.Size = new Size(768, 51);
        taskDatabasePathPanel.TabIndex = 17;
        // 
        // _taskDatabasePathLabel
        // 
        _taskDatabasePathLabel.AutoEllipsis = true;
        _taskDatabasePathLabel.Dock = DockStyle.Fill;
        _taskDatabasePathLabel.ForeColor = SystemColors.GrayText;
        _taskDatabasePathLabel.Location = new Point(10, 2);
        _taskDatabasePathLabel.Name = "_taskDatabasePathLabel";
        _taskDatabasePathLabel.Size = new Size(746, 47);
        _taskDatabasePathLabel.TabIndex = 18;
        // 
        // tasksTableLayoutPanel
        // 
        tasksTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tasksTableLayoutPanel.ColumnCount = 1;
        tasksTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tasksTableLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 2);
        tasksTableLayoutPanel.Controls.Add(_assignedTasksDataGridView, 0, 1);
        tasksTableLayoutPanel.Controls.Add(_availableTasksDataGridView, 0, 3);
        tasksTableLayoutPanel.Controls.Add(assignedTaskSearchTableLayoutPanel, 0, 0);
        tasksTableLayoutPanel.Location = new Point(35, 175);
        tasksTableLayoutPanel.Name = "tasksTableLayoutPanel";
        tasksTableLayoutPanel.RowCount = 4;
        tasksTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tasksTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tasksTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tasksTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tasksTableLayoutPanel.Size = new Size(1225, 620);
        tasksTableLayoutPanel.TabIndex = 20;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 6;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 188F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 359F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 132F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 221F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 258F));
        tableLayoutPanel1.Controls.Add(_availableTaskSearchPatternPanel, 1, 0);
        tableLayoutPanel1.Controls.Add(_availableTaskSearchPatternLabel, 0, 0);
        tableLayoutPanel1.Controls.Add(_availableTaskSearchByLabel, 3, 0);
        tableLayoutPanel1.Controls.Add(_availableTaskSearchByComboBox, 4, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(3, 313);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(1219, 44);
        tableLayoutPanel1.TabIndex = 21;
        // 
        // _availableTaskSearchPatternPanel
        // 
        _availableTaskSearchPatternPanel.BackColor = SystemColors.Window;
        _availableTaskSearchPatternPanel.BorderStyle = BorderStyle.FixedSingle;
        _availableTaskSearchPatternPanel.Controls.Add(_availableTaskSearchPatternRichTextBox);
        _availableTaskSearchPatternPanel.Dock = DockStyle.Fill;
        _availableTaskSearchPatternPanel.Location = new Point(191, 3);
        _availableTaskSearchPatternPanel.Name = "_availableTaskSearchPatternPanel";
        _availableTaskSearchPatternPanel.Padding = new Padding(10, 0, 10, 0);
        _availableTaskSearchPatternPanel.Size = new Size(353, 38);
        _availableTaskSearchPatternPanel.TabIndex = 21;
        // 
        // _availableTaskSearchPatternRichTextBox
        // 
        _availableTaskSearchPatternRichTextBox.BorderStyle = BorderStyle.None;
        _availableTaskSearchPatternRichTextBox.DetectUrls = false;
        _availableTaskSearchPatternRichTextBox.Dock = DockStyle.Fill;
        _availableTaskSearchPatternRichTextBox.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _availableTaskSearchPatternRichTextBox.Location = new Point(10, 0);
        _availableTaskSearchPatternRichTextBox.Multiline = false;
        _availableTaskSearchPatternRichTextBox.Name = "_availableTaskSearchPatternRichTextBox";
        _availableTaskSearchPatternRichTextBox.ScrollBars = RichTextBoxScrollBars.None;
        _availableTaskSearchPatternRichTextBox.Size = new Size(331, 36);
        _availableTaskSearchPatternRichTextBox.TabIndex = 19;
        _availableTaskSearchPatternRichTextBox.Text = "";
        _availableTaskSearchPatternRichTextBox.WordWrap = false;
        _availableTaskSearchPatternRichTextBox.TextChanged += AvailableTaskSearchPatternRichTextBox_TextChanged;
        // 
        // _availableTaskSearchPatternLabel
        // 
        _availableTaskSearchPatternLabel.AutoSize = true;
        _availableTaskSearchPatternLabel.Dock = DockStyle.Fill;
        _availableTaskSearchPatternLabel.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _availableTaskSearchPatternLabel.Location = new Point(3, 0);
        _availableTaskSearchPatternLabel.Name = "_availableTaskSearchPatternLabel";
        _availableTaskSearchPatternLabel.Size = new Size(182, 44);
        _availableTaskSearchPatternLabel.TabIndex = 20;
        _availableTaskSearchPatternLabel.Text = "Search Pattern";
        _availableTaskSearchPatternLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // _availableTaskSearchByLabel
        // 
        _availableTaskSearchByLabel.AutoSize = true;
        _availableTaskSearchByLabel.Dock = DockStyle.Fill;
        _availableTaskSearchByLabel.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _availableTaskSearchByLabel.Location = new Point(586, 0);
        _availableTaskSearchByLabel.Name = "_availableTaskSearchByLabel";
        _availableTaskSearchByLabel.Size = new Size(126, 44);
        _availableTaskSearchByLabel.TabIndex = 21;
        _availableTaskSearchByLabel.Text = "Search By";
        _availableTaskSearchByLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // _availableTaskSearchByComboBox
        // 
        _availableTaskSearchByComboBox.Dock = DockStyle.Fill;
        _availableTaskSearchByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        _availableTaskSearchByComboBox.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _availableTaskSearchByComboBox.ItemHeight = 29;
        _availableTaskSearchByComboBox.Items.AddRange(new object[] { "Reference", "Description", "Training Category", "Type", "Training Started", "Training Completed", "Trainer Initials", "Certifier Initials", "Certifying Score", "Required Score" });
        _availableTaskSearchByComboBox.Location = new Point(718, 3);
        _availableTaskSearchByComboBox.Name = "_availableTaskSearchByComboBox";
        _availableTaskSearchByComboBox.Size = new Size(215, 37);
        _availableTaskSearchByComboBox.TabIndex = 22;
        _availableTaskSearchByComboBox.SelectedIndexChanged += AvailableTaskSearchByComboBox_SelectedIndexChanged;
        // 
        // _assignedTasksDataGridView
        // 
        _assignedTasksDataGridView.AllowUserToAddRows = false;
        _assignedTasksDataGridView.AllowUserToDeleteRows = false;
        _assignedTasksDataGridView.AllowUserToResizeColumns = false;
        _assignedTasksDataGridView.AllowUserToResizeRows = false;
        _assignedTasksDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _assignedTasksDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        _assignedTasksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        _assignedTasksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        _assignedTasksDataGridView.Columns.AddRange(new DataGridViewColumn[] { UnassignButtons });
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        _assignedTasksDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
        _assignedTasksDataGridView.Dock = DockStyle.Fill;
        _assignedTasksDataGridView.EnableHeadersVisualStyles = false;
        _assignedTasksDataGridView.Location = new Point(0, 50);
        _assignedTasksDataGridView.Margin = new Padding(0);
        _assignedTasksDataGridView.MultiSelect = false;
        _assignedTasksDataGridView.Name = "_assignedTasksDataGridView";
        _assignedTasksDataGridView.RowHeadersVisible = false;
        _assignedTasksDataGridView.RowHeadersWidth = 62;
        _assignedTasksDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        _assignedTasksDataGridView.ScrollBars = ScrollBars.Vertical;
        _assignedTasksDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
        _assignedTasksDataGridView.ShowCellErrors = false;
        _assignedTasksDataGridView.ShowCellToolTips = false;
        _assignedTasksDataGridView.ShowEditingIcon = false;
        _assignedTasksDataGridView.ShowRowErrors = false;
        _assignedTasksDataGridView.Size = new Size(1225, 260);
        _assignedTasksDataGridView.TabIndex = 18;
        _assignedTasksDataGridView.CellClick += AssignedTasksDataGridView_CellClick;
        _assignedTasksDataGridView.ColumnAdded += AssignedTasksDataGridView_ColumnAdded;
        // 
        // UnassignButtons
        // 
        UnassignButtons.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        UnassignButtons.FillWeight = 1F;
        UnassignButtons.HeaderText = "";
        UnassignButtons.MinimumWidth = 8;
        UnassignButtons.Name = "UnassignButtons";
        UnassignButtons.Text = "✖";
        UnassignButtons.UseColumnTextForButtonValue = true;
        UnassignButtons.Width = 35;
        // 
        // _availableTasksDataGridView
        // 
        _availableTasksDataGridView.AllowUserToAddRows = false;
        _availableTasksDataGridView.AllowUserToDeleteRows = false;
        _availableTasksDataGridView.AllowUserToResizeColumns = false;
        _availableTasksDataGridView.AllowUserToResizeRows = false;
        _availableTasksDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _availableTasksDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle3.BackColor = SystemColors.Control;
        dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
        dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        _availableTasksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
        _availableTasksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = SystemColors.Window;
        dataGridViewCellStyle4.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
        _availableTasksDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
        _availableTasksDataGridView.Dock = DockStyle.Fill;
        _availableTasksDataGridView.EnableHeadersVisualStyles = false;
        _availableTasksDataGridView.Location = new Point(0, 360);
        _availableTasksDataGridView.Margin = new Padding(0);
        _availableTasksDataGridView.Name = "_availableTasksDataGridView";
        _availableTasksDataGridView.ReadOnly = true;
        _availableTasksDataGridView.RowHeadersVisible = false;
        _availableTasksDataGridView.RowHeadersWidth = 62;
        _availableTasksDataGridView.ScrollBars = ScrollBars.Vertical;
        _availableTasksDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        _availableTasksDataGridView.ShowCellErrors = false;
        _availableTasksDataGridView.ShowCellToolTips = false;
        _availableTasksDataGridView.ShowEditingIcon = false;
        _availableTasksDataGridView.ShowRowErrors = false;
        _availableTasksDataGridView.Size = new Size(1225, 260);
        _availableTasksDataGridView.TabIndex = 19;
        _availableTasksDataGridView.CellMouseDoubleClick += AvailableTasksDataGridView_CellMouseDoubleClick;
        _availableTasksDataGridView.ColumnAdded += AvailableTasksDataGridView_ColumnAdded;
        _availableTasksDataGridView.KeyDown += AvailableTasksDataGridView_KeyDown;
        // 
        // assignedTaskSearchTableLayoutPanel
        // 
        assignedTaskSearchTableLayoutPanel.ColumnCount = 6;
        assignedTaskSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 188F));
        assignedTaskSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 359F));
        assignedTaskSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
        assignedTaskSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 132F));
        assignedTaskSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 221F));
        assignedTaskSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 258F));
        assignedTaskSearchTableLayoutPanel.Controls.Add(_assignedTaskSearchPatternPanel, 1, 0);
        assignedTaskSearchTableLayoutPanel.Controls.Add(_assignedTaskSearchPatternLabel, 0, 0);
        assignedTaskSearchTableLayoutPanel.Controls.Add(_assignedTaskSearchByLabel, 3, 0);
        assignedTaskSearchTableLayoutPanel.Controls.Add(_assignedTaskSearchByComboBox, 4, 0);
        assignedTaskSearchTableLayoutPanel.Dock = DockStyle.Fill;
        assignedTaskSearchTableLayoutPanel.Location = new Point(3, 3);
        assignedTaskSearchTableLayoutPanel.Name = "assignedTaskSearchTableLayoutPanel";
        assignedTaskSearchTableLayoutPanel.RowCount = 1;
        assignedTaskSearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        assignedTaskSearchTableLayoutPanel.Size = new Size(1219, 44);
        assignedTaskSearchTableLayoutPanel.TabIndex = 20;
        // 
        // _assignedTaskSearchPatternPanel
        // 
        _assignedTaskSearchPatternPanel.BackColor = SystemColors.Window;
        _assignedTaskSearchPatternPanel.BorderStyle = BorderStyle.FixedSingle;
        _assignedTaskSearchPatternPanel.Controls.Add(_assignedTaskSearchPatternRichTextBox);
        _assignedTaskSearchPatternPanel.Dock = DockStyle.Fill;
        _assignedTaskSearchPatternPanel.Location = new Point(191, 3);
        _assignedTaskSearchPatternPanel.Name = "_assignedTaskSearchPatternPanel";
        _assignedTaskSearchPatternPanel.Padding = new Padding(10, 0, 10, 0);
        _assignedTaskSearchPatternPanel.Size = new Size(353, 38);
        _assignedTaskSearchPatternPanel.TabIndex = 21;
        // 
        // _assignedTaskSearchPatternRichTextBox
        // 
        _assignedTaskSearchPatternRichTextBox.BorderStyle = BorderStyle.None;
        _assignedTaskSearchPatternRichTextBox.DetectUrls = false;
        _assignedTaskSearchPatternRichTextBox.Dock = DockStyle.Fill;
        _assignedTaskSearchPatternRichTextBox.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _assignedTaskSearchPatternRichTextBox.Location = new Point(10, 0);
        _assignedTaskSearchPatternRichTextBox.Multiline = false;
        _assignedTaskSearchPatternRichTextBox.Name = "_assignedTaskSearchPatternRichTextBox";
        _assignedTaskSearchPatternRichTextBox.ScrollBars = RichTextBoxScrollBars.None;
        _assignedTaskSearchPatternRichTextBox.Size = new Size(331, 36);
        _assignedTaskSearchPatternRichTextBox.TabIndex = 19;
        _assignedTaskSearchPatternRichTextBox.Text = "";
        _assignedTaskSearchPatternRichTextBox.WordWrap = false;
        _assignedTaskSearchPatternRichTextBox.TextChanged += AssignedTaskSearchPatternRichTextBox_TextChanged;
        // 
        // _assignedTaskSearchPatternLabel
        // 
        _assignedTaskSearchPatternLabel.AutoSize = true;
        _assignedTaskSearchPatternLabel.Dock = DockStyle.Fill;
        _assignedTaskSearchPatternLabel.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _assignedTaskSearchPatternLabel.Location = new Point(3, 0);
        _assignedTaskSearchPatternLabel.Name = "_assignedTaskSearchPatternLabel";
        _assignedTaskSearchPatternLabel.Size = new Size(182, 44);
        _assignedTaskSearchPatternLabel.TabIndex = 20;
        _assignedTaskSearchPatternLabel.Text = "Search Pattern";
        _assignedTaskSearchPatternLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // _assignedTaskSearchByLabel
        // 
        _assignedTaskSearchByLabel.AutoSize = true;
        _assignedTaskSearchByLabel.Dock = DockStyle.Fill;
        _assignedTaskSearchByLabel.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _assignedTaskSearchByLabel.Location = new Point(586, 0);
        _assignedTaskSearchByLabel.Name = "_assignedTaskSearchByLabel";
        _assignedTaskSearchByLabel.Size = new Size(126, 44);
        _assignedTaskSearchByLabel.TabIndex = 21;
        _assignedTaskSearchByLabel.Text = "Search By";
        _assignedTaskSearchByLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // _assignedTaskSearchByComboBox
        // 
        _assignedTaskSearchByComboBox.Dock = DockStyle.Fill;
        _assignedTaskSearchByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        _assignedTaskSearchByComboBox.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _assignedTaskSearchByComboBox.ItemHeight = 29;
        _assignedTaskSearchByComboBox.Items.AddRange(new object[] { "Reference", "Description", "Training Category", "Type", "Training Started", "Training Completed", "Trainer Initials", "Certifier Initials", "Certifying Score", "Required Score" });
        _assignedTaskSearchByComboBox.Location = new Point(718, 3);
        _assignedTaskSearchByComboBox.Name = "_assignedTaskSearchByComboBox";
        _assignedTaskSearchByComboBox.Size = new Size(215, 37);
        _assignedTaskSearchByComboBox.TabIndex = 22;
        _assignedTaskSearchByComboBox.SelectedIndexChanged += AssignedTaskSearchByComboBox_SelectedIndexChanged;
        // 
        // _taskDatabaseLabel
        // 
        _taskDatabaseLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        _taskDatabaseLabel.AutoSize = true;
        _taskDatabaseLabel.Location = new Point(25, 825);
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
        _selectTaskDatabaseButton.Location = new Point(1079, 825);
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
        _copyTaskDatabaseButtonFilePath.Location = new Point(1022, 825);
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
        Controls.Add(tasksTableLayoutPanel);
        Controls.Add(taskDatabasePathPanel);
        Controls.Add(headerTableLayout);
        Controls.Add(_copyTaskDatabaseButtonFilePath);
        Controls.Add(_selectTaskDatabaseButton);
        Controls.Add(_taskDatabaseLabel);
        Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(5);
        Name = "ProjectEditorUserControl";
        Size = new Size(1300, 900);
        Load += ProjectEditorUserControl_Load;
        headerTableLayout.ResumeLayout(false);
        managerPanel.ResumeLayout(false);
        coursePanel.ResumeLayout(false);
        positionPanel.ResumeLayout(false);
        traineePanel.ResumeLayout(false);
        taskDatabasePathPanel.ResumeLayout(false);
        tasksTableLayoutPanel.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        _availableTaskSearchPatternPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)_assignedTasksDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)_availableTasksDataGridView).EndInit();
        assignedTaskSearchTableLayoutPanel.ResumeLayout(false);
        assignedTaskSearchTableLayoutPanel.PerformLayout();
        _assignedTaskSearchPatternPanel.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label _taskDatabaseLabel;
    private Button _selectTaskDatabaseButton;
    private Button _copyTaskDatabaseButtonFilePath;
    private Label _traineeLabel;
    private Label _courseLabel;
    private Label _managerLabel;
    private Label _positionLabel;
    private Label _taskDatabasePathLabel;
    private RichTextBox _courseRichTextBox;
    private RichTextBox _positionRichTextBox;
    private RichTextBox _managerRichTextBox;
    private RichTextBox _traineeRichTextBox;
    private DataGridView _assignedTasksDataGridView;
    private DataGridView _availableTasksDataGridView;
    private DataGridViewButtonColumn UnassignButtons;
    private Label _assignedTaskSearchPatternLabel;
    private RichTextBox _assignedTaskSearchPatternRichTextBox;
    private Label _assignedTaskSearchByLabel;
    private ComboBox _assignedTaskSearchByComboBox;
    private RichTextBox _availableTaskSearchPatternRichTextBox;
    private Label _availableTaskSearchPatternLabel;
    private Label _availableTaskSearchByLabel;
    private ComboBox _availableTaskSearchByComboBox;
}
