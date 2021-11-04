using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zork.Builder.WinForms.Forms
{
    public partial class addNewRoomForm : Form
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
        public addNewRoomForm()
        {
            InitializeComponent();
        }
    }
}
