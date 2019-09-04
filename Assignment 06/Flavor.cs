using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;

namespace FlavorSpace
{
    public enum Flavor { REGULAR, ORANGE, LEMON }

    public static class FlavorOps
    {
        private static List<Flavor> _allFlavors = new List<Flavor>();

        //dynamically adds all enum flavors to the list
        static FlavorOps()
        {
            foreach (Flavor value in Enum.GetValues(typeof(Flavor)))
            {
                _allFlavors.Add(value);
            }
        }

        // method to convert a string value into an enumeral         
        public static Flavor ToFlavor(string FlavorName)
        {
            FlavorName = FlavorName.ToUpper();
            if (Enum.IsDefined(typeof(Flavor), FlavorName))
            {
                return (Flavor)Enum.Parse(typeof(Flavor), FlavorName);
            }
            else
            {
                throw new InvalidEnumArgumentException(string.Format($"Exception {FlavorName} not recognized"));
            }
        }

        // property to return a List<Flavor> of all of the Varieties         
        public static List<Flavor> AllFlavors
        {
            get
            {
                return _allFlavors;
            }
        }
    }

}
