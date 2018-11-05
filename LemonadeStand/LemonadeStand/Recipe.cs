using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        public decimal salePrice;
        public double cupsNeeded;
        public double iceNeeded;
        public double sugarNeeded;
        public double lemonNeeded;
        Inventory inventory = new Inventory();


        public Recipe()
        {
            salePrice = 1.00m;
            cupsNeeded = 15;
            iceNeeded = 2;
            sugarNeeded = 2;
            lemonNeeded = 2;
        }

        public void createLemonade()
        {
            UserInterface userInterface = new UserInterface();
            userInterface.changeRecipePrompt();

            string input = Console.ReadLine();
            if (input[0] == 'y' || input[0] == 'Y')
            {
                userInterface.itemsToChangePrompt();
                string changeItem = Console.ReadLine();

                if (changeItem[0] == 'i' || changeItem[0] == 'I')
                {
                    checkIceInventory();

                }
                else if (changeItem[0] == 's' || changeItem[0] == 'S')
                {

                }
                else if (changeItem[0] == 'l' || changeItem[0] == 'L')
                {

                }
                else
                {
                    Console.WriteLine("Please enter a valid option!");
                }
            }
            else if (input[0] == 'n' || input[0] == 'N')
            {
                // exit to lemonade stand
            }
            Console.WriteLine("Please enter a valid option");
            createLemonade();

            
        }

        public double changeRecipeItems()
        {
            int qty = 0;

            if (!int.TryParse(Console.ReadLine(), out qty))
            {
                Console.WriteLine("Please enter a valid numerical value!");
            }

            return qty;

        }

        public void checkIceInventory()
        {
            Console.Clear();
            Console.WriteLine("Here is your current inventory.");
            //inventory.CurrentInventory();
            //double result = inventory.numberOfIce - iceNeeded;
            //Console.WriteLine("total --- " + result);
            //Console.WriteLine("number of ice --- " + inventory.numberOfIce);
            //Console.WriteLine("ice needed ----" + iceNeeded);
            //Console.WriteLine("Enter qty you'd like to add to recipe.");
            //if ((inventory.numberOfIce - iceNeeded) >= changeRecipeItems())
            //{
            //    Console.WriteLine("You do not have enough items in your inventory to make this change.");
            //    checkIceInventory();
            //}
            //else
            //{
            //    iceNeeded = iceNeeded + changeRecipeItems();
            //    Console.WriteLine($"your new {iceNeeded} is this");

            //}
        }

        }
    }
