using System.ComponentModel;
using System.Reflection;
using RPG.src.Entities;
using RPG.src.Models;

namespace RPG;

class Program
{
    static void Main(string[] args)
    {
        List<Hero> heroi =  new List<Hero>();

        bool op = true;
        while(op)
        {
            int Menu;
            string EscolhaMenu = "[1] - Warrior\n"
                                + "[2] - Mage\n"
                                + "[3] - Assassin\n"
                                + "[4] - Acher\n"
                                + "[5] - Iniciar Jogo\n"
                                + "[0] - Sair\n";

            Console.WriteLine("Qual Tipo de heroi vc Gostaria de Criar");
            Console.WriteLine(EscolhaMenu);
            Menu = int.Parse(Console.ReadLine());
            switch(Menu)
            {
                case 1:
                    Console.WriteLine("Nome do Guerreiro: ");
                    Warrior warrior = new Warrior(Console.ReadLine());
                    heroi.Add(warrior);
                    break;

                case 2:
                    Console.WriteLine("Nome do Mago: ");
                    Mage mage = new Mage(Console.ReadLine());
                    heroi.Add(mage);
                    break;

                case 3:
                    Console.WriteLine("Nome do Assassino: ");
                    Assassin assassin = new Assassin(Console.ReadLine());
                    heroi.Add(assassin);
                    break;

                case 4:
                    Console.WriteLine("Nome do Arqueiro: ");
                    Acher acher = new Acher(Console.ReadLine());
                    heroi.Add(acher);
                    break;
                
                case 5:
                    Jogo jogo = new Jogo();
                    jogo.main(heroi);
                    break;
                case 0:
                    op = false;
                    break;
                
            }
        
        foreach(var listaHeroi in heroi)
        {
            Console.WriteLine(listaHeroi.ToString());
            Console.WriteLine("---------------------------------------------------");
        }
        }
    }
}
