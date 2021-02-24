using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Models.Heros
{  //Class Ranger extends from Hero class 
    /*and it has      Health 
                      Dexterity 
                      Intelligence 
                      Level 
                      Strength 
                      CurrentExperience
    */
    class Ranger : Hero
    {
        public Ranger(int health, int strength, int dexterity, int intelligence) : base(health, strength, dexterity, intelligence)
        {

        }
        public Ranger() : base()
        {
            this.Type = HeroType.RANGER;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
