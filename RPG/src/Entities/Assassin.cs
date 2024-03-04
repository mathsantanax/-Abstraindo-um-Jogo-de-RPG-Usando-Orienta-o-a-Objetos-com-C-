namespace RPG.src.Entities
{
    public class Assassin : Hero
    {
        // Criação da classe assassino com dados pré definidos
        public Assassin(string Name)
        {
            this.Name = Name;
            this.Level = 15;
            this.HeroType = "Assassin";
            this.Health = 1000;
            this.Attack = 80;
            this.Defense = 350;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}