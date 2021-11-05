﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zork.Builder.WinForms
{
    public partial class AddNewRoomForm : Form
    {
        public string RoomName
        {
            get
            {
                return newRoomTextBox.Text;
            }
            set
            {
                newRoomTextBox.Text = value;
            }
        }
        public AddNewRoomForm()
        {
            InitializeComponent();
        }

        private void newRoomTextBox_TextChanged(object sender, EventArgs e)
        {
            addNewRoomButton.Enabled = !string.IsNullOrWhiteSpace(RoomName);
        }

        private void addNewRoomButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelNewRoomButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
