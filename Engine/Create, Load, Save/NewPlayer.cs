﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Create__Load__Save
{
    public static class NewPlayer
    {
        public static void CreateNewPlayer()
        {
            string userInput;              // Holds user's input
            bool validInput = false;


            while(validInput == false)
            {
                Console.WriteLine("Are you a new player?");
                Console.Write("> ");
                userInput = Console.ReadLine();

                if(userInput.ToLower() == "no")
                {
                    validInput = true;
                    Console.WriteLine("What is your character's name?");
                    userInput = Console.ReadLine();
                    // Load game
                }
                else if (userInput.ToLower() == "yes")
                {
                    validInput = true;
                    CreatePlayer.CreatePlayerMenu();
                }
                else
                {
                    Console.WriteLine("Not a valid option. Please try again!");
                    CreatePlayer.CreatePlayerMenu();
                }
            }
        }
    }
}
