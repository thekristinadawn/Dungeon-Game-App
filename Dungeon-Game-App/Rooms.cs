using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_Game_App
{
    internal class Rooms
    {
        private int roomID;
        private string roomName;
        private Dictionary<int,Rooms>dungeonRooms;
        private string roomStyle;
        private int randomRoom;

        public bool isLocked = false;
        public bool isLit = false;
        public bool isClearOfMonsters = false;
        public bool previouslyOpen = false;

        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public string RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }

        public Dictionary<int,Rooms> DungeonRooms
        {
            get { return dungeonRooms; }
            set { dungeonRooms = value; }
        }
        public string Style
        {
            get { return roomStyle; }
            set { roomStyle = value; }
        }

        public int RandomRoom
        {
            get { return randomRoom; }
            set { randomRoom = value; }
        }

        public bool IsLocked
        {
            get { return isLocked; }
            set { isLocked = value; }
        }

        public bool IsLit
        {
            get { return isLit; }
            set { isLit = value; }
        }
        public bool IsClearOfMonsters
        {
            get { return isClearOfMonsters; }
            set { isClearOfMonsters = value; }
        }
        public bool PreviouslyOpen
        {
            get { return previouslyOpen; }
            set { previouslyOpen = value; }
        }



    }
}
