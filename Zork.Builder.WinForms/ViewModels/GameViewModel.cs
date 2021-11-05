using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork.Builder.WinForms
{
    internal class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Filename { get; set; }
        public bool GameIsLoaded { get; set; }
        public World World { get; set; }
        public Player Player { get; set; }
        public string StartingLocation { get; set; }
        public BindingList<Room> Rooms { get; set; }

        public Game Game
        {
            get => _game;
            set
            {
                if (_game != value)
                {
                    _game = value;
                    if (_game != null)
                    {
                        World = new World();
                        StartingLocation = null;
                        Player = new Player(World, StartingLocation);
                        Rooms = new BindingList<Room>(_game.World.Rooms);
                    }
                    else
                    {
                        World = new World();
                        StartingLocation = null;
                        Player = new Player(World, StartingLocation);
                        Rooms = new BindingList<Room>();
                    }
                }
                
            }
        }

        public GameViewModel(Game game = null)
        {
            Game = game;
        }

        private Game _game;

    }
}
