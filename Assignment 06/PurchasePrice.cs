namespace PurchasePriceSpace
{
    public class PurchasePrice
    {
        int _Price;
        public int Price
        {
            get
            {
                return _Price;
            }
            set
            {
                _Price = value;
            }
        }

        decimal _PriceDecimal;
        public decimal PriceDecimal
        {
            get
            {
                return _PriceDecimal;
            }        
            set
            {
                _PriceDecimal = value;
            }
        }
                
        public PurchasePrice()
        {
            _Price = 0;
            _PriceDecimal = 0m;
        }

        public PurchasePrice(int initialPrice)
        {
            Price = initialPrice;
        }

        public PurchasePrice(decimal initialPrice)
        {
            PriceDecimal = initialPrice;
        }     
    }
}
