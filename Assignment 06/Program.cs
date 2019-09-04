using System;
using PurchasePriceSpace;
using CanRackSpace;
using CanSpace;
using CoinSpace;
using FlavorSpace;
using CoinBoxSpace;
using VendorBadFlavorSpace;
using System.Diagnostics;


namespace MainSpace
{
    class Program
    {     
        public static string userInput;
        public static bool LoopBridge = true;
        public static PurchasePrice soda;        
        public static CanRack canRack = new CanRack();
        public static CoinBox coinbox = new CoinBox();

        static void SetSodaPrice()
        {
            Console.Write("Welcome to the .NET C# Soda Vending Machine.\nHow much is the current price of Soda, please enter a value between $0 - $1.00 : ");

            userInput = Console.ReadLine();

            if(decimal.Parse(userInput) > 1m)
            {
                userInput = (int.Parse(userInput) / 100m).ToString();
            }            

            if (decimal.TryParse(userInput, out decimal x))
            {
                soda = new PurchasePrice(x);                
            }
            else
            {
                soda = new PurchasePrice(int.Parse(Program.userInput));                
            }
        }

        static void PaySodaPrice()
        {
            decimal price;
            if (soda.Price != 0)
            {
                Console.Write($"Please insert {soda.Price:c}\nType in either a nickel, dime, quarter, or halfdoller to pay for the soda: ");

                price = soda.Price;

            }
            else
            {
                Console.Write($"Please insert {soda.PriceDecimal:c}\nType in either a nickel, dime, quarter, or halfdoller to pay for the soda: ");

                price = soda.PriceDecimal;
            }

            userInput = Console.ReadLine();
            
            coinbox.Deposit(new Coin(userInput));


            if(coinbox.ValueOf() < price)
            {
                Console.WriteLine($"{coinbox.ValueOf():c} is less than {price:c}, please add more money.");

                PaySodaPrice();
            }
            else
            {
                Console.WriteLine($"You paid {coinbox.ValueOf():c}. Thank you!");
            }
        }

        static void SelectSodaFlavor()
        {
            Console.WriteLine("Please select a flavor: Regular, Orange, Lemon: ");

            userInput = Console.ReadLine().ToUpper();

            try
            {
                var flavorName = (Flavor)Enum.Parse(typeof(Flavor), userInput);
                Can can = new Can(FlavorOps.ToFlavor(userInput));
                canRack.RemoveACanOf(can.TheFlavor);
                Debug.Write($"Result {flavorName}");
            }
            catch (Exception exc)
            {
                Console.WriteLine("Incorrect entry, please try again.");
                Debug.WriteLine($"Exception {exc.Message}");
                SelectSodaFlavor();
            }
        }

        static void CompleteOrder()
        {
            canRack.DisplayCanRack();

            Console.WriteLine($"\n{coinbox.SlugCount} Slugs, {coinbox.NickelCount} Nickels, {coinbox.DimeCount} Dimes, {coinbox.QuarterCount} Quarters, {coinbox.HalfDollarCount} Halfdollars. Total Value of CoinBox: {coinbox.ValueOf():c2}.\nWould you like another can, yes or no: ");


            userInput = Console.ReadLine();

            if (userInput == "yes")
            {
                Console.WriteLine("Thank you for your purchase");
                LoopBridge = true;
            }
            else if (userInput == "no")
            {
                LoopBridge = false;
            }
            else
            {
                Console.WriteLine("Please try again.");
                LoopBridge = false;
            }
        }

        static void Main()
        {

            canRack.FillTheCanRack();

            do
            {
                SetSodaPrice();

                PaySodaPrice();

                SelectSodaFlavor();

                CompleteOrder();

            } while (LoopBridge == true);
        }
    }
}

