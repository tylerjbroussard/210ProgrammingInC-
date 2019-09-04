using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnackSpace;
using HealthFoodSpace;
using PurchasePriceSpace;

namespace BananaSpace
{
    class Banana : HealthFood
    {
        public Banana(DateTime dateTime, string name, PurchasePrice price) : base(dateTime, name, price)
        {

        }

        public override string ToString()
        {
            string message = base.ToString();
            return string.Format($"Banana\n{message}");
        }
    }
}
