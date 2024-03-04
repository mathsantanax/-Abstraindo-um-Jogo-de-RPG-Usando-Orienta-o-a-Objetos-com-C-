using RPG.src.Entities;

namespace RPG.src.Models
{
    public class Ataque
    {
        public void Atacar(Hero hero, Hero hero1)
        {
            if(hero.Ataque() > hero1.Defesa())
            {
                hero1.Health -= hero.Attack;
            }
            else
            {
                hero1.Defense -= hero.Attack / 2;
            }
        }
    }
}