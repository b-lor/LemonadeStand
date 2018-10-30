using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public void StartGame()
        {

            GameRules();

            Console.ReadLine();
        }

        public void GameRules()
        {
            Console.WriteLine("Welcome to Milwaukee's hottest Lemonade Stand");
            Console.ReadLine();
            Console.WriteLine("You have 'X' amount of days to sell as much lemonade as possible. You will set the number of days (minimum 7 days).\n");
            Console.WriteLine("You'll have to purchase 4 main ingredients, lemons, sugar, plastic cups and ice cubes.\n");
            Console.WriteLine("Ice cubes melt at the end of every day so you will have to purchase them each morning.\n");
            Console.WriteLine("Lemons have a 36 hour shelf life - anything you purchase in the morning will go bad at the end of the next day.\n");
            Console.WriteLine("Sugar and plastic cups have no shelf life.  Puchase as needed.\n");
            Console.WriteLine("By default, there is an old lemonade recipe that you will use and a price for each of those cups. You can tweak the ingredients and price per your demands.\n");
            Console.WriteLine("You have full control of inventory, pricing, quality control and recipe.\n");
            Console.WriteLine("You'll have to deal with mother nature as well. Depending on the weather, you may sell more or less.\n");
            Console.WriteLine("The more sun and higher temperature, the more you'll sell. The wetter and lower temperature, the less sales.\n");
        }
    }
}
