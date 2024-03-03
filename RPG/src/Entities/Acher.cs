namespace RPG.src.Entities
{
    public class Acher : Hero
    {
        public Acher(string Name)
        {
            this.Name = Name;
            this.Level = 15;
            this.HeroType = "Acher";
            this.Health = 1200;
            this.Attack = 75;
            this.Defense = 275;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}