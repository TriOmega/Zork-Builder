
namespace Zork.Builder.WinForms
{
    partial class ZorkBuilderMainMenu
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
            System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator dividerStripMenuItem1;
            System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator dividerStripMenuItem2;
            System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
            this.roomsTabControl = new System.Windows.Forms.TabControl();
            this.roomsTabPage = new System.Windows.Forms.TabPage();
            this.roomsListGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomDescriptionPanel = new System.Windows.Forms.Panel();
            this.roomDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.roomDescriptionLabel = new System.Windows.Forms.Label();
            this.roomNamePanel = new System.Windows.Forms.Panel();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.neighborsPanel = new System.Windows.Forms.Panel();
            this.northNeighborAssigner = new Zork.Builder.WinForms.UserControls.NeighborAssigner();
            this.eastNeighborAssigner = new Zork.Builder.WinForms.UserControls.NeighborAssigner();
            this.southNeighborAssigner = new Zork.Builder.WinForms.UserControls.NeighborAssigner();
            this.westNeighborAssigner = new Zork.Builder.WinForms.UserControls.NeighborAssigner();
            this.compassPictureBox = new System.Windows.Forms.PictureBox();
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.commandsTabPage = new System.Windows.Forms.TabPage();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalValuesGroupBox = new System.Windows.Forms.GroupBox();
            this.exitMessageTextBox = new System.Windows.Forms.TextBox();
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.exitMessageLabel = new System.Windows.Forms.Label();
            this.startLocationBox = new System.Windows.Forms.ComboBox();
            this.welcomeMessageTextBox = new System.Windows.Forms.TextBox();
            this.startLocationLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dividerStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dividerStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsTabControl.SuspendLayout();
            this.roomsTabPage.SuspendLayout();
            this.roomsListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.roomDescriptionPanel.SuspendLayout();
            this.roomNamePanel.SuspendLayout();
            this.neighborsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compassPictureBox)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.globalValuesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // dividerStripMenuItem1
            // 
            dividerStripMenuItem1.Name = "dividerStripMenuItem1";
            dividerStripMenuItem1.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // dividerStripMenuItem2
            // 
            dividerStripMenuItem2.Name = "dividerStripMenuItem2";
            dividerStripMenuItem2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // roomsTabControl
            // 
            this.roomsTabControl.Controls.Add(this.roomsTabPage);
            this.roomsTabControl.Controls.Add(this.itemsTabPage);
            this.roomsTabControl.Controls.Add(this.commandsTabPage);
            this.roomsTabControl.Location = new System.Drawing.Point(12, 148);
            this.roomsTabControl.Name = "roomsTabControl";
            this.roomsTabControl.SelectedIndex = 0;
            this.roomsTabControl.Size = new System.Drawing.Size(1104, 370);
            this.roomsTabControl.TabIndex = 0;
            // 
            // roomsTabPage
            // 
            this.roomsTabPage.Controls.Add(this.roomsListGroupBox);
            this.roomsTabPage.Controls.Add(this.roomDescriptionPanel);
            this.roomsTabPage.Controls.Add(this.roomNamePanel);
            this.roomsTabPage.Controls.Add(this.neighborsPanel);
            this.roomsTabPage.Location = new System.Drawing.Point(4, 22);
            this.roomsTabPage.Name = "roomsTabPage";
            this.roomsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.roomsTabPage.Size = new System.Drawing.Size(1096, 344);
            this.roomsTabPage.TabIndex = 0;
            this.roomsTabPage.Text = "Rooms";
            this.roomsTabPage.UseVisualStyleBackColor = true;
            // 
            // roomsListGroupBox
            // 
            this.roomsListGroupBox.Controls.Add(this.deleteButton);
            this.roomsListGroupBox.Controls.Add(this.addButton);
            this.roomsListGroupBox.Controls.Add(this.roomsListBox);
            this.roomsListGroupBox.Location = new System.Drawing.Point(10, 13);
            this.roomsListGroupBox.Margin = new System.Windows.Forms.Padding(10);
            this.roomsListGroupBox.Name = "roomsListGroupBox";
            this.roomsListGroupBox.Size = new System.Drawing.Size(193, 320);
            this.roomsListGroupBox.TabIndex = 6;
            this.roomsListGroupBox.TabStop = false;
            this.roomsListGroupBox.Text = "Rooms List";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(101, 282);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(10);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 25);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 282);
            this.addButton.Margin = new System.Windows.Forms.Padding(10);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 25);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // roomsListBox
            // 
            this.roomsListBox.DataSource = this.roomsBindingSource;
            this.roomsListBox.DisplayMember = "Name";
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(6, 19);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(175, 251);
            this.roomsListBox.TabIndex = 3;
            this.roomsListBox.ValueMember = "Player";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.WinForms.GameViewModel);
            // 
            // roomDescriptionPanel
            // 
            this.roomDescriptionPanel.Controls.Add(this.roomDescriptionTextBox);
            this.roomDescriptionPanel.Controls.Add(this.roomDescriptionLabel);
            this.roomDescriptionPanel.Location = new System.Drawing.Point(223, 94);
            this.roomDescriptionPanel.Margin = new System.Windows.Forms.Padding(10);
            this.roomDescriptionPanel.Name = "roomDescriptionPanel";
            this.roomDescriptionPanel.Size = new System.Drawing.Size(340, 239);
            this.roomDescriptionPanel.TabIndex = 3;
            // 
            // roomDescriptionTextBox
            // 
            this.roomDescriptionTextBox.Location = new System.Drawing.Point(8, 28);
            this.roomDescriptionTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.roomDescriptionTextBox.Multiline = true;
            this.roomDescriptionTextBox.Name = "roomDescriptionTextBox";
            this.roomDescriptionTextBox.Size = new System.Drawing.Size(320, 206);
            this.roomDescriptionTextBox.TabIndex = 1;
            // 
            // roomDescriptionLabel
            // 
            this.roomDescriptionLabel.AutoSize = true;
            this.roomDescriptionLabel.Location = new System.Drawing.Point(5, 5);
            this.roomDescriptionLabel.Margin = new System.Windows.Forms.Padding(5);
            this.roomDescriptionLabel.Name = "roomDescriptionLabel";
            this.roomDescriptionLabel.Size = new System.Drawing.Size(91, 13);
            this.roomDescriptionLabel.TabIndex = 0;
            this.roomDescriptionLabel.Text = "Room Description";
            // 
            // roomNamePanel
            // 
            this.roomNamePanel.Controls.Add(this.roomNameTextBox);
            this.roomNamePanel.Controls.Add(this.roomNameLabel);
            this.roomNamePanel.Location = new System.Drawing.Point(223, 13);
            this.roomNamePanel.Margin = new System.Windows.Forms.Padding(10);
            this.roomNamePanel.Name = "roomNamePanel";
            this.roomNamePanel.Size = new System.Drawing.Size(330, 61);
            this.roomNamePanel.TabIndex = 5;
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.Location = new System.Drawing.Point(5, 28);
            this.roomNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(320, 20);
            this.roomNameTextBox.TabIndex = 4;
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(5, 5);
            this.roomNameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(66, 13);
            this.roomNameLabel.TabIndex = 6;
            this.roomNameLabel.Text = "Room Name";
            // 
            // neighborsPanel
            // 
            this.neighborsPanel.Controls.Add(this.northNeighborAssigner);
            this.neighborsPanel.Controls.Add(this.eastNeighborAssigner);
            this.neighborsPanel.Controls.Add(this.southNeighborAssigner);
            this.neighborsPanel.Controls.Add(this.westNeighborAssigner);
            this.neighborsPanel.Controls.Add(this.compassPictureBox);
            this.neighborsPanel.Location = new System.Drawing.Point(583, 13);
            this.neighborsPanel.Margin = new System.Windows.Forms.Padding(10);
            this.neighborsPanel.Name = "neighborsPanel";
            this.neighborsPanel.Size = new System.Drawing.Size(500, 320);
            this.neighborsPanel.TabIndex = 4;
            // 
            // northNeighborAssigner
            // 
            this.northNeighborAssigner.Location = new System.Drawing.Point(170, 2);
            this.northNeighborAssigner.Margin = new System.Windows.Forms.Padding(5);
            this.northNeighborAssigner.Name = "northNeighborAssigner";
            this.northNeighborAssigner.Size = new System.Drawing.Size(165, 75);
            this.northNeighborAssigner.TabIndex = 6;
            this.northNeighborAssigner.Load += new System.EventHandler(this.northNeighborAssigner_Load);
            // 
            // eastNeighborAssigner
            // 
            this.eastNeighborAssigner.Location = new System.Drawing.Point(330, 132);
            this.eastNeighborAssigner.Margin = new System.Windows.Forms.Padding(5);
            this.eastNeighborAssigner.Name = "eastNeighborAssigner";
            this.eastNeighborAssigner.Size = new System.Drawing.Size(165, 75);
            this.eastNeighborAssigner.TabIndex = 5;
            this.eastNeighborAssigner.Load += new System.EventHandler(this.eastNeighborAssigner_Load);
            // 
            // southNeighborAssigner
            // 
            this.southNeighborAssigner.Location = new System.Drawing.Point(170, 243);
            this.southNeighborAssigner.Margin = new System.Windows.Forms.Padding(5);
            this.southNeighborAssigner.Name = "southNeighborAssigner";
            this.southNeighborAssigner.Size = new System.Drawing.Size(165, 75);
            this.southNeighborAssigner.TabIndex = 4;
            this.southNeighborAssigner.Load += new System.EventHandler(this.southNeighborAssigner_Load);
            // 
            // westNeighborAssigner
            // 
            this.westNeighborAssigner.Location = new System.Drawing.Point(5, 124);
            this.westNeighborAssigner.Margin = new System.Windows.Forms.Padding(5);
            this.westNeighborAssigner.Name = "westNeighborAssigner";
            this.westNeighborAssigner.Size = new System.Drawing.Size(165, 75);
            this.westNeighborAssigner.TabIndex = 1;
            this.westNeighborAssigner.Load += new System.EventHandler(this.westNeighborAssigner_Load);
            // 
            // compassPictureBox
            // 
            this.compassPictureBox.Location = new System.Drawing.Point(175, 85);
            this.compassPictureBox.Name = "compassPictureBox";
            this.compassPictureBox.Size = new System.Drawing.Size(150, 150);
            this.compassPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.compassPictureBox.TabIndex = 3;
            this.compassPictureBox.TabStop = false;
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemsTabPage.Size = new System.Drawing.Size(1096, 344);
            this.itemsTabPage.TabIndex = 1;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // commandsTabPage
            // 
            this.commandsTabPage.Location = new System.Drawing.Point(4, 22);
            this.commandsTabPage.Name = "commandsTabPage";
            this.commandsTabPage.Size = new System.Drawing.Size(1096, 344);
            this.commandsTabPage.TabIndex = 2;
            this.commandsTabPage.Text = "Commands";
            this.commandsTabPage.UseVisualStyleBackColor = true;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1123, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            newToolStripMenuItem,
            openToolStripMenuItem,
            dividerStripMenuItem1,
            saveToolStripMenuItem,
            saveAsToolStripMenuItem,
            dividerStripMenuItem2,
            exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // globalValuesGroupBox
            // 
            this.globalValuesGroupBox.Controls.Add(this.exitMessageTextBox);
            this.globalValuesGroupBox.Controls.Add(this.welcomeMessageLabel);
            this.globalValuesGroupBox.Controls.Add(this.exitMessageLabel);
            this.globalValuesGroupBox.Controls.Add(this.startLocationBox);
            this.globalValuesGroupBox.Controls.Add(this.welcomeMessageTextBox);
            this.globalValuesGroupBox.Controls.Add(this.startLocationLabel);
            this.globalValuesGroupBox.Location = new System.Drawing.Point(12, 27);
            this.globalValuesGroupBox.Name = "globalValuesGroupBox";
            this.globalValuesGroupBox.Size = new System.Drawing.Size(1100, 115);
            this.globalValuesGroupBox.TabIndex = 2;
            this.globalValuesGroupBox.TabStop = false;
            this.globalValuesGroupBox.Text = "Global Values";
            // 
            // exitMessageTextBox
            // 
            this.exitMessageTextBox.Location = new System.Drawing.Point(115, 82);
            this.exitMessageTextBox.Name = "exitMessageTextBox";
            this.exitMessageTextBox.Size = new System.Drawing.Size(445, 20);
            this.exitMessageTextBox.TabIndex = 4;
            // 
            // welcomeMessageLabel
            // 
            this.welcomeMessageLabel.AutoSize = true;
            this.welcomeMessageLabel.Location = new System.Drawing.Point(6, 55);
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(101, 13);
            this.welcomeMessageLabel.TabIndex = 3;
            this.welcomeMessageLabel.Text = "Welcome Message:";
            // 
            // exitMessageLabel
            // 
            this.exitMessageLabel.AutoSize = true;
            this.exitMessageLabel.Location = new System.Drawing.Point(6, 85);
            this.exitMessageLabel.Name = "exitMessageLabel";
            this.exitMessageLabel.Size = new System.Drawing.Size(73, 13);
            this.exitMessageLabel.TabIndex = 1;
            this.exitMessageLabel.Text = "Exit Message:";
            // 
            // startLocationBox
            // 
            this.startLocationBox.FormattingEnabled = true;
            this.startLocationBox.Location = new System.Drawing.Point(115, 22);
            this.startLocationBox.Name = "startLocationBox";
            this.startLocationBox.Size = new System.Drawing.Size(121, 21);
            this.startLocationBox.TabIndex = 3;
            this.startLocationBox.SelectedIndexChanged += new System.EventHandler(this.startLocationBox_SelectedIndexChanged);
            // 
            // welcomeMessageTextBox
            // 
            this.welcomeMessageTextBox.Location = new System.Drawing.Point(115, 52);
            this.welcomeMessageTextBox.Name = "welcomeMessageTextBox";
            this.welcomeMessageTextBox.Size = new System.Drawing.Size(445, 20);
            this.welcomeMessageTextBox.TabIndex = 2;
            // 
            // startLocationLabel
            // 
            this.startLocationLabel.AutoSize = true;
            this.startLocationLabel.Location = new System.Drawing.Point(6, 25);
            this.startLocationLabel.Name = "startLocationLabel";
            this.startLocationLabel.Size = new System.Drawing.Size(76, 13);
            this.startLocationLabel.TabIndex = 0;
            this.startLocationLabel.Text = "Start Location:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON Files|*.json";
            // 
            // ZorkBuilderMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 526);
            this.Controls.Add(this.globalValuesGroupBox);
            this.Controls.Add(this.roomsTabControl);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "ZorkBuilderMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zork Builder - Main Menu";
            this.Load += new System.EventHandler(this.ZorkBuilderMainMenu_Load);
            this.roomsTabControl.ResumeLayout(false);
            this.roomsTabPage.ResumeLayout(false);
            this.roomsListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.roomDescriptionPanel.ResumeLayout(false);
            this.roomDescriptionPanel.PerformLayout();
            this.roomNamePanel.ResumeLayout(false);
            this.roomNamePanel.PerformLayout();
            this.neighborsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.compassPictureBox)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.globalValuesGroupBox.ResumeLayout(false);
            this.globalValuesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl roomsTabControl;
        private System.Windows.Forms.TabPage roomsTabPage;
        private System.Windows.Forms.TabPage itemsTabPage;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox globalValuesGroupBox;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.TabPage commandsTabPage;
        private System.Windows.Forms.Label exitMessageLabel;
        private System.Windows.Forms.Label startLocationLabel;
        private System.Windows.Forms.TextBox exitMessageTextBox;
        private System.Windows.Forms.Label welcomeMessageLabel;
        private System.Windows.Forms.ComboBox startLocationBox;
        private System.Windows.Forms.TextBox welcomeMessageTextBox;
        private System.Windows.Forms.PictureBox compassPictureBox;
        private System.Windows.Forms.Panel neighborsPanel;
        private UserControls.NeighborAssigner westNeighborAssigner;
        private UserControls.NeighborAssigner northNeighborAssigner;
        private UserControls.NeighborAssigner eastNeighborAssigner;
        private UserControls.NeighborAssigner southNeighborAssigner;
        private System.Windows.Forms.Panel roomDescriptionPanel;
        private System.Windows.Forms.TextBox roomDescriptionTextBox;
        private System.Windows.Forms.Label roomDescriptionLabel;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.Panel roomNamePanel;
        private System.Windows.Forms.GroupBox roomsListGroupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
    }
}

