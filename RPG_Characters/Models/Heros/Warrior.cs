using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Models.Heros
{
    class Warrior:Hero
    {

        public Warrior(int health, int strength, int dexterity, int intelligence) : base(health, strength, dexterity, intelligence)
        {

        }

        public Warrior() : base()
        {
            this.Type = HeroType.WARRIOR;

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
