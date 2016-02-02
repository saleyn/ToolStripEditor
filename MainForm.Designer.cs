namespace ToolStripCustomizer
{
    partial class MainForm
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.ToolStripSeparator toolStripSeparator;
      System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
      System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
      System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
      System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
      System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
      System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
      System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
      System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
      System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
      System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
      System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
      System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
      System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
      System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
      System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
      System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
      System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
      System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
      System.Windows.Forms.ToolStripMenuItem optionsMenuItem;
      System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
      System.Windows.Forms.StatusStrip statusStrip;
      System.Windows.Forms.ToolStripButton openToolStripButton;
      System.Windows.Forms.ToolStripButton saveToolStripButton;
      System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
      System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
      System.Windows.Forms.ToolStripButton helpToolStripButton;
      System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
      System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
      System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
      System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
      System.Windows.Forms.ToolStripMenuItem clearMenuItem;
      System.Windows.Forms.ToolStripMenuItem resetMenuItem;
      System.Windows.Forms.ToolStripLabel searchLabel;
      System.Windows.Forms.ToolStripMenuItem findMenuItem;
      System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
      System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.clearMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.previewToolStrip = new System.Windows.Forms.ToolStrip();
      this.toolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
      this.toolStripCheckPreviewButton = new System.Windows.Forms.ToolStripButton();
      this.searchToolStrip = new System.Windows.Forms.ToolStrip();
      this.searchTextBox = new ToolStripCustomizer.ToolStripSpringTextBox();
      this.cancelButton = new System.Windows.Forms.ToolStripButton();
      this.mainToolStrip = new System.Windows.Forms.ToolStrip();
      this.newToolStripButton = new System.Windows.Forms.ToolStripSplitButton();
      this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.colorToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newFromPresetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.selectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.roundedEdgesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.colorAdjustmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
      this.gridView = new System.Windows.Forms.DataGridView();
      this.ColorTableItemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColorValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColorPreviewColumn = new System.Windows.Forms.DataGridViewImageColumn();
      this.EditColorColumn = new System.Windows.Forms.DataGridViewButtonColumn();
      this.rowContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.copyPopupItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pastePopupItem = new System.Windows.Forms.ToolStripMenuItem();
      this.selectAllPopupItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fromKnownColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.alphaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.colorDialog = new System.Windows.Forms.ColorDialog();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.searchWorker = new System.ComponentModel.BackgroundWorker();
      this.screenColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
      toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
      toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
      toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
      toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
      toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
      toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
      toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
      toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
      toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
      toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
      toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
      toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
      toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      optionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      statusStrip = new System.Windows.Forms.StatusStrip();
      openToolStripButton = new System.Windows.Forms.ToolStripButton();
      saveToolStripButton = new System.Windows.Forms.ToolStripButton();
      toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
      helpToolStripButton = new System.Windows.Forms.ToolStripButton();
      toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
      toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
      toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      clearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      resetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      searchLabel = new System.Windows.Forms.ToolStripLabel();
      findMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
      toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
      statusStrip.SuspendLayout();
      this.previewToolStrip.SuspendLayout();
      this.searchToolStrip.SuspendLayout();
      this.mainToolStrip.SuspendLayout();
      this.menuStrip.SuspendLayout();
      this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
      this.toolStripContainer.ContentPanel.SuspendLayout();
      this.toolStripContainer.TopToolStripPanel.SuspendLayout();
      this.toolStripContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
      this.rowContextMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStripSeparator
      // 
      toolStripSeparator.Name = "toolStripSeparator";
      toolStripSeparator.Size = new System.Drawing.Size(161, 6);
      // 
      // toolStripSeparator1
      // 
      toolStripSeparator1.Name = "toolStripSeparator1";
      toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
      // 
      // toolStripSeparator4
      // 
      toolStripSeparator4.Name = "toolStripSeparator4";
      toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
      // 
      // toolStripMenuItem1
      // 
      toolStripMenuItem1.Name = "toolStripMenuItem1";
      toolStripMenuItem1.Size = new System.Drawing.Size(161, 6);
      // 
      // toolStripMenuItem3
      // 
      toolStripMenuItem3.Name = "toolStripMenuItem3";
      toolStripMenuItem3.Size = new System.Drawing.Size(92, 22);
      toolStripMenuItem3.Text = "0";
      toolStripMenuItem3.Click += new System.EventHandler(this.SetAlphaMenuItemClick);
      // 
      // toolStripMenuItem4
      // 
      toolStripMenuItem4.Name = "toolStripMenuItem4";
      toolStripMenuItem4.Size = new System.Drawing.Size(92, 22);
      toolStripMenuItem4.Text = "20";
      toolStripMenuItem4.Click += new System.EventHandler(this.SetAlphaMenuItemClick);
      // 
      // toolStripMenuItem5
      // 
      toolStripMenuItem5.Name = "toolStripMenuItem5";
      toolStripMenuItem5.Size = new System.Drawing.Size(92, 22);
      toolStripMenuItem5.Text = "40";
      toolStripMenuItem5.Click += new System.EventHandler(this.SetAlphaMenuItemClick);
      // 
      // toolStripMenuItem6
      // 
      toolStripMenuItem6.Name = "toolStripMenuItem6";
      toolStripMenuItem6.Size = new System.Drawing.Size(92, 22);
      toolStripMenuItem6.Text = "60";
      toolStripMenuItem6.Click += new System.EventHandler(this.SetAlphaMenuItemClick);
      // 
      // toolStripMenuItem7
      // 
      toolStripMenuItem7.Name = "toolStripMenuItem7";
      toolStripMenuItem7.Size = new System.Drawing.Size(92, 22);
      toolStripMenuItem7.Text = "80";
      toolStripMenuItem7.Click += new System.EventHandler(this.SetAlphaMenuItemClick);
      // 
      // toolStripMenuItem8
      // 
      toolStripMenuItem8.Name = "toolStripMenuItem8";
      toolStripMenuItem8.Size = new System.Drawing.Size(92, 22);
      toolStripMenuItem8.Text = "100";
      toolStripMenuItem8.Click += new System.EventHandler(this.SetAlphaMenuItemClick);
      // 
      // toolStripMenuItem9
      // 
      toolStripMenuItem9.Name = "toolStripMenuItem9";
      toolStripMenuItem9.Size = new System.Drawing.Size(92, 22);
      toolStripMenuItem9.Text = "120";
      toolStripMenuItem9.Click += new System.EventHandler(this.SetAlphaMenuItemClick);
      // 
      // toolStripMenuItem10
      // 
      toolStripMenuItem10.Name = "toolStripMenuItem10";
      toolStripMenuItem10.Size = new System.Drawing.Size(92, 22);
      toolStripMenuItem10.Text = "140";
      toolStripMenuItem10.Click += new System.EventHandler(this.SetAlphaMenuItemClick);
      // 
      // toolStripMenuItem11
      // 
      toolStripMenuItem11.Name = "toolStripMenuItem11";
      toolStripMenuItem11.Size = new System.Drawing.Size(92, 22);
      toolStripMenuItem11.Text = "160";
      toolStripMenuItem11.Click += new System.EventHandler(this.SetAlphaMenuItemClick);
      // 
      // toolStripMenuItem12
      // 
      toolStripMenuItem12.Name = "toolStripMenuItem12";
      toolStripMenuItem12.Size = new System.Drawing.Size(92, 22);
      toolStripMenuItem12.Text = "180";
      toolStripMenuItem12.Click += new System.EventHandler(this.SetAlphaMenuItemClick);
      // 
      // toolStripMenuItem13
      // 
      toolStripMenuItem13.Name = "toolStripMenuItem13";
      toolStripMenuItem13.Size = new System.Drawing.Size(92, 22);
      toolStripMenuItem13.Text = "200";
      toolStripMenuItem13.Click += new System.EventHandler(this.SetAlphaMenuItemClick);
      // 
      // toolStripMenuItem14
      // 
      toolStripMenuItem14.Name = "toolStripMenuItem14";
      toolStripMenuItem14.Size = new System.Drawing.Size(92, 22);
      toolStripMenuItem14.Text = "220";
      toolStripMenuItem14.Click += new System.EventHandler(this.SetAlphaMenuItemClick);
      // 
      // toolStripMenuItem15
      // 
      toolStripMenuItem15.Name = "toolStripMenuItem15";
      toolStripMenuItem15.Size = new System.Drawing.Size(92, 22);
      toolStripMenuItem15.Text = "240";
      toolStripMenuItem15.Click += new System.EventHandler(this.SetAlphaMenuItemClick);
      // 
      // toolStripMenuItem16
      // 
      toolStripMenuItem16.Name = "toolStripMenuItem16";
      toolStripMenuItem16.Size = new System.Drawing.Size(92, 22);
      toolStripMenuItem16.Text = "255";
      toolStripMenuItem16.Click += new System.EventHandler(this.SetAlphaMenuItemClick);
      // 
      // toolStripSeparator3
      // 
      toolStripSeparator3.Name = "toolStripSeparator3";
      toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
      // 
      // resetToolStripMenuItem
      // 
      resetToolStripMenuItem.Name = "resetToolStripMenuItem";
      resetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
      resetToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      resetToolStripMenuItem.Text = "&Reset";
      resetToolStripMenuItem.Click += new System.EventHandler(this.ResetMenuItemClick);
      // 
      // optionsMenuItem
      // 
      optionsMenuItem.Name = "optionsMenuItem";
      optionsMenuItem.Size = new System.Drawing.Size(177, 22);
      optionsMenuItem.Text = "&Options...";
      optionsMenuItem.Click += new System.EventHandler(this.OptionsMenuItemClick);
      // 
      // aboutMenuItem
      // 
      aboutMenuItem.Name = "aboutMenuItem";
      aboutMenuItem.Size = new System.Drawing.Size(116, 22);
      aboutMenuItem.Text = "&About...";
      aboutMenuItem.Click += new System.EventHandler(this.AboutMenuItemClick);
      // 
      // statusStrip
      // 
      statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
      statusStrip.Location = new System.Drawing.Point(0, 490);
      statusStrip.Name = "statusStrip";
      statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
      statusStrip.Size = new System.Drawing.Size(597, 22);
      statusStrip.TabIndex = 1;
      // 
      // statusLabel
      // 
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(0, 17);
      // 
      // openToolStripButton
      // 
      openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      openToolStripButton.Image = global::ToolStripCustomizer.Properties.Resources._58;
      openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      openToolStripButton.Name = "openToolStripButton";
      openToolStripButton.Size = new System.Drawing.Size(23, 22);
      openToolStripButton.Text = "Open";
      openToolStripButton.Click += new System.EventHandler(this.OpenMenuItemClick);
      // 
      // saveToolStripButton
      // 
      saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      saveToolStripButton.Image = global::ToolStripCustomizer.Properties.Resources._71;
      saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      saveToolStripButton.Name = "saveToolStripButton";
      saveToolStripButton.Size = new System.Drawing.Size(23, 22);
      saveToolStripButton.Text = "Save As";
      saveToolStripButton.Click += new System.EventHandler(this.SaveMenuItemClick);
      // 
      // toolStripSeparator6
      // 
      toolStripSeparator6.Name = "toolStripSeparator6";
      toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripSeparator7
      // 
      toolStripSeparator7.Name = "toolStripSeparator7";
      toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
      // 
      // helpToolStripButton
      // 
      helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      helpToolStripButton.Image = global::ToolStripCustomizer.Properties.Resources._151;
      helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      helpToolStripButton.Name = "helpToolStripButton";
      helpToolStripButton.Size = new System.Drawing.Size(23, 22);
      helpToolStripButton.Text = "About";
      helpToolStripButton.Click += new System.EventHandler(this.AboutMenuItemClick);
      // 
      // toolStripComboBox1
      // 
      toolStripComboBox1.Name = "toolStripComboBox1";
      toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
      toolStripComboBox1.Text = "Combo Box";
      // 
      // toolStripTextBox1
      // 
      toolStripTextBox1.Name = "toolStripTextBox1";
      toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
      toolStripTextBox1.Text = "Text Box";
      // 
      // toolStripSeparator2
      // 
      toolStripSeparator2.Name = "toolStripSeparator2";
      toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
      // 
      // toolStripMenuItem2
      // 
      toolStripMenuItem2.Checked = true;
      toolStripMenuItem2.CheckState = System.Windows.Forms.CheckState.Checked;
      toolStripMenuItem2.Name = "toolStripMenuItem2";
      toolStripMenuItem2.Size = new System.Drawing.Size(181, 22);
      toolStripMenuItem2.Text = "Checked Item";
      // 
      // clearMenuItem
      // 
      clearMenuItem.Name = "clearMenuItem";
      clearMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
      clearMenuItem.Size = new System.Drawing.Size(164, 22);
      clearMenuItem.Text = "C&lear";
      clearMenuItem.Click += new System.EventHandler(this.ClearMenuItemClick);
      // 
      // resetMenuItem
      // 
      resetMenuItem.Name = "resetMenuItem";
      resetMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
      resetMenuItem.Size = new System.Drawing.Size(164, 22);
      resetMenuItem.Text = "&Reset";
      resetMenuItem.Click += new System.EventHandler(this.ResetMenuItemClick);
      // 
      // searchLabel
      // 
      searchLabel.Name = "searchLabel";
      searchLabel.Size = new System.Drawing.Size(45, 24);
      searchLabel.Text = "Search:";
      // 
      // findMenuItem
      // 
      findMenuItem.Name = "findMenuItem";
      findMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
      findMenuItem.Size = new System.Drawing.Size(164, 22);
      findMenuItem.Text = "&Find";
      findMenuItem.Click += new System.EventHandler(this.FindMenuItemClick);
      // 
      // toolStripSeparator8
      // 
      toolStripSeparator8.Name = "toolStripSeparator8";
      toolStripSeparator8.Size = new System.Drawing.Size(161, 6);
      // 
      // toolStripSeparator9
      // 
      toolStripSeparator9.Name = "toolStripSeparator9";
      toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
      // 
      // clearMainMenuItem
      // 
      this.clearMainMenuItem.Enabled = false;
      this.clearMainMenuItem.Name = "clearMainMenuItem";
      this.clearMainMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
      this.clearMainMenuItem.Size = new System.Drawing.Size(164, 22);
      this.clearMainMenuItem.Text = "&Clear";
      this.clearMainMenuItem.Click += new System.EventHandler(this.ClearMenuItemClick);
      // 
      // previewToolStrip
      // 
      this.previewToolStrip.Dock = System.Windows.Forms.DockStyle.None;
      this.previewToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton,
            this.toolStripCheckPreviewButton});
      this.previewToolStrip.Location = new System.Drawing.Point(3, 0);
      this.previewToolStrip.Name = "previewToolStrip";
      this.previewToolStrip.Size = new System.Drawing.Size(183, 25);
      this.previewToolStrip.TabIndex = 1;
      this.previewToolStrip.Text = "Preview";
      // 
      // toolStripSplitButton
      // 
      this.toolStripSplitButton.AutoToolTip = false;
      this.toolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripComboBox1,
            toolStripTextBox1,
            toolStripSeparator2,
            toolStripMenuItem2});
      this.toolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripSplitButton.Name = "toolStripSplitButton";
      this.toolStripSplitButton.Size = new System.Drawing.Size(64, 22);
      this.toolStripSplitButton.Text = "Preview";
      this.toolStripSplitButton.ButtonClick += new System.EventHandler(this.ToolStripSplitButtonButtonClick);
      // 
      // toolStripCheckPreviewButton
      // 
      this.toolStripCheckPreviewButton.AutoToolTip = false;
      this.toolStripCheckPreviewButton.Checked = true;
      this.toolStripCheckPreviewButton.CheckOnClick = true;
      this.toolStripCheckPreviewButton.CheckState = System.Windows.Forms.CheckState.Checked;
      this.toolStripCheckPreviewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripCheckPreviewButton.Name = "toolStripCheckPreviewButton";
      this.toolStripCheckPreviewButton.Size = new System.Drawing.Size(107, 22);
      this.toolStripCheckPreviewButton.Text = "Preview (checked)";
      this.toolStripCheckPreviewButton.CheckedChanged += new System.EventHandler(this.ToolStripCheckPreviewButtonCheckedChanged);
      // 
      // searchToolStrip
      // 
      this.searchToolStrip.Dock = System.Windows.Forms.DockStyle.None;
      this.searchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            searchLabel,
            this.searchTextBox,
            this.cancelButton});
      this.searchToolStrip.Location = new System.Drawing.Point(0, 0);
      this.searchToolStrip.Name = "searchToolStrip";
      this.searchToolStrip.Size = new System.Drawing.Size(597, 27);
      this.searchToolStrip.Stretch = true;
      this.searchToolStrip.TabIndex = 3;
      this.searchToolStrip.Text = "Search";
      // 
      // searchTextBox
      // 
      this.searchTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
      this.searchTextBox.Name = "searchTextBox";
      this.searchTextBox.Size = new System.Drawing.Size(486, 23);
      this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBoxKeyDown);
      this.searchTextBox.TextChanged += new System.EventHandler(this.SearchTextBoxTextChanged);
      // 
      // cancelButton
      // 
      this.cancelButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.cancelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.cancelButton.Enabled = false;
      this.cancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(23, 24);
      this.cancelButton.Text = "Clear Search";
      this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
      // 
      // mainToolStrip
      // 
      this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
      this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            openToolStripButton,
            saveToolStripButton,
            toolStripSeparator6,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            toolStripSeparator7,
            this.colorToolStripButton,
            toolStripSeparator9,
            helpToolStripButton});
      this.mainToolStrip.Location = new System.Drawing.Point(3, 25);
      this.mainToolStrip.Name = "mainToolStrip";
      this.mainToolStrip.Size = new System.Drawing.Size(215, 25);
      this.mainToolStrip.TabIndex = 0;
      this.mainToolStrip.Text = "Standard";
      // 
      // newToolStripButton
      // 
      this.newToolStripButton.AutoToolTip = false;
      this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.newToolStripButton.Name = "newToolStripButton";
      this.newToolStripButton.Size = new System.Drawing.Size(47, 22);
      this.newToolStripButton.Text = "New";
      this.newToolStripButton.ButtonClick += new System.EventHandler(this.NewMenuItemClick);
      // 
      // copyToolStripButton
      // 
      this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.copyToolStripButton.Image = global::ToolStripCustomizer.Properties.Resources._2;
      this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copyToolStripButton.Name = "copyToolStripButton";
      this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.copyToolStripButton.Text = "Copy";
      this.copyToolStripButton.Click += new System.EventHandler(this.CopyMenuItemClick);
      // 
      // pasteToolStripButton
      // 
      this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.pasteToolStripButton.Image = global::ToolStripCustomizer.Properties.Resources._4;
      this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.pasteToolStripButton.Name = "pasteToolStripButton";
      this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.pasteToolStripButton.Text = "Paste";
      this.pasteToolStripButton.Click += new System.EventHandler(this.PasteMenuItemClick);
      // 
      // colorToolStripButton
      // 
      this.colorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.colorToolStripButton.Image = global::ToolStripCustomizer.Properties.Resources._149;
      this.colorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.colorToolStripButton.Name = "colorToolStripButton";
      this.colorToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.colorToolStripButton.Text = "Color Adjustment";
      this.colorToolStripButton.Click += new System.EventHandler(this.ColorAdjustmentMenuItemClick);
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(597, 24);
      this.menuStrip.TabIndex = 0;
      this.menuStrip.Text = "Main Menu";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.newFromPresetMenuItem,
            this.openMenuItem,
            toolStripSeparator,
            this.saveMenuItem,
            toolStripSeparator1,
            this.exitMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // newMenuItem
      // 
      this.newMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.newMenuItem.Name = "newMenuItem";
      this.newMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.newMenuItem.Size = new System.Drawing.Size(164, 22);
      this.newMenuItem.Text = "&New";
      this.newMenuItem.Click += new System.EventHandler(this.NewMenuItemClick);
      // 
      // newFromPresetMenuItem
      // 
      this.newFromPresetMenuItem.Name = "newFromPresetMenuItem";
      this.newFromPresetMenuItem.Size = new System.Drawing.Size(164, 22);
      this.newFromPresetMenuItem.Text = "New From Preset";
      // 
      // openMenuItem
      // 
      this.openMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.openMenuItem.Name = "openMenuItem";
      this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.openMenuItem.Size = new System.Drawing.Size(164, 22);
      this.openMenuItem.Text = "&Open";
      this.openMenuItem.Click += new System.EventHandler(this.OpenMenuItemClick);
      // 
      // saveMenuItem
      // 
      this.saveMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveMenuItem.Name = "saveMenuItem";
      this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.saveMenuItem.Size = new System.Drawing.Size(164, 22);
      this.saveMenuItem.Text = "&Save As";
      this.saveMenuItem.Click += new System.EventHandler(this.SaveMenuItemClick);
      // 
      // exitMenuItem
      // 
      this.exitMenuItem.Name = "exitMenuItem";
      this.exitMenuItem.Size = new System.Drawing.Size(164, 22);
      this.exitMenuItem.Text = "E&xit";
      this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItemClick);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyMenuItem,
            this.pasteMenuItem,
            this.toolStripSeparator5,
            resetToolStripMenuItem,
            this.clearMainMenuItem,
            toolStripSeparator4,
            this.selectAllMenuItem,
            toolStripSeparator8,
            findMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editToolStripMenuItem.Text = "&Edit";
      // 
      // copyMenuItem
      // 
      this.copyMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copyMenuItem.Name = "copyMenuItem";
      this.copyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copyMenuItem.Size = new System.Drawing.Size(164, 22);
      this.copyMenuItem.Text = "&Copy";
      this.copyMenuItem.Click += new System.EventHandler(this.CopyMenuItemClick);
      // 
      // pasteMenuItem
      // 
      this.pasteMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.pasteMenuItem.Name = "pasteMenuItem";
      this.pasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.pasteMenuItem.Size = new System.Drawing.Size(164, 22);
      this.pasteMenuItem.Text = "&Paste";
      this.pasteMenuItem.Click += new System.EventHandler(this.PasteMenuItemClick);
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(161, 6);
      // 
      // selectAllMenuItem
      // 
      this.selectAllMenuItem.Name = "selectAllMenuItem";
      this.selectAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.selectAllMenuItem.Size = new System.Drawing.Size(164, 22);
      this.selectAllMenuItem.Text = "Select &All";
      this.selectAllMenuItem.Click += new System.EventHandler(this.SelectAllMenuItemClick);
      // 
      // viewToolStripMenuItem
      // 
      this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roundedEdgesMenuItem});
      this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
      this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.viewToolStripMenuItem.Text = "&View";
      // 
      // roundedEdgesMenuItem
      // 
      this.roundedEdgesMenuItem.Checked = true;
      this.roundedEdgesMenuItem.CheckOnClick = true;
      this.roundedEdgesMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.roundedEdgesMenuItem.Name = "roundedEdgesMenuItem";
      this.roundedEdgesMenuItem.Size = new System.Drawing.Size(156, 22);
      this.roundedEdgesMenuItem.Text = "&Rounded Edges";
      this.roundedEdgesMenuItem.CheckedChanged += new System.EventHandler(this.RoundedEdgesMenuItemCheckedChanged);
      // 
      // toolsToolStripMenuItem
      // 
      this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorAdjustmentToolStripMenuItem,
            this.toolStripSeparator10,
            optionsMenuItem});
      this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
      this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
      this.toolsToolStripMenuItem.Text = "&Tools";
      // 
      // colorAdjustmentToolStripMenuItem
      // 
      this.colorAdjustmentToolStripMenuItem.Name = "colorAdjustmentToolStripMenuItem";
      this.colorAdjustmentToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
      this.colorAdjustmentToolStripMenuItem.Text = "&Color Adjustment...";
      this.colorAdjustmentToolStripMenuItem.Click += new System.EventHandler(this.ColorAdjustmentMenuItemClick);
      // 
      // toolStripSeparator10
      // 
      this.toolStripSeparator10.Name = "toolStripSeparator10";
      this.toolStripSeparator10.Size = new System.Drawing.Size(174, 6);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            aboutMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // toolStripContainer
      // 
      // 
      // toolStripContainer.BottomToolStripPanel
      // 
      this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.searchToolStrip);
      // 
      // toolStripContainer.ContentPanel
      // 
      this.toolStripContainer.ContentPanel.Controls.Add(this.gridView);
      this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(597, 389);
      this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.toolStripContainer.Location = new System.Drawing.Point(0, 24);
      this.toolStripContainer.Name = "toolStripContainer";
      this.toolStripContainer.Size = new System.Drawing.Size(597, 466);
      this.toolStripContainer.TabIndex = 2;
      this.toolStripContainer.Text = "toolStripContainer1";
      // 
      // toolStripContainer.TopToolStripPanel
      // 
      this.toolStripContainer.TopToolStripPanel.Controls.Add(this.previewToolStrip);
      this.toolStripContainer.TopToolStripPanel.Controls.Add(this.mainToolStrip);
      // 
      // gridView
      // 
      this.gridView.AllowUserToAddRows = false;
      this.gridView.AllowUserToDeleteRows = false;
      this.gridView.AllowUserToResizeColumns = false;
      this.gridView.AllowUserToResizeRows = false;
      this.gridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.gridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
      this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColorTableItemColumn,
            this.ColorValueColumn,
            this.ColorPreviewColumn,
            this.EditColorColumn});
      this.gridView.ContextMenuStrip = this.rowContextMenu;
      this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
      this.gridView.Location = new System.Drawing.Point(0, 0);
      this.gridView.Name = "gridView";
      this.gridView.RowHeadersVisible = false;
      this.gridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
      this.gridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gridView.Size = new System.Drawing.Size(597, 389);
      this.gridView.TabIndex = 2;
      this.gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCellContentClick);
      this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCellDoubleClick);
      this.gridView.SelectionChanged += new System.EventHandler(this.GridViewSelectionChanged);
      this.gridView.Enter += new System.EventHandler(this.GridViewEnter);
      this.gridView.Leave += new System.EventHandler(this.GridViewLeave);
      this.gridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GridViewMouseDown);
      // 
      // ColorTableItemColumn
      // 
      this.ColorTableItemColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ColorTableItemColumn.HeaderText = "Color Table Item";
      this.ColorTableItemColumn.Name = "ColorTableItemColumn";
      this.ColorTableItemColumn.ReadOnly = true;
      // 
      // ColorValueColumn
      // 
      this.ColorValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColorValueColumn.HeaderText = "Color";
      this.ColorValueColumn.Name = "ColorValueColumn";
      this.ColorValueColumn.ReadOnly = true;
      this.ColorValueColumn.Width = 61;
      // 
      // ColorPreviewColumn
      // 
      this.ColorPreviewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColorPreviewColumn.HeaderText = "Preview";
      this.ColorPreviewColumn.Name = "ColorPreviewColumn";
      this.ColorPreviewColumn.ReadOnly = true;
      this.ColorPreviewColumn.Width = 54;
      // 
      // EditColorColumn
      // 
      this.EditColorColumn.HeaderText = "Edit";
      this.EditColorColumn.Name = "EditColorColumn";
      this.EditColorColumn.Width = 50;
      // 
      // rowContextMenu
      // 
      this.rowContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyPopupItem,
            this.pastePopupItem,
            this.selectAllPopupItem,
            toolStripSeparator3,
            this.fromKnownColorMenuItem,
            this.alphaMenuItem,
            this.screenColorMenuItem,
            toolStripMenuItem1,
            resetMenuItem,
            clearMenuItem});
      this.rowContextMenu.Name = "rowContextMenu";
      this.rowContextMenu.Size = new System.Drawing.Size(165, 214);
      this.rowContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.RowContextMenuOpening);
      // 
      // copyPopupItem
      // 
      this.copyPopupItem.Image = ((System.Drawing.Image)(resources.GetObject("copyPopupItem.Image")));
      this.copyPopupItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copyPopupItem.Name = "copyPopupItem";
      this.copyPopupItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copyPopupItem.Size = new System.Drawing.Size(164, 22);
      this.copyPopupItem.Text = "&Copy";
      this.copyPopupItem.Click += new System.EventHandler(this.CopyMenuItemClick);
      // 
      // pastePopupItem
      // 
      this.pastePopupItem.Image = ((System.Drawing.Image)(resources.GetObject("pastePopupItem.Image")));
      this.pastePopupItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.pastePopupItem.Name = "pastePopupItem";
      this.pastePopupItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.pastePopupItem.Size = new System.Drawing.Size(164, 22);
      this.pastePopupItem.Text = "&Paste";
      this.pastePopupItem.Click += new System.EventHandler(this.PasteMenuItemClick);
      // 
      // selectAllPopupItem
      // 
      this.selectAllPopupItem.Name = "selectAllPopupItem";
      this.selectAllPopupItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.selectAllPopupItem.Size = new System.Drawing.Size(164, 22);
      this.selectAllPopupItem.Text = "Select &All";
      this.selectAllPopupItem.Click += new System.EventHandler(this.SelectAllMenuItemClick);
      // 
      // fromKnownColorMenuItem
      // 
      this.fromKnownColorMenuItem.Name = "fromKnownColorMenuItem";
      this.fromKnownColorMenuItem.Size = new System.Drawing.Size(164, 22);
      this.fromKnownColorMenuItem.Text = "&System Color";
      // 
      // alphaMenuItem
      // 
      this.alphaMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripMenuItem3,
            toolStripMenuItem4,
            toolStripMenuItem5,
            toolStripMenuItem6,
            toolStripMenuItem7,
            toolStripMenuItem8,
            toolStripMenuItem9,
            toolStripMenuItem10,
            toolStripMenuItem11,
            toolStripMenuItem12,
            toolStripMenuItem13,
            toolStripMenuItem14,
            toolStripMenuItem15,
            toolStripMenuItem16});
      this.alphaMenuItem.Name = "alphaMenuItem";
      this.alphaMenuItem.Size = new System.Drawing.Size(164, 22);
      this.alphaMenuItem.Text = "Alp&ha";
      // 
      // colorDialog
      // 
      this.colorDialog.FullOpen = true;
      this.colorDialog.SolidColorOnly = true;
      // 
      // openFileDialog
      // 
      this.openFileDialog.Filter = "C# or VB.NET files|*.cs;*.vb|All files|*.*";
      // 
      // saveFileDialog
      // 
      this.saveFileDialog.DefaultExt = "cs";
      this.saveFileDialog.Filter = "C# class|*.cs|VB.NET class|*.vb|All files|*.*";
      // 
      // searchWorker
      // 
      this.searchWorker.WorkerReportsProgress = true;
      this.searchWorker.WorkerSupportsCancellation = true;
      this.searchWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SearchWorkerDoWork);
      this.searchWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.OnSearchWorkerProgressChanged);
      // 
      // screenColorMenuItem
      // 
      this.screenColorMenuItem.Name = "screenColorMenuItem";
      this.screenColorMenuItem.Size = new System.Drawing.Size(164, 22);
      this.screenColorMenuItem.Text = "Scree&n Color";
      this.screenColorMenuItem.Click += new System.EventHandler(this.screenColorMenuItem_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.ClientSize = new System.Drawing.Size(597, 512);
      this.Controls.Add(this.toolStripContainer);
      this.Controls.Add(this.menuStrip);
      this.Controls.Add(statusStrip);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip;
      this.MinimumSize = new System.Drawing.Size(350, 350);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ToolStrip Customizer for .NET WinForms";
      this.Activated += new System.EventHandler(this.MainFormActivated);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
      this.Load += new System.EventHandler(this.MainFormLoad);
      statusStrip.ResumeLayout(false);
      statusStrip.PerformLayout();
      this.previewToolStrip.ResumeLayout(false);
      this.previewToolStrip.PerformLayout();
      this.searchToolStrip.ResumeLayout(false);
      this.searchToolStrip.PerformLayout();
      this.mainToolStrip.ResumeLayout(false);
      this.mainToolStrip.PerformLayout();
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
      this.toolStripContainer.BottomToolStripPanel.PerformLayout();
      this.toolStripContainer.ContentPanel.ResumeLayout(false);
      this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
      this.toolStripContainer.TopToolStripPanel.PerformLayout();
      this.toolStripContainer.ResumeLayout(false);
      this.toolStripContainer.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
      this.rowContextMenu.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ContextMenuStrip rowContextMenu;
        private System.Windows.Forms.ToolStripMenuItem fromKnownColorMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem copyPopupItem;
        private System.Windows.Forms.ToolStripMenuItem pastePopupItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorTableItemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorValueColumn;
        private System.Windows.Forms.DataGridViewImageColumn ColorPreviewColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditColorColumn;
        private System.Windows.Forms.ToolStripMenuItem selectAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllPopupItem;
        private System.Windows.Forms.ToolStripMenuItem newFromPresetMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ToolStripSplitButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton;
        private System.Windows.Forms.ToolStripButton toolStripCheckPreviewButton;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem alphaMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roundedEdgesMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private ToolStripSpringTextBox searchTextBox;
        private System.Windows.Forms.ToolStripButton cancelButton;
        private System.ComponentModel.BackgroundWorker searchWorker;
        private System.Windows.Forms.ToolStrip previewToolStrip;
        private System.Windows.Forms.ToolStrip searchToolStrip;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripMenuItem clearMainMenuItem;
        private System.Windows.Forms.ToolStripButton colorToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem colorAdjustmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
    private System.Windows.Forms.ToolStripMenuItem screenColorMenuItem;
  }
}

