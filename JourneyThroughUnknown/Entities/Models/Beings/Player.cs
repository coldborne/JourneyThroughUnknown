using System.Collections.Generic;

namespace JourneyThroughUnknown.Entities.Models.Beings
{
    public class Player : Essence
    {
        private List<Thing> _inventory = new List<Thing>();

        public void Add(Thing thing)
        {
            _inventory.Add(thing);
        }

    }
}


