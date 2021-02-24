using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Models.Weapons
{
    //class Weapon is a super class for MagiceWeapon,MeleeWeapon, and RangedWeapon
   public class Weapon
    {
        public string Name { get; set; }

        //Enum WeaponType has 3 types MELEE,RANGED,MAGIC


        public WeaponType Type { get; set; }
        public int Damage { get; set; }
        public int Level { get; set; }

        public Weapon()
        {
        }

       public Weapon( string Name, int Level)
        {
            this.Name = Name;
            this.Level = Level;
        }

        public override string ToString()
        {
            return $"{Type} Detalis" + "\n" +
                 "Name: " + Name + "\n" +
                 "Type: " + Type + "\n" +
                 "Damage: " + Damage + "\n" +
                 "Lvl: " + Level + "\n";  
        }
    }
}
