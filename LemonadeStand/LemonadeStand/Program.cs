using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            // define rules to game
            // enter name
            // select the number of days to run
            // dislplay weather, inventory levels and bank account
            // visit store to buy materials
            // choose quantity of each material to use in lemonade
            // Define customer, more/less likely to make purchase based on price/quality
            // At the end of the day, display profit/loss statement
            // Create multiple players
            // integrate weather api based on current temp and forecast
            Game game = new Game();
            game.Intro();
            Console.ReadKey();
        }
    }
}
