using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Zork.Builder.WinForms
{
    public partial class ZorkBuilderMainMenu : Form
    {
        private GameViewModel _viewModel;
        internal GameViewModel ViewModel 
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
        }

        private void ZorkBuilderMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string jsonString = File.ReadAllText(openFileDialog.FileName);
                ViewModel.Game = JsonConvert.DeserializeObject<Game>(jsonString);
                this.Text = (openFileDialog.FileName == null ? "Zork Builder - Main Menu" : $"Zork Builder - {openFileDialog.SafeFileName}");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
