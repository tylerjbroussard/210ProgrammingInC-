using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnackSpace;
using PurchasePriceSpace;

namespace HealthFoodSpace
{
    abstract class HealthFood : Snack
    {
        private DateTime FreshUntil = DateTime.Now;

        public HealthFood(DateTime dateTime, string name, PurchasePrice price) : base(name, price)
        {
            this.FreshUntil = dateTime;
        }
        
        public override string ToString()
        {
            string newMessage = base.ToString();
            return string.Format($"{newMessage}\nFresh until: {FreshUntil}");

        }
    }
}
//HealthFood has a constructor that takes three parameters: string name, PurchasePrice price, and DateTime freshUntil. 