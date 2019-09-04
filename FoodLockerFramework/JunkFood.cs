/*
 * JunkFood has a constructor that takes three parameters: string name, PurchasePrice price, and int caloriesFromFat. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnackSpace;
using PurchasePriceSpace;

namespace JunkfoodSpace
{
    abstract class JunkFood : Snack
    {
        public int CaloriesFromFat;

        public JunkFood(int caloriesFromFat, string name, PurchasePrice price) : base(name, price)
        {
            this.CaloriesFromFat = caloriesFromFat;
        }
            
        public override string ToString()
        {
            string newMessage = base.ToString();
            return string.Format($"{newMessage}\nCalories from fat: {CaloriesFromFat}");
        }

    }
}
