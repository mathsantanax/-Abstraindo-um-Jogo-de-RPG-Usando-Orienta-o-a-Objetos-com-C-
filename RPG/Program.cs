using RPG.src.Entities;

namespace RPG;

class Program
{
    static void Main(string[] args)
    {

        Hero hero = new Hero(nome: "Arus", level: 15, tipo: "Guerreiro", hp: 1500);

        Console.WriteLine($"Heroi: {hero.Nome} {hero.HeroType} {hero.Level} {hero.Health}");
    }
}
