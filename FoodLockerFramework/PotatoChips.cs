using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnackSpace;
using JunkfoodSpace;
using PurchasePriceSpace;

namespace PotatoChipsSpace
{
    class PotatoChips : JunkFood
    {
        public PotatoChips(int caloriesFromFat, string name, PurchasePrice price) : base(caloriesFromFat, name, price)
        {

        }

        public override string ToString()
        {
            string message = base.ToString();
            return string.Format($"Potato Chips\n{message}");
        }
    }
}
