using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand 
{
    public class Inventory
    {
        public double numberOfCup;
        public double numberOfIce;
        public double numberOfSugar;
        public double numberOfLemon;
        public int numberOfPitcher;

        public Inventory()
        {
            numberOfCup = 0;
            numberOfIce = 0;
            numberOfSugar = 0;
            numberOfLemon = 0;
            numberOfPitcher = 0;

        }

        public void CurrentInventory()
        {
            string checkInput;
            Console.WriteLine($"Inventory:   Cups: {numberOfCup}   Ice: {numberOfIce}   Sugar: {numberOfSugar}   Lemon: {numberOfLemon}");
            // minimum inventory to start game
            if (numberOfCup < 15 || numberOfIce < 2 || numberOfSugar < 2 || numberOfLemon < 2)
            {
                Console.WriteLine("You do not have enough to make 1 pitcher of lemonade. Let's go shopping now.");
                System.Threading.Thread.Sleep(2000);
            }
            Console.WriteLine("Do you still want to go to the store?");
            Console.WriteLine("Type 'Yes' to visit store or 'No' to exit game");
            checkInput = Console.ReadLine();
            if (checkInput[0] == 'y' || checkInput[0] == 'Y')
            {

            }
            else
            {
                Environment.Exit(0);
            }

        }

    }
}
