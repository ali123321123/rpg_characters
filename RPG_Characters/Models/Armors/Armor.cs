using RPG_Characters.Models.Heros;
using RPG_Characters.Models.Slots;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Models.Armors
{
   public  class Armor
    {

        public int Level { get; set; }

        public string Name { get; set; }

        public Hero Hero { get; set; }

        public ArmorType ArmorType { get; set; }
        public Slot Slot { get; set; }

        public Armor(int level, string name, Hero hero)
        {
            Level = level;
            Name = name;
            Hero = hero;
            
        }

        public Armor()
        {
        }



       
    }
}
