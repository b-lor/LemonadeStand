using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand 
{
    public class Inventory
    {
        public List<int> cup;
        public List<int> ice;
        public List<int> sugar;
        public List<int> lemon;
        //public double numberOfCup;
        //public double numberOfIce;
        //public double numberOfSugar;
        //public double numberOfLemon;


        public Inventory()
        {
            cup = new List<int>();
            ice = new List<int>();
            sugar = new List<int>();
            ice = new List<int>();
        }

        //public void CurrentInventory()
        //{
        //    //string checkInput;
        //    Console.WriteLine($"Inventory:   Cups: {numberOfCup}   Ice: {numberOfIce}   Sugar: {numberOfSugar}   Lemon: {numberOfLemon}");
        //    // minimum inventory to start game
        //    if (numberOfCup < 15 && numberOfIce < 2 && numberOfSugar < 2 && numberOfLemon < 2)
        //    {
        //        Console.WriteLine("You do not have enough to make 1 pitcher of lemonade. Let's go shopping now.");
        //        //System.Threading.Thread.Sleep(2000);
        //    }

        //    Console.WriteLine("Ok, you have enough for 1 pitcher now, you can buy more items or begin?");
        //Console.WriteLine("Type 'Yes' to visit store or 'No' to exit game");
        //checkInput = Console.ReadLine();

        //if (checkInput[0] == 'n' || checkInput[0] == 'N')
        //{
        //    Environment.Exit(0);
        //}
        //else if (checkInput[0] == 'y' || checkInput[0] == 'Y')
        //{

        //}
        //else
        //{
        //    Console.WriteLine(checkInput);
        //}

        //}


        public void AddCupToInventory(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                Cup cup = new Cup();
                cup.Add(cup);
            }
        }

        public void AddIceToInventory(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                Ice ice = new Ice();
                ice.Add(ice);
            }
        }

        public void AddSugarToInventory(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                Sugar sugar = new Sugar();
                sugar.Add(sugar);
            }
        }

        public void AddLemonToInventory(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                Lemon lemon = new Lemon();
                lemon.Add(lemon);
            }
        }

        internal void AddCupToInventory(double qtyToBuy)
        {
            throw new NotImplementedException();
        }
    }
}
