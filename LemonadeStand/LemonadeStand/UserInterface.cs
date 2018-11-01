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
            Console.WriteLine("To make it worth your time, you'd have to work at least 7 days.");
            Console.WriteLine("How many days would you like to open the lemonade stand?");
        }

    }
}
