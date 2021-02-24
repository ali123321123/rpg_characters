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

        public int BonusHp { get; set; }
        public int BonusStr { get; set; }

        public int BonusDex { get; set; }

        public int BonusInt { get; set; }

        public Armor(int level, string name, Hero hero)
        {
            Level = level;
            Name = name;
            Hero = hero;
            
        }

        public Armor()
        {
        }

        public override string ToString()
        {
            return $"Item stats for : {Name}" + "\n" +
                   $"Armor Type     : {ArmorType}\n" +
                   $"Slot           : {Slot.Type}\n" +
                   $"Armor Level     :{Level    }\n" +
                   $"Bonus Hp       : {BonusHp}  \n" +
                   $"Bonus Dex      : {BonusDex} \n" +
                   $"Bonus Int     :  {BonusInt} \n" +
                   $"Bonus Str    :   {BonusStr} \n";
        }
    }
}
