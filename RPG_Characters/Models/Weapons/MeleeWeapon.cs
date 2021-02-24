using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Models.Weapons
{
    class MeleeWeapon:Weapon
    {

        public MeleeWeapon(string Name, int Level) : base(Name, Level)
        {
            this.Damage = 15;
            this.Type = WeaponType.MELEE;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
