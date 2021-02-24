using RPG_Characters.Models.Heros;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Services.initialize
{
  public  class HeroInit
    {
        /*The goal with this  service 
        class is to initialize all Heros for first Time
        */
        
      
        public HeroInit()
        {

        }
        //initializing method which depend on the type of the Hero
        public Hero initialize(Hero hero)
        {
            if (hero.GetType() == typeof(Warrior))
            {
                hero.Dexterity = 3;
                hero.Health = 150;
                hero.Intelligence = 1;
                hero.Strength = 10;
                hero.Type = HeroType.WARRIOR;
            }
            else if (hero.GetType() == typeof(Ranger))
            {
                hero.Dexterity = 10;
                hero.Health = 120;
                hero.Intelligence = 2;
                hero.Strength = 5;
                hero.Type = HeroType.RANGER;
            }
            else if (hero.GetType() == typeof(Mage))
            {
                hero.Dexterity = 3;
                hero.Health = 100;
                hero.Intelligence = 10;
                hero.Strength = 2;
                hero.Type = HeroType.MAGE;

            }

            return hero;
        }





    }
}
