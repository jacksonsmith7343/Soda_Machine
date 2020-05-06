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
        public List<GrapeSoda> grapeSodasInMachine;
        public List<OrangeSoda> orangeSodasInMachine;
        public List<LemonSoda> lemonSodasInMachine;
        public List<Coin> payment;
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

            grapeSodasInMachine = new List<GrapeSoda>();

            for (int index = 0; index < 10; index++)
            {
                GrapeSoda grapeSoda = new GrapeSoda();
                grapeSodasInMachine.Add(grapeSoda);
            }

            orangeSodasInMachine = new List<OrangeSoda>();
            for (int index = 0; index < 10; index++)
            {
                OrangeSoda orangeSoda = new OrangeSoda();
                orangeSodasInMachine.Add(orangeSoda);
            }

            lemonSodasInMachine = new List<LemonSoda>();
            for (int index = 0; index < 10; index++)
            {
                LemonSoda lemonSoda = new LemonSoda();
                lemonSodasInMachine.Add(lemonSoda);
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

            AllowPayment();

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
            grapeSodasInMachine.RemoveAt(0);
        }
        public void DispenseOrangeSoda()
        {
            orangeSodasInMachine.RemoveAt(0);
        }
        public void DispenseLemonSoda()
        {
            lemonSodasInMachine.RemoveAt(0);
        }

        public void AllowPayment()
        {
            payment = new List<Coin>();
        }
    }
}
