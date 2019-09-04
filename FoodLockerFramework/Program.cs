using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppleSpace;
using BananaSpace;
using CandyBarSpace;
using FoodLockerSpace;
using HealthFoodSpace;
using JunkfoodSpace;
using PotatoChipsSpace;
using SnackSpace;
using PurchasePriceSpace;

namespace FoodLockerFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodLocker food = new FoodLocker();

            food.Stock();

            foreach(var item in food.Store)
            {
                
                Console.WriteLine(item.ToString());
            }

            

            PurchasePrice price = new PurchasePrice(5);



            Apple apple = new Apple("Washington red", price, DateTime.Now);
            Banana banana = new Banana(DateTime.Now, "Georges favorite!", new PurchasePrice(99));
            CandyBar candy = new CandyBar(56, "Fatty bar", new PurchasePrice(25));
            PotatoChips potatoChips = new PotatoChips(99, "Lazzzz", new PurchasePrice(87));

            Console.WriteLine(apple.ToString() + banana.ToString() + candy.ToString() + potatoChips.ToString());


        }
    }
}
