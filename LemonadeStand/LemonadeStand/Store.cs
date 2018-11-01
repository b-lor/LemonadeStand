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
            cupPrice = 0.50D;
            icePrice = 1.00D;
            sugarPrice = 1.00D;
            lemonPrice = 1.00D;
        }

        public void DisplayItemPrice()
        {
            Console.WriteLine("Item Prices:");
            Console.WriteLine("{0:0.00} : Cup   - 1 qty", cupPrice);
            Console.WriteLine("{0:0.00} : Ice   - 1 scoop", icePrice);
            Console.WriteLine("{0:0.00} : Sugar - 1 scoop", sugarPrice);
            Console.WriteLine("{0:0.00} : Lemon - 1 qty", lemonPrice);


        }
    }
}
