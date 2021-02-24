using RPG_Characters.Models.Heros;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Models.Armors
{
    //Class ClothArmor Extend from Armor.
    //So the class has this attributes
    //Level,Name,Hero,ArmorType,Slot,BonusHp,BonusStr,BonusXp,BounsInt
    class ClothArmor :Armor
    {
        public ClothArmor(int level, string name, Hero hero) : base( level,  name,  hero)
        {
            ArmorType = ArmorType.CLOTH;
        }
    }
}
