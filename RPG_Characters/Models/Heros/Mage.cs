using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Models.Heros
{
    //Class Mage extends from Hero class 
    /*and it has "HP: "Health 
                      " Dexterity 
                      "Intelligence 
                      " Level 
                      "Strength 
                      "CurrentExperience"
    */
    class Mage: Hero
    {
      


        public Mage():base()
        {
            this.Type = HeroType.MAGE;
        }

        public Mage(int health, int strength, int dexterity, int intelligence) :base( health,  strength,  dexterity,  intelligence)
        {

        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
