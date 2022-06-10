namespace diorpg.src.Infrastructure.Entities
{
    public class Hunter : Hero
    {
        public Hunter(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public override string ToString()
        {
            return $"{this.Name} is a {this.HeroType}";
        }

        public override string Attack()
        {
            return $"{this.Name} attacks with his {this.Weapon}";
        }
    }
}