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
        public int cupsNeeded;
        public int iceNeeded;
        public int sugarNeeded;
        public int lemonNeeded;
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
            Console.WriteLine("Cups : 15 cups   Ice : 2 scoops   Sugar : 2 scoops    Lemon : 2 whole lemon");
            Console.WriteLine($"This is your default Lemonade recipe and the minimum required to make 1 pitcher.");
            Console.WriteLine("Would you like to change it, type 'yes' to change or 'no' to start the day");
        }



    }
}
