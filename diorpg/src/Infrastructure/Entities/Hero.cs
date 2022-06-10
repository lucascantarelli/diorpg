using diorpg.src.Domain.Enums;
namespace diorpg.src.Infrastructure.Entities
{
    public class Hero
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public string HeroType { get; private set; }
        public string Weapon { get; private set; }


        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Weapon = this.HeroWeapon(HeroType);
        }

        public override string ToString()
        {
            return this.Name;
        }

        public int GetHeroLevel()
        {
            return this.Level;
        }

        public string GetHeroType()
        {
            return this.HeroType;
        }

        public virtual string Attack()
        {
            return $"{this.Name} attacks with his {this.HeroType}";
        }

        private string HeroWeapon(string heroType)
        {
            switch (heroType)
            {
                case "Warrior":
                    return WeaponType.AXE;
                case "Mage":
                    return WeaponType.STAFF;
                case "Hunter":
                    return WeaponType.BOW;
            }
            return "Galho do Aprendiz";
        }

    }
}