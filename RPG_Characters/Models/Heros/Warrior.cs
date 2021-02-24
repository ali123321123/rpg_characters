using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Models.Heros
{ //Class Warrior extends  from Hero class 
    /*and it has      Health 
                      Dexterity 
                      Intelligence 
                      Level 
                      Strength 
                      CurrentExperience
    */
    class Warrior :Hero
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
