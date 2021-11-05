using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zork;
using Newtonsoft.Json.Linq;
using Zork.Builder.WinForms.UserControls;

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
                globalValuesGroupBox,
                roomsListGroupBox,
                roomNamePanel,
                roomDescriptionPanel,
                neighborsPanel
            };

            _worldDependentMenuItems = new MenuItem[]
            {

            };

            IsWorldLoaded = false;

            _NeighborAssignerControlMap = new Dictionary<Directions, NeighborAssigner>
            {
                { Directions.North, northNeighborAssigner },
                { Directions.South, southNeighborAssigner },
                { Directions.East, eastNeighborAssigner },
                { Directions.West, westNeighborAssigner }
            };
        }

        private void ZorkBuilderMainMenu_Load(object sender, EventArgs e)
        {

        }

        #region File Menu

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Game defaultGameFile = new Game(new World {Rooms = new List<Room>()}, null);
                SaveWorld(saveFileDialog.FileName, defaultGameFile);
                UpdateMainMenuWithFileName(saveFileDialog.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonFileData = File.ReadAllText(openFileDialog.FileName);
                    ViewModel.Game = JsonConvert.DeserializeObject<Game>(jsonFileData);
                    //ViewModel.World = JsonConvert.DeserializeObject<World>(jsonFileData);
                    //ViewModel.Player = JsonConvert.DeserializeObject<Player>(jsonFileData);
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) => SaveWorld(ViewModel.Filename, ViewModel.Game);

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void addButton_Click(object sender, EventArgs e)
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
                        ViewModel.Rooms.Add(room);
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to delete this room?", "ZorkBuilder", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)roomsListBox.SelectedItem);
                roomsListBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
            }
        }

        private void startLocationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }

        private void roomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = roomsListBox.SelectedItem != null;
            Room selectedRoom = roomsListBox.SelectedItem as Room;
            foreach (var entry in _NeighborAssignerControlMap)
            {
                entry.Value.Room = selectedRoom;
            }
        }

        private GameViewModel _viewModel;
        private Control[] _worldDependentControls;
        private MenuItem[] _worldDependentMenuItems;
        private readonly Dictionary<Directions, NeighborAssigner> _NeighborAssignerControlMap;

    }
}
