﻿
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
            System.Windows.Forms.TabControl roomsTabControl;
            System.Windows.Forms.TabPage roomsTabPage;
            System.Windows.Forms.GroupBox roomsListGroupBox;
            System.Windows.Forms.Button deleteButton;
            System.Windows.Forms.Button addButton;
            System.Windows.Forms.ListBox roomsListBox;
            System.Windows.Forms.Panel roomDescriptionPanel;
            System.Windows.Forms.TextBox roomDescriptionTextBox;
            System.Windows.Forms.Label roomDescriptionLabel;
            System.Windows.Forms.Panel roomNamePanel;
            System.Windows.Forms.TextBox roomNameTextBox;
            System.Windows.Forms.Label roomNameLabel;
            System.Windows.Forms.Panel neighborsPanel;
            System.Windows.Forms.PictureBox compassPictureBox;
            System.Windows.Forms.TabPage itemsTabPage;
            System.Windows.Forms.TabPage commandsTabPage;
            System.Windows.Forms.MenuStrip mainMenuStrip;
            System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator dividerStripMenuItem1;
            System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator dividerStripMenuItem2;
            System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
            System.Windows.Forms.GroupBox globalValuesGroupBox;
            System.Windows.Forms.TextBox exitMessageTextBox;
            System.Windows.Forms.Label welcomeMessageLabel;
            System.Windows.Forms.Label exitMessageLabel;
            System.Windows.Forms.ComboBox comboBox1;
            System.Windows.Forms.TextBox welcomeMessageTextBox;
            System.Windows.Forms.Label startLocationLabel;
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northNeighborAssigner = new Zork.Builder.WinForms.UserControls.NeighborAssigner();
            this.eastNeighborAssigner = new Zork.Builder.WinForms.UserControls.NeighborAssigner();
            this.southNeighborAssigner = new Zork.Builder.WinForms.UserControls.NeighborAssigner();
            this.westNeighborAssigner = new Zork.Builder.WinForms.UserControls.NeighborAssigner();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            roomsTabControl = new System.Windows.Forms.TabControl();
            roomsTabPage = new System.Windows.Forms.TabPage();
            roomsListGroupBox = new System.Windows.Forms.GroupBox();
            deleteButton = new System.Windows.Forms.Button();
            addButton = new System.Windows.Forms.Button();
            roomsListBox = new System.Windows.Forms.ListBox();
            roomDescriptionPanel = new System.Windows.Forms.Panel();
            roomDescriptionTextBox = new System.Windows.Forms.TextBox();
            roomDescriptionLabel = new System.Windows.Forms.Label();
            roomNamePanel = new System.Windows.Forms.Panel();
            roomNameTextBox = new System.Windows.Forms.TextBox();
            roomNameLabel = new System.Windows.Forms.Label();
            neighborsPanel = new System.Windows.Forms.Panel();
            compassPictureBox = new System.Windows.Forms.PictureBox();
            itemsTabPage = new System.Windows.Forms.TabPage();
            commandsTabPage = new System.Windows.Forms.TabPage();
            mainMenuStrip = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dividerStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dividerStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            globalValuesGroupBox = new System.Windows.Forms.GroupBox();
            exitMessageTextBox = new System.Windows.Forms.TextBox();
            welcomeMessageLabel = new System.Windows.Forms.Label();
            exitMessageLabel = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            welcomeMessageTextBox = new System.Windows.Forms.TextBox();
            startLocationLabel = new System.Windows.Forms.Label();
            roomsTabControl.SuspendLayout();
            roomsTabPage.SuspendLayout();
            roomsListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            roomDescriptionPanel.SuspendLayout();
            roomNamePanel.SuspendLayout();
            neighborsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(compassPictureBox)).BeginInit();
            mainMenuStrip.SuspendLayout();
            globalValuesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // roomsListGroupBox
            // 
            roomsListGroupBox.Controls.Add(deleteButton);
            roomsListGroupBox.Controls.Add(addButton);
            roomsListGroupBox.Controls.Add(roomsListBox);
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
            deleteButton.Location = new System.Drawing.Point(101, 282);
            deleteButton.Margin = new System.Windows.Forms.Padding(10);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(75, 25);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new System.Drawing.Point(13, 282);
            addButton.Margin = new System.Windows.Forms.Padding(10);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(75, 25);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // roomsListBox
            // 
            roomsListBox.DataSource = this.roomsBindingSource;
            roomsListBox.DisplayMember = "Name";
            roomsListBox.FormattingEnabled = true;
            roomsListBox.Location = new System.Drawing.Point(6, 19);
            roomsListBox.Name = "roomsListBox";
            roomsListBox.Size = new System.Drawing.Size(175, 251);
            roomsListBox.TabIndex = 3;
            roomsListBox.ValueMember = "Description";
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.WinForms.GameViewModel);
            // 
            // roomDescriptionPanel
            // 
            roomDescriptionPanel.Controls.Add(roomDescriptionTextBox);
            roomDescriptionPanel.Controls.Add(roomDescriptionLabel);
            roomDescriptionPanel.Location = new System.Drawing.Point(223, 94);
            roomDescriptionPanel.Margin = new System.Windows.Forms.Padding(10);
            roomDescriptionPanel.Name = "roomDescriptionPanel";
            roomDescriptionPanel.Size = new System.Drawing.Size(340, 239);
            roomDescriptionPanel.TabIndex = 3;
            // 
            // roomDescriptionTextBox
            // 
            roomDescriptionTextBox.Location = new System.Drawing.Point(8, 28);
            roomDescriptionTextBox.Margin = new System.Windows.Forms.Padding(5);
            roomDescriptionTextBox.Multiline = true;
            roomDescriptionTextBox.Name = "roomDescriptionTextBox";
            roomDescriptionTextBox.Size = new System.Drawing.Size(320, 206);
            roomDescriptionTextBox.TabIndex = 1;
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
            roomNamePanel.Controls.Add(roomNameTextBox);
            roomNamePanel.Controls.Add(roomNameLabel);
            roomNamePanel.Location = new System.Drawing.Point(223, 13);
            roomNamePanel.Margin = new System.Windows.Forms.Padding(10);
            roomNamePanel.Name = "roomNamePanel";
            roomNamePanel.Size = new System.Drawing.Size(330, 61);
            roomNamePanel.TabIndex = 5;
            // 
            // roomNameTextBox
            // 
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
            this.northNeighborAssigner.Location = new System.Drawing.Point(170, 2);
            this.northNeighborAssigner.Margin = new System.Windows.Forms.Padding(5);
            this.northNeighborAssigner.Name = "northNeighborAssigner";
            this.northNeighborAssigner.Size = new System.Drawing.Size(165, 75);
            this.northNeighborAssigner.TabIndex = 6;
            // 
            // eastNeighborAssigner
            // 
            this.eastNeighborAssigner.Location = new System.Drawing.Point(330, 132);
            this.eastNeighborAssigner.Margin = new System.Windows.Forms.Padding(5);
            this.eastNeighborAssigner.Name = "eastNeighborAssigner";
            this.eastNeighborAssigner.Size = new System.Drawing.Size(165, 75);
            this.eastNeighborAssigner.TabIndex = 5;
            // 
            // southNeighborAssigner
            // 
            this.southNeighborAssigner.Location = new System.Drawing.Point(170, 243);
            this.southNeighborAssigner.Margin = new System.Windows.Forms.Padding(5);
            this.southNeighborAssigner.Name = "southNeighborAssigner";
            this.southNeighborAssigner.Size = new System.Drawing.Size(165, 75);
            this.southNeighborAssigner.TabIndex = 4;
            // 
            // westNeighborAssigner
            // 
            this.westNeighborAssigner.Location = new System.Drawing.Point(5, 124);
            this.westNeighborAssigner.Margin = new System.Windows.Forms.Padding(5);
            this.westNeighborAssigner.Name = "westNeighborAssigner";
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
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            newToolStripMenuItem.Text = "&New";
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
            exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // globalValuesGroupBox
            // 
            globalValuesGroupBox.Controls.Add(exitMessageTextBox);
            globalValuesGroupBox.Controls.Add(welcomeMessageLabel);
            globalValuesGroupBox.Controls.Add(exitMessageLabel);
            globalValuesGroupBox.Controls.Add(comboBox1);
            globalValuesGroupBox.Controls.Add(welcomeMessageTextBox);
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(115, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 21);
            comboBox1.TabIndex = 3;
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
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON|*.json";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
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
            roomsTabControl.ResumeLayout(false);
            roomsTabPage.ResumeLayout(false);
            roomsListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            roomDescriptionPanel.ResumeLayout(false);
            roomDescriptionPanel.PerformLayout();
            roomNamePanel.ResumeLayout(false);
            roomNamePanel.PerformLayout();
            neighborsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(compassPictureBox)).EndInit();
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            globalValuesGroupBox.ResumeLayout(false);
            globalValuesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private UserControls.NeighborAssigner northNeighborAssigner;
        private UserControls.NeighborAssigner eastNeighborAssigner;
        private UserControls.NeighborAssigner southNeighborAssigner;
        private UserControls.NeighborAssigner westNeighborAssigner;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
    }
}
