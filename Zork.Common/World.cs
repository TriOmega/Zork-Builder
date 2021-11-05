﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Zork
{
    public class World : INotifyPropertyChanged
    {
        public List<Room> Rooms { get; set; }

        //public List<Neighbor> Neighbors { get; set; }

        [JsonIgnore]
        public Dictionary<string, Room> RoomsByName => mRoomsByName;

        public Player SpawnPlayer() => new Player(this, StartingLocation);

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            mRoomsByName = Rooms.ToDictionary(room => room.Name, room => room);


            foreach (Room room in Rooms) 
            {
                room.CreatePotentialNeighborsFromNames(this);
                room.UpdateNeighbors(this);
            }
        }

        [JsonProperty]
        private string StartingLocation { get; set; }

        private Dictionary<string, Room> mRoomsByName;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}