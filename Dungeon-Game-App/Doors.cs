using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_Game_App
{
    public class Doors
    {
        private bool _isOpen = false;
        private bool _previouslyOpened = false;
        private bool _doorLocked = false;

        public bool IsOpen
        {
            get { return _isOpen; }
            set { _isOpen = value; }
        }

        public bool PreviouslyOpened
        {
            get { return _previouslyOpened; }
            set { _previouslyOpened = value; }
        }

        public bool DoorLocked
        {
            get { return _doorLocked; }
            set { _doorLocked = value; }
        }

    }
}
