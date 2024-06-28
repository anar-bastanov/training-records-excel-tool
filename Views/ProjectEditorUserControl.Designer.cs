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
        TableLayoutPanel profileTableLayout;
        Panel managerPanel;
        Panel coursePanel;
        Panel positionPanel;
        Panel traineePanel;
        Label traineeLabel;
        Label courseLabel;
        Label positionLabel;
        Label managerLabel;
        Panel taskDatabasePathPanel;
        TableLayoutPanel tasksTableLayoutPanel;
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        TableLayoutPanel assignedTaskSearchTableLayoutPanel;
        Panel assignedTaskSearchPatternPanel;
        Label assignedTaskSearchPatternLabel;
        Label assignedTaskSearchByLabel;
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        TableLayoutPanel availableTaskSearchTableLayoutPanel;
        Panel availableTaskSearchPatternPanel;
        Label availableTaskSearchPatternLabel;
        Label availableTaskSearchByLabel;
        Label taskDatabaseLabel;
        Button copyTaskDatabaseFilePathButton;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectEditorUserControl));
        _managerRichTextBox = new RichTextBox();
        _courseRichTextBox = new RichTextBox();
        _positionRichTextBox = new RichTextBox();
        _traineeRichTextBox = new RichTextBox();
        _taskDatabasePathLabel = new Label();
        _assignedTasksDataGridView = new DataGridView();
        unassignButtons = new DataGridViewButtonColumn();
        _assignedTaskSearchPatternRichTextBox = new RichTextBox();
        _assignedTaskSearchByComboBox = new ComboBox();
        _assignedTaskSearchCountLabel = new Label();
        _availableTasksDataGridView = new DataGridView();
        _availableTaskSearchPatternRichTextBox = new RichTextBox();
        _availableTaskSearchByComboBox = new ComboBox();
        _availableTaskSearchCountLabel = new Label();
        _selectTaskDatabaseButton = new Button();
        profileTableLayout = new TableLayoutPanel();
        managerPanel = new Panel();
        coursePanel = new Panel();
        positionPanel = new Panel();
        traineePanel = new Panel();
        traineeLabel = new Label();
        courseLabel = new Label();
        positionLabel = new Label();
        managerLabel = new Label();
        taskDatabasePathPanel = new Panel();
        tasksTableLayoutPanel = new TableLayoutPanel();
        assignedTaskSearchTableLayoutPanel = new TableLayoutPanel();
        assignedTaskSearchPatternPanel = new Panel();
        assignedTaskSearchPatternLabel = new Label();
        assignedTaskSearchByLabel = new Label();
        availableTaskSearchTableLayoutPanel = new TableLayoutPanel();
        availableTaskSearchPatternPanel = new Panel();
        availableTaskSearchPatternLabel = new Label();
        availableTaskSearchByLabel = new Label();
        taskDatabaseLabel = new Label();
        copyTaskDatabaseFilePathButton = new Button();
        profileTableLayout.SuspendLayout();
        managerPanel.SuspendLayout();
        coursePanel.SuspendLayout();
        positionPanel.SuspendLayout();
        traineePanel.SuspendLayout();
        taskDatabasePathPanel.SuspendLayout();
        tasksTableLayoutPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_assignedTasksDataGridView).BeginInit();
        assignedTaskSearchTableLayoutPanel.SuspendLayout();
        assignedTaskSearchPatternPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_availableTasksDataGridView).BeginInit();
        availableTaskSearchTableLayoutPanel.SuspendLayout();
        availableTaskSearchPatternPanel.SuspendLayout();
        SuspendLayout();
        // 
        // profileTableLayout
        // 
        profileTableLayout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        profileTableLayout.ColumnCount = 4;
        profileTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
        profileTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        profileTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
        profileTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        profileTableLayout.Controls.Add(managerPanel, 3, 1);
        profileTableLayout.Controls.Add(coursePanel, 1, 1);
        profileTableLayout.Controls.Add(positionPanel, 3, 0);
        profileTableLayout.Controls.Add(traineePanel, 1, 0);
        profileTableLayout.Controls.Add(traineeLabel, 0, 0);
        profileTableLayout.Controls.Add(courseLabel, 0, 1);
        profileTableLayout.Controls.Add(positionLabel, 2, 0);
        profileTableLayout.Controls.Add(managerLabel, 2, 1);
        profileTableLayout.Location = new Point(25, 25);
        profileTableLayout.Name = "profileTableLayout";
        profileTableLayout.RowCount = 2;
        profileTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        profileTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        profileTableLayout.Size = new Size(1235, 122);
        profileTableLayout.TabIndex = 1;
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
        managerPanel.TabIndex = 4;
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
        _managerRichTextBox.TabIndex = 0;
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
        coursePanel.TabIndex = 3;
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
        _courseRichTextBox.TabIndex = 0;
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
        positionPanel.TabIndex = 2;
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
        _positionRichTextBox.TabIndex = 0;
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
        traineePanel.TabIndex = 1;
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
        _traineeRichTextBox.TabIndex = 0;
        _traineeRichTextBox.Text = "";
        _traineeRichTextBox.WordWrap = false;
        // 
        // traineeLabel
        // 
        traineeLabel.Location = new Point(5, 0);
        traineeLabel.Margin = new Padding(5, 0, 5, 0);
        traineeLabel.Name = "traineeLabel";
        traineeLabel.Size = new Size(130, 43);
        traineeLabel.TabIndex = 0;
        traineeLabel.Text = "Trainee";
        traineeLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // courseLabel
        // 
        courseLabel.Location = new Point(5, 61);
        courseLabel.Margin = new Padding(5, 0, 5, 0);
        courseLabel.Name = "courseLabel";
        courseLabel.Size = new Size(130, 43);
        courseLabel.TabIndex = 0;
        courseLabel.Text = "Course";
        courseLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // positionLabel
        // 
        positionLabel.Anchor = AnchorStyles.Top;
        positionLabel.Location = new Point(616, 0);
        positionLabel.Margin = new Padding(5, 0, 5, 0);
        positionLabel.Name = "positionLabel";
        positionLabel.Size = new Size(142, 43);
        positionLabel.TabIndex = 0;
        positionLabel.Text = "Position";
        positionLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // managerLabel
        // 
        managerLabel.Anchor = AnchorStyles.Top;
        managerLabel.Location = new Point(616, 61);
        managerLabel.Margin = new Padding(5, 0, 5, 0);
        managerLabel.Name = "managerLabel";
        managerLabel.Size = new Size(142, 43);
        managerLabel.TabIndex = 0;
        managerLabel.Text = "Manager";
        managerLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // taskDatabasePathPanel
        // 
        taskDatabasePathPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        taskDatabasePathPanel.BackColor = SystemColors.Control;
        taskDatabasePathPanel.BorderStyle = BorderStyle.FixedSingle;
        taskDatabasePathPanel.Controls.Add(_taskDatabasePathLabel);
        taskDatabasePathPanel.Cursor = Cursors.No;
        taskDatabasePathPanel.Location = new Point(254, 825);
        taskDatabasePathPanel.Margin = new Padding(3, 3, 0, 3);
        taskDatabasePathPanel.Name = "taskDatabasePathPanel";
        taskDatabasePathPanel.Padding = new Padding(10, 2, 10, 0);
        taskDatabasePathPanel.Size = new Size(768, 51);
        taskDatabasePathPanel.TabIndex = 0;
        // 
        // _taskDatabasePathLabel
        // 
        _taskDatabasePathLabel.AutoEllipsis = true;
        _taskDatabasePathLabel.Dock = DockStyle.Fill;
        _taskDatabasePathLabel.ForeColor = SystemColors.GrayText;
        _taskDatabasePathLabel.Location = new Point(10, 2);
        _taskDatabasePathLabel.Name = "_taskDatabasePathLabel";
        _taskDatabasePathLabel.Size = new Size(746, 47);
        _taskDatabasePathLabel.TabIndex = 0;
        // 
        // tasksTableLayoutPanel
        // 
        tasksTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tasksTableLayoutPanel.ColumnCount = 1;
        tasksTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tasksTableLayoutPanel.Controls.Add(_assignedTasksDataGridView, 0, 1);
        tasksTableLayoutPanel.Controls.Add(assignedTaskSearchTableLayoutPanel, 0, 0);
        tasksTableLayoutPanel.Controls.Add(_availableTasksDataGridView, 0, 4);
        tasksTableLayoutPanel.Controls.Add(availableTaskSearchTableLayoutPanel, 0, 3);
        tasksTableLayoutPanel.Location = new Point(35, 175);
        tasksTableLayoutPanel.Name = "tasksTableLayoutPanel";
        tasksTableLayoutPanel.RowCount = 5;
        tasksTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tasksTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tasksTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        tasksTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tasksTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tasksTableLayoutPanel.Size = new Size(1225, 620);
        tasksTableLayoutPanel.TabIndex = 4;
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
        dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiCondensed", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        _assignedTasksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        _assignedTasksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        _assignedTasksDataGridView.Columns.AddRange(new DataGridViewColumn[] { unassignButtons });
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
        _assignedTasksDataGridView.Size = new Size(1225, 247);
        _assignedTasksDataGridView.TabIndex = 7;
        _assignedTasksDataGridView.CellContentClick += AssignedTasksDataGridView_CellContentClick;
        _assignedTasksDataGridView.CellEnter += AssignedTasksDataGridView_CellEnter;
        _assignedTasksDataGridView.CellValueChanged += AssignedTasksDataGridView_CellValueChanged;
        _assignedTasksDataGridView.ColumnAdded += AssignedTasksDataGridView_ColumnAdded;
        _assignedTasksDataGridView.KeyDown += AssignedTasksDataGridView_KeyDown;
        // 
        // unassignButtons
        // 
        unassignButtons.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        unassignButtons.FillWeight = 1F;
        unassignButtons.HeaderText = "";
        unassignButtons.MinimumWidth = 8;
        unassignButtons.Name = "unassignButtons";
        unassignButtons.Text = "✖";
        unassignButtons.UseColumnTextForButtonValue = true;
        unassignButtons.Width = 35;
        // 
        // assignedTaskSearchTableLayoutPanel
        // 
        assignedTaskSearchTableLayoutPanel.ColumnCount = 7;
        assignedTaskSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 188F));
        assignedTaskSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
        assignedTaskSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
        assignedTaskSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 132F));
        assignedTaskSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
        assignedTaskSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
        assignedTaskSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 235F));
        assignedTaskSearchTableLayoutPanel.Controls.Add(assignedTaskSearchPatternPanel, 1, 0);
        assignedTaskSearchTableLayoutPanel.Controls.Add(assignedTaskSearchPatternLabel, 0, 0);
        assignedTaskSearchTableLayoutPanel.Controls.Add(assignedTaskSearchByLabel, 3, 0);
        assignedTaskSearchTableLayoutPanel.Controls.Add(_assignedTaskSearchByComboBox, 4, 0);
        assignedTaskSearchTableLayoutPanel.Controls.Add(_assignedTaskSearchCountLabel, 6, 0);
        assignedTaskSearchTableLayoutPanel.Dock = DockStyle.Fill;
        assignedTaskSearchTableLayoutPanel.Location = new Point(3, 3);
        assignedTaskSearchTableLayoutPanel.Name = "assignedTaskSearchTableLayoutPanel";
        assignedTaskSearchTableLayoutPanel.RowCount = 1;
        assignedTaskSearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        assignedTaskSearchTableLayoutPanel.Size = new Size(1219, 44);
        assignedTaskSearchTableLayoutPanel.TabIndex = 0;
        // 
        // assignedTaskSearchPatternPanel
        // 
        assignedTaskSearchPatternPanel.BackColor = SystemColors.Window;
        assignedTaskSearchPatternPanel.BorderStyle = BorderStyle.FixedSingle;
        assignedTaskSearchPatternPanel.Controls.Add(_assignedTaskSearchPatternRichTextBox);
        assignedTaskSearchPatternPanel.Dock = DockStyle.Fill;
        assignedTaskSearchPatternPanel.Location = new Point(191, 3);
        assignedTaskSearchPatternPanel.Name = "assignedTaskSearchPatternPanel";
        assignedTaskSearchPatternPanel.Padding = new Padding(10, 0, 10, 0);
        assignedTaskSearchPatternPanel.Size = new Size(266, 38);
        assignedTaskSearchPatternPanel.TabIndex = 0;
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
        _assignedTaskSearchPatternRichTextBox.Size = new Size(244, 36);
        _assignedTaskSearchPatternRichTextBox.TabIndex = 9;
        _assignedTaskSearchPatternRichTextBox.Text = "";
        _assignedTaskSearchPatternRichTextBox.WordWrap = false;
        _assignedTaskSearchPatternRichTextBox.TextChanged += AssignedTaskSearchPatternRichTextBox_TextChanged;
        // 
        // assignedTaskSearchPatternLabel
        // 
        assignedTaskSearchPatternLabel.AutoSize = true;
        assignedTaskSearchPatternLabel.Dock = DockStyle.Fill;
        assignedTaskSearchPatternLabel.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        assignedTaskSearchPatternLabel.Location = new Point(3, 0);
        assignedTaskSearchPatternLabel.Name = "assignedTaskSearchPatternLabel";
        assignedTaskSearchPatternLabel.Size = new Size(182, 44);
        assignedTaskSearchPatternLabel.TabIndex = 0;
        assignedTaskSearchPatternLabel.Text = "Search Pattern";
        assignedTaskSearchPatternLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // assignedTaskSearchByLabel
        // 
        assignedTaskSearchByLabel.AutoSize = true;
        assignedTaskSearchByLabel.Dock = DockStyle.Fill;
        assignedTaskSearchByLabel.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        assignedTaskSearchByLabel.Location = new Point(488, 0);
        assignedTaskSearchByLabel.Name = "assignedTaskSearchByLabel";
        assignedTaskSearchByLabel.Size = new Size(126, 44);
        assignedTaskSearchByLabel.TabIndex = 21;
        assignedTaskSearchByLabel.Text = "Search By";
        assignedTaskSearchByLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // _assignedTaskSearchByComboBox
        // 
        _assignedTaskSearchByComboBox.Cursor = Cursors.Hand;
        _assignedTaskSearchByComboBox.Dock = DockStyle.Fill;
        _assignedTaskSearchByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        _assignedTaskSearchByComboBox.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _assignedTaskSearchByComboBox.ItemHeight = 29;
        _assignedTaskSearchByComboBox.Items.AddRange(new object[] { "Reference", "Description", "Training Category", "Type", "Training Started", "Training Completed", "Trainer Initials", "Certifier Initials", "Certifying Score", "Required Score" });
        _assignedTaskSearchByComboBox.Location = new Point(620, 3);
        _assignedTaskSearchByComboBox.Name = "_assignedTaskSearchByComboBox";
        _assignedTaskSearchByComboBox.Size = new Size(214, 37);
        _assignedTaskSearchByComboBox.TabIndex = 10;
        _assignedTaskSearchByComboBox.SelectedIndexChanged += AssignedTaskSearchByComboBox_SelectedIndexChanged;
        // 
        // _assignedTaskSearchCountLabel
        // 
        _assignedTaskSearchCountLabel.AutoSize = true;
        _assignedTaskSearchCountLabel.Dock = DockStyle.Fill;
        _assignedTaskSearchCountLabel.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _assignedTaskSearchCountLabel.ForeColor = SystemColors.GrayText;
        _assignedTaskSearchCountLabel.Location = new Point(986, 0);
        _assignedTaskSearchCountLabel.Name = "_assignedTaskSearchCountLabel";
        _assignedTaskSearchCountLabel.Size = new Size(230, 44);
        _assignedTaskSearchCountLabel.TabIndex = 0;
        _assignedTaskSearchCountLabel.TextAlign = ContentAlignment.MiddleRight;
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
        dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiCondensed", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
        _availableTasksDataGridView.Location = new Point(0, 372);
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
        _availableTasksDataGridView.Size = new Size(1225, 248);
        _availableTasksDataGridView.TabIndex = 8;
        _availableTasksDataGridView.CellMouseDoubleClick += AvailableTasksDataGridView_CellMouseDoubleClick;
        _availableTasksDataGridView.ColumnAdded += AvailableTasksDataGridView_ColumnAdded;
        _availableTasksDataGridView.KeyDown += AvailableTasksDataGridView_KeyDown;
        // 
        // availableTaskSearchTableLayoutPanel
        // 
        availableTaskSearchTableLayoutPanel.ColumnCount = 7;
        availableTaskSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 188F));
        availableTaskSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
        availableTaskSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
        availableTaskSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 132F));
        availableTaskSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
        availableTaskSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
        availableTaskSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 235F));
        availableTaskSearchTableLayoutPanel.Controls.Add(availableTaskSearchPatternPanel, 1, 0);
        availableTaskSearchTableLayoutPanel.Controls.Add(availableTaskSearchPatternLabel, 0, 0);
        availableTaskSearchTableLayoutPanel.Controls.Add(availableTaskSearchByLabel, 3, 0);
        availableTaskSearchTableLayoutPanel.Controls.Add(_availableTaskSearchByComboBox, 4, 0);
        availableTaskSearchTableLayoutPanel.Controls.Add(_availableTaskSearchCountLabel, 6, 0);
        availableTaskSearchTableLayoutPanel.Dock = DockStyle.Fill;
        availableTaskSearchTableLayoutPanel.Location = new Point(3, 325);
        availableTaskSearchTableLayoutPanel.Name = "availableTaskSearchTableLayoutPanel";
        availableTaskSearchTableLayoutPanel.RowCount = 1;
        availableTaskSearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        availableTaskSearchTableLayoutPanel.Size = new Size(1219, 44);
        availableTaskSearchTableLayoutPanel.TabIndex = 0;
        // 
        // availableTaskSearchPatternPanel
        // 
        availableTaskSearchPatternPanel.BackColor = SystemColors.Window;
        availableTaskSearchPatternPanel.BorderStyle = BorderStyle.FixedSingle;
        availableTaskSearchPatternPanel.Controls.Add(_availableTaskSearchPatternRichTextBox);
        availableTaskSearchPatternPanel.Dock = DockStyle.Fill;
        availableTaskSearchPatternPanel.Location = new Point(191, 3);
        availableTaskSearchPatternPanel.Name = "availableTaskSearchPatternPanel";
        availableTaskSearchPatternPanel.Padding = new Padding(10, 0, 10, 0);
        availableTaskSearchPatternPanel.Size = new Size(266, 38);
        availableTaskSearchPatternPanel.TabIndex = 0;
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
        _availableTaskSearchPatternRichTextBox.Size = new Size(244, 36);
        _availableTaskSearchPatternRichTextBox.TabIndex = 11;
        _availableTaskSearchPatternRichTextBox.Text = "";
        _availableTaskSearchPatternRichTextBox.WordWrap = false;
        _availableTaskSearchPatternRichTextBox.TextChanged += AvailableTaskSearchPatternRichTextBox_TextChanged;
        // 
        // availableTaskSearchPatternLabel
        // 
        availableTaskSearchPatternLabel.AutoSize = true;
        availableTaskSearchPatternLabel.Dock = DockStyle.Fill;
        availableTaskSearchPatternLabel.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        availableTaskSearchPatternLabel.Location = new Point(3, 0);
        availableTaskSearchPatternLabel.Name = "availableTaskSearchPatternLabel";
        availableTaskSearchPatternLabel.Size = new Size(182, 44);
        availableTaskSearchPatternLabel.TabIndex = 0;
        availableTaskSearchPatternLabel.Text = "Search Pattern";
        availableTaskSearchPatternLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // availableTaskSearchByLabel
        // 
        availableTaskSearchByLabel.AutoSize = true;
        availableTaskSearchByLabel.Dock = DockStyle.Fill;
        availableTaskSearchByLabel.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        availableTaskSearchByLabel.Location = new Point(488, 0);
        availableTaskSearchByLabel.Name = "availableTaskSearchByLabel";
        availableTaskSearchByLabel.Size = new Size(126, 44);
        availableTaskSearchByLabel.TabIndex = 0;
        availableTaskSearchByLabel.Text = "Search By";
        availableTaskSearchByLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // _availableTaskSearchByComboBox
        // 
        _availableTaskSearchByComboBox.Cursor = Cursors.Hand;
        _availableTaskSearchByComboBox.Dock = DockStyle.Fill;
        _availableTaskSearchByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        _availableTaskSearchByComboBox.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _availableTaskSearchByComboBox.ItemHeight = 29;
        _availableTaskSearchByComboBox.Items.AddRange(new object[] { "Reference", "Description", "Training Category", "Type", "Training Started", "Training Completed", "Trainer Initials", "Certifier Initials", "Certifying Score", "Required Score" });
        _availableTaskSearchByComboBox.Location = new Point(620, 3);
        _availableTaskSearchByComboBox.Name = "_availableTaskSearchByComboBox";
        _availableTaskSearchByComboBox.Size = new Size(214, 37);
        _availableTaskSearchByComboBox.TabIndex = 12;
        _availableTaskSearchByComboBox.SelectedIndexChanged += AvailableTaskSearchByComboBox_SelectedIndexChanged;
        // 
        // _availableTaskSearchCountLabel
        // 
        _availableTaskSearchCountLabel.AutoSize = true;
        _availableTaskSearchCountLabel.Dock = DockStyle.Fill;
        _availableTaskSearchCountLabel.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _availableTaskSearchCountLabel.ForeColor = SystemColors.GrayText;
        _availableTaskSearchCountLabel.Location = new Point(986, 0);
        _availableTaskSearchCountLabel.Name = "_availableTaskSearchCountLabel";
        _availableTaskSearchCountLabel.Size = new Size(230, 44);
        _availableTaskSearchCountLabel.TabIndex = 0;
        _availableTaskSearchCountLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // taskDatabaseLabel
        // 
        taskDatabaseLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        taskDatabaseLabel.AutoSize = true;
        taskDatabaseLabel.Location = new Point(25, 825);
        taskDatabaseLabel.Margin = new Padding(5, 0, 5, 0);
        taskDatabaseLabel.Name = "taskDatabaseLabel";
        taskDatabaseLabel.Size = new Size(221, 43);
        taskDatabaseLabel.TabIndex = 0;
        taskDatabaseLabel.Text = "Task Database";
        taskDatabaseLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // copyTaskDatabaseFilePathButton
        // 
        copyTaskDatabaseFilePathButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        copyTaskDatabaseFilePathButton.BackgroundImage = (Image)resources.GetObject("copyTaskDatabaseFilePathButton.BackgroundImage");
        copyTaskDatabaseFilePathButton.BackgroundImageLayout = ImageLayout.Zoom;
        copyTaskDatabaseFilePathButton.Cursor = Cursors.Hand;
        copyTaskDatabaseFilePathButton.Location = new Point(1022, 825);
        copyTaskDatabaseFilePathButton.Margin = new Padding(0, 3, 3, 3);
        copyTaskDatabaseFilePathButton.Name = "copyTaskDatabaseFilePathButton";
        copyTaskDatabaseFilePathButton.Size = new Size(51, 51);
        copyTaskDatabaseFilePathButton.TabIndex = 3;
        copyTaskDatabaseFilePathButton.UseVisualStyleBackColor = true;
        copyTaskDatabaseFilePathButton.Click += CopyTaskDatabaseFilePathButton_Click;
        // 
        // _selectTaskDatabaseButton
        // 
        _selectTaskDatabaseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _selectTaskDatabaseButton.AutoSize = true;
        _selectTaskDatabaseButton.Cursor = Cursors.Hand;
        _selectTaskDatabaseButton.Location = new Point(1079, 825);
        _selectTaskDatabaseButton.Name = "_selectTaskDatabaseButton";
        _selectTaskDatabaseButton.Size = new Size(186, 53);
        _selectTaskDatabaseButton.TabIndex = 2;
        _selectTaskDatabaseButton.Text = "Select File";
        _selectTaskDatabaseButton.UseVisualStyleBackColor = true;
        _selectTaskDatabaseButton.Click += SelectTaskDatabaseButton_Click;
        // 
        // ProjectEditorUserControl
        // 
        AutoScaleDimensions = new SizeF(17F, 43F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        Controls.Add(tasksTableLayoutPanel);
        Controls.Add(taskDatabasePathPanel);
        Controls.Add(profileTableLayout);
        Controls.Add(copyTaskDatabaseFilePathButton);
        Controls.Add(_selectTaskDatabaseButton);
        Controls.Add(taskDatabaseLabel);
        Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(5);
        Name = "ProjectEditorUserControl";
        Size = new Size(1300, 900);
        Load += ProjectEditorUserControl_Load;
        profileTableLayout.ResumeLayout(false);
        managerPanel.ResumeLayout(false);
        coursePanel.ResumeLayout(false);
        positionPanel.ResumeLayout(false);
        traineePanel.ResumeLayout(false);
        taskDatabasePathPanel.ResumeLayout(false);
        tasksTableLayoutPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)_assignedTasksDataGridView).EndInit();
        assignedTaskSearchTableLayoutPanel.ResumeLayout(false);
        assignedTaskSearchTableLayoutPanel.PerformLayout();
        assignedTaskSearchPatternPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)_availableTasksDataGridView).EndInit();
        availableTaskSearchTableLayoutPanel.ResumeLayout(false);
        availableTaskSearchTableLayoutPanel.PerformLayout();
        availableTaskSearchPatternPanel.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button _selectTaskDatabaseButton;
    private Label _taskDatabasePathLabel;
    private RichTextBox _courseRichTextBox;
    private RichTextBox _positionRichTextBox;
    private RichTextBox _managerRichTextBox;
    private RichTextBox _traineeRichTextBox;
    private DataGridView _assignedTasksDataGridView;
    private DataGridView _availableTasksDataGridView;
    private DataGridViewButtonColumn unassignButtons;
    private RichTextBox _assignedTaskSearchPatternRichTextBox;
    private ComboBox _assignedTaskSearchByComboBox;
    private RichTextBox _availableTaskSearchPatternRichTextBox;
    private ComboBox _availableTaskSearchByComboBox;
    private Label _assignedTaskSearchCountLabel;
    private Label _availableTaskSearchCountLabel;
}
