using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public double cupPrice;
        public double icePrice;
        public double sugarPrice;
        public double lemonPrice;


        public Store()
        {
            cupPrice = 0.25D;
            icePrice = 0.50D;
            sugarPrice = 0.75D;
            lemonPrice = 0.75D;
        }

        public void DisplayItemPrice()
        {
            Console.WriteLine("Price    : Items:");
            Console.WriteLine("{0:0.00} : Cup   - 1 count", cupPrice);
            Console.WriteLine("{0:0.00} : Ice   - 1 scoop", icePrice);
            Console.WriteLine("{0:0.00} : Sugar - 1 scoop", sugarPrice);
            Console.WriteLine("{0:0.00} : Lemon - 1 whole", lemonPrice);
        }

        public void BuyItems()
        {
            string itemToBuy;
            Console.WriteLine();
            Console.WriteLine("Item #:  Description");
            Console.WriteLine("'1'   :  Buy more cups");
            Console.WriteLine("'2'   :  Buy more ice");
            Console.WriteLine("'3'   :  Buy more sugar");
            Console.WriteLine("'4'   :  Buy more lemon");
            itemToBuy = Console.ReadLine();

            switch(itemToBuy)
            {
                case "1":
                    Console.WriteLine("How many cups would you like to purchase?");
                    purchaseCup();

                    break;
                case "2":
                    Console.WriteLine("How many scoops of ice would you like to purchase?");
                    purchaseIce();
                    break;
                case "3":
                    Console.WriteLine("How many scoops of sugar would you like to purchase?");
                    purchaseSugar();
                    break;
                case "4":
                    Console.WriteLine("How many lemons would you like to purchase?");
                    purchaseLemon();
                    break;
                default:
                    Console.WriteLine("Please enter a valid item number (1-4)");
                    break;
            }

        }
        public void purchaseCup()
        {
            int item;
            item = Convert.ToInt32(Console.ReadLine());
        }

        public void purchaseIce()
        {
            int item;
            item = Convert.ToInt32(Console.ReadLine());
        }

        public void purchaseSugar()
        {
            int item;
            item = Convert.ToInt32(Console.ReadLine());
        }

        public void purchaseLemon()
        {
            int item;
            item = Convert.ToInt32(Console.ReadLine());
        }
    }
}
