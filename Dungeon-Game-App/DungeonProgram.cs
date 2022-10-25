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
                "------------------------",
                "|  Choose your action: |",
                "|  A) ATTACK           |",
                "|  R) RUN AWAY         |",
                "|  C) COLLECT TREASURE |",
                "|  P) PLAYER INFO      |",
                "|  M) MONSTER INFO     |",
                "|  E) END GAME         |"
                "------------------------\n"
            };

            bool exit = false;

            //name character
            Player name = new Player(inputName, 1, 1, 1, null);

            //intro to pick character variables and weapons
            string introduction = "Welcome to the Dungeon.";
            string charCreate = "You will now pick whom you would like to be.";

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

            bool validPlayerChoice = false;

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

            //create monster dictionary

            Dictionary<int, Rooms> dungeonRooms = new Dictionary<int, Rooms>();
            Rooms dungeonRoom1 = new Rooms()
            {
                RoomID = 1;
                RoomName = "The Silent Quarters "
                RoomDescription = "You enter a medium-sized room. The silence is eerie"
            }


            Console.WriteLine(titleGame);
            Console.WriteLine(gameDescription);

            ConsoleKey userChoice = Console.ReadKey(intercept: true).Key;


            switch (userChoice)
            {
                case ConsoleKey.K:
                    Console.WriteLine("Good choice wise knight, you have been equipped with a Double-Edged sword.");
                    Weapon sword = new Weapon() //object notation, mostly used at VU
                    {
                        Name = "Double Edged Sword",
                        MinDamage = 0,
                        MaxDamage = 8,
                        IsTwoHanded = true,
                        BonusHitChance = .25f
                    };
                    break;
                case ConsoleKey.S:
                    Console.WriteLine("Good choice wise soldier, you have been equipped with a M4 Carbine.");
                    Weapon gun = new Weapon() 
                    {
                        Name = "M4 Carbine",
                        MinDamage = 0,
                        MaxDamage = 10,
                        IsTwoHanded = true,
                        BonusHitChance = .25f
                    };
                    break;
                case ConsoleKey.R:
                    Console.WriteLine("Good choice ranger, you have been equipped with an axe.");
                    Weapon gun = new Weapon()
                    {
                        Name = "Rifle",
                        MinDamage = 0,
                        MaxDamage = 6,
                        IsTwoHanded = true,
                        BonusHitChance = .25f      
                    }
                    break;
            }

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

