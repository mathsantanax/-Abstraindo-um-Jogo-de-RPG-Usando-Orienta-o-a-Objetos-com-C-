using RPG.src.Entities;

namespace RPG.src.Models
{
    public class Jogo
    {
        public void main(List<Hero> heroes)
        {
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

            if (warrior == null || mage == null )
            {
                Console.WriteLine("Não foi possível encontrar o guerreiro e/ou o mago na lista de heróis.");
                return;
            }

            bool op = true;
            while(op)
            {
                string Heroi = "[1] - Warrior\n"
                                + "[2] - Mage\n"
                                + "[3] - Assassin\n"
                                + "[4] - Acher\n"
                                + "[0] - Sair do Jogo\n";

                Console.WriteLine(Heroi);
                int Menu = int.Parse(Console.ReadLine());
                switch(Menu)
                {
                    case 1:
                        Console.WriteLine(warrior.ToString());
                        break;

                    case 2:
                        Console.WriteLine(mage.ToString());
                        break;

                    case 3:
                        Console.WriteLine(assassin.ToString());
                        break;
                    
                    case 4:
                        Console.WriteLine(acher.ToString());
                        break;

                    case 0:
                        op = false;
                        break;
                }
            }
        }
    }
}