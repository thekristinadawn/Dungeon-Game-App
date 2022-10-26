using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Dungeon_Game_App
{
    public class DungeonProgram
    {

        //public static string RoomDescription() 
        //Title, Menu, Rooms (dungeons), Room descriptions

        
        public static void Main(string[] args)
        {
            //Dungeon Variables
            string[] titleGame =
                {
                ██▄     ▄      ▄     ▄▀  ▄███▄   ████▄    ▄       ████▄ ▄████      ██▄   ████▄ ████▄ █▀▄▀█ 
                █  █     █      █  ▄▀    █▀   ▀  █   █     █      █   █ █▀   ▀     █  █  █   █ █   █ █ █ █ 
                █   █ █   █ ██   █ █ ▀▄  ██▄▄    █   █ ██   █     █   █ █▀▀        █   █ █   █ █   █ █ ▄ █ 
                █  █  █   █ █ █  █ █   █ █▄   ▄▀ ▀████ █ █  █     ▀████ █          █  █  ▀████ ▀████ █   █ 
                ███▀  █▄ ▄█ █  █ █  ███  ▀███▀         █  █ █            █         ███▀                 █  
                ▀▀             
                };

            

            string[] gameDescription =
            {
                "Welcome to the Dungeon of Doom. The dungeon is full of rooms and treasures.",
                "Any treasure that you may find, is yours to keep. The treasures come with great risk.",
                "Monsters plague the Dungeon and may be in any room. The monsters are fearless and",
                "will attack. Your journey begins now..."
                
            };

           

            string[] dungeonMenu =
            {
                "--------------------------",
                "|  Choose your action:   |",
                "|  A) ATTACK             |",
                "|  R) RUN AWAY           |",
                "|  C) COLLECT TREASURE   |",
                "|  G) GO TO ANOTHER ROOM |",
                "|  P) PLAYER INFO        |",
                "|  M) MONSTER INFO       |",
                "|  E) END GAME           |",
                "--------------------------\n"
            };


            string[] weaponMenu =
            {
                "----------------------------",
                "|  Choose your weapon:     |",
                "|  D) DOUBLE EDGED SWORD   |",
                "|  P) PISTOL               |",
                "|  R) REVOLVER             |",
                "|  B) BLASTER              |",
                "----------------------------\n"
            };

            bool validWeaponChoice = false;

            //room locations

            string[] directionMenu =
           {
                "--------------------------------",
                "|  Pick a direction:            |",
                "|  N) North                     |",
                "|  S) South                     |",
                "|  E) East                      |",
                "|  W) West                      |",
                "--------------------------------\n"
            };

            bool validDirectionChoice = false;

            //create rooms dictionary

            Dictionary<int, Rooms> dungeonRooms = new Dictionary<int, Rooms>();
            Rooms dungeonRoom1 = new Rooms()
            {
                RoomID = 1,
                RoomName = "The Silent Quarters ",
                RoomStyle = "You enter a medium-sized room. The silence is eerie and it smells musty.",
                IsLocked = true,
                IsLit = false,
                IsClearOfMonsters = false
            };
            dungeonRooms.Add(1, dungeonRoom1);

            Rooms dungeonRoom2 = new Rooms()
            {
                RoomID = 2,
                RoomName = "The Lost Tunnel",
                RoomStyle = "You enter a narrow tunnel like room. The brick walls are damp and slimy.",
                IsLocked = false,
                IsLit = true,
                IsClearOfMonsters = true

            };
            dungeonRooms.Add(2, dungeonRoom2);

            Rooms dungeonRoom3 = new Rooms()
            {
                RoomID = 3,
                RoomName = "The Wicked Chambers",
                RoomStyle = "The room is large and filled with stuff where monsters can easily hide.",
                IsLocked = true,
                IsLit = true,
                IsClearOfMonsters = false
            };
            dungeonRooms.Add(3, dungeonRoom3);

            Rooms 4 = new Rooms()
            {
                RoomID = 4,
                RoomName = "The Invisible Pits",
                RoomStyle = "The room is small and visibility is low. The air is filled with dust and the walls are covered with cobwebs.",
                IsLocked = true,
                IsLit = false,
                IsClearOfMonsters = false
            };
            dungeonRooms.Add(4, dungeonRoom4);

            Rooms 5 = new Rooms()
            {
                RoomID = 5,
                RoomName = "The Frozen Quarters",
                RoomStyle = "The first thing you notice is the drop in temperature. The room causes you to shiver...",
                IsLocked = false,
                IsLit = false,
                IsClearOfMonsters = false
            };
            dungeonRooms.Add(5, dungeonRoom5);

            Rooms 6 = new Rooms()
            {
                RoomID = 5,
                RoomName = "The Twisted Maze",
                RoomStyle = "This room is tricky and like a maze. Walls everywhere and you're not sure which way to turn.",
                IsLocked = true,
                IsLit = false,
                IsClearOfMonsters = false
            };
            dungeonRooms.Add(6, dungeonRoom6);

            //monsters dictionary

            //create rooms dictionary

            Dictionary<int, Monsters> monsters = new Dictionary<int, Monsters>();
            Monsters monster1 = new Monsters()
            {
                MonsterID = 1,
                MonsterName = "Vaporman",
                Block = 3,
                MaxHealth = 75,
                MinDamage = 5,
                MaxDamage = 25
            };
            monsters.Add(1, monster1);

            Monsters monster2 = new Monsters()
            {
                MonsterID = 2,
                MonsterName = "The Crying Blob",
                Block = 4,
                MaxHealth = 95,
                MinDamage = 3,
                MaxDamage = 14
            };
            monsters.Add(2, monster2);

            Monsters monster3 = new Monsters()
            {
                MonsterID = 3,
                MonsterName = "The Sneaky Alien",
                Block = 2,
                MaxHealth = 60,
                MinDamage = 3,
                MaxDamage = 9
            };
            monsters.Add(3, monster3);

            Monsters monster4 = new Monsters()
            {
                MonsterID = 4,
                MonsterName = "The Wondrous Freak",
                Block = 6,
                MaxHealth = 80,
                MinDamage = 2,
                MaxDamage = 40
            };
            monsters.Add(4, monster4);

            Monsters monster5 = new Monsters()
            {
                MonsterID = 5,
                MonsterName = "The Flaming Dragon",
                Block = 10,
                MaxHealth = 100,
                MinDamage = 10,
                MaxDamage = 20
            };
            monsters.Add(5, monster5);


            //start of game
            Console.WriteLine(titleGame);
            Console.WriteLine(gameDescription);

            string[] startMenu =
           {
                "------------------------",
                "|  Choose your action: |",
                "|  P) PLAYER CREATION  |",
                "|  E) END GAME         |",
                "------------------------\n"
            };

            string[] playerMenu =
           {
                "--------------------------------",
                "|  Choose whom you want to be: |",
                "|  K) KNIGHT                   |",
                "|  R) RANGER                   |",
                "|  S) SOLDIER                  |",
                "|  W) WARRIOR                  |",
                "--------------------------------\n"
            };

            bool exit = false;
            bool validPlayerChoice = false;

            do
            {
                Console.WriteLine(startMenu);
                ConsoleKey userChoice = Console.ReadKey(true).Key;

                switch (userChoice)
                { 
                    case ConsoleKey.P:
                    Console.WriteLine("Enter your name:");
                    Player.playerName = Console.ReadLine();
                        do
                        {
                            Console.WriteLine(playerMenu);
                            ConsoleKey userPlayer = Console.ReadKey(true).Key;

                            if (userPlayer == ConsoleKey.K)
                            {
                                Console.WriteLine("Good choice wise knight.";
                                Player.PlayerFighter = "Knight";
                                Player.Block = 4;
                                Player.MaxHealth = 75;
                                Player.HitChance = 12;
                                validPlayerChoice = true;
                            }
                            else if (userPlayer == ConsoleKey.R)
                            {
                                Console.WriteLine("Good choice good ranger.";
                                Player.PlayerFighter = "Ranger";
                                Player.Block = 5;
                                Player.MaxHealth = 80;
                                Player.HitChance = 10;
                                validPlayerChoice = true;
                            }
                            else if (userPlayer == ConsoleKey.S)
                            {
                                Console.WriteLine("Good choice good soldier.";
                                Player.PlayerFighter = "Soldier";
                                Player.Block = 6;
                                Player.MaxHealth = 90;
                                Player.HitChance = 15;
                                validPlayerChoice = true;
                            }
                            else if (userPlayer == ConsoleKey.W)
                            {
                                Console.WriteLine("Good choice warrior.";
                                Player.PlayerFighter = "Warrior";
                                Player.Block = 10;
                                Player.MaxHealth = 100;
                                Player.HitChance = 20;
                                validPlayerChoice = true;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid choice from the menu options!");
                                    continue;
                            }


                        }while (validPlayerChoice != true);


            do
            {
                Console.WriteLine("\n Please choose an action:\n A.) Attack\n R.) Run Away\n P.) Player Info\n M.) Monster Info\n X.) Exit\n");
                key = Console.ReadLine().Key;
                Console.Clear();
  
                
                switch(key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("You have attacked!"); //
                        break;
                    case ConsoleKey.R:
                        Console.WriteLine("You have ran away!");
                        break;
                    case ConsoleKey.P:
                        Console.WriteLine("Player Info:");
                        Console.WriteLine("Your name is {0}, damage assesment is: {1}, name,maxdamage,");
                        break;
                    case ConsoleKey.M:
                        Console.WriteLine("Monster Info:")
                        break;
                    case ConsoleKey.X:
                        Console.WriteLine("GOODBYE, DUNGEON MASTER!");
                        break;
                    default:
                        Console.WriteLine("Thou hast chosen an improper option, indeed. Will thoust try again?");
                        break;

                }


            } while (!exit);

           

        }
    }
}



/*
           TODO:
           Create a do-while loop for the menu choices (The user can choose to attack, run away, player info, monster info, or exit)
           Create a loop for the room with an exit bool
           Catch the user's input
           Write a function to get the room description
           Create an instance of character for your player
           Create instances of character for your monsters
           Create an array to store your monsters
           Randomly select room and the monster in it
           Handle doing battle between your player and the monster in the room
           Check the player's and monster's life
           Handle if the player or monster wins
            */

