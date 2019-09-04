using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CoinSpace
{

    public class Coin
    {
        private Denomination _pocketChange;

        public enum Denomination
        { SLUG = 0, NICKEL = 5, DIME = 10, QUARTER = 25, HALFDOLLAR = 50 }

        public static readonly Coin HALFDOLLARCOIN = new Coin(Denomination.HALFDOLLAR);
        public static readonly Coin QUARTERCOIN = new Coin(Denomination.QUARTER);
        public static readonly Coin DIMECOIN = new Coin(Denomination.DIME);
        public static readonly Coin NICKELCOIN = new Coin(Denomination.NICKEL);
        public static readonly Coin SLUGCOIN = new Coin(Denomination.SLUG);


        public Coin()
        {
            _pocketChange = Denomination.SLUG;
        }

        public Coin(Denomination CoinEnumeral)
        {
            _pocketChange = CoinEnumeral;
        }

        public Coin(string CoinName)
        {
            CoinName = CoinName.ToUpper();
            if(Enum.TryParse(CoinName, out Denomination coinName) && Enum.IsDefined(typeof(Denomination), CoinName))
            {
                _pocketChange = coinName;
            }
            else
            {
                _pocketChange = Denomination.SLUG;
                Debug.WriteLine($"Coin({CoinName}) tryparse was not successful");   
            }
        }
        
        public static Coin.Denomination ConvertStringToEnumeral(string CoinName)
        {
            Denomination denominationEnumeral = (Denomination)Enum.Parse(typeof(Denomination), CoinName);
            return denominationEnumeral;
        }

        public Coin(decimal CoinValue)
        {
            if (Enum.IsDefined(typeof(Denomination), CoinValue))
            {
                _pocketChange = (Denomination)CoinValue;
            }
            else
            {
                _pocketChange = Denomination.SLUG;
                Debug.WriteLine($"Coin({CoinValue}) tryparse was not successful");
            }
        }

        private static List<Denomination> _allDenominations = new List<Denomination>();

        static Coin()
        {
            foreach (string coinName in Enum.GetNames(typeof(Denomination)))
            {
                Denomination denominationEnumeral;
                Enum.TryParse<Denomination>(coinName, out denominationEnumeral);
                _allDenominations.Add(denominationEnumeral);
            }
        }

        public static decimal ValueOfCoin(Coin.Denomination denominationEnumeral)
        {
            return convertEnumeralToDecimal(denominationEnumeral);
        }

        private static decimal convertEnumeralToDecimal(Coin.Denomination denominationEnumeral)
        {
            return (decimal)denominationEnumeral / 100M;
        }

        public decimal ValueOf
        {
            get
            {
                if ((int)_pocketChange > 1m)
                {
                    return ((decimal)_pocketChange / 100m);
                }
                return (decimal)_pocketChange;
            }
        }

        public Denomination CoinEnumeral
        {
            get
            {
                return _pocketChange;
            }
        }
        public static List<Denomination> AllDenominations
        {
            get
            {
                return _allDenominations;
            }
        }

        public override string ToString()
        {
            return Enum.GetName(typeof(Denomination), _pocketChange);
        }

    }  
}