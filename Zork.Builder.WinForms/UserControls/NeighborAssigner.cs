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
                        var potentialNeighbors = new List<Room>();
                        foreach (Room neighbor in Rooms)
                        {
                            if (!neighbor.Equals(value))
                            {
                                potentialNeighbors.Add(neighbor);
                            }
                        }
                        //var potentialNeighbors = new List<Room>(Rooms); 
                        potentialNeighbors.Insert(0, NoNeighbor);
                        
                        neighborComboBox.SelectedIndexChanged -= NeighborComboBox_SelectedIndexChanged;
                        neighborComboBox.DataSource = potentialNeighbors;

                        if (_room.Neighbors != null && _room.Neighbors.TryGetValue(Direction, out Room neighborRoom))
                        {
                            CurrentNeighbor = neighborRoom;
                        }
                        else
                        {
                            CurrentNeighbor = NoNeighbor;
                        }

                        neighborComboBox.SelectedIndexChanged += NeighborComboBox_SelectedIndexChanged;
                    }
                    else
                    {
                        neighborComboBox.DataSource = null;
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
        public Room CurrentNeighbor
        {
            get => (Room)neighborComboBox.SelectedItem;
            set => neighborComboBox.SelectedItem = value;
        }
        public NeighborAssigner()
        {
            InitializeComponent();
        }

        public NeighborAssigner(Directions direction, Room room)
        {
            Direction = direction;
            Room = room ?? throw new ArgumentNullException(nameof(room));
        }


        private void NeighborComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_room != null)
            {
                Room selectedRoom = (Room)neighborComboBox.SelectedItem;
                if (selectedRoom == NoNeighbor)
                {
                    _room.Neighbors.Remove(Direction);
                }
                else
                {
                    _room.Neighbors[Direction] = selectedRoom;
                }
            }
        }

        private static readonly Room NoNeighbor = new Room() { Name = "None" };

        private Room _room;
        private Directions _direction;
        public BindingList<Room> Rooms { get; set; }
    }
}
