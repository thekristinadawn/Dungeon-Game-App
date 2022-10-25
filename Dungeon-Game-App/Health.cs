using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_Game_App
{
    internal class Health
    {
        private string _playerName;
        private int _hitChance;
        private int _numOfLives;
        private int _currentHealth;
        private int _maxHealth;
        private int _block; //ability to defend
        private int _minDamage;
        private int _maxDamage;
        

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

        public int CurrentHealth
        {
            get { return _currentHealth; }
            set
            {
                if (value <= MaxHealth)
                {
                    _currentHealth = value; //returning to battle - where your previous health was entering a new battle 
                }
                else
                {
                    _currentHealth = 1;
                }
            }
        }

        public int MaxHealth
        {
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }
        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

    }
}
