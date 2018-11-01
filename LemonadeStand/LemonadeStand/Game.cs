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
            AskDaysToPlay();
            string daysToPlay = Console.ReadLine();


        }
    }
}
