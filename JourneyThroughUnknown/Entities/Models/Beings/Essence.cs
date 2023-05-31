namespace JourneyThroughUnknown.Entities.Models.Beings
{
    public abstract class Essence
    {
        public int Health { get; private set; }
        public int Damage { get; private set; }

        public void GetDamage(int damage)
        {
            Health -= damage;
        }
    }
}


