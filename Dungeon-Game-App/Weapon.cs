using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_Game_App
{
    public class Weapon
    {
        //name, minimum damage, max damage, is two-handed, bonus hit chance
        //we use underscores to assign properties for the variables we want 
        private string _name;
        private int _minDamage;
        private int _maxDamage;
        private int _isTwoHanded;
        private int _bonusHitChance;
        public int _remainingAmmo;

}
        //properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value; //rolling for damage twice
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public int IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        //Ability to create a weapon object to be used by the character

    }
}
