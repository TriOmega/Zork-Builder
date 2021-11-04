﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Zork.Builder.WinForms
{
    class GameViewModel : INotifyPropertyChanged
    {
        public BindingList<Room> Rooms { get; set; }

        public Game Game
        {
            set
            {
                if (_game != value)
                {
                    _game = value;
                    if (_game != null)
                    {
                        Rooms = new BindingList<Room>(_game.World.Rooms);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>();
                    }

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Game)));
                }
            }
        }

        private Game _game;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
