namespace RPG.src.Entities
{
    public class Mage : Hero
    {

        // Criação da classe mago com dados pré definidos
        public Mage(string Name)
        {
            this.Name = Name;
            this.Level = 15;
            this.HeroType = "Mage";
            this.Health = 900;
            this.Attack = 100;
            this.Defense = 200;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}