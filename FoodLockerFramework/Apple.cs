using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnackSpace;
using HealthFoodSpace;
using PurchasePriceSpace;

namespace AppleSpace
{
    class Apple : HealthFood
    {

        public Apple(string name, PurchasePrice price, DateTime dateTime) : base(dateTime, name, price)
        {

        }

        public override string ToString()
        {
            string message = base.ToString();
            return string.Format($"Apple\n{message}");
        }
    }
}
