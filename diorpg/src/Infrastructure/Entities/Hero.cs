namespace diorpg.src.Infrastructure.Entities
{
    public class Hero
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public string HeroType { get; private set; }

        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string ToString()
        {
            return this.Name;
        }

        public int GetHeroLevel()
        {
            return this.Level;        }

        public string GetHeroType()
        {
            return this.HeroType;
        }


    }
}