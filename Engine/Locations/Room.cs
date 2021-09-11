﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Locations
{
    public class Room
    {
        private int _id;
        private string roomName;
        private string roomDescript;
        // Monsters
        private int _locationNorth;
        private int _locationEast;
        private int _locationSouth;
        private int _locationWest;


        public int ID { get { return _id; } set { _id = value; } }
        public string RoomName { get { return roomName; } set { roomName = value; } }
        public string RoomDescription { get { return roomDescript; } set { roomDescript = value; } }
        
        // Monsters

        public int LocationToNorth { get { return _locationNorth; } set { _locationNorth = value; } }
        public int LocationToEast { get { return _locationEast; } set { _locationEast = value; } }
        public int LocationToSouth { get { return _locationSouth;  } set { _locationSouth = value; } }
        public int LocationToWest { get { return _locationWest; } set { _locationWest = value; } }


        public Room(int id, string name, string descript, int exit1, int exit2, int exit3, int exit4)
        {
            this.ID = id;
            this.RoomName = name;
            this.roomDescript = descript;
            this.LocationToNorth = exit1;
            this.LocationToEast = exit2;
            this.LocationToSouth = exit3;
            this.LocationToWest = exit4;
        }
    }
}
