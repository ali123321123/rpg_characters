using RPG_Characters.Models.Heros;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Models.Armors
{
    class ClothArmor:Armor
    {
        public ClothArmor(int level, string name, Hero hero) : base( level,  name,  hero)
        {
            ArmorType = ArmorType.CLOTH;
        }
    }
}
