using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_Game_App
{
    class Monsters: Health
    {
        private int monsterID;
        private string monsterName;
        private Dictionary<int, Monsters> monsters;
        private int randomMonster;
        private int randomMonsterDamage;
        private string randomMonsterTreasure;
        
        public int MonsterID
        {
            get { return monsterID; }
            set { monsterID = value; }
        }
        public string MonsterName
        {
            get { return monsterName; }
            set { monsterName = value; }
        }

        public Dictionary<int, Monsters>monsters
        {
            get { return monsters; }
            set { monsters = value; }
        }

        public int RandomMonster
        {
            get { return randomMonster; }
            set { randomMonster = value; }
        }

        public int RandomMonsterDamage
        {
            get { return randomMonsterDamage; }
            set { randomMonsterDamage = value; }
        }

        public string RandomMonsterTreasure
        { 
            get { return randomMonsterTreasure; }
            set { randomMonsterTreasure = value; }
        }

    }
}
