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
        Inventory inventory = new Inventory();
        Account account = new Account();

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
            Console.WriteLine($"You have ${account.cashOnHand} left to spend.");
            string itemToBuy;
            Console.WriteLine();
            Console.WriteLine("Item #:  Description");
            Console.WriteLine("'1'   :  Buy more cups");
            Console.WriteLine("'2'   :  Buy more ice");
            Console.WriteLine("'3'   :  Buy more sugar");
            Console.WriteLine("'4'   :  Buy more lemon");
            Console.WriteLine("'5'   :  Skip the store, let's begin");
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
                case "5":
                    Console.WriteLine("All Set. Let's go make some lemonade.");
                    makeLemonade();
                    break;
                default:
                    Console.WriteLine("Please enter a valid item number (1-5)");
                    break;
            }

        }
        public void purchaseCup()
        {
            double qtyToBuy = ValidateQTY();
            double totalCost = qtyToBuy * cupPrice;
            Console.WriteLine("cost to purchase it $" + totalCost);

            double overAmount = totalCost - account.cashOnHand;

            while (totalCost > account.cashOnHand)
            {
                Console.WriteLine($"Your balance ${account.cashOnHand}. You need ${overAmount} more to purchase {qtyToBuy} cups. ");
                Console.WriteLine("Please enter a different quantity");
                purchaseCup();
                break;
            }
            Console.WriteLine($"Are you sure you want to purchase {qtyToBuy} cups for {totalCost}?");
            Console.WriteLine("Type 'Yes' to confirm and exit this screen, 'No' to enter a new qty to purchase.");

            string input = Console.ReadLine();
            if (input[0] == 'n' || input[0] == 'N')
            {
                Console.WriteLine("Enter your new quantity now.");
                purchaseCup();
            }
            else
            {
                account.cashOnHand = account.cashOnHand - totalCost;
                inventory.numberOfCup = inventory.numberOfCup + qtyToBuy;
                inventory.CurrentInventory();
                BuyItems();
            }
        }


        public void purchaseIce()
        {
            double qtyToBuy = ValidateQTY();
            double totalCost = qtyToBuy * icePrice;
            Console.WriteLine("cost to purchase it $" + totalCost);

            double overAmount = totalCost - account.cashOnHand;

            while (totalCost > account.cashOnHand)
            {
                Console.WriteLine($"Your balance ${account.cashOnHand}. You need ${overAmount} more to purchase {qtyToBuy} ice. ");
                Console.WriteLine("Please enter a different quantity");
                purchaseCup();
                break;
            }
            Console.WriteLine($"Are you sure you want to purchase {qtyToBuy} ice for ${totalCost}?");
            Console.WriteLine("Type 'Yes' to confirm and exit this screen, 'No' to enter a new qty to purchase.");

            string input = Console.ReadLine();
            if (input[0] == 'n' || input[0] == 'N')
            {
                Console.WriteLine("Enter your new quantity now.");
                purchaseIce();
            }
            else
            {
                account.cashOnHand = account.cashOnHand - totalCost;
                inventory.numberOfIce = inventory.numberOfIce + qtyToBuy;
                inventory.CurrentInventory();
                BuyItems();
            }
        }

        public void purchaseSugar()
        {
            double qtyToBuy = ValidateQTY();
            double totalCost = qtyToBuy * sugarPrice;
            Console.WriteLine("cost to purchase it $" + totalCost);

            double overAmount = totalCost - account.cashOnHand;

            while (totalCost > account.cashOnHand)
            {
                Console.WriteLine($"Your balance ${account.cashOnHand}. You need ${overAmount} more to purchase {qtyToBuy} sugar. ");
                Console.WriteLine("Please enter a different quantity");
                purchaseCup();
                break;
            }
            Console.WriteLine($"Are you sure you want to purchase {qtyToBuy} sugar for ${totalCost}?");
            Console.WriteLine("Type 'Yes' to confirm and exit this screen, 'No' to enter a new qty to purchase.");

            string input = Console.ReadLine();
            if (input[0] == 'n' || input[0] == 'N')
            {
                Console.WriteLine("Enter your new quantity now.");
                purchaseSugar();
            }
            else
            {
                account.cashOnHand = account.cashOnHand - totalCost;
                inventory.numberOfSugar = inventory.numberOfSugar + qtyToBuy;
                inventory.CurrentInventory();
                BuyItems();
            }
        }

        public void purchaseLemon()
        {
            double qtyToBuy = ValidateQTY();
            double totalCost = qtyToBuy * lemonPrice;
            Console.WriteLine("cost to purchase it $" + totalCost);


            double overAmount = totalCost - account.cashOnHand;

            while (totalCost > account.cashOnHand)
            {
                Console.WriteLine($"Your balance ${account.cashOnHand}. You need ${overAmount} more to purchase {qtyToBuy} lemons. ");
                Console.WriteLine("Please enter a different quantity");
                purchaseCup();
                break;
            }
            Console.WriteLine($"Are you sure you want to purchase {qtyToBuy} lemons for ${totalCost}?");
            Console.WriteLine("Type 'Yes' to confirm and exit this screen, 'No' to enter a new qty to purchase.");

            string input = Console.ReadLine();
            if (input[0] == 'n' || input[0] == 'N')
            {
                Console.WriteLine("Enter your new quantity now.");
                purchaseLemon();
            }
            else
            {
                account.cashOnHand = account.cashOnHand - totalCost;
                inventory.numberOfLemon = inventory.numberOfLemon + qtyToBuy;
                inventory.CurrentInventory();
                BuyItems();
            }
        }

        public double ValidateQTY()
        {
            int qty = 0;

            while (!int.TryParse(Console.ReadLine(), out qty))
            {
                Console.WriteLine("Please enter a valid numerical value!");
            }

            return qty;

        }

        public void makeLemonade()
        {
            Recipe recipe = new Recipe();
            recipe.createLemonade();

        }
    }
}
