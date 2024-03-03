using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public class Hero
    {
        public Hero(string nome, int level, string tipo, int hp)
        {
            Nome = nome;
            Level = level;
            HeroType = tipo;
            Health = hp;
        }

        public string Nome { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int Health { get; set; }
    }
}