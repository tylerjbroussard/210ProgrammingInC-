using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnackSpace;
using JunkfoodSpace;
using PurchasePriceSpace;

namespace CandyBarSpace
{
    class CandyBar : JunkFood
    {
        public CandyBar(int caloriesFromFat, string name, PurchasePrice price) : base(caloriesFromFat, name, price)
        {

        }

        public override string ToString()
        {
            string message = base.ToString();
            return string.Format($"Candy Bar\n{message}");
        }

    }
}
