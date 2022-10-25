using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_Game_App
{
    public class Rooms
    {
        public string _roomID;
        public List<Doorway> doorwayList;
        public bool isPositioned = false; //or room style??
        public bool isLit = false;
        public bool isClearOfMonsters = false;

        public Rooms()
            _roomID = new List<string>();
            doorWayList = new List<Doorway>();
    }
}
