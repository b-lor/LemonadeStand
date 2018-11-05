using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
  

    class UserInterface
    {

        public void GameRules()
        {
            Console.WriteLine("Welcome to Lemonade Stand\n");
            Console.WriteLine("You receive a $50 birthday gift from your Grandma but you wanted a Playstation9 instead.\n");
            Console.WriteLine("The newest Playstation9 is $300. You still need $250 to purchase the system so you decide to open up a lemonade stand.\n");
            Console.ReadLine();
            Console.WriteLine("Here are the rules to the game:\n");

            Console.WriteLine("In order to get started, you'll have to purchase 4 main ingredients, lemons, sugar, plastic cups and ice cubes in order to start.\n");

            Console.WriteLine("1. All unused lemonade will be discarded at the end of every day.");
            Console.WriteLine("2. Ice cubes melt at the end of every day so you will have to purchase them every morning.\n");
            Console.WriteLine("3. Lemons and sugar has a 7 day shelf life but beware of those pesky bugs, they can ruin your inventory.\n");
            Console.WriteLine("4. Plastic cups will last forever.  Puchase as needed.\n");

            Console.WriteLine("You will start with your Grandma's lemonade recipe.\n");
            Console.WriteLine("You can tweak the ingredients to increase or decrease sales.\n");
            Console.WriteLine("You have full control of inventory, pricing, quality control and recipe.\n");
            Console.WriteLine("You'll have to deal with mother nature as well. Depending on the weather, you may sell more or less.\n");
        }

        public void AskDaysToPlay()
        {
            Console.WriteLine("To make it worth your time, you'd have to work at least 7 days but no longer than 21 days.");
            Console.WriteLine("How many days would you like to open the lemonade stand?");
        }

        public void checkInventory()
        {
            Console.WriteLine("Before we start, we need to look at your current inventory level.");
        }

        public void storeInfo()
        {
            Console.WriteLine("Before we go to the store to make your purchases, take a look at my recipe?");
            Console.WriteLine("It's not too sweet nor is it too sour. Adjust recipe to make it sweeter/more sour.");
            Console.WriteLine("Adjust if you are not selling enough or if you are selling too much too quick.");
            Console.WriteLine("My recipe makes 15 cups (1 pitcher) of lemonade. At a minimum, you'll need this amount to start");
            Console.WriteLine("Ice   - 2 scoop");
            Console.WriteLine("Sugar - 2 scoop");
            Console.WriteLine("Lemon - 2 whole lemon");
            Console.WriteLine("Cups  - 15 per pitcher");
            Console.WriteLine("You are now at the store, here is a list of their pricing.");
            Console.WriteLine("Buy only what you think you need, items not used are destined to go to waste");
        }
        
        public void changeRecipePrompt()
        {
            Console.WriteLine("Cups : 15 cups   Ice : 2 scoops   Sugar : 2 scoops    Lemon : 2 whole lemon");
            Console.WriteLine($"This is your default Lemonade recipe and the minimum required to make 1 pitcher.");
            Console.WriteLine("Would you like to change it, type 'yes' to change or 'no' to start the day");

        }

        public void itemsToChangePrompt()
        {
            Console.WriteLine("What woud you like to add to your current recipe?");
            Console.WriteLine("Type 'ice', 'sugar' or 'lemon' to change it's default value.");
        }
    }
}
