using System.ComponentModel;
using System.Reflection;
using RPG.src.Entities;
using RPG.src.Models;

namespace RPG;

class Program
{
    static void Main(string[] args)
    {
        List<Hero> heroi =  new List<Hero>(); // lista de herois

        bool op = true;
        while(op) // looping para o menu
        {
            int Menu;
            string EscolhaMenu = "[1] - Warrior\n"
                                + "[2] - Mage\n"
                                + "[3] - Assassin\n"
                                + "[4] - Acher\n"
                                + "[5] - Iniciar Jogo\n"
                                + "[0] - Sair\n";

            Console.WriteLine("Qual Tipo de heroi vc Gostaria de Criar");
            Console.WriteLine(EscolhaMenu); //imprindo o menu
            Menu = int.Parse(Console.ReadLine()); // escolha para qual classe criar
            switch(Menu) // criando a classe 
            {
                case 1: // criando o warrior
                    Console.WriteLine("Nome do Guerreiro: ");
                    Warrior warrior = new Warrior(Console.ReadLine());
                    heroi.Add(warrior);
                    break;

                case 2: // criando o mago
                    Console.WriteLine("Nome do Mago: ");
                    Mage mage = new Mage(Console.ReadLine());
                    heroi.Add(mage);
                    break;

                case 3: // criando o assassino
                    Console.WriteLine("Nome do Assassino: ");
                    Assassin assassin = new Assassin(Console.ReadLine());
                    heroi.Add(assassin);
                    break;

                case 4: // criando o arqueiro
                    Console.WriteLine("Nome do Arqueiro: ");
                    Acher acher = new Acher(Console.ReadLine());
                    heroi.Add(acher);
                    break;
                
                case 5: // iniciando o jogo e passando a lista de herois
                    Jogo jogo = new Jogo();
                    jogo.main(heroi);
                    break;

                case 0: // saindo do jogo
                    op = false;
                    break;

                default: // caso o usuario não escolha a opção correta
                    Console.WriteLine("Escolha uma opção valida.");
                    break;
                
            }
        
        foreach(var listaHeroi in heroi) // listando os herois
        {
            Console.WriteLine(listaHeroi.ToString());
            Console.WriteLine("---------------------------------------------------");
        }
        }
    }
}
