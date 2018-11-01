using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public Recipe newRecipe;
        public int numberOfCup;
        public int numberOfIce;
        public int numberOfSugar;
        public int numberOfLemon;
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
            
            while (numberOfCup == 0 || numberOfIce == 0 || numberOfSugar == 0 || numberOfLemon == 0)
            {
                Console.WriteLine("You need to go to the store to buy more required items. Type 'yes' to go shopping or 'no' to quit...");
                checkInput = Console.ReadLine();
                if (checkInput[0] == 'y' || checkInput[0] == 'Y')
                {
                    break;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }

        
    }
}
