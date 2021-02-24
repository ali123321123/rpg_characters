using RPG_Characters.Models.Heros;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Models.Armors
{
    class LeatherArmor:Armor
    {
        public LeatherArmor(int level, string name, Hero hero) : base(level, name, hero)
        {
            ArmorType = ArmorType.LEATHER;
        }
    }
}
