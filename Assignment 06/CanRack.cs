using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections;
using FlavorSpace;

namespace CanRackSpace
{
    public class CanRack
    {
        Dictionary<Flavor, List<string>> _TotalCans = new Dictionary<Flavor, List<string>>();
                
        readonly int _capacity = 3;
        readonly int _empty = 0;

        public CanRack()
        {
            foreach (Flavor aFlavor in FlavorOps.AllFlavors)
            {
                _TotalCans.Add(aFlavor, new List<string> { Capacity = _capacity });
            }

            Debug.WriteLine("New can rack object instantiated.");
        }

        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            if (_TotalCans[FlavorOps.ToFlavor(FlavorOfCanToBeAdded)].Count == _capacity)
            {
                Console.WriteLine($"The rack for {FlavorOfCanToBeAdded} is currently full. Try again.");
                Debug.WriteLine($"{FlavorOfCanToBeAdded} rack is full");
            }
            else
            {
                _TotalCans[FlavorOps.ToFlavor(FlavorOfCanToBeAdded)].Add("can");
                Debug.WriteLine($"Adding a can of {FlavorOfCanToBeAdded} to the rack.");
            }
        }

        public void AddACanOf(Flavor FlavorOfCanToBeAdded)
        {
            if (_TotalCans[FlavorOfCanToBeAdded].Count == _capacity)
            {
                Console.WriteLine($"The rack for {FlavorOfCanToBeAdded} is currently full. Try again.");
                Debug.WriteLine($"{FlavorOfCanToBeAdded} rack is full");
            }
            else
            {
                _TotalCans[FlavorOfCanToBeAdded].Add("can");
                Debug.WriteLine($"Adding a can of {FlavorOfCanToBeAdded} to the rack.");
            }
        }

        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            if (_TotalCans[FlavorOps.ToFlavor(FlavorOfCanToBeRemoved)].Count > _empty)
            {
                _TotalCans[FlavorOps.ToFlavor(FlavorOfCanToBeRemoved)].Remove("can");
                Console.WriteLine($"Dispensing a can of {FlavorOfCanToBeRemoved}");
                Debug.WriteLine($"Removing a can of {FlavorOfCanToBeRemoved} from the rack.");
            }
            else
            {
                Console.WriteLine($"The rack for {FlavorOfCanToBeRemoved} is already empty. Try again.");
                Debug.WriteLine($"{FlavorOfCanToBeRemoved} rack is already empty.");
            }
        }

        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            if (_TotalCans[FlavorOfCanToBeRemoved].Count > _empty)
            {
                _TotalCans[FlavorOfCanToBeRemoved].Remove("can");
                Console.WriteLine($"Dispensing a can of {FlavorOfCanToBeRemoved}");
                Debug.WriteLine($"Removing a can of {FlavorOfCanToBeRemoved} from the rack.");
            }
            else
            {
                Console.WriteLine($"The rack for {FlavorOfCanToBeRemoved} is already empty. Try again.");
                Debug.WriteLine($"{FlavorOfCanToBeRemoved} rack is already empty.");
            }
        }

        //this method has been rewritten to avoid use of nested  loops and to scale with growing flavor and capacity sizes
        public void FillTheCanRack()
        {               
            Queue underCapacity = new Queue();

            foreach (Flavor aFlavor in FlavorOps.AllFlavors)
            {
                if (_TotalCans[aFlavor].Count < _capacity)
                {
                    underCapacity.Enqueue(aFlavor);
                }
            }

            while ((underCapacity.Count != _empty))
            {
                if (_TotalCans[(Flavor)underCapacity.Peek()].Count == _capacity || underCapacity.Count == _empty)
                {
                    underCapacity.Dequeue();

                    if (underCapacity.Count != _empty)
                    {
                        AddACanOf((Flavor)underCapacity.Peek());
                    }
                }
                else
                {
                    AddACanOf((Flavor)underCapacity.Peek());
                }

            };

            Debug.WriteLine("The can rack has been filled.");
        }

        public void EmptyCanRackOf(Flavor FlavorOfBinToBeEmptied)
        {
            _TotalCans[FlavorOfBinToBeEmptied].Clear();

            Debug.WriteLine($"Emptying the {FlavorOfBinToBeEmptied} rack flavor.");
        }

        public bool IsFull(Flavor FlavorOfBinToCheck)
        {
            if (_TotalCans[FlavorOfBinToCheck].Count == _capacity)
            {
                Debug.WriteLine($"{FlavorOfBinToCheck} flavor is full.");
                return true;
            }
            else
            {
                Debug.WriteLine($"{FlavorOfBinToCheck} flavor is not full.");
                return false;
            }
        }

        public bool IsEmpty(Flavor FlavorOfBinToCheck)
        {
            if (_TotalCans[FlavorOfBinToCheck].Count == _empty)
            {
                Debug.WriteLine($"{FlavorOfBinToCheck} flavor is empty.");
                return true;
            }
            else
            {
                Debug.WriteLine($"{FlavorOfBinToCheck} flavor is not empty.");
                return false;
            }
        }

        public int this[Flavor FlavorOfBin]
        {
            get
            {
                return _TotalCans[FlavorOfBin].Count;
            }
            set
            {
                if(_TotalCans[FlavorOfBin].Count == value)
                {
                    //do nothing
                }
                else if (_TotalCans[FlavorOfBin].Count < value)
                {
                    while(!IsEmpty(FlavorOfBin) && _TotalCans[FlavorOfBin].Count > value)
                    {
                        AddACanOf(FlavorOfBin);
                    }
                }
                else if(_TotalCans[FlavorOfBin].Count > value)
                {
                    while(!IsEmpty(FlavorOfBin) && _TotalCans[FlavorOfBin].Count > value)
                    {
                        RemoveACanOf(FlavorOfBin);
                    }
                }

                int sodaCansLeftOver = _TotalCans[FlavorOfBin].Count - value;

                if(sodaCansLeftOver == _empty)
                {
                    //do nothing
                }
                else if (sodaCansLeftOver < _empty)
                {
                    string pluralCan = string.Format(sodaCansLeftOver == -1 ? "" : "s");
                    string pluralWas = string.Format(sodaCansLeftOver == -1 ? "was" : "were");
                    Debug.WriteLine("{0} Bin Full. {1} can{2} of flavor {0} {3} not placed in vending machine",
                        FlavorOfBin, -sodaCansLeftOver, pluralCan, pluralWas);

                }
                else if (sodaCansLeftOver > _empty)
                {
                    string pluralCan = string.Format(sodaCansLeftOver == 1 ? "" : "s");
                    string pluralWas = string.Format(sodaCansLeftOver == 1 ? "was" : "were");
                    Debug.WriteLine("{0} Bin Empty. {1} can{2} of flavor {0} {3} not available for removal",
                        FlavorOfBin, sodaCansLeftOver, pluralCan, pluralWas);
                }
            }
        }

        public void DisplayCanRack()
        {
            foreach (var sodaName in _TotalCans.Keys)
            {
                Console.WriteLine($"{sodaName} soda has {_TotalCans[sodaName].Count} cans in the rack.");
            }
        }

        public decimal DisplayCanRack(Flavor flavor)
        {
            return _TotalCans[flavor].Count;
        }
    }
}