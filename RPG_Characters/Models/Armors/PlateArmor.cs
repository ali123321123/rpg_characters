using RPG_Characters.Models.Heros;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Models.Armors
{//Class PlateArmor Extend from Armor.
    //So the class has this attributes
    //Level,Name,Hero,ArmorType,Slot,BonusHp,BonusStr,BonusXp,BounsInt
    class PlateArmor :Armor
    {

        public PlateArmor(int level, string name, Hero hero) : base(level, name, hero)
        {
            ArmorType = ArmorType.PLATE;
        }
    }
}
