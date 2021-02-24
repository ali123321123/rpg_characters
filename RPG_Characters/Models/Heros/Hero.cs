using RPG_Characters.Models.Weapons;
using RPG_Characters.Models.Slots;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Models.Heros
{
   public  class Hero
    {
      public int Health { get; set; }
      public int Strength { get; set; }
     public  int Dexterity { get; set; }
     public  int Intelligence { get; set; }

     public  int Level { get; set; }

      public int CurrentExperience { get; set; }

      public int ExperinceToNextLevel { get; set;}
      
      public HeroType Type { get; set; }

        

    

        public Hero()
        {
           Level = 1;
            CurrentExperience = 0;
            ExperinceToNextLevel = 100;
        }

        public Hero(int health, int strength, int dexterity, int intelligence)
        {
            Health = health;
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }


        public override string ToString()
        {
            return $"{Type} Detalis" + "\n" +
                   "HP: " + Health + "\n" +
                   "Dex: " + Dexterity + "\n" +
                   "Int: " + Intelligence + "\n" +
                   "Lvl: " + Level + "\n" +
                   "Str: " + Strength + "\n"+
                   "XP :  "+CurrentExperience + "\n";


        }
    }
}
