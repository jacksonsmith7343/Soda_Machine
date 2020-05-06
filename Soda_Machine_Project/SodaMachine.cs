using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine_Project
{
    class SodaMachine
    {
        //member variables (has a)
        public List<Coin>internalRegister;
        public List<Soda> internalInventory;


        //constructor (spawner)
        public SodaMachine()
        {
            
            internalRegister = new List<Coin>();

            for (int index = 0; index < 20; index++)
            {
                Quarter quarter = new Quarter();
                internalRegister.Add(quarter);
            }

            for (int index = 0; index < 10; index++)
            {
                Dime dime = new Dime();
                internalRegister.Add(dime);
            }

            for (int index = 0; index < 20; index++)
            {
                Nickel nickel = new Nickel();
                internalRegister.Add(nickel);
            }
            for (int index = 0; index < 50; index++)
            {
                Penny penny = new Penny();
                internalRegister.Add(penny);
            }

            internalInventory = new List<Soda>();

            for (int index = 0; index < 10; index++)
            {
                GrapeSoda grapeSoda = new GrapeSoda();
                internalInventory.Add(grapeSoda);
            }
            for (int index = 0; index < 10; index++)
            {
                OrangeSoda orangeSoda = new OrangeSoda();
                internalInventory.Add(orangeSoda);
            }
            for (int index = 0; index < 10; index++)
            {
                LemonSoda lemonSoda = new LemonSoda();
                internalInventory.Add(lemonSoda);
            }
        }


        //member methods (can do)
        public void SodaMenu()
        {
            Console.WriteLine("Welcome to soda machine. What would you like to do? \n1) Buy GrapeSoda? \n2) Buy OrageSoda? \n3) Buy LemonSoda?");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    SellGrapeSoda();
                    break;
                case "2":
                    SellOrangeSoda();
                    break;
                case "3":
                    SellLemonSoda();
                    break;
            }
        }

        public void SellGrapeSoda()
        {
            Console.WriteLine("Grape soda costs 60 cents. Please add money.");
            if (moneyGiven == priceOfGrapeSoda)
            {
                DispenseGrapeSoda();
            }
            else if (moneyGiven > priceOfGrapeSoda)
            {
                DispenseGrapeSoda();
                DispenseMoney();
            }
            else
            {
                DispenseMoney();
            }
        }

        public void SellOrangeSoda()
        {
            Console.WriteLine("Orange soda costs 35 cents. Please add money.");
            if (moneyGiven == priceOfOrangeSoda)
            {
                DispenseOrangeSoda();
            }
            else if (moneyGiven > priceOfOrangeSoda)
            {
                DispenseOrangeSoda();
                DispenseMoney();
            }
            else
            {
                DispenseMoney();
            }
        }
        public void SellLemonSoda()
        {
            Console.WriteLine("Lemon soda costs 6 cents. Please add money.");
            if (moneyGiven == priceOfLemonSoda)
            {
                DispenseLemonSoda();
            }
            else if (moneyGiven > priceOfLemonSoda)
            {
                DispenseLemonSoda();
                DispenseMoney();
            }
            else
            {
                DispenseMoney();
            }
        }

        public void DispenseMoney()
        {
            
        }
        public void DispenseGrapeSoda()
        {
            internalInventory.RemoveAt(0);
        }
        public void DispenseOrangeSoda()
        {
            internalInventory.RemoveAt(0);
        }
        public void DispenseLemonSoda()
        {
            internalInventory.RemoveAt(0);
        }
    }
}
