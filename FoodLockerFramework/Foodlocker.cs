using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnackSpace;
using AppleSpace;
using BananaSpace;
using CandyBarSpace;
using PotatoChipsSpace;

namespace FoodLockerSpace
{
    public class FoodLocker
    {
        public enum Snacks { APPLE, BANANA, CANDYBAR, POTATOCHIPS }


        public readonly int size;
        public readonly int maxSize = 5;

        public FoodLocker()
        {
            size = maxSize;
        }

        public int Size
        {
            get
            {
                return size;
            }
        }

        public List<Snacks> Store;

        //put randome selectsions of items in the store
        public void Stock()
        {
            Store = new List<Snacks>();

            Random random = new Random();

            int randomNumber = random.Next(0, 10);
           
            int x;

            for (var i = 0; i < randomNumber; i++)
            {
                x = random.Next(0, 4);

                Store.Add((Snacks)(x));
            }
        }
    }

}
