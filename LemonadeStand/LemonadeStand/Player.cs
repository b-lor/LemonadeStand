using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public string Name { get; set; }
        public Inventory inventory;
        public Account account;

        public Player()
        {
            inventory = new Inventory();
            account = new Account();
        }


    }

}
