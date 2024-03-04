using RPG.src.Entities;

namespace RPG.src.Models
{
    public class Ataque
    {
        // classe de ataque para reduzir a vida e a defesa do heroi
        public void Atacar(Hero hero, Hero hero1)
        {
            if(hero.Ataque() > hero1.Defesa())
            {
                hero1.Health -= hero.Attack; // subtraindo vida do hero1 caso o ataque seja maior que a defesa
            }
            else
            {
                hero1.Defense -= hero.Attack / 2; // subtraindo a defesa divido por 2 caso a defesa seja maior que o ataque
            }
        }
    }
}