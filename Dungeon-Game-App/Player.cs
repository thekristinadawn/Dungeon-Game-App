using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_Game_App
{
    internal class Player : Health
    {
        //Character info
        private string playerName;
        private string playerFighter;
        private string playerWeapon;
       
        public int playerHitDamage;

        
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public string PlayerFighter
        {
            get { return playerFighter; }
            set { playerFighter = value; }
        }


        public string PlayerWeapon
        {
            get { return playerWeapon; }
            set { playerWeapon = value; }
        }

        public string PlayerHitDamage
        {
            get { return playerHitDamage; }
            set { playerHitDamage = value; }
        }

        




        /* TODO:
        Ability to create a character object to be used in the dungeon for creating your player and the monsters they battle
        Calculate the hit chance (e.g. player hit chance + weapon bonus hit chance)
        Calculate the damage (e.g. using System.Random to choose a number between the equipped weapon minimum and maximum damage)
        */
    }

