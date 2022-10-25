using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_Game_App
{
    internal class Character
    {
        //name, hit chance, max health, health, block, equipped weapon
        private string _playerName;
        private int _hitChance;
        private int _numOfLives;
        private int _health
        private int _maxHealth;
        private int _block; //ability to defend
        private Weapon _weapon;

        public string PlayerName
        {
            get { return _playerName; }
            set { _playerName = value; }
        }

        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }

        public int NumberOfLives
        {
            get { return _numOfLives; }
            set { _numOfLives = value; }
        }

        public int Health
        {
            get { return _health; }
            set
            {
                if (value <= MaxHealth)
                {
                    _health = value; //returning to battle - where your previous health was entering a new battle 
                }
                else
                {
                    _health = 1;
                }
            }
        }
        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }

        public Weapon Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }


        //System.Random

        //set up properties



        
        /* TODO:
        Ability to create a character object to be used in the dungeon for creating your player and the monsters they battle
        Calculate the hit chance (e.g. player hit chance + weapon bonus hit chance)
        Calculate the damage (e.g. using System.Random to choose a number between the equipped weapon minimum and maximum damage)
        */
    }

