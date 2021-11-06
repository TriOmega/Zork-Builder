
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
            System.Windows.Forms.GroupBox roomsListGroupBox;
            System.Windows.Forms.Panel roomDescriptionPanel;
            System.Windows.Forms.Label roomDescriptionLabel;
            System.Windows.Forms.Panel roomNamePanel;
            System.Windows.Forms.Label roomNameLabel;
            System.Windows.Forms.Panel neighborsPanel;
            System.Windows.Forms.PictureBox compassPictureBox;
            System.Windows.Forms.GroupBox globalValuesGroupBox;
            System.Windows.Forms.TextBox exitMessageTextBox;
            System.Windows.Forms.Label welcomeMessageLabel;
            System.Windows.Forms.Label exitMessageLabel;
            System.Windows.Forms.Label startLocationLabel;
            System.Windows.Forms.TabPage roomsTabPage;
            System.Windows.Forms.TabPage itemsTabPage;
            System.Windows.Forms.TabPage commandsTabPage;
            System.Windows.Forms.TabControl roomsTabControl;
            System.Windows.Forms.MenuStrip mainMenuStrip;
            System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.northNeighborAssigner = new Zork.Builder.WinForms.UserControls.NeighborAssigner();
            this.eastNeighborAssigner = new Zork.Builder.WinForms.UserControls.NeighborAssigner();
            this.southNeighborAssigner = new Zork.Builder.WinForms.UserControls.NeighborAssigner();
            this.westNeighborAssigner = new Zork.Builder.WinForms.UserControls.NeighborAssigner();
            this.startLocationBox = new System.Windows.Forms.ComboBox();
            this.roomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.welcomeMessageTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dividerStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dividerStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsListGroupBox = new System.Windows.Forms.GroupBox();
            roomDescriptionPanel = new System.Windows.Forms.Panel();
            roomDescriptionLabel = new System.Windows.Forms.Label();
            roomNamePanel = new System.Windows.Forms.Panel();
            roomNameLabel = new System.Windows.Forms.Label();
            neighborsPanel = new System.Windows.Forms.Panel();
            compassPictureBox = new System.Windows.Forms.PictureBox();
            globalValuesGroupBox = new System.Windows.Forms.GroupBox();
            exitMessageTextBox = new System.Windows.Forms.TextBox();
            welcomeMessageLabel = new System.Windows.Forms.Label();
            exitMessageLabel = new System.Windows.Forms.Label();
            startLocationLabel = new System.Windows.Forms.Label();
            roomsTabPage = new System.Windows.Forms.TabPage();
            itemsTabPage = new System.Windows.Forms.TabPage();
            commandsTabPage = new System.Windows.Forms.TabPage();
            roomsTabControl = new System.Windows.Forms.TabControl();
            mainMenuStrip = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            roomDescriptionPanel.SuspendLayout();
            roomNamePanel.SuspendLayout();
            neighborsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(compassPictureBox)).BeginInit();
            globalValuesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).BeginInit();
            roomsTabPage.SuspendLayout();
            roomsTabControl.SuspendLayout();
            mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
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
            saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            saveAsToolStripMenuItem.Text = "Save As...";
            saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
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
            // roomsListGroupBox
            // 
            roomsListGroupBox.Controls.Add(this.deleteButton);
            roomsListGroupBox.Controls.Add(this.addButton);
            roomsListGroupBox.Controls.Add(this.roomsListBox);
            roomsListGroupBox.Location = new System.Drawing.Point(10, 13);
            roomsListGroupBox.Margin = new System.Windows.Forms.Padding(10);
            roomsListGroupBox.Name = "roomsListGroupBox";
            roomsListGroupBox.Size = new System.Drawing.Size(193, 320);
            roomsListGroupBox.TabIndex = 6;
            roomsListGroupBox.TabStop = false;
            roomsListGroupBox.Text = "Rooms List";
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
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
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
            this.roomsListBox.SelectedIndexChanged += new System.EventHandler(this.RoomsListBox_SelectedIndexChanged);
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
            roomDescriptionPanel.Controls.Add(this.roomDescriptionTextBox);
            roomDescriptionPanel.Controls.Add(roomDescriptionLabel);
            roomDescriptionPanel.Location = new System.Drawing.Point(223, 94);
            roomDescriptionPanel.Margin = new System.Windows.Forms.Padding(10);
            roomDescriptionPanel.Name = "roomDescriptionPanel";
            roomDescriptionPanel.Size = new System.Drawing.Size(340, 239);
            roomDescriptionPanel.TabIndex = 3;
            // 
            // roomDescriptionTextBox
            // 
            this.roomDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            this.roomDescriptionTextBox.Location = new System.Drawing.Point(8, 28);
            this.roomDescriptionTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.roomDescriptionTextBox.Multiline = true;
            this.roomDescriptionTextBox.Name = "roomDescriptionTextBox";
            this.roomDescriptionTextBox.Size = new System.Drawing.Size(320, 206);
            this.roomDescriptionTextBox.TabIndex = 1;
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
            // roomNamePanel
            // 
            roomNamePanel.Controls.Add(this.roomNameTextBox);
            roomNamePanel.Controls.Add(roomNameLabel);
            roomNamePanel.Location = new System.Drawing.Point(223, 13);
            roomNamePanel.Margin = new System.Windows.Forms.Padding(10);
            roomNamePanel.Name = "roomNamePanel";
            roomNamePanel.Size = new System.Drawing.Size(330, 61);
            roomNamePanel.TabIndex = 5;
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true));
            this.roomNameTextBox.Location = new System.Drawing.Point(5, 28);
            this.roomNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(320, 20);
            this.roomNameTextBox.TabIndex = 4;
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
            // neighborsPanel
            // 
            neighborsPanel.Controls.Add(this.northNeighborAssigner);
            neighborsPanel.Controls.Add(this.eastNeighborAssigner);
            neighborsPanel.Controls.Add(this.southNeighborAssigner);
            neighborsPanel.Controls.Add(this.westNeighborAssigner);
            neighborsPanel.Controls.Add(compassPictureBox);
            neighborsPanel.Location = new System.Drawing.Point(583, 13);
            neighborsPanel.Margin = new System.Windows.Forms.Padding(10);
            neighborsPanel.Name = "neighborsPanel";
            neighborsPanel.Size = new System.Drawing.Size(500, 320);
            neighborsPanel.TabIndex = 4;
            // 
            // northNeighborAssigner
            // 
            this.northNeighborAssigner.CurrentNeighbor = null;
            this.northNeighborAssigner.Direction = Zork.Directions.North;
            this.northNeighborAssigner.Location = new System.Drawing.Point(170, 2);
            this.northNeighborAssigner.Margin = new System.Windows.Forms.Padding(5);
            this.northNeighborAssigner.Name = "northNeighborAssigner";
            this.northNeighborAssigner.Room = null;
            this.northNeighborAssigner.Rooms = null;
            this.northNeighborAssigner.Size = new System.Drawing.Size(165, 75);
            this.northNeighborAssigner.TabIndex = 6;
            // 
            // eastNeighborAssigner
            // 
            this.eastNeighborAssigner.CurrentNeighbor = null;
            this.eastNeighborAssigner.Direction = Zork.Directions.East;
            this.eastNeighborAssigner.Location = new System.Drawing.Point(330, 132);
            this.eastNeighborAssigner.Margin = new System.Windows.Forms.Padding(5);
            this.eastNeighborAssigner.Name = "eastNeighborAssigner";
            this.eastNeighborAssigner.Room = null;
            this.eastNeighborAssigner.Rooms = null;
            this.eastNeighborAssigner.Size = new System.Drawing.Size(165, 75);
            this.eastNeighborAssigner.TabIndex = 5;
            // 
            // southNeighborAssigner
            // 
            this.southNeighborAssigner.CurrentNeighbor = null;
            this.southNeighborAssigner.Direction = Zork.Directions.South;
            this.southNeighborAssigner.Location = new System.Drawing.Point(170, 243);
            this.southNeighborAssigner.Margin = new System.Windows.Forms.Padding(5);
            this.southNeighborAssigner.Name = "southNeighborAssigner";
            this.southNeighborAssigner.Room = null;
            this.southNeighborAssigner.Rooms = null;
            this.southNeighborAssigner.Size = new System.Drawing.Size(165, 75);
            this.southNeighborAssigner.TabIndex = 4;
            // 
            // westNeighborAssigner
            // 
            this.westNeighborAssigner.CurrentNeighbor = null;
            this.westNeighborAssigner.Direction = Zork.Directions.West;
            this.westNeighborAssigner.Location = new System.Drawing.Point(5, 124);
            this.westNeighborAssigner.Margin = new System.Windows.Forms.Padding(5);
            this.westNeighborAssigner.Name = "westNeighborAssigner";
            this.westNeighborAssigner.Room = null;
            this.westNeighborAssigner.Rooms = null;
            this.westNeighborAssigner.Size = new System.Drawing.Size(165, 75);
            this.westNeighborAssigner.TabIndex = 1;
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
            // globalValuesGroupBox
            // 
            globalValuesGroupBox.Controls.Add(exitMessageTextBox);
            globalValuesGroupBox.Controls.Add(welcomeMessageLabel);
            globalValuesGroupBox.Controls.Add(exitMessageLabel);
            globalValuesGroupBox.Controls.Add(this.startLocationBox);
            globalValuesGroupBox.Controls.Add(this.welcomeMessageTextBox);
            globalValuesGroupBox.Controls.Add(startLocationLabel);
            globalValuesGroupBox.Location = new System.Drawing.Point(12, 27);
            globalValuesGroupBox.Name = "globalValuesGroupBox";
            globalValuesGroupBox.Size = new System.Drawing.Size(1100, 115);
            globalValuesGroupBox.TabIndex = 2;
            globalValuesGroupBox.TabStop = false;
            globalValuesGroupBox.Text = "Global Values";
            // 
            // exitMessageTextBox
            // 
            exitMessageTextBox.Enabled = false;
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
            // startLocationBox
            // 
            this.startLocationBox.DataSource = this.roomsBindingSource1;
            this.startLocationBox.DisplayMember = "Name";
            this.startLocationBox.FormattingEnabled = true;
            this.startLocationBox.Location = new System.Drawing.Point(115, 22);
            this.startLocationBox.Name = "startLocationBox";
            this.startLocationBox.Size = new System.Drawing.Size(121, 21);
            this.startLocationBox.TabIndex = 3;
            this.startLocationBox.ValueMember = "Description";
            this.startLocationBox.SelectedIndexChanged += new System.EventHandler(this.startLocationBox_SelectedIndexChanged);
            // 
            // roomsBindingSource1
            // 
            this.roomsBindingSource1.DataMember = "Rooms";
            this.roomsBindingSource1.DataSource = this.gameViewModelBindingSource;
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
            startLocationLabel.AutoSize = true;
            startLocationLabel.Location = new System.Drawing.Point(6, 25);
            startLocationLabel.Name = "startLocationLabel";
            startLocationLabel.Size = new System.Drawing.Size(76, 13);
            startLocationLabel.TabIndex = 0;
            startLocationLabel.Text = "Start Location:";
            // 
            // roomsTabPage
            // 
            roomsTabPage.Controls.Add(roomsListGroupBox);
            roomsTabPage.Controls.Add(roomDescriptionPanel);
            roomsTabPage.Controls.Add(roomNamePanel);
            roomsTabPage.Controls.Add(neighborsPanel);
            roomsTabPage.Location = new System.Drawing.Point(4, 22);
            roomsTabPage.Name = "roomsTabPage";
            roomsTabPage.Padding = new System.Windows.Forms.Padding(3);
            roomsTabPage.Size = new System.Drawing.Size(1096, 344);
            roomsTabPage.TabIndex = 0;
            roomsTabPage.Text = "Rooms";
            roomsTabPage.UseVisualStyleBackColor = true;
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
            this.Controls.Add(globalValuesGroupBox);
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
            roomsListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            roomDescriptionPanel.ResumeLayout(false);
            roomDescriptionPanel.PerformLayout();
            roomNamePanel.ResumeLayout(false);
            roomNamePanel.PerformLayout();
            neighborsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(compassPictureBox)).EndInit();
            globalValuesGroupBox.ResumeLayout(false);
            globalValuesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).EndInit();
            roomsTabPage.ResumeLayout(false);
            roomsTabControl.ResumeLayout(false);
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
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
        private System.Windows.Forms.BindingSource roomsBindingSource1;
        private System.Windows.Forms.TextBox welcomeMessageTextBox;
        private System.Windows.Forms.TextBox roomDescriptionTextBox;
        private System.Windows.Forms.TextBox roomNameTextBox;
    }
}

