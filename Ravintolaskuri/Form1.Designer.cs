namespace Ravintolaskuri
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CustomButton.GrayButton grayBtn = new CustomButton.GrayButton();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelFood = new System.Windows.Forms.Label();
            this.solidsBox = new System.Windows.Forms.ListBox();
            this.labelDrink = new System.Windows.Forms.Label();
            this.drinksBox = new System.Windows.Forms.ListBox();
            this.labelSupplement = new System.Windows.Forms.Label();
            this.supplementsBox = new System.Windows.Forms.ListBox();
            this.labelExtra = new System.Windows.Forms.Label();
            this.extrasBox = new System.Windows.Forms.ListBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.formattingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatFoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatDiaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFoodsBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDiaryBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.loadFoodsBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDiaryBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodEditInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diaryInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogFoods = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogDiary = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogFoods = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogDiary = new System.Windows.Forms.OpenFileDialog();
            this.tabControl = new Dotnetrix_Samples.TabControl();
            this.tabPageCalculator = new System.Windows.Forms.TabPage();
            this.groupBoxSelected = new System.Windows.Forms.GroupBox();
            this.btnClearSelected = new CustomButton.XButton1();
            this.selectedFoodsBox = new System.Windows.Forms.ListBox();
            this.groupBoxFood = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelKcal = new System.Windows.Forms.Label();
            this.labelProtein = new System.Windows.Forms.Label();
            this.labelCarbs = new System.Windows.Forms.Label();
            this.labelFat = new System.Windows.Forms.Label();
            this.labelSFat = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.groupBoxProgressbar = new System.Windows.Forms.GroupBox();
            this.progressLabel = new System.Windows.Forms.Label();
            this.textBoxTargetKcal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressLabelTarget = new System.Windows.Forms.Label();
            this.progressLabel1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelSelectedName = new System.Windows.Forms.Label();
            this.groupBoxShares = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelProteinShare = new System.Windows.Forms.Label();
            this.labelCarbsShare = new System.Windows.Forms.Label();
            this.labelFatShare = new System.Windows.Forms.Label();
            this.groupBoxSums = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelKcalSum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelProteinSum = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelCarbsSum = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelFatSum = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelSFatSum = new System.Windows.Forms.Label();
            this.tabPageDGV = new System.Windows.Forms.TabPage();
            this.btnSave = new CustomButton.XButton1();
            this.btnDelete = new CustomButton.XButton1();
            this.btnAdd = new CustomButton.XButton1();
            this.dataGridViewFoods = new System.Windows.Forms.DataGridView();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kcal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SFat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageDiary = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBoxDiaryDay = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDeleteFromDiary = new CustomButton.XButton1();
            this.btnAddToDiary = new CustomButton.XButton1();
            this.labelDiarySFat = new System.Windows.Forms.Label();
            this.labelDiaryFat = new System.Windows.Forms.Label();
            this.labelDiaryCarbs = new System.Windows.Forms.Label();
            this.labelDiaryProtein = new System.Windows.Forms.Label();
            this.labelDiaryKcal = new System.Windows.Forms.Label();
            this.groupBoxRadio = new System.Windows.Forms.GroupBox();
            this.radioSFat = new System.Windows.Forms.RadioButton();
            this.radioFat = new System.Windows.Forms.RadioButton();
            this.radioCarbs = new System.Windows.Forms.RadioButton();
            this.radioProtein = new System.Windows.Forms.RadioButton();
            this.radioKcal = new System.Windows.Forms.RadioButton();
            this.groupBoxDiagram = new System.Windows.Forms.GroupBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelEnergyCheck = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageCalculator.SuspendLayout();
            this.groupBoxSelected.SuspendLayout();
            this.groupBoxFood.SuspendLayout();
            this.groupBoxProgressbar.SuspendLayout();
            this.groupBoxShares.SuspendLayout();
            this.groupBoxSums.SuspendLayout();
            this.tabPageDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoods)).BeginInit();
            this.tabPageDiary.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxDiaryDay.SuspendLayout();
            this.groupBoxRadio.SuspendLayout();
            this.groupBoxDiagram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.ForeColor = System.Drawing.Color.White;
            this.labelFood.Location = new System.Drawing.Point(12, 33);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(36, 13);
            this.labelFood.TabIndex = 0;
            this.labelFood.Text = "Ruoat";
            // 
            // solidsBox
            // 
            this.solidsBox.BackColor = System.Drawing.Color.LightGray;
            this.solidsBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.solidsBox.FormattingEnabled = true;
            this.solidsBox.Location = new System.Drawing.Point(15, 49);
            this.solidsBox.Name = "solidsBox";
            this.solidsBox.Size = new System.Drawing.Size(147, 121);
            this.solidsBox.TabIndex = 1;
            this.solidsBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.solidsBox_DrawItem);
            this.solidsBox.SelectedIndexChanged += new System.EventHandler(this.solidsBox_SelectedIndexChanged);
            this.solidsBox.DoubleClick += new System.EventHandler(this.solidBox_DoubleClick);
            // 
            // labelDrink
            // 
            this.labelDrink.AutoSize = true;
            this.labelDrink.ForeColor = System.Drawing.Color.White;
            this.labelDrink.Location = new System.Drawing.Point(12, 193);
            this.labelDrink.Name = "labelDrink";
            this.labelDrink.Size = new System.Drawing.Size(41, 13);
            this.labelDrink.TabIndex = 2;
            this.labelDrink.Text = "Juomat";
            // 
            // drinksBox
            // 
            this.drinksBox.BackColor = System.Drawing.Color.LightGray;
            this.drinksBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drinksBox.FormattingEnabled = true;
            this.drinksBox.Location = new System.Drawing.Point(15, 209);
            this.drinksBox.Name = "drinksBox";
            this.drinksBox.Size = new System.Drawing.Size(147, 121);
            this.drinksBox.TabIndex = 3;
            this.drinksBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.drinksBox_DrawItem);
            this.drinksBox.SelectedIndexChanged += new System.EventHandler(this.drinksBox_SelectedIndexChanged);
            this.drinksBox.DoubleClick += new System.EventHandler(this.drinksBox_DoubleClick);
            // 
            // labelSupplement
            // 
            this.labelSupplement.AutoSize = true;
            this.labelSupplement.ForeColor = System.Drawing.Color.White;
            this.labelSupplement.Location = new System.Drawing.Point(12, 354);
            this.labelSupplement.Name = "labelSupplement";
            this.labelSupplement.Size = new System.Drawing.Size(67, 13);
            this.labelSupplement.TabIndex = 4;
            this.labelSupplement.Text = "Lisäravinteet";
            // 
            // supplementsBox
            // 
            this.supplementsBox.BackColor = System.Drawing.Color.LightGray;
            this.supplementsBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.supplementsBox.FormattingEnabled = true;
            this.supplementsBox.Location = new System.Drawing.Point(15, 370);
            this.supplementsBox.Name = "supplementsBox";
            this.supplementsBox.Size = new System.Drawing.Size(147, 121);
            this.supplementsBox.TabIndex = 5;
            this.supplementsBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.supplementsBox_DrawItem);
            this.supplementsBox.SelectedIndexChanged += new System.EventHandler(this.supplementsBox_SelectedIndexChanged);
            this.supplementsBox.DoubleClick += new System.EventHandler(this.supplementsBox_DoubleClick);
            // 
            // labelExtra
            // 
            this.labelExtra.AutoSize = true;
            this.labelExtra.ForeColor = System.Drawing.Color.White;
            this.labelExtra.Location = new System.Drawing.Point(12, 512);
            this.labelExtra.Name = "labelExtra";
            this.labelExtra.Size = new System.Drawing.Size(121, 13);
            this.labelExtra.TabIndex = 6;
            this.labelExtra.Text = "Lisukkeet, hedelmät ym.";
            // 
            // extrasBox
            // 
            this.extrasBox.BackColor = System.Drawing.Color.LightGray;
            this.extrasBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.extrasBox.FormattingEnabled = true;
            this.extrasBox.Location = new System.Drawing.Point(15, 528);
            this.extrasBox.Name = "extrasBox";
            this.extrasBox.Size = new System.Drawing.Size(147, 121);
            this.extrasBox.TabIndex = 7;
            this.extrasBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.extrasBox_DrawItem);
            this.extrasBox.SelectedIndexChanged += new System.EventHandler(this.extrasBox_SelectedIndexChanged);
            this.extrasBox.DoubleClick += new System.EventHandler(this.extrasBox_DoubleClick);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formattingToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.instructionToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(858, 24);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip1";
            // 
            // formattingToolStripMenuItem
            // 
            this.formattingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatFoodsToolStripMenuItem,
            this.formatDiaryToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.formattingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.formattingToolStripMenuItem.Name = "formattingToolStripMenuItem";
            this.formattingToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.formattingToolStripMenuItem.Text = "Tyhjennys";
            // 
            // formatFoodsToolStripMenuItem
            // 
            this.formatFoodsToolStripMenuItem.Image = global::Ravintolaskuri.Properties.Resources.close3;
            this.formatFoodsToolStripMenuItem.Name = "formatFoodsToolStripMenuItem";
            this.formatFoodsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.formatFoodsToolStripMenuItem.Text = "Tyhjennä ruokataulu";
            this.formatFoodsToolStripMenuItem.Click += new System.EventHandler(this.formatFoodsToolStripMenuItem_Click);
            // 
            // formatDiaryToolStripMenuItem
            // 
            this.formatDiaryToolStripMenuItem.Image = global::Ravintolaskuri.Properties.Resources.close3;
            this.formatDiaryToolStripMenuItem.Name = "formatDiaryToolStripMenuItem";
            this.formatDiaryToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.formatDiaryToolStripMenuItem.Text = "Tyhjennä päiväkirja";
            this.formatDiaryToolStripMenuItem.Click += new System.EventHandler(this.formatDiaryToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Ravintolaskuri.Properties.Resources.close;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exitToolStripMenuItem.Text = "Sulje";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createFoodsBackupToolStripMenuItem,
            this.createDiaryBackupToolStripMenuItem,
            this.toolStripSeparator2,
            this.loadFoodsBackupToolStripMenuItem,
            this.loadDiaryBackupToolStripMenuItem});
            this.backupToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.backupToolStripMenuItem.Text = "Varmuuskopio";
            // 
            // createFoodsBackupToolStripMenuItem
            // 
            this.createFoodsBackupToolStripMenuItem.Image = global::Ravintolaskuri.Properties.Resources._out;
            this.createFoodsBackupToolStripMenuItem.Name = "createFoodsBackupToolStripMenuItem";
            this.createFoodsBackupToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.createFoodsBackupToolStripMenuItem.Text = "Luo laskurin varmuuskopio";
            this.createFoodsBackupToolStripMenuItem.Click += new System.EventHandler(this.createFoodsBackupToolStripMenuItem_Click);
            // 
            // createDiaryBackupToolStripMenuItem
            // 
            this.createDiaryBackupToolStripMenuItem.Image = global::Ravintolaskuri.Properties.Resources._out;
            this.createDiaryBackupToolStripMenuItem.Name = "createDiaryBackupToolStripMenuItem";
            this.createDiaryBackupToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.createDiaryBackupToolStripMenuItem.Text = "Luo päiväkirjan varmuuskopio";
            this.createDiaryBackupToolStripMenuItem.Click += new System.EventHandler(this.createDiaryBackupToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(238, 6);
            // 
            // loadFoodsBackupToolStripMenuItem
            // 
            this.loadFoodsBackupToolStripMenuItem.Image = global::Ravintolaskuri.Properties.Resources._in;
            this.loadFoodsBackupToolStripMenuItem.Name = "loadFoodsBackupToolStripMenuItem";
            this.loadFoodsBackupToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.loadFoodsBackupToolStripMenuItem.Text = "Lataa laskuri varmuuskopio";
            this.loadFoodsBackupToolStripMenuItem.Click += new System.EventHandler(this.loadFoodsBackupToolStripMenuItem_Click);
            // 
            // loadDiaryBackupToolStripMenuItem
            // 
            this.loadDiaryBackupToolStripMenuItem.Image = global::Ravintolaskuri.Properties.Resources._in;
            this.loadDiaryBackupToolStripMenuItem.Name = "loadDiaryBackupToolStripMenuItem";
            this.loadDiaryBackupToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.loadDiaryBackupToolStripMenuItem.Text = "Lataa päiväkirjan varmuuskopio";
            this.loadDiaryBackupToolStripMenuItem.Click += new System.EventHandler(this.loadDiaryBackupToolStripMenuItem_Click);
            // 
            // instructionToolStripMenuItem
            // 
            this.instructionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorInfoToolStripMenuItem,
            this.foodEditInfoToolStripMenuItem,
            this.diaryInfoToolStripMenuItem,
            this.backupInfoToolStripMenuItem});
            this.instructionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.instructionToolStripMenuItem.Name = "instructionToolStripMenuItem";
            this.instructionToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.instructionToolStripMenuItem.Text = "Ohje";
            // 
            // calculatorInfoToolStripMenuItem
            // 
            this.calculatorInfoToolStripMenuItem.Image = global::Ravintolaskuri.Properties.Resources.q3;
            this.calculatorInfoToolStripMenuItem.Name = "calculatorInfoToolStripMenuItem";
            this.calculatorInfoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.calculatorInfoToolStripMenuItem.Text = "Laskuri";
            this.calculatorInfoToolStripMenuItem.Click += new System.EventHandler(this.calculatorInfoToolStripMenuItem_Click);
            // 
            // foodEditInfoToolStripMenuItem
            // 
            this.foodEditInfoToolStripMenuItem.Image = global::Ravintolaskuri.Properties.Resources.q3;
            this.foodEditInfoToolStripMenuItem.Name = "foodEditInfoToolStripMenuItem";
            this.foodEditInfoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.foodEditInfoToolStripMenuItem.Text = "Ruokien muokkaus";
            this.foodEditInfoToolStripMenuItem.Click += new System.EventHandler(this.foodEditInfoToolStripMenuItem_Click);
            // 
            // diaryInfoToolStripMenuItem
            // 
            this.diaryInfoToolStripMenuItem.Image = global::Ravintolaskuri.Properties.Resources.q3;
            this.diaryInfoToolStripMenuItem.Name = "diaryInfoToolStripMenuItem";
            this.diaryInfoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.diaryInfoToolStripMenuItem.Text = "Makropäiväkirja";
            this.diaryInfoToolStripMenuItem.Click += new System.EventHandler(this.diaryInfoToolStripMenuItem_Click);
            // 
            // backupInfoToolStripMenuItem
            // 
            this.backupInfoToolStripMenuItem.Image = global::Ravintolaskuri.Properties.Resources.q3;
            this.backupInfoToolStripMenuItem.Name = "backupInfoToolStripMenuItem";
            this.backupInfoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.backupInfoToolStripMenuItem.Text = "Varmuuskopiointi";
            this.backupInfoToolStripMenuItem.Click += new System.EventHandler(this.backupInfoToolStripMenuItem_Click);
            // 
            // saveFileDialogFoods
            // 
            this.saveFileDialogFoods.FileName = "FoodBackup.json";
            this.saveFileDialogFoods.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // saveFileDialogDiary
            // 
            this.saveFileDialogDiary.FileName = "DiaryBackup.json";
            this.saveFileDialogDiary.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog2_FileOk);
            // 
            // openFileDialogFoods
            // 
            this.openFileDialogFoods.FileName = "FoodBackup.json";
            // 
            // openFileDialogDiary
            // 
            this.openFileDialogDiary.FileName = "DiaryBackup.json";
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabControl.Controls.Add(this.tabPageCalculator);
            this.tabControl.Controls.Add(this.tabPageDGV);
            this.tabControl.Controls.Add(this.tabPageDiary);
            this.tabControl.Location = new System.Drawing.Point(182, 49);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(665, 600);
            this.tabControl.TabIndex = 11;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabPageCalculator
            // 
            this.tabPageCalculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageCalculator.Controls.Add(this.groupBoxSelected);
            this.tabPageCalculator.Controls.Add(this.groupBoxFood);
            this.tabPageCalculator.Controls.Add(this.groupBoxProgressbar);
            this.tabPageCalculator.Controls.Add(this.labelSelectedName);
            this.tabPageCalculator.Controls.Add(this.groupBoxShares);
            this.tabPageCalculator.Controls.Add(this.groupBoxSums);
            this.tabPageCalculator.ForeColor = System.Drawing.Color.White;
            this.tabPageCalculator.Location = new System.Drawing.Point(4, 25);
            this.tabPageCalculator.Name = "tabPageCalculator";
            this.tabPageCalculator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCalculator.Size = new System.Drawing.Size(657, 571);
            this.tabPageCalculator.TabIndex = 0;
            this.tabPageCalculator.Text = "Laskuri";
            // 
            // groupBoxSelected
            // 
            this.groupBoxSelected.Controls.Add(this.btnClearSelected);
            this.groupBoxSelected.Controls.Add(this.selectedFoodsBox);
            this.groupBoxSelected.ForeColor = System.Drawing.Color.White;
            this.groupBoxSelected.Location = new System.Drawing.Point(352, 42);
            this.groupBoxSelected.Name = "groupBoxSelected";
            this.groupBoxSelected.Size = new System.Drawing.Size(278, 443);
            this.groupBoxSelected.TabIndex = 28;
            this.groupBoxSelected.TabStop = false;
            this.groupBoxSelected.Text = "Valitut ruoat";
            // 
            // btnClearSelected
            // 
            this.btnClearSelected.ColorTable = grayBtn;            
            this.btnClearSelected.Location = new System.Drawing.Point(103, 410);
            this.btnClearSelected.Name = "btnClearSelected";
            this.btnClearSelected.Size = new System.Drawing.Size(75, 23);
            this.btnClearSelected.TabIndex = 24;
            this.btnClearSelected.Text = "Tyhjennä";
            this.btnClearSelected.Theme = CustomButton.Theme.BUTTON_GRAY;
            this.btnClearSelected.UseVisualStyleBackColor = true;
            this.btnClearSelected.Click += new System.EventHandler(this.btnClearSelected_Click_1);
            // 
            // selectedFoodsBox
            // 
            this.selectedFoodsBox.BackColor = System.Drawing.Color.LightGray;
            this.selectedFoodsBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectedFoodsBox.FormattingEnabled = true;
            this.selectedFoodsBox.Location = new System.Drawing.Point(18, 19);
            this.selectedFoodsBox.Name = "selectedFoodsBox";
            this.selectedFoodsBox.Size = new System.Drawing.Size(242, 381);
            this.selectedFoodsBox.TabIndex = 15;
            this.selectedFoodsBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.selectedFoodsBox_DrawItem);
            this.selectedFoodsBox.DoubleClick += new System.EventHandler(this.selectedFoodBox_DoubleClick);
            // 
            // groupBoxFood
            // 
            this.groupBoxFood.Controls.Add(this.label6);
            this.groupBoxFood.Controls.Add(this.label5);
            this.groupBoxFood.Controls.Add(this.label4);
            this.groupBoxFood.Controls.Add(this.label3);
            this.groupBoxFood.Controls.Add(this.label2);
            this.groupBoxFood.Controls.Add(this.labelKcal);
            this.groupBoxFood.Controls.Add(this.labelProtein);
            this.groupBoxFood.Controls.Add(this.labelCarbs);
            this.groupBoxFood.Controls.Add(this.labelFat);
            this.groupBoxFood.Controls.Add(this.labelSFat);
            this.groupBoxFood.Controls.Add(this.labelInfo);
            this.groupBoxFood.ForeColor = System.Drawing.Color.White;
            this.groupBoxFood.Location = new System.Drawing.Point(22, 42);
            this.groupBoxFood.Name = "groupBoxFood";
            this.groupBoxFood.Size = new System.Drawing.Size(225, 164);
            this.groupBoxFood.TabIndex = 25;
            this.groupBoxFood.TabStop = false;
            this.groupBoxFood.Text = "Ravintoarvot";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tyydyttyneet rasvat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Rasvat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Hiilihydraatit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Proteiinit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kalorit:";
            // 
            // labelKcal
            // 
            this.labelKcal.AutoSize = true;
            this.labelKcal.Location = new System.Drawing.Point(141, 28);
            this.labelKcal.Name = "labelKcal";
            this.labelKcal.Size = new System.Drawing.Size(0, 13);
            this.labelKcal.TabIndex = 1;
            // 
            // labelProtein
            // 
            this.labelProtein.AutoSize = true;
            this.labelProtein.Location = new System.Drawing.Point(141, 48);
            this.labelProtein.Name = "labelProtein";
            this.labelProtein.Size = new System.Drawing.Size(0, 13);
            this.labelProtein.TabIndex = 2;
            // 
            // labelCarbs
            // 
            this.labelCarbs.AutoSize = true;
            this.labelCarbs.Location = new System.Drawing.Point(141, 68);
            this.labelCarbs.Name = "labelCarbs";
            this.labelCarbs.Size = new System.Drawing.Size(0, 13);
            this.labelCarbs.TabIndex = 3;
            // 
            // labelFat
            // 
            this.labelFat.AutoSize = true;
            this.labelFat.Location = new System.Drawing.Point(141, 88);
            this.labelFat.Name = "labelFat";
            this.labelFat.Size = new System.Drawing.Size(0, 13);
            this.labelFat.TabIndex = 4;
            // 
            // labelSFat
            // 
            this.labelSFat.AutoSize = true;
            this.labelSFat.Location = new System.Drawing.Point(141, 108);
            this.labelSFat.Name = "labelSFat";
            this.labelSFat.Size = new System.Drawing.Size(0, 13);
            this.labelSFat.TabIndex = 5;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(10, 138);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(31, 13);
            this.labelInfo.TabIndex = 17;
            this.labelInfo.Text = "Info: ";
            // 
            // groupBoxProgressbar
            // 
            this.groupBoxProgressbar.Controls.Add(this.progressLabel);
            this.groupBoxProgressbar.Controls.Add(this.textBoxTargetKcal);
            this.groupBoxProgressbar.Controls.Add(this.label1);
            this.groupBoxProgressbar.Controls.Add(this.progressLabelTarget);
            this.groupBoxProgressbar.Controls.Add(this.progressLabel1);
            this.groupBoxProgressbar.Controls.Add(this.progressBar);
            this.groupBoxProgressbar.ForeColor = System.Drawing.Color.White;
            this.groupBoxProgressbar.Location = new System.Drawing.Point(22, 492);
            this.groupBoxProgressbar.Name = "groupBoxProgressbar";
            this.groupBoxProgressbar.Size = new System.Drawing.Size(608, 71);
            this.groupBoxProgressbar.TabIndex = 27;
            this.groupBoxProgressbar.TabStop = false;
            this.groupBoxProgressbar.Text = "Kalorimittari";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.BackColor = System.Drawing.Color.Lime;
            this.progressLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressLabel.Location = new System.Drawing.Point(243, 45);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(38, 15);
            this.progressLabel.TabIndex = 22;
            this.progressLabel.Text = "0 kcal";
            // 
            // textBoxTargetKcal
            // 
            this.textBoxTargetKcal.BackColor = System.Drawing.Color.LightGray;
            this.textBoxTargetKcal.Location = new System.Drawing.Point(508, 42);
            this.textBoxTargetKcal.Name = "textBoxTargetKcal";
            this.textBoxTargetKcal.Size = new System.Drawing.Size(73, 20);
            this.textBoxTargetKcal.TabIndex = 18;
            this.textBoxTargetKcal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKcal_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tavoite kcal";
            // 
            // progressLabelTarget
            // 
            this.progressLabelTarget.AutoSize = true;
            this.progressLabelTarget.Location = new System.Drawing.Point(442, 23);
            this.progressLabelTarget.Name = "progressLabelTarget";
            this.progressLabelTarget.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressLabelTarget.Size = new System.Drawing.Size(42, 13);
            this.progressLabelTarget.TabIndex = 21;
            this.progressLabelTarget.Text = "     kcal";
            // 
            // progressLabel1
            // 
            this.progressLabel1.AutoSize = true;
            this.progressLabel1.Location = new System.Drawing.Point(14, 23);
            this.progressLabel1.Name = "progressLabel1";
            this.progressLabel1.Size = new System.Drawing.Size(36, 13);
            this.progressLabel1.TabIndex = 20;
            this.progressLabel1.Text = "0 kcal";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(14, 39);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(474, 26);
            this.progressBar.TabIndex = 8;
            // 
            // labelSelectedName
            // 
            this.labelSelectedName.AutoSize = true;
            this.labelSelectedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedName.ForeColor = System.Drawing.Color.White;
            this.labelSelectedName.Location = new System.Drawing.Point(30, 9);
            this.labelSelectedName.Name = "labelSelectedName";
            this.labelSelectedName.Size = new System.Drawing.Size(211, 25);
            this.labelSelectedName.TabIndex = 0;
            this.labelSelectedName.Text = "TESTTESTTESTEST";
            // 
            // groupBoxShares
            // 
            this.groupBoxShares.Controls.Add(this.labelEnergyCheck);
            this.groupBoxShares.Controls.Add(this.label14);
            this.groupBoxShares.Controls.Add(this.label13);
            this.groupBoxShares.Controls.Add(this.label12);
            this.groupBoxShares.Controls.Add(this.labelProteinShare);
            this.groupBoxShares.Controls.Add(this.labelCarbsShare);
            this.groupBoxShares.Controls.Add(this.labelFatShare);
            this.groupBoxShares.ForeColor = System.Drawing.Color.White;
            this.groupBoxShares.Location = new System.Drawing.Point(22, 359);
            this.groupBoxShares.Name = "groupBoxShares";
            this.groupBoxShares.Size = new System.Drawing.Size(225, 126);
            this.groupBoxShares.TabIndex = 26;
            this.groupBoxShares.TabStop = false;
            this.groupBoxShares.Text = "Prosentuaalinen osuus energiasta";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Rasvat:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Hiilihydraatit:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Proteiinit:";
            // 
            // labelProteinShare
            // 
            this.labelProteinShare.AutoSize = true;
            this.labelProteinShare.Location = new System.Drawing.Point(141, 28);
            this.labelProteinShare.Name = "labelProteinShare";
            this.labelProteinShare.Size = new System.Drawing.Size(0, 13);
            this.labelProteinShare.TabIndex = 12;
            // 
            // labelCarbsShare
            // 
            this.labelCarbsShare.AutoSize = true;
            this.labelCarbsShare.Location = new System.Drawing.Point(141, 48);
            this.labelCarbsShare.Name = "labelCarbsShare";
            this.labelCarbsShare.Size = new System.Drawing.Size(0, 13);
            this.labelCarbsShare.TabIndex = 13;
            // 
            // labelFatShare
            // 
            this.labelFatShare.AutoSize = true;
            this.labelFatShare.Location = new System.Drawing.Point(141, 68);
            this.labelFatShare.Name = "labelFatShare";
            this.labelFatShare.Size = new System.Drawing.Size(0, 13);
            this.labelFatShare.TabIndex = 14;
            // 
            // groupBoxSums
            // 
            this.groupBoxSums.Controls.Add(this.label7);
            this.groupBoxSums.Controls.Add(this.labelKcalSum);
            this.groupBoxSums.Controls.Add(this.label8);
            this.groupBoxSums.Controls.Add(this.labelProteinSum);
            this.groupBoxSums.Controls.Add(this.label9);
            this.groupBoxSums.Controls.Add(this.labelCarbsSum);
            this.groupBoxSums.Controls.Add(this.label10);
            this.groupBoxSums.Controls.Add(this.labelFatSum);
            this.groupBoxSums.Controls.Add(this.label11);
            this.groupBoxSums.Controls.Add(this.labelSFatSum);
            this.groupBoxSums.ForeColor = System.Drawing.Color.White;
            this.groupBoxSums.Location = new System.Drawing.Point(22, 212);
            this.groupBoxSums.Name = "groupBoxSums";
            this.groupBoxSums.Size = new System.Drawing.Size(225, 141);
            this.groupBoxSums.TabIndex = 24;
            this.groupBoxSums.TabStop = false;
            this.groupBoxSums.Text = "Yhteensä";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tyydyttyneet rasvat:";
            // 
            // labelKcalSum
            // 
            this.labelKcalSum.AutoSize = true;
            this.labelKcalSum.Location = new System.Drawing.Point(141, 28);
            this.labelKcalSum.Name = "labelKcalSum";
            this.labelKcalSum.Size = new System.Drawing.Size(0, 13);
            this.labelKcalSum.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Rasvat";
            // 
            // labelProteinSum
            // 
            this.labelProteinSum.AutoSize = true;
            this.labelProteinSum.Location = new System.Drawing.Point(141, 48);
            this.labelProteinSum.Name = "labelProteinSum";
            this.labelProteinSum.Size = new System.Drawing.Size(0, 13);
            this.labelProteinSum.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Hiilihydraatit";
            // 
            // labelCarbsSum
            // 
            this.labelCarbsSum.AutoSize = true;
            this.labelCarbsSum.Location = new System.Drawing.Point(141, 68);
            this.labelCarbsSum.Name = "labelCarbsSum";
            this.labelCarbsSum.Size = new System.Drawing.Size(0, 13);
            this.labelCarbsSum.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Proteiinit:";
            // 
            // labelFatSum
            // 
            this.labelFatSum.AutoSize = true;
            this.labelFatSum.Location = new System.Drawing.Point(141, 88);
            this.labelFatSum.Name = "labelFatSum";
            this.labelFatSum.Size = new System.Drawing.Size(0, 13);
            this.labelFatSum.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Kalorit:";
            // 
            // labelSFatSum
            // 
            this.labelSFatSum.AutoSize = true;
            this.labelSFatSum.Location = new System.Drawing.Point(141, 108);
            this.labelSFatSum.Name = "labelSFatSum";
            this.labelSFatSum.Size = new System.Drawing.Size(0, 13);
            this.labelSFatSum.TabIndex = 10;
            // 
            // tabPageDGV
            // 
            this.tabPageDGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageDGV.Controls.Add(this.btnSave);
            this.tabPageDGV.Controls.Add(this.btnDelete);
            this.tabPageDGV.Controls.Add(this.btnAdd);
            this.tabPageDGV.Controls.Add(this.dataGridViewFoods);
            this.tabPageDGV.ForeColor = System.Drawing.Color.White;
            this.tabPageDGV.Location = new System.Drawing.Point(4, 25);
            this.tabPageDGV.Name = "tabPageDGV";
            this.tabPageDGV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDGV.Size = new System.Drawing.Size(657, 571);
            this.tabPageDGV.TabIndex = 1;
            this.tabPageDGV.Text = "Ruokataulukko";
            // 
            // btnSave
            // 
            this.btnSave.ColorTable = grayBtn;
            this.btnSave.Location = new System.Drawing.Point(513, 542);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 23);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Tallenna tiedot";
            this.btnSave.Theme = CustomButton.Theme.BUTTON_GRAY;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.ColorTable = grayBtn;
            this.btnDelete.Location = new System.Drawing.Point(88, 542);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Poista";
            this.btnDelete.Theme = CustomButton.Theme.BUTTON_GRAY;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.ColorTable = grayBtn;
            this.btnAdd.Location = new System.Drawing.Point(7, 542);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Lisää";
            this.btnAdd.Theme = CustomButton.Theme.BUTTON_GRAY;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // dataGridViewFoods
            // 
            this.dataGridViewFoods.AllowUserToAddRows = false;
            this.dataGridViewFoods.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewFoods.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFoods.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewFoods.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFoods.ColumnHeadersHeight = 21;
            this.dataGridViewFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewFoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodName,
            this.Kcal,
            this.Protein,
            this.Carbs,
            this.Fat,
            this.SFat,
            this.Category,
            this.Info});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFoods.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewFoods.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewFoods.Location = new System.Drawing.Point(7, 6);
            this.dataGridViewFoods.MultiSelect = false;
            this.dataGridViewFoods.Name = "dataGridViewFoods";
            this.dataGridViewFoods.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFoods.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewFoods.RowHeadersWidth = 40;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewFoods.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewFoods.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewFoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFoods.Size = new System.Drawing.Size(644, 532);
            this.dataGridViewFoods.TabIndex = 33;
            this.dataGridViewFoods.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewFoods_CellBeginEdit);
            this.dataGridViewFoods.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRuoka_CellEndEdit);
            this.dataGridViewFoods.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewFoods_CellValidating);
            this.dataGridViewFoods.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewFoods_RowValidating);
            // 
            // FoodName
            // 
            this.FoodName.DataPropertyName = "FoodName";
            this.FoodName.HeaderText = "Ruoka";
            this.FoodName.MaxInputLength = 40;
            this.FoodName.Name = "FoodName";
            this.FoodName.Width = 150;
            // 
            // Kcal
            // 
            this.Kcal.DataPropertyName = "Kcal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Kcal.DefaultCellStyle = dataGridViewCellStyle3;
            this.Kcal.HeaderText = "kcal";
            this.Kcal.MaxInputLength = 4;
            this.Kcal.Name = "Kcal";
            this.Kcal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Kcal.Width = 40;
            // 
            // Protein
            // 
            this.Protein.DataPropertyName = "Protein";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Protein.DefaultCellStyle = dataGridViewCellStyle4;
            this.Protein.HeaderText = "Prot";
            this.Protein.MaxInputLength = 4;
            this.Protein.Name = "Protein";
            this.Protein.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Protein.Width = 40;
            // 
            // Carbs
            // 
            this.Carbs.DataPropertyName = "Carbs";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Carbs.DefaultCellStyle = dataGridViewCellStyle5;
            this.Carbs.HeaderText = "HH";
            this.Carbs.MaxInputLength = 4;
            this.Carbs.Name = "Carbs";
            this.Carbs.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Carbs.Width = 40;
            // 
            // Fat
            // 
            this.Fat.DataPropertyName = "Fat";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Fat.DefaultCellStyle = dataGridViewCellStyle6;
            this.Fat.HeaderText = "Rasva";
            this.Fat.MaxInputLength = 4;
            this.Fat.Name = "Fat";
            this.Fat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fat.Width = 45;
            // 
            // SFat
            // 
            this.SFat.DataPropertyName = "SFat";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SFat.DefaultCellStyle = dataGridViewCellStyle7;
            this.SFat.HeaderText = "T rasva";
            this.SFat.MaxInputLength = 4;
            this.SFat.Name = "SFat";
            this.SFat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SFat.Width = 50;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Kategoria";
            this.Category.Items.AddRange(new object[] {
            "Ruoka",
            "Juoma",
            "Lisäravinne",
            "Lisuke"});
            this.Category.Name = "Category";
            this.Category.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Category.Width = 85;
            // 
            // Info
            // 
            this.Info.DataPropertyName = "Info";
            this.Info.HeaderText = "Info";
            this.Info.MaxInputLength = 40;
            this.Info.Name = "Info";
            this.Info.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Info.Width = 160;
            // 
            // tabPageDiary
            // 
            this.tabPageDiary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageDiary.Controls.Add(this.flowLayoutPanel1);
            this.tabPageDiary.Controls.Add(this.groupBoxDiagram);
            this.tabPageDiary.ForeColor = System.Drawing.Color.White;
            this.tabPageDiary.Location = new System.Drawing.Point(4, 25);
            this.tabPageDiary.Name = "tabPageDiary";
            this.tabPageDiary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDiary.Size = new System.Drawing.Size(657, 571);
            this.tabPageDiary.TabIndex = 2;
            this.tabPageDiary.Text = "Makropäiväkirja";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.monthCalendar);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxDiaryDay);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxRadio);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(645, 186);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowWeekNumbers = true;
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // groupBoxDiaryDay
            // 
            this.groupBoxDiaryDay.Controls.Add(this.label19);
            this.groupBoxDiaryDay.Controls.Add(this.label18);
            this.groupBoxDiaryDay.Controls.Add(this.label17);
            this.groupBoxDiaryDay.Controls.Add(this.label16);
            this.groupBoxDiaryDay.Controls.Add(this.label15);
            this.groupBoxDiaryDay.Controls.Add(this.btnDeleteFromDiary);
            this.groupBoxDiaryDay.Controls.Add(this.btnAddToDiary);
            this.groupBoxDiaryDay.Controls.Add(this.labelDiarySFat);
            this.groupBoxDiaryDay.Controls.Add(this.labelDiaryFat);
            this.groupBoxDiaryDay.Controls.Add(this.labelDiaryCarbs);
            this.groupBoxDiaryDay.Controls.Add(this.labelDiaryProtein);
            this.groupBoxDiaryDay.Controls.Add(this.labelDiaryKcal);
            this.groupBoxDiaryDay.ForeColor = System.Drawing.Color.White;
            this.groupBoxDiaryDay.Location = new System.Drawing.Point(214, 3);
            this.groupBoxDiaryDay.Name = "groupBoxDiaryDay";
            this.groupBoxDiaryDay.Size = new System.Drawing.Size(201, 167);
            this.groupBoxDiaryDay.TabIndex = 1;
            this.groupBoxDiaryDay.TabStop = false;
            this.groupBoxDiaryDay.Text = "Valitun päivän makrot";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 108);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Tyydyttyneet rasvat:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Rasvat:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Hiilihydraatit:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Proteiinit:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Kalorit:";
            // 
            // btnDeleteFromDiary
            // 
            this.btnDeleteFromDiary.ColorTable = grayBtn;
            this.btnDeleteFromDiary.Location = new System.Drawing.Point(110, 135);
            this.btnDeleteFromDiary.Name = "btnDeleteFromDiary";
            this.btnDeleteFromDiary.Size = new System.Drawing.Size(80, 26);
            this.btnDeleteFromDiary.TabIndex = 6;
            this.btnDeleteFromDiary.Text = "Poista tiedot";
            this.btnDeleteFromDiary.Theme = CustomButton.Theme.BUTTON_GRAY;
            this.btnDeleteFromDiary.UseVisualStyleBackColor = true;
            this.btnDeleteFromDiary.Click += new System.EventHandler(this.btnDeleteFromDiary_Click_1);
            // 
            // btnAddToDiary
            // 
            this.btnAddToDiary.ColorTable = grayBtn;
            this.btnAddToDiary.Location = new System.Drawing.Point(13, 135);
            this.btnAddToDiary.Name = "btnAddToDiary";
            this.btnAddToDiary.Size = new System.Drawing.Size(80, 26);
            this.btnAddToDiary.TabIndex = 5;
            this.btnAddToDiary.Text = "Lisää tiedot";
            this.btnAddToDiary.Theme = CustomButton.Theme.BUTTON_GRAY;
            this.btnAddToDiary.UseVisualStyleBackColor = true;
            this.btnAddToDiary.Click += new System.EventHandler(this.btnAddToDiary_Click_1);
            // 
            // labelDiarySFat
            // 
            this.labelDiarySFat.AutoSize = true;
            this.labelDiarySFat.Location = new System.Drawing.Point(141, 108);
            this.labelDiarySFat.Name = "labelDiarySFat";
            this.labelDiarySFat.Size = new System.Drawing.Size(0, 13);
            this.labelDiarySFat.TabIndex = 4;
            // 
            // labelDiaryFat
            // 
            this.labelDiaryFat.AutoSize = true;
            this.labelDiaryFat.Location = new System.Drawing.Point(141, 88);
            this.labelDiaryFat.Name = "labelDiaryFat";
            this.labelDiaryFat.Size = new System.Drawing.Size(0, 13);
            this.labelDiaryFat.TabIndex = 3;
            // 
            // labelDiaryCarbs
            // 
            this.labelDiaryCarbs.AutoSize = true;
            this.labelDiaryCarbs.Location = new System.Drawing.Point(141, 68);
            this.labelDiaryCarbs.Name = "labelDiaryCarbs";
            this.labelDiaryCarbs.Size = new System.Drawing.Size(0, 13);
            this.labelDiaryCarbs.TabIndex = 2;
            // 
            // labelDiaryProtein
            // 
            this.labelDiaryProtein.AutoSize = true;
            this.labelDiaryProtein.Location = new System.Drawing.Point(141, 48);
            this.labelDiaryProtein.Name = "labelDiaryProtein";
            this.labelDiaryProtein.Size = new System.Drawing.Size(0, 13);
            this.labelDiaryProtein.TabIndex = 1;
            // 
            // labelDiaryKcal
            // 
            this.labelDiaryKcal.AutoSize = true;
            this.labelDiaryKcal.Location = new System.Drawing.Point(141, 28);
            this.labelDiaryKcal.Name = "labelDiaryKcal";
            this.labelDiaryKcal.Size = new System.Drawing.Size(0, 13);
            this.labelDiaryKcal.TabIndex = 0;
            // 
            // groupBoxRadio
            // 
            this.groupBoxRadio.Controls.Add(this.radioSFat);
            this.groupBoxRadio.Controls.Add(this.radioFat);
            this.groupBoxRadio.Controls.Add(this.radioCarbs);
            this.groupBoxRadio.Controls.Add(this.radioProtein);
            this.groupBoxRadio.Controls.Add(this.radioKcal);
            this.groupBoxRadio.ForeColor = System.Drawing.Color.White;
            this.groupBoxRadio.Location = new System.Drawing.Point(421, 3);
            this.groupBoxRadio.Name = "groupBoxRadio";
            this.groupBoxRadio.Size = new System.Drawing.Size(162, 167);
            this.groupBoxRadio.TabIndex = 10;
            this.groupBoxRadio.TabStop = false;
            this.groupBoxRadio.Text = "Diagrammi";
            // 
            // radioSFat
            // 
            this.radioSFat.AutoSize = true;
            this.radioSFat.Location = new System.Drawing.Point(15, 125);
            this.radioSFat.Name = "radioSFat";
            this.radioSFat.Size = new System.Drawing.Size(117, 17);
            this.radioSFat.TabIndex = 13;
            this.radioSFat.TabStop = true;
            this.radioSFat.Text = "Tyydyttyneet rasvat";
            this.radioSFat.UseVisualStyleBackColor = true;
            // 
            // radioFat
            // 
            this.radioFat.AutoSize = true;
            this.radioFat.Location = new System.Drawing.Point(15, 100);
            this.radioFat.Name = "radioFat";
            this.radioFat.Size = new System.Drawing.Size(59, 17);
            this.radioFat.TabIndex = 12;
            this.radioFat.Text = "Rasvat";
            this.radioFat.UseVisualStyleBackColor = true;
            this.radioFat.CheckedChanged += new System.EventHandler(this.radioFat_CheckedChanged);
            // 
            // radioCarbs
            // 
            this.radioCarbs.AutoSize = true;
            this.radioCarbs.Location = new System.Drawing.Point(15, 75);
            this.radioCarbs.Name = "radioCarbs";
            this.radioCarbs.Size = new System.Drawing.Size(81, 17);
            this.radioCarbs.TabIndex = 11;
            this.radioCarbs.Text = "Hiilihydraatit";
            this.radioCarbs.UseVisualStyleBackColor = true;
            this.radioCarbs.CheckedChanged += new System.EventHandler(this.radioCarbs_CheckedChanged);
            // 
            // radioProtein
            // 
            this.radioProtein.AutoSize = true;
            this.radioProtein.Location = new System.Drawing.Point(15, 50);
            this.radioProtein.Name = "radioProtein";
            this.radioProtein.Size = new System.Drawing.Size(65, 17);
            this.radioProtein.TabIndex = 10;
            this.radioProtein.Text = "Proteiinit";
            this.radioProtein.UseVisualStyleBackColor = true;
            this.radioProtein.CheckedChanged += new System.EventHandler(this.radioProtein_CheckedChanged);
            // 
            // radioKcal
            // 
            this.radioKcal.AutoSize = true;
            this.radioKcal.Checked = true;
            this.radioKcal.Location = new System.Drawing.Point(15, 25);
            this.radioKcal.Name = "radioKcal";
            this.radioKcal.Size = new System.Drawing.Size(54, 17);
            this.radioKcal.TabIndex = 9;
            this.radioKcal.TabStop = true;
            this.radioKcal.Text = "Kalorit";
            this.radioKcal.UseVisualStyleBackColor = true;
            this.radioKcal.CheckedChanged += new System.EventHandler(this.radioKcal_CheckedChanged);
            // 
            // groupBoxDiagram
            // 
            this.groupBoxDiagram.Controls.Add(this.chart);
            this.groupBoxDiagram.ForeColor = System.Drawing.Color.White;
            this.groupBoxDiagram.Location = new System.Drawing.Point(12, 186);
            this.groupBoxDiagram.Name = "groupBoxDiagram";
            this.groupBoxDiagram.Size = new System.Drawing.Size(639, 377);
            this.groupBoxDiagram.TabIndex = 11;
            this.groupBoxDiagram.TabStop = false;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(15, 19);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart.PaletteCustomColors = new System.Drawing.Color[] {
            System.Drawing.Color.Blue};
            series1.ChartArea = "ChartArea1";
            series1.Name = "kcal";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YValuesPerPoint = 4;
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(609, 343);
            this.chart.TabIndex = 5;
            this.chart.Text = "chart1";
            // 
            // labelEnergyCheck
            // 
            this.labelEnergyCheck.AutoSize = true;
            this.labelEnergyCheck.Location = new System.Drawing.Point(10, 95);
            this.labelEnergyCheck.Name = "labelEnergyCheck";
            this.labelEnergyCheck.Size = new System.Drawing.Size(0, 13);
            this.labelEnergyCheck.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(858, 661);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.extrasBox);
            this.Controls.Add(this.labelExtra);
            this.Controls.Add(this.supplementsBox);
            this.Controls.Add(this.labelSupplement);
            this.Controls.Add(this.drinksBox);
            this.Controls.Add(this.labelDrink);
            this.Controls.Add(this.solidsBox);
            this.Controls.Add(this.labelFood);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ravintolaskuri - Timo-Jaakko Paasila";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageCalculator.ResumeLayout(false);
            this.tabPageCalculator.PerformLayout();
            this.groupBoxSelected.ResumeLayout(false);
            this.groupBoxFood.ResumeLayout(false);
            this.groupBoxFood.PerformLayout();
            this.groupBoxProgressbar.ResumeLayout(false);
            this.groupBoxProgressbar.PerformLayout();
            this.groupBoxShares.ResumeLayout(false);
            this.groupBoxShares.PerformLayout();
            this.groupBoxSums.ResumeLayout(false);
            this.groupBoxSums.PerformLayout();
            this.tabPageDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoods)).EndInit();
            this.tabPageDiary.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxDiaryDay.ResumeLayout(false);
            this.groupBoxDiaryDay.PerformLayout();
            this.groupBoxRadio.ResumeLayout(false);
            this.groupBoxRadio.PerformLayout();
            this.groupBoxDiagram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFood;
        private System.Windows.Forms.ListBox solidsBox;
        private System.Windows.Forms.Label labelDrink;
        private System.Windows.Forms.ListBox drinksBox;
        private System.Windows.Forms.Label labelSupplement;
        private System.Windows.Forms.ListBox supplementsBox;
        private System.Windows.Forms.Label labelExtra;
        private System.Windows.Forms.ListBox extrasBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem formattingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatFoodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatDiaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodEditInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diaryInfoToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox groupBoxDiaryDay;
        private System.Windows.Forms.Label labelDiarySFat;
        private System.Windows.Forms.Label labelDiaryFat;
        private System.Windows.Forms.Label labelDiaryCarbs;
        private System.Windows.Forms.Label labelDiaryProtein;
        private System.Windows.Forms.Label labelDiaryKcal;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.DataGridView dataGridViewFoods;
        private System.Windows.Forms.GroupBox groupBoxSelected;
        private System.Windows.Forms.ListBox selectedFoodsBox;
        private System.Windows.Forms.GroupBox groupBoxProgressbar;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.TextBox textBoxTargetKcal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label progressLabelTarget;
        private System.Windows.Forms.Label progressLabel1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBoxShares;
        private System.Windows.Forms.Label labelProteinShare;
        private System.Windows.Forms.Label labelCarbsShare;
        private System.Windows.Forms.Label labelFatShare;
        private System.Windows.Forms.GroupBox groupBoxFood;
        private System.Windows.Forms.Label labelKcal;
        private System.Windows.Forms.Label labelProtein;
        private System.Windows.Forms.Label labelCarbs;
        private System.Windows.Forms.Label labelFat;
        private System.Windows.Forms.Label labelSFat;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.GroupBox groupBoxSums;
        private System.Windows.Forms.Label labelKcalSum;
        private System.Windows.Forms.Label labelProteinSum;
        private System.Windows.Forms.Label labelCarbsSum;
        private System.Windows.Forms.Label labelFatSum;
        private System.Windows.Forms.Label labelSFatSum;
        private System.Windows.Forms.Label labelSelectedName;
        private System.Windows.Forms.GroupBox groupBoxRadio;
        private System.Windows.Forms.RadioButton radioFat;
        private System.Windows.Forms.RadioButton radioCarbs;
        private System.Windows.Forms.RadioButton radioProtein;
        private System.Windows.Forms.RadioButton radioKcal;
        private System.Windows.Forms.GroupBox groupBoxDiagram;
        private System.Windows.Forms.RadioButton radioSFat;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFoodsBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDiaryBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFoodsBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDiaryBackupToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogFoods;
        private System.Windows.Forms.SaveFileDialog saveFileDialogDiary;
        private System.Windows.Forms.OpenFileDialog openFileDialogFoods;
        private System.Windows.Forms.OpenFileDialog openFileDialogDiary;
        private System.Windows.Forms.ToolStripMenuItem backupInfoToolStripMenuItem;
        private Dotnetrix_Samples.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageCalculator;
        private System.Windows.Forms.TabPage tabPageDGV;
        private System.Windows.Forms.TabPage tabPageDiary;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private CustomButton.XButton1 btnClearSelected;
        private CustomButton.XButton1 btnAdd;
        private CustomButton.XButton1 btnDelete;
        private CustomButton.XButton1 btnSave;
        private CustomButton.XButton1 btnAddToDiary;
        private CustomButton.XButton1 btnDeleteFromDiary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kcal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protein;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SFat;
        private System.Windows.Forms.DataGridViewComboBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.Label labelEnergyCheck;
    }
}