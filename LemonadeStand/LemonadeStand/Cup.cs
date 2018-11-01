using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Cup :Inventory
    {
        public double cupInStock;

        public Cup()
        {
            cupInStock = 0;
        }
    }
}
