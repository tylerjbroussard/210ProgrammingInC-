using FlavorSpace;

namespace CanSpace
{

    public class Can
    {
        public readonly Flavor TheFlavor = Flavor.REGULAR; 

        public Can()
        {
            //added this just to assign TheFlavor value
            TheFlavor = Flavor.REGULAR;
        }

        public Can(Flavor AFlavor)
        {
            TheFlavor = AFlavor;
        } 
    }
}
