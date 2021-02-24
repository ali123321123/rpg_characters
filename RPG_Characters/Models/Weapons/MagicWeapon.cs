using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Models.Weapons
{
    class MagicWeapon:Weapon
    {


        public MagicWeapon(string Name, int Level):base(Name,Level)
        {
            this.Damage = 25;
            this.Type = WeaponType.MAGIC;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
