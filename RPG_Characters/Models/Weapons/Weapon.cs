using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Models.Weapons
{
   public class Weapon
    {
        public string Name { get; set; }

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
