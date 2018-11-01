using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Ice : Inventory
    {
        public double iceInStock;

        public Ice()
        {
            iceInStock = 0;
        }
    }
}
