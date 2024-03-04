namespace RPG.src.Entities
{
    public class Warrior : Hero
    {

        // Criação da classe warrior com dados pré definidos
        public Warrior(string Name)
        {
            // Configuração especificas do warrior
            this.Name = Name;
            this.Level = 15;
            this.HeroType = "Warrior";
            this.Health = 1500;
            this.Attack = 50;
            this.Defense = 500;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}