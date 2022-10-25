using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_Game_App
{
    internal class Weapon
    {
        //name, minimum damage, max damage, is two-handed, bonus hit chance
        //we use underscores to assign properties for the variables we want 
        private string weaponName;
        private int weaponMinDamage;
        private int weaponMaxDamage;
        private int isTwoHanded;
        private int bonusHitChance;
        private int remainingAmmo;
        private int randomWeaponDamage;

        //properties
        //Ability to create a weapon object to be used by the character
        public string WeaponName
        {
            get { return weaponName; }
            set { weaponName = value; }
        }

        public int WeaponMinDamage
        {
            get { return weaponMinDamage; }
            set
            {
                if (value > 0 && value <= weaponMaxDamage)
                {
                    weaponMinDamage = value; //rolling for damage twice
                }
                else
                {
                    weaponMinDamage = 1;
                }
            }
        }
        public int WeaponMaxDamage
        {
            get { return weaponMaxDamage; }
            set { weaponMaxDamage = value; }
        }

        public int IsTwoHanded
        {
            get { return isTwoHanded; }
            set { isTwoHanded = value; }
        }
        public int BonusHitChance
        {
            get { return bonusHitChance; }
            set { bonusHitChance = value; }
        }

        public int RemainingAmmo
        {
            get { return remainingAmmo; }
            set { remainingAmmo = value; }
        }

        public int RandomWeaponDamage
        {
            get { return randomWeaponDamage; }
            set { randomWeaponDamage = value; }
        }

    }
}
