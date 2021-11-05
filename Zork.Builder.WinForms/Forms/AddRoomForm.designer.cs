
namespace Zork.Builder.WinForms
{
    partial class AddNewRoomForm
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
            System.Windows.Forms.Label newRoomNameLabel;
            System.Windows.Forms.Button cancelNewRoomButton;
            this.addNewRoomButton = new System.Windows.Forms.Button();
            this.newRoomTextBox = new System.Windows.Forms.TextBox();
            newRoomNameLabel = new System.Windows.Forms.Label();
            cancelNewRoomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newRoomNameLabel
            // 
            newRoomNameLabel.AutoSize = true;
            newRoomNameLabel.Location = new System.Drawing.Point(6, 9);
            newRoomNameLabel.Name = "newRoomNameLabel";
            newRoomNameLabel.Size = new System.Drawing.Size(94, 13);
            newRoomNameLabel.TabIndex = 0;
            newRoomNameLabel.Text = "New Room Name:";
            // 
            // cancelNewRoomButton
            // 
            cancelNewRoomButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelNewRoomButton.Location = new System.Drawing.Point(196, 60);
            cancelNewRoomButton.Margin = new System.Windows.Forms.Padding(10);
            cancelNewRoomButton.Name = "cancelNewRoomButton";
            cancelNewRoomButton.Size = new System.Drawing.Size(75, 25);
            cancelNewRoomButton.TabIndex = 7;
            cancelNewRoomButton.Text = "Cancel";
            cancelNewRoomButton.UseVisualStyleBackColor = true;
            cancelNewRoomButton.Click += new System.EventHandler(this.cancelNewRoomButton_Click);
            // 
            // addNewRoomButton
            // 
            this.addNewRoomButton.Enabled = false;
            this.addNewRoomButton.Location = new System.Drawing.Point(108, 60);
            this.addNewRoomButton.Name = "addNewRoomButton";
            this.addNewRoomButton.Size = new System.Drawing.Size(75, 25);
            this.addNewRoomButton.TabIndex = 6;
            this.addNewRoomButton.Text = "Ok";
            this.addNewRoomButton.UseVisualStyleBackColor = true;
            this.addNewRoomButton.Click += new System.EventHandler(this.addNewRoomButton_Click);
            // 
            // newRoomTextBox
            // 
            this.newRoomTextBox.Location = new System.Drawing.Point(8, 27);
            this.newRoomTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.newRoomTextBox.Name = "newRoomTextBox";
            this.newRoomTextBox.Size = new System.Drawing.Size(262, 20);
            this.newRoomTextBox.TabIndex = 1;
            this.newRoomTextBox.TextChanged += new System.EventHandler(this.newRoomTextBox_TextChanged);
            // 
            // AddNewRoomForm
            // 
            this.AcceptButton = this.addNewRoomButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = cancelNewRoomButton;
            this.ClientSize = new System.Drawing.Size(283, 94);
            this.Controls.Add(cancelNewRoomButton);
            this.Controls.Add(this.addNewRoomButton);
            this.Controls.Add(newRoomNameLabel);
            this.Controls.Add(this.newRoomTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddNewRoomForm";
            this.Text = "Add New Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newRoomTextBox;
        private System.Windows.Forms.Button addNewRoomButton;
    }
}