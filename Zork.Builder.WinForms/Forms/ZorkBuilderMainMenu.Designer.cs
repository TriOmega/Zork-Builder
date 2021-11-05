
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
            System.Windows.Forms.TextBox roomDescriptionTextBox;
            System.Windows.Forms.Label roomDescriptionLabel;
            System.Windows.Forms.TextBox roomNameTextBox;
            System.Windows.Forms.Label roomNameLabel;
            System.Windows.Forms.PictureBox compassPictureBox;
            System.Windows.Forms.TextBox exitMessageTextBox;
            System.Windows.Forms.Label welcomeMessageLabel;
            System.Windows.Forms.Label exitMessageLabel;
            System.Windows.Forms.TextBox welcomeMessageTextBox;
            System.Windows.Forms.Label startLocationLabel;
            System.Windows.Forms.TabPage roomsTabPage;
            System.Windows.Forms.TabPage itemsTabPage;
            System.Windows.Forms.TabPage commandsTabPage;
            System.Windows.Forms.TabControl roomsTabControl;
            System.Windows.Forms.MenuStrip mainMenuStrip;
            System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsListGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.roomDescriptionPanel = new System.Windows.Forms.Panel();
            this.roomNamePanel = new System.Windows.Forms.Panel();
            this.neighborsPanel = new System.Windows.Forms.Panel();
            this.northNeighborAssigner = new Zork.Builder.WinForms.UserControls.NeighborAssigner();
            this.eastNeighborAssigner = new Zork.Builder.WinForms.UserControls.NeighborAssigner();
            this.southNeighborAssigner = new Zork.Builder.WinForms.UserControls.NeighborAssigner();
            this.westNeighborAssigner = new Zork.Builder.WinForms.UserControls.NeighborAssigner();
            this.globalValuesGroupBox = new System.Windows.Forms.GroupBox();
            this.startLocationBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dividerStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dividerStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomDescriptionTextBox = new System.Windows.Forms.TextBox();
            roomDescriptionLabel = new System.Windows.Forms.Label();
            roomNameTextBox = new System.Windows.Forms.TextBox();
            roomNameLabel = new System.Windows.Forms.Label();
            compassPictureBox = new System.Windows.Forms.PictureBox();
            exitMessageTextBox = new System.Windows.Forms.TextBox();
            welcomeMessageLabel = new System.Windows.Forms.Label();
            exitMessageLabel = new System.Windows.Forms.Label();
            welcomeMessageTextBox = new System.Windows.Forms.TextBox();
            startLocationLabel = new System.Windows.Forms.Label();
            roomsTabPage = new System.Windows.Forms.TabPage();
            itemsTabPage = new System.Windows.Forms.TabPage();
            commandsTabPage = new System.Windows.Forms.TabPage();
            roomsTabControl = new System.Windows.Forms.TabControl();
            mainMenuStrip = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(compassPictureBox)).BeginInit();
            roomsTabPage.SuspendLayout();
            this.roomsListGroupBox.SuspendLayout();
            this.roomDescriptionPanel.SuspendLayout();
            this.roomNamePanel.SuspendLayout();
            this.neighborsPanel.SuspendLayout();
            roomsTabControl.SuspendLayout();
            mainMenuStrip.SuspendLayout();
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
            saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            saveAsToolStripMenuItem.Text = "Save As...";
            saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
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
            // roomDescriptionTextBox
            // 
            roomDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            roomDescriptionTextBox.Location = new System.Drawing.Point(8, 28);
            roomDescriptionTextBox.Margin = new System.Windows.Forms.Padding(5);
            roomDescriptionTextBox.Multiline = true;
            roomDescriptionTextBox.Name = "roomDescriptionTextBox";
            roomDescriptionTextBox.Size = new System.Drawing.Size(320, 206);
            roomDescriptionTextBox.TabIndex = 1;
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
            // roomDescriptionLabel
            // 
            roomDescriptionLabel.AutoSize = true;
            roomDescriptionLabel.Location = new System.Drawing.Point(5, 5);
            roomDescriptionLabel.Margin = new System.Windows.Forms.Padding(5);
            roomDescriptionLabel.Name = "roomDescriptionLabel";
            roomDescriptionLabel.Size = new System.Drawing.Size(91, 13);
            roomDescriptionLabel.TabIndex = 0;
            roomDescriptionLabel.Text = "Room Description";
            // 
            // roomNameTextBox
            // 
            roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true));
            roomNameTextBox.Location = new System.Drawing.Point(5, 28);
            roomNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            roomNameTextBox.Name = "roomNameTextBox";
            roomNameTextBox.Size = new System.Drawing.Size(320, 20);
            roomNameTextBox.TabIndex = 4;
            // 
            // roomNameLabel
            // 
            roomNameLabel.AutoSize = true;
            roomNameLabel.Location = new System.Drawing.Point(5, 5);
            roomNameLabel.Margin = new System.Windows.Forms.Padding(5);
            roomNameLabel.Name = "roomNameLabel";
            roomNameLabel.Size = new System.Drawing.Size(66, 13);
            roomNameLabel.TabIndex = 6;
            roomNameLabel.Text = "Room Name";
            // 
            // compassPictureBox
            // 
            compassPictureBox.Image = global::Zork.Builder.WinForms.Properties.Resources.Compass;
            compassPictureBox.Location = new System.Drawing.Point(175, 85);
            compassPictureBox.Name = "compassPictureBox";
            compassPictureBox.Size = new System.Drawing.Size(150, 150);
            compassPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            compassPictureBox.TabIndex = 3;
            compassPictureBox.TabStop = false;
            // 
            // exitMessageTextBox
            // 
            exitMessageTextBox.Location = new System.Drawing.Point(115, 82);
            exitMessageTextBox.Name = "exitMessageTextBox";
            exitMessageTextBox.Size = new System.Drawing.Size(445, 20);
            exitMessageTextBox.TabIndex = 4;
            // 
            // welcomeMessageLabel
            // 
            welcomeMessageLabel.AutoSize = true;
            welcomeMessageLabel.Location = new System.Drawing.Point(6, 55);
            welcomeMessageLabel.Name = "welcomeMessageLabel";
            welcomeMessageLabel.Size = new System.Drawing.Size(101, 13);
            welcomeMessageLabel.TabIndex = 3;
            welcomeMessageLabel.Text = "Welcome Message:";
            // 
            // exitMessageLabel
            // 
            exitMessageLabel.AutoSize = true;
            exitMessageLabel.Location = new System.Drawing.Point(6, 85);
            exitMessageLabel.Name = "exitMessageLabel";
            exitMessageLabel.Size = new System.Drawing.Size(73, 13);
            exitMessageLabel.TabIndex = 1;
            exitMessageLabel.Text = "Exit Message:";
            // 
            // welcomeMessageTextBox
            // 
            welcomeMessageTextBox.Location = new System.Drawing.Point(115, 52);
            welcomeMessageTextBox.Name = "welcomeMessageTextBox";
            welcomeMessageTextBox.Size = new System.Drawing.Size(445, 20);
            welcomeMessageTextBox.TabIndex = 2;
            // 
            // startLocationLabel
            // 
            startLocationLabel.AutoSize = true;
            startLocationLabel.Location = new System.Drawing.Point(6, 25);
            startLocationLabel.Name = "startLocationLabel";
            startLocationLabel.Size = new System.Drawing.Size(76, 13);
            startLocationLabel.TabIndex = 0;
            startLocationLabel.Text = "Start Location:";
            // 
            // roomsTabPage
            // 
            roomsTabPage.Controls.Add(this.roomsListGroupBox);
            roomsTabPage.Controls.Add(this.roomDescriptionPanel);
            roomsTabPage.Controls.Add(this.roomNamePanel);
            roomsTabPage.Controls.Add(this.neighborsPanel);
            roomsTabPage.Location = new System.Drawing.Point(4, 22);
            roomsTabPage.Name = "roomsTabPage";
            roomsTabPage.Padding = new System.Windows.Forms.Padding(3);
            roomsTabPage.Size = new System.Drawing.Size(1096, 344);
            roomsTabPage.TabIndex = 0;
            roomsTabPage.Text = "Rooms";
            roomsTabPage.UseVisualStyleBackColor = true;
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
            this.roomsListBox.SelectedIndexChanged += new System.EventHandler(this.roomsListBox_SelectedIndexChanged);
            // 
            // roomDescriptionPanel
            // 
            this.roomDescriptionPanel.Controls.Add(roomDescriptionTextBox);
            this.roomDescriptionPanel.Controls.Add(roomDescriptionLabel);
            this.roomDescriptionPanel.Location = new System.Drawing.Point(223, 94);
            this.roomDescriptionPanel.Margin = new System.Windows.Forms.Padding(10);
            this.roomDescriptionPanel.Name = "roomDescriptionPanel";
            this.roomDescriptionPanel.Size = new System.Drawing.Size(340, 239);
            this.roomDescriptionPanel.TabIndex = 3;
            // 
            // roomNamePanel
            // 
            this.roomNamePanel.Controls.Add(roomNameTextBox);
            this.roomNamePanel.Controls.Add(roomNameLabel);
            this.roomNamePanel.Location = new System.Drawing.Point(223, 13);
            this.roomNamePanel.Margin = new System.Windows.Forms.Padding(10);
            this.roomNamePanel.Name = "roomNamePanel";
            this.roomNamePanel.Size = new System.Drawing.Size(330, 61);
            this.roomNamePanel.TabIndex = 5;
            // 
            // neighborsPanel
            // 
            this.neighborsPanel.Controls.Add(this.northNeighborAssigner);
            this.neighborsPanel.Controls.Add(this.eastNeighborAssigner);
            this.neighborsPanel.Controls.Add(this.southNeighborAssigner);
            this.neighborsPanel.Controls.Add(this.westNeighborAssigner);
            this.neighborsPanel.Controls.Add(compassPictureBox);
            this.neighborsPanel.Location = new System.Drawing.Point(583, 13);
            this.neighborsPanel.Margin = new System.Windows.Forms.Padding(10);
            this.neighborsPanel.Name = "neighborsPanel";
            this.neighborsPanel.Size = new System.Drawing.Size(500, 320);
            this.neighborsPanel.TabIndex = 4;
            // 
            // northNeighborAssigner
            // 
            this.northNeighborAssigner.currentNeighbor = null;
            this.northNeighborAssigner.Direction = Zork.Directions.North;
            this.northNeighborAssigner.Location = new System.Drawing.Point(170, 2);
            this.northNeighborAssigner.Margin = new System.Windows.Forms.Padding(5);
            this.northNeighborAssigner.Name = "northNeighborAssigner";
            this.northNeighborAssigner.Room = null;
            this.northNeighborAssigner.Size = new System.Drawing.Size(165, 75);
            this.northNeighborAssigner.TabIndex = 6;
            // 
            // eastNeighborAssigner
            // 
            this.eastNeighborAssigner.currentNeighbor = null;
            this.eastNeighborAssigner.Direction = Zork.Directions.East;
            this.eastNeighborAssigner.Location = new System.Drawing.Point(330, 132);
            this.eastNeighborAssigner.Margin = new System.Windows.Forms.Padding(5);
            this.eastNeighborAssigner.Name = "eastNeighborAssigner";
            this.eastNeighborAssigner.Room = null;
            this.eastNeighborAssigner.Size = new System.Drawing.Size(165, 75);
            this.eastNeighborAssigner.TabIndex = 5;
            // 
            // southNeighborAssigner
            // 
            this.southNeighborAssigner.currentNeighbor = null;
            this.southNeighborAssigner.Direction = Zork.Directions.South;
            this.southNeighborAssigner.Location = new System.Drawing.Point(170, 243);
            this.southNeighborAssigner.Margin = new System.Windows.Forms.Padding(5);
            this.southNeighborAssigner.Name = "southNeighborAssigner";
            this.southNeighborAssigner.Room = null;
            this.southNeighborAssigner.Size = new System.Drawing.Size(165, 75);
            this.southNeighborAssigner.TabIndex = 4;
            // 
            // westNeighborAssigner
            // 
            this.westNeighborAssigner.currentNeighbor = null;
            this.westNeighborAssigner.Direction = Zork.Directions.West;
            this.westNeighborAssigner.Location = new System.Drawing.Point(5, 124);
            this.westNeighborAssigner.Margin = new System.Windows.Forms.Padding(5);
            this.westNeighborAssigner.Name = "westNeighborAssigner";
            this.westNeighborAssigner.Room = null;
            this.westNeighborAssigner.Size = new System.Drawing.Size(165, 75);
            this.westNeighborAssigner.TabIndex = 1;
            // 
            // itemsTabPage
            // 
            itemsTabPage.Location = new System.Drawing.Point(4, 22);
            itemsTabPage.Name = "itemsTabPage";
            itemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            itemsTabPage.Size = new System.Drawing.Size(1096, 344);
            itemsTabPage.TabIndex = 1;
            itemsTabPage.Text = "Items";
            itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // commandsTabPage
            // 
            commandsTabPage.Location = new System.Drawing.Point(4, 22);
            commandsTabPage.Name = "commandsTabPage";
            commandsTabPage.Size = new System.Drawing.Size(1096, 344);
            commandsTabPage.TabIndex = 2;
            commandsTabPage.Text = "Commands";
            commandsTabPage.UseVisualStyleBackColor = true;
            // 
            // roomsTabControl
            // 
            roomsTabControl.Controls.Add(roomsTabPage);
            roomsTabControl.Controls.Add(itemsTabPage);
            roomsTabControl.Controls.Add(commandsTabPage);
            roomsTabControl.Location = new System.Drawing.Point(12, 148);
            roomsTabControl.Name = "roomsTabControl";
            roomsTabControl.SelectedIndex = 0;
            roomsTabControl.Size = new System.Drawing.Size(1104, 370);
            roomsTabControl.TabIndex = 0;
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileToolStripMenuItem});
            mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new System.Drawing.Size(1123, 24);
            mainMenuStrip.TabIndex = 1;
            mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            newToolStripMenuItem,
            openToolStripMenuItem,
            dividerStripMenuItem1,
            saveToolStripMenuItem,
            saveAsToolStripMenuItem,
            dividerStripMenuItem2,
            exitToolStripMenuItem});
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // globalValuesGroupBox
            // 
            this.globalValuesGroupBox.Controls.Add(exitMessageTextBox);
            this.globalValuesGroupBox.Controls.Add(welcomeMessageLabel);
            this.globalValuesGroupBox.Controls.Add(exitMessageLabel);
            this.globalValuesGroupBox.Controls.Add(this.startLocationBox);
            this.globalValuesGroupBox.Controls.Add(welcomeMessageTextBox);
            this.globalValuesGroupBox.Controls.Add(startLocationLabel);
            this.globalValuesGroupBox.Location = new System.Drawing.Point(12, 27);
            this.globalValuesGroupBox.Name = "globalValuesGroupBox";
            this.globalValuesGroupBox.Size = new System.Drawing.Size(1100, 115);
            this.globalValuesGroupBox.TabIndex = 2;
            this.globalValuesGroupBox.TabStop = false;
            this.globalValuesGroupBox.Text = "Global Values";
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
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON Files|*.json";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Zork Game Files (*.json)|*.json";
            // 
            // ZorkBuilderMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 526);
            this.Controls.Add(this.globalValuesGroupBox);
            this.Controls.Add(roomsTabControl);
            this.Controls.Add(mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "ZorkBuilderMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zork Builder - Main Menu";
            this.Load += new System.EventHandler(this.ZorkBuilderMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(compassPictureBox)).EndInit();
            roomsTabPage.ResumeLayout(false);
            this.roomsListGroupBox.ResumeLayout(false);
            this.roomDescriptionPanel.ResumeLayout(false);
            this.roomDescriptionPanel.PerformLayout();
            this.roomNamePanel.ResumeLayout(false);
            this.roomNamePanel.PerformLayout();
            this.neighborsPanel.ResumeLayout(false);
            roomsTabControl.ResumeLayout(false);
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            this.globalValuesGroupBox.ResumeLayout(false);
            this.globalValuesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControls.NeighborAssigner westNeighborAssigner;
        private UserControls.NeighborAssigner northNeighborAssigner;
        private UserControls.NeighborAssigner eastNeighborAssigner;
        private UserControls.NeighborAssigner southNeighborAssigner;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.ComboBox startLocationBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.GroupBox roomsListGroupBox;
        private System.Windows.Forms.Panel roomDescriptionPanel;
        private System.Windows.Forms.Panel roomNamePanel;
        private System.Windows.Forms.Panel neighborsPanel;
        private System.Windows.Forms.GroupBox globalValuesGroupBox;
    }
}

