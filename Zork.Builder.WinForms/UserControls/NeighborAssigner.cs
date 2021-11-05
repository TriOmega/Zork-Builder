using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zork.Builder.WinForms.UserControls
{
    public partial class NeighborAssigner : UserControl
    {
        public Room Room
        {
            get => _room;
            set
            {
                if (_room != value)
                {
                    _room = value;
                    if (_room != null)
                    {
                        var potentialNeighbors = new List<Neighbor>(_room.PotentialNeighbors);
                        potentialNeighbors.Insert(0, NoNeighbor);
                        neighborComboBox.DataSource = potentialNeighbors;
                    }
                    else
                    {
                        currentNeighbor = NoNeighbor;
                    }
                }
            }
        }
        public Directions Direction 
        {
            get => _direction;
            set
            {
                _direction = value;
                directionTextBox.Text = _direction.ToString();
            }
        }
        public NeighborAssigner()
        {
            InitializeComponent();
        }

        public Neighbor currentNeighbor 
        {
            get => (Neighbor)neighborComboBox.SelectedItem;
            set => neighborComboBox.SelectedItem = value;
        }

        private void neighborComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private static readonly Neighbor NoNeighbor = new Neighbor() { Name = "None" };

        private Directions _direction;
        private Room _room;
    }
}
