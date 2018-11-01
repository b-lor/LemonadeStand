using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Sugar : Inventory
    {
        public double sugarInStock;

        public Sugar()
        {
            sugarInStock = 0;       
        }
    }
}
