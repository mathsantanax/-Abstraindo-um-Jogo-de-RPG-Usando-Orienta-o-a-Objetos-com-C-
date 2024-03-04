using RPG.src.Entities;

namespace RPG.src.Models
{
    public class Jogo
    {
        public void main(List<Hero> heroes) // puxando os herois cadastrados
        {
            Ataque ataque = new Ataque(); // chamando a classe ataque

            Warrior warrior = null;
            Mage mage = null;
            Assassin assassin = null;
            Acher acher = null;


            // foreah para atribuir o herois da lista nas variaveis das classes
            foreach (var hero in heroes)
            {
                if (hero is Warrior)
                    warrior = (Warrior)hero; 
                else if (hero is Mage)
                    mage = (Mage)hero;
                else if (hero is Assassin)
                    assassin = (Assassin)hero;
                else if (hero is Acher)
                    acher = (Acher)hero;
            }
            
            // verificando se tem alguma classe nula se sim retornar o menu anterior para cadastrar
            if (warrior == null || mage == null || assassin == null || acher == null )
            {
                Console.WriteLine("Não foi possível encontrar os heróis na lista.");
                return;
            }


            // iniciando o jogo
            bool op = true;
            while(op) // operador while para o menu
            {
                string Heroi = "[1] - Warrior\n"
                                + "[2] - Mage\n"
                                + "[3] - Assassin\n"
                                + "[4] - Acher\n"
                                + "[5] - Listar\n"
                                + "[0] - Sair do Jogo\n";
                
                Console.WriteLine("Qual das Classes ira atacar: ");
                Console.WriteLine(Heroi);
                int Menu = int.Parse(Console.ReadLine());
                switch(Menu) // eslhendo qual heroi irá atacar primeiro
                {
                    case 1: // escolha do warrior
                        Console.WriteLine($"Warrio - {warrior.Name}"); // aprensentando o atacante
                        Console.WriteLine($"Qual Classe Gostaria de Atacar: \n[1] - Mago \n[2] - Assassino \n [3] - Arqueiro");
                        int escolhaWarrior = int.Parse(Console.ReadLine());// escolha para atacar
                        switch(escolhaWarrior) //escolhendo quem o warrior ira atacar
                        {
                            case 1: // Warrior atacando o mago
                                Console.WriteLine($"O {warrior.HeroType} Atacou com a espada o {mage.HeroType}");
                                ataque.Atacar(warrior, mage);
                                Console.WriteLine($"Estatisticas \nNome: {mage.Name} Vida: {mage.Health} Defesa: {mage.Defense}");
                            break;
                            
                            case 2: // warrior atacando o assassino
                                Console.WriteLine($"O {warrior.HeroType} Atacou com a espada o {assassin.HeroType}");
                                ataque.Atacar(warrior, assassin);
                                Console.WriteLine($"Estatisticas \nNome: {assassin.Name} Vida: {assassin.Health} Defesa: {assassin.Defense}");
                                break;
                            
                            case 3: // warrior atacando o arqueiro
                                Console.WriteLine($"O {warrior.HeroType} Atacou com a espada o {acher.HeroType}");
                                ataque.Atacar(warrior, acher);
                                Console.WriteLine($"Estatisticas \nNome: {acher.Name} Vida: {acher.Health} Defesa: {acher.Defense}");
                                break;
                        }
                        break;

                    case 2: // escolha do mago
                        Console.WriteLine($"Mago - {mage.Name}"); // aprensentando o atacante
                        Console.WriteLine($"Qual Classe Gostaria de Atacar: \n[1] - Warrior \n[2] - Assassino \n [3] - Arqueiro");
                        int escolhaMage = int.Parse(Console.ReadLine()); // escolha para atacar
                        switch(escolhaMage) // escolhendo quem o mago ira atacar
                        {
                            case 1: // atacando o warrior
                                Console.WriteLine($"O {mage.HeroType} Atacou com a Magia o {warrior.HeroType}");
                                ataque.Atacar(mage, warrior);
                                Console.WriteLine($"Estatisticas \nNome: {warrior.Name} Vida: {warrior.Health} Defesa: {warrior.Defense}");
                            break;
                            
                            case 2: // atacando o assassino 
                                Console.WriteLine($"O {mage.HeroType} Atacou com a Magia o {assassin.HeroType}");
                                ataque.Atacar(mage, assassin);
                                Console.WriteLine($"Estatisticas \nNome: {assassin.Name} Vida: {assassin.Health} Defesa: {assassin.Defense}");
                                break;
                            
                            case 3:// atacando o acher
                                Console.WriteLine($"O {mage.HeroType} Atacou com a Magia o {acher.HeroType}");
                                ataque.Atacar(mage, acher);
                                Console.WriteLine($"Estatisticas \nNome: {acher.Name} Vida: {acher.Health} Defesa: {acher.Defense}");
                                break;
                        }
                        break;

                    case 3: // escolha Assassin
                        Console.WriteLine($"Assassino - {assassin.Name}"); // aprensentando o atacante
                        Console.WriteLine($"Qual Classe Gostaria de Atacar: \n[1] - Mago \n[2] - Warrior \n [3] - Arqueiro");
                        int escolhaAssassino = int.Parse(Console.ReadLine());// escolha para atacar
                        switch(escolhaAssassino) // escolhendo quem o assassino ira atacar
                        {
                            case 1: // atacando o mago
                                Console.WriteLine($"O {assassin.HeroType} Atacou com a Adaga o {mage.HeroType}");
                                ataque.Atacar(assassin, mage);
                                Console.WriteLine($"Estatisticas \nNome: {mage.Name} Vida: {mage.Health} Defesa: {mage.Defense}");
                            break;
                            
                            case 2: // atacando o warrior
                                Console.WriteLine($"O {assassin.HeroType} Atacou com a Adaga o {warrior.HeroType}");
                                ataque.Atacar(assassin, warrior);
                                Console.WriteLine($"Estatisticas \nNome: {warrior.Name} Vida: {warrior.Health} Defesa: {warrior.Defense}");
                                break;
                            
                            case 3: // atacando o acher
                                Console.WriteLine($"O {assassin.HeroType} Atacou com a Adaga o {acher.HeroType}");
                                ataque.Atacar(assassin, acher);
                                Console.WriteLine($"Estatisticas \nNome: {acher.Name} Vida: {acher.Health} Defesa: {acher.Defense}");
                                break;
                        }
                        break;
                    
                    case 4: // escolha acher
                        Console.WriteLine($"Acher - {acher.Name}"); // aprensentando o atacante
                        Console.WriteLine($"Qual Classe Gostaria de Atacar: \n[1] - Mago \n[2] - Assassino \n [3] - Warrior");
                        int escolhaAcher = int.Parse(Console.ReadLine());// escolha para atacar
                        switch(escolhaAcher) // escolhendo quem o acher ira atacar
                        {
                            case 1: // atacando o mago
                                Console.WriteLine($"O {acher.HeroType} Atacou com a Arco o {mage.HeroType}");
                                ataque.Atacar(acher, mage);
                                Console.WriteLine($"Estatisticas \nNome: {mage.Name} Vida: {mage.Health} Defesa: {mage.Defense}");
                            break;
                            
                            case 2: // atacando o assassino
                                Console.WriteLine($"O {acher.HeroType} Atacou com a Arco o {assassin.HeroType}");
                                ataque.Atacar(acher, assassin);
                                Console.WriteLine($"Estatisticas \nNome: {assassin.Name} Vida: {assassin.Health} Defesa: {assassin.Defense}");
                                break;
                            
                            case 3: // atacando o warrior
                                Console.WriteLine($"O {acher.HeroType} Atacou com a Arco o {warrior.HeroType}");
                                ataque.Atacar(acher, warrior);
                                Console.WriteLine($"Estatisticas \nNome: {warrior.Name} Vida: {warrior.Health} Defesa: {warrior.Defense}");
                                break;
                        }
                        break;
                    
                    case 5:  // listagem dos herois
                        foreach(var listaHeroi in heroes)
                        {
                            Console.WriteLine(listaHeroi.ToString());
                            Console.WriteLine("---------------------------------------------------");
                        }
                        break;

                    case 0: // para voltar ao menu anterior
                        op = false;
                        break;

                    default:// caso o usuario não escolha a opção correta
                        Console.WriteLine("Escolha uma opçao valida");
                    break;
                }
                Console.WriteLine("Aperte qualquer tecla pra continuar");
                Console.Read(); // aguardando o usuario apertar qualquer tecla para continuar
                Console.Clear(); // limpando a tela
            }
        }
    }
}