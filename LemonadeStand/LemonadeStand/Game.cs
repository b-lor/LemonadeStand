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
        public Inventory inventory = new Inventory();
        public int numberOfDaysToPlay;

        public void Intro()
        {
            GameRules();
            Console.ReadLine();
            Weather weather = new Weather();
            weather.ActualWeather();
            StartGame();
        }

        public void StartGame()
        {
            Console.Clear();
            string playerName = createPlayer();
            createDays();
            //checkInventory();
            //inventory.CurrentInventory();
            cashToSpend();
            VisitStore();

        }

        public void VisitStore()
        {
            storeInfo();
            Store store = new Store();
            store.DisplayItemPrice();
            store.BuyItems();


        }

        public string createPlayer()
        {
            Console.WriteLine("Please enter your name:");
            string playerName = Console.ReadLine();
            Console.WriteLine($"\n\nHowdy {playerName}, I'll be your guide today so let me help you get started.\n");
            return playerName;
        }

        public void createDays()
        {
            int daysToPlay;
            AskDaysToPlay();

            while(!int.TryParse(Console.ReadLine(), out daysToPlay) || daysToPlay < 7 || daysToPlay > 21)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Input, please select a valid number between 7-21");
            }
            numberOfDaysToPlay = daysToPlay;
            Console.WriteLine($"Ok, you've selected to play for {daysToPlay} days.");
            Console.ReadKey();
            Console.Clear();
        }

        public void cashToSpend()
        {
            double myCash = 0;
            Account account = new Account();
            myCash = account.cashOnHand;
            Console.WriteLine($"You have ${myCash} to spend.");

        }
    }
}
