using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game : UserInterface
    {
        public Player playerName;

        public void Intro()
        {
            GameRules();
            Console.ReadLine();
            StartGame();
            DaysToOpen();
        
        }

        public void StartGame()
        {
            createPlayer();
            createDays();
        }

        public void DaysToOpen()
        {

        }

        public void createPlayer()
        {
            Console.WriteLine("Please enter your name:");
            playerName = new Player(Console.ReadLine());
            Console.WriteLine($"Howdy { playerName.name}, I'll be your guide today so let me help you get started.");
        }

        public void createDays()
        {
            int daysToPlay;
            AskDaysToPlay();

            while(!int.TryParse(Console.ReadLine(), out daysToPlay) || daysToPlay < 7 || daysToPlay > 21)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Input, please select a number between 7-21");
            }
            Console.WriteLine($"You have selected to play for {daysToPlay} days.");
        }

    }
}
