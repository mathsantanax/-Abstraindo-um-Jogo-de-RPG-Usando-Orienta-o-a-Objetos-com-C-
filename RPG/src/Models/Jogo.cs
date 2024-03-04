using RPG.src.Entities;

namespace RPG.src.Models
{
    public class Jogo
    {
        public void main(List<Hero> heroes)
        {
            Ataque ataque = new Ataque();

            Warrior warrior = null;
            Mage mage = null;
            Assassin assassin = null;
            Acher acher = null;

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

            if (warrior == null || mage == null || assassin == null || acher == null )
            {
                Console.WriteLine("Não foi possível encontrar os heróis na lista.");
                return;
            }

            bool op = true;
            while(op)
            {
                string Heroi = "[1] - Warrior\n"
                                + "[2] - Mage\n"
                                + "[3] - Assassin\n"
                                + "[4] - Acher\n"
                                + "[5] - Listar\n"
                                + "[0] - Sair do Jogo\n";

                Console.WriteLine(Heroi);
                int Menu = int.Parse(Console.ReadLine());
                switch(Menu)
                {
                    case 1:
                        Console.WriteLine($"Warrio - {warrior.Name}");
                        Console.WriteLine($"Qual Classe Gostaria de Atacar: \n[1] - Mago \n[2] - Assassino \n [3] - Arqueiro");
                        int escolhaWarrior = int.Parse(Console.ReadLine());
                        switch(escolhaWarrior)
                        {
                            case 1:
                                Console.WriteLine($"O {warrior.HeroType} Atacou com a espada o {mage.HeroType}");
                                ataque.Atacar(warrior, mage);
                                Console.WriteLine($"Estatisticas \nNome: {mage.Name} Vida: {mage.Health} Defesa: {mage.Defense}");
                            break;
                            
                            case 2:
                                Console.WriteLine($"O {warrior.HeroType} Atacou com a espada o {assassin.HeroType}");
                                ataque.Atacar(warrior, assassin);
                                Console.WriteLine($"Estatisticas \nNome: {assassin.Name} Vida: {assassin.Health} Defesa: {assassin.Defense}");
                                break;
                            
                            case 3:
                                Console.WriteLine($"O {warrior.HeroType} Atacou com a espada o {acher.HeroType}");
                                ataque.Atacar(warrior, acher);
                                Console.WriteLine($"Estatisticas \nNome: {acher.Name} Vida: {acher.Health} Defesa: {acher.Defense}");
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine($"Mago - {mage.Name}");
                        Console.WriteLine($"Qual Classe Gostaria de Atacar: \n[1] - Warrior \n[2] - Assassino \n [3] - Arqueiro");
                        int escolhaMage = int.Parse(Console.ReadLine());
                        switch(escolhaMage)
                        {
                            case 1:
                                Console.WriteLine($"O {mage.HeroType} Atacou com a Magia o {warrior.HeroType}");
                                ataque.Atacar(mage, warrior);
                                Console.WriteLine($"Estatisticas \nNome: {warrior.Name} Vida: {warrior.Health} Defesa: {warrior.Defense}");
                            break;
                            
                            case 2:
                                Console.WriteLine($"O {mage.HeroType} Atacou com a Magia o {assassin.HeroType}");
                                ataque.Atacar(mage, assassin);
                                Console.WriteLine($"Estatisticas \nNome: {assassin.Name} Vida: {assassin.Health} Defesa: {assassin.Defense}");
                                break;
                            
                            case 3:
                                Console.WriteLine($"O {mage.HeroType} Atacou com a Magia o {acher.HeroType}");
                                ataque.Atacar(mage, acher);
                                Console.WriteLine($"Estatisticas \nNome: {acher.Name} Vida: {acher.Health} Defesa: {acher.Defense}");
                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine($"Assassino - {assassin.Name}");
                        Console.WriteLine($"Qual Classe Gostaria de Atacar: \n[1] - Mago \n[2] - Warrior \n [3] - Arqueiro");
                        int escolhaAssassino = int.Parse(Console.ReadLine());
                        switch(escolhaAssassino)
                        {
                            case 1:
                                Console.WriteLine($"O {assassin.HeroType} Atacou com a Adaga o {mage.HeroType}");
                                ataque.Atacar(assassin, mage);
                                Console.WriteLine($"Estatisticas \nNome: {mage.Name} Vida: {mage.Health} Defesa: {mage.Defense}");
                            break;
                            
                            case 2:
                                Console.WriteLine($"O {assassin.HeroType} Atacou com a Adaga o {warrior.HeroType}");
                                ataque.Atacar(assassin, warrior);
                                Console.WriteLine($"Estatisticas \nNome: {warrior.Name} Vida: {warrior.Health} Defesa: {warrior.Defense}");
                                break;
                            
                            case 3:
                                Console.WriteLine($"O {assassin.HeroType} Atacou com a Adaga o {acher.HeroType}");
                                ataque.Atacar(assassin, acher);
                                Console.WriteLine($"Estatisticas \nNome: {acher.Name} Vida: {acher.Health} Defesa: {acher.Defense}");
                                break;
                        }
                        break;
                    
                    case 4:
                        Console.WriteLine($"Acher - {acher.Name}");
                        Console.WriteLine($"Qual Classe Gostaria de Atacar: \n[1] - Mago \n[2] - Assassino \n [3] - Warrior");
                        int escolhaAcher = int.Parse(Console.ReadLine());
                        switch(escolhaAcher)
                        {
                            case 1:
                                Console.WriteLine($"O {acher.HeroType} Atacou com a Arco o {mage.HeroType}");
                                ataque.Atacar(acher, mage);
                                Console.WriteLine($"Estatisticas \nNome: {mage.Name} Vida: {mage.Health} Defesa: {mage.Defense}");
                            break;
                            
                            case 2:
                                Console.WriteLine($"O {acher.HeroType} Atacou com a Arco o {assassin.HeroType}");
                                ataque.Atacar(acher, assassin);
                                Console.WriteLine($"Estatisticas \nNome: {assassin.Name} Vida: {assassin.Health} Defesa: {assassin.Defense}");
                                break;
                            
                            case 3:
                                Console.WriteLine($"O {acher.HeroType} Atacou com a Arco o {warrior.HeroType}");
                                ataque.Atacar(acher, warrior);
                                Console.WriteLine($"Estatisticas \nNome: {warrior.Name} Vida: {warrior.Health} Defesa: {warrior.Defense}");
                                break;
                        }
                        break;
                    
                    case 5:
                        foreach(var listaHeroi in heroes)
                        {
                            Console.WriteLine(listaHeroi.ToString());
                            Console.WriteLine("---------------------------------------------------");
                        }
                        break;
                    case 0:
                        op = false;
                        break;
                }
                Thread.Sleep(5000);
                Console.Clear();
            }
        }
    }
}