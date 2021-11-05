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
                addButton,
                deleteButton,
                startLocationBox,
                westNeighborAssigner,
                eastNeighborAssigner,
                northNeighborAssigner,
                southNeighborAssigner
            };

            _worldDependentMenuItems = new MenuItem[]
            {
                
            };

            IsWorldLoaded = false;
        }

        private void ZorkBuilderMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }
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
            MessageBox.Show("Not yet implemented");
        }

        private void startLocationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
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
                    this.Text = (openFileDialog.FileName == null ? "Zork Builder - Main Menu" : $"Zork Builder - {openFileDialog.SafeFileName}");
                    IsWorldLoaded = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private GameViewModel _viewModel;
        private Control[] _worldDependentControls;
        private MenuItem[] _worldDependentMenuItems;
    }
}
