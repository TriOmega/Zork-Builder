using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Zork.Builder.WinForms.UserControls;
using System.ComponentModel;

namespace Zork.Builder.WinForms
{
    public partial class ZorkBuilderMainMenu : Form
    {
        private bool IsWorldLoaded
        {
            get
            {
                return _viewModel.GameIsLoaded;
            }
            set
            {
                ViewModel.GameIsLoaded = value;
                foreach (var control in _worldDependentControls)
                {
                    control.Enabled = _viewModel.GameIsLoaded;
                }
                foreach (var item in _worldDependentMenuItems)
                {
                    item.Enabled = _viewModel.GameIsLoaded;
                }

                if (_viewModel.GameIsLoaded)
                {
                    foreach (NeighborAssigner nAssigner in _neighborAssigners)
                    {
                        InitDirectionBox(nAssigner);
                    }
                }
                
            }
        }

        private GameViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                if (_viewModel != value)
                {
                    _viewModel = value;
                    gameViewModelBindingSource.DataSource = _viewModel;
                }
            }
        }

        public ZorkBuilderMainMenu()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();

            _worldDependentControls = new Control[]
            {
                addButton,
                deleteButton,
                startLocationBox,
                westNeighborAssigner,
                welcomeMessageTextBox,
                roomNameTextBox,
                roomDescriptionTextBox,
                eastNeighborAssigner,
                northNeighborAssigner,
                southNeighborAssigner
            };

            _worldDependentMenuItems = new MenuItem[]
            {
                
            };

            IsWorldLoaded = false;

            _neighborControlMap = new Dictionary<Directions, NeighborAssigner>
            {
                { Directions.North, northNeighborAssigner },
                { Directions.South, southNeighborAssigner },
                { Directions.East, eastNeighborAssigner },
                { Directions.West, westNeighborAssigner }
            };

            _neighborAssigners = new Control[]
            {
                westNeighborAssigner,
                eastNeighborAssigner,
                northNeighborAssigner,
                southNeighborAssigner
            };
        }

        #region File Menu

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Game defaultGameFile = new Game(new World {Rooms = new List<Room>()}, null);
                SaveWorld(saveFileDialog.FileName, defaultGameFile);
                UpdateMainMenuWithFileName(saveFileDialog.FileName);
                IsWorldLoaded = true;
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonFileData = File.ReadAllText(openFileDialog.FileName);
                    ViewModel.Game = JsonConvert.DeserializeObject<Game>(jsonFileData);
                    ViewModel.Filename = openFileDialog.FileName;
                    UpdateMainMenuWithFileName(ViewModel.Filename);
                    IsWorldLoaded = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) => SaveWorld(ViewModel.Filename, ViewModel.Game);

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Filename = saveFileDialog.FileName;
                SaveWorld(ViewModel.Filename, ViewModel.Game);
                UpdateMainMenuWithFileName(ViewModel.Filename);
            }
        }

        private void SaveWorld(string filepath, Game game)
        {
            if (string.IsNullOrEmpty(filepath))
            {
                throw new InvalidProgramException("Filename expected!");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };

            foreach(Room room in _viewModel.Rooms)
            {
                room.UpdateNeighborNames();
            }

            using (StreamWriter streamWriter = new StreamWriter(filepath))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, game);
            }
        }

        private void UpdateMainMenuWithFileName(string filepath)
        {
            this.Text = (filepath == null ? "Zork Builder - Main Menu" : $"Zork Builder - {Path.GetFileName(filepath)}");
        }

        #endregion

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (AddNewRoomForm addRoomForm = new AddNewRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room existingRoom = ViewModel.Rooms.
                        FirstOrDefault(room => room.Name.Equals(addRoomForm.RoomName, StringComparison.OrdinalIgnoreCase));
                    if (existingRoom != null)
                    {
                        MessageBox.Show("A room with this name already exists.","ZorkBuilder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        Room room = new Room(addRoomForm.RoomName);
                        room.Neighbors = new Dictionary<Directions, Room>();
                        ViewModel.Rooms.Add(room);
                    }
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to delete this room?", "ZorkBuilder", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)roomsListBox.SelectedItem);
                roomsListBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
            }
        }
        private void RoomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = roomsListBox.SelectedItem != null;
            startLocationBox.Enabled = roomsListBox.SelectedItem != null;
            Room selectedRoom = roomsListBox.SelectedItem as Room;

            foreach (KeyValuePair < Directions, NeighborAssigner > entry in _neighborControlMap)
            {
                entry.Value.Room = selectedRoom;
            }
        }

        private void startLocationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (startLocationBox.SelectedItem != null)
            {
                Room selectedRoom = startLocationBox.SelectedItem as Room;
                ViewModel.StartingLocation = selectedRoom.Name;
                ViewModel.World.StartingLocation = selectedRoom.Name;
            }
        }

        private void InitDirectionBox(NeighborAssigner assigner)
        {
            assigner.Rooms = ViewModel.Rooms;
            assigner.Room = ViewModel.Rooms[0];
        }

        private GameViewModel _viewModel;
        private Control[] _worldDependentControls;
        private Control[] _neighborAssigners;
        private MenuItem[] _worldDependentMenuItems;
        private readonly Dictionary<Directions, NeighborAssigner> _neighborControlMap;

    }
}
