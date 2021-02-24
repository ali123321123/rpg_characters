using RPG_Characters.Models.Heros;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Models.Armors
{ //Class LeatherArmor Extend from Armor.
    //So the class has this attributes
    //Level,Name,Hero,ArmorType,Slot,BonusHp,BonusStr,BonusXp,BounsInt
    class LeatherArmor :Armor
    {
        public LeatherArmor(int level, string name, Hero hero) : base(level, name, hero)
        {
            ArmorType = ArmorType.LEATHER;
        }
    }
}
