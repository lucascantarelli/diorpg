using diorpg.src.Infrastructure.Entities;
using diorpg.src.Domain.Enums;

Hero hero = new Hero("Arus", 1, HeroType.WARRIOR);

Warrior warrior = new Warrior("Arus", 1, HeroType.WARRIOR);
Hunter hunter = new Hunter("Lucas", 1, HeroType.HUNTER);
Wizard mage = new Wizard("Cantarelli", 1, HeroType.MAGE);

Console.WriteLine($"{warrior.ToString()}, Level: {warrior.Level} ,{warrior.Attack()}");
Console.WriteLine($"{hunter.ToString()}, Level: {hunter.Level} ,{hunter.Attack()}");
Console.WriteLine($"{mage.ToString()}, Level: {mage.Level} ,{mage.Attack()}");