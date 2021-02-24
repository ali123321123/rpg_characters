using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Models.Weapons
{
    class RangedWeapon:Weapon
    {

        public RangedWeapon(string Name, int Level) : base(Name, Level)
        {
            this.Damage = 5;
            this.Type = WeaponType.RANGED;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
