namespace lab5
{
    partial class IntellisenseForm
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
            this.appMenu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.allNamesListBox = new System.Windows.Forms.ListBox();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.namesBox = new System.Windows.Forms.ListBox();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.addWordMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontChangeStrip = new System.Windows.Forms.ToolStrip();
            this.boldButton = new System.Windows.Forms.ToolStripButton();
            this.italicButton = new System.Windows.Forms.ToolStripButton();
            this.underlineButton = new System.Windows.Forms.ToolStripButton();
            this.fontColorButton = new System.Windows.Forms.ToolStripButton();
            this.backColorButton = new System.Windows.Forms.ToolStripButton();
            this.fontComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.appMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.addWordMenu.SuspendLayout();
            this.fontChangeStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // appMenu
            // 
            this.appMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.appMenu.Location = new System.Drawing.Point(0, 0);
            this.appMenu.Name = "appMenu";
            this.appMenu.Size = new System.Drawing.Size(784, 24);
            this.appMenu.TabIndex = 1;
            this.appMenu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLoad,
            this.exportToolStripMenuItem});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuLoad
            // 
            this.menuLoad.Name = "menuLoad";
            this.menuLoad.Size = new System.Drawing.Size(180, 22);
            this.menuLoad.Text = "Load";
            this.menuLoad.Click += new System.EventHandler(this.menuLoad_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // loadFileDialog
            // 
            this.loadFileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainSplitContainer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 27);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.mainSplitContainer.Panel1.Controls.Add(this.tableLayoutPanel);
            this.mainSplitContainer.Panel1.Controls.Add(this.allNamesListBox);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.mainSplitContainer.Panel2.Controls.Add(this.toolStripContainer);
            this.mainSplitContainer.Size = new System.Drawing.Size(784, 534);
            this.mainSplitContainer.SplitterDistance = 218;
            this.mainSplitContainer.SplitterWidth = 10;
            this.mainSplitContainer.TabIndex = 4;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.addButton, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.sortButton, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 504);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(218, 30);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 24);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add new word";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortButton.Location = new System.Drawing.Point(112, 3);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(103, 24);
            this.sortButton.TabIndex = 1;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // allNamesListBox
            // 
            this.allNamesListBox.AllowDrop = true;
            this.allNamesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allNamesListBox.FormattingEnabled = true;
            this.allNamesListBox.Location = new System.Drawing.Point(3, 3);
            this.allNamesListBox.Name = "allNamesListBox";
            this.allNamesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.allNamesListBox.Size = new System.Drawing.Size(212, 498);
            this.allNamesListBox.TabIndex = 0;
            this.allNamesListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.allNamesListBox_DragDrop);
            this.allNamesListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.allNamesListBox_DragEnter);
            this.allNamesListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allNamesListBox_KeyDown);
            // 
            // toolStripContainer
            // 
            this.toolStripContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.namesBox);
            this.toolStripContainer.ContentPanel.Controls.Add(this.textBox);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(547, 509);
            this.toolStripContainer.LeftToolStripPanelVisible = false;
            this.toolStripContainer.Location = new System.Drawing.Point(3, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.RightToolStripPanelVisible = false;
            this.toolStripContainer.Size = new System.Drawing.Size(547, 534);
            this.toolStripContainer.TabIndex = 4;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.fontChangeStrip);
            // 
            // namesBox
            // 
            this.namesBox.FormattingEnabled = true;
            this.namesBox.Location = new System.Drawing.Point(52, 51);
            this.namesBox.Name = "namesBox";
            this.namesBox.Size = new System.Drawing.Size(125, 121);
            this.namesBox.TabIndex = 0;
            this.namesBox.Visible = false;
            // 
            // textBox
            // 
            this.textBox.AcceptsTab = true;
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.ContextMenuStrip = this.addWordMenu;
            this.textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(544, 506);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "";
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.textBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox_PreviewKeyDown);
            // 
            // addWordMenu
            // 
            this.addWordMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItem});
            this.addWordMenu.Name = "addWordMenu";
            this.addWordMenu.ShowImageMargin = false;
            this.addWordMenu.ShowItemToolTips = false;
            this.addWordMenu.Size = new System.Drawing.Size(43, 26);
            this.addWordMenu.Opening += new System.ComponentModel.CancelEventHandler(this.addWordMenu_Opening);
            // 
            // contextMenuItem
            // 
            this.contextMenuItem.Name = "contextMenuItem";
            this.contextMenuItem.Size = new System.Drawing.Size(42, 22);
            // 
            // fontChangeStrip
            // 
            this.fontChangeStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fontChangeStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldButton,
            this.italicButton,
            this.underlineButton,
            this.fontColorButton,
            this.backColorButton,
            this.fontComboBox});
            this.fontChangeStrip.Location = new System.Drawing.Point(3, 0);
            this.fontChangeStrip.Name = "fontChangeStrip";
            this.fontChangeStrip.Size = new System.Drawing.Size(250, 25);
            this.fontChangeStrip.TabIndex = 7;
            this.fontChangeStrip.Text = "toolStrip1";
            this.fontChangeStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fontChangeStrip_ItemClicked);
            // 
            // boldButton
            // 
            this.boldButton.BackColor = System.Drawing.SystemColors.Control;
            this.boldButton.CheckOnClick = true;
            this.boldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldButton.Image = global::lab5.Properties.Resources.Bold;
            this.boldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(23, 22);
            this.boldButton.Text = "toolStripButton1";
            this.boldButton.ToolTipText = "Bold";
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // italicButton
            // 
            this.italicButton.CheckOnClick = true;
            this.italicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicButton.Image = global::lab5.Properties.Resources.Italic;
            this.italicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(23, 22);
            this.italicButton.Text = "toolStripButton1";
            this.italicButton.ToolTipText = "Italic";
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // underlineButton
            // 
            this.underlineButton.CheckOnClick = true;
            this.underlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineButton.Image = global::lab5.Properties.Resources.Underline;
            this.underlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(23, 22);
            this.underlineButton.Text = "toolStripButton1";
            this.underlineButton.ToolTipText = "Underline";
            this.underlineButton.Click += new System.EventHandler(this.underlineButton_Click);
            // 
            // fontColorButton
            // 
            this.fontColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontColorButton.Image = global::lab5.Properties.Resources.FontColor;
            this.fontColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontColorButton.Name = "fontColorButton";
            this.fontColorButton.Size = new System.Drawing.Size(23, 22);
            this.fontColorButton.Text = "toolStripButton1";
            this.fontColorButton.ToolTipText = "Font Color";
            this.fontColorButton.Click += new System.EventHandler(this.fontColorButton_Click);
            // 
            // backColorButton
            // 
            this.backColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backColorButton.Image = global::lab5.Properties.Resources.BackColor;
            this.backColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backColorButton.Name = "backColorButton";
            this.backColorButton.Size = new System.Drawing.Size(23, 22);
            this.backColorButton.Text = "toolStripButton1";
            this.backColorButton.ToolTipText = "Background Color";
            this.backColorButton.Click += new System.EventHandler(this.backColorButton_Click);
            // 
            // fontComboBox
            // 
            this.fontComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.fontComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fontComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(121, 25);
            this.fontComboBox.SelectedIndexChanged += new System.EventHandler(this.fontComboBox_SelectedIndexChanged);
            // 
            // IntellisenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.appMenu);
            this.MainMenuStrip = this.appMenu;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "IntellisenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyIntellisense";
            this.appMenu.ResumeLayout(false);
            this.appMenu.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.addWordMenu.ResumeLayout(false);
            this.fontChangeStrip.ResumeLayout(false);
            this.fontChangeStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip appMenu;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuLoad;
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ListBox allNamesListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.ContextMenuStrip addWordMenu;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem;
        private System.Windows.Forms.ListBox namesBox;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ToolStrip fontChangeStrip;
        private System.Windows.Forms.ToolStripButton boldButton;
        private System.Windows.Forms.ToolStripButton italicButton;
        private System.Windows.Forms.ToolStripButton underlineButton;
        private System.Windows.Forms.ToolStripButton fontColorButton;
        private System.Windows.Forms.ToolStripButton backColorButton;
        private System.Windows.Forms.ToolStripComboBox fontComboBox;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

