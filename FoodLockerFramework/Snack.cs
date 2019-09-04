using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurchasePriceSpace;

namespace SnackSpace
{
    abstract class Snack
    {
        private string name;

        private PurchasePrice price;

        public Snack(string name, PurchasePrice price )
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return string.Format($"Name: {name}, Price: {price.Price:c}"); 
                
        }
    }
}

//Snack has a constructor that takes two parameters: string name and PurchasePrice price. 