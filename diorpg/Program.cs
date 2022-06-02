using diorpg.src.Infrastructure.Entities;
using diorpg.src.Domain.Enums;


// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Hero hero = new Hero("Arus", 1, HeroType.WARRIOR);

Console.WriteLine(hero.ToString());
