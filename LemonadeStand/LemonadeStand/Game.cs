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
            StartGame();

            
        }

        public void StartGame()
        {
            string playerName = createPlayer();
            createDays();
            checkInventory();
            //inventory.CurrentInventory();
            listCup();
            cashToSpend();
            VisitStore();

        }

        public void listCup()
        {
            foreach(int cups in inventory.cup)
            {
                Console.WriteLine("youasdfjioasdfj isdjfsd" + cups);
            }

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
            Console.WriteLine($"Howdy {playerName}, I'll be your guide today so let me help you get started.");
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
            Console.WriteLine($"Ok, you've selected to play for {daysToPlay} days. Let's start...");
        }

        public void cashToSpend()
        {
            double myCash = 0;
            Account account = new Account();
            myCash = account.cashOnHand;
            Console.WriteLine($"Your current balance is ${myCash}.");

        }
    }
}
