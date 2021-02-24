using RPG_Characters.Models.Armors;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Services.initializeService
{
  public class ArmorInit
    {
        public ArmorInit()
        {

        }


        public Armor initialize(Armor armor)
        {
            if (armor.GetType() == typeof(ClothArmor))
            {
                armor.Hero.Strength += 0;
                armor.Hero.Dexterity += 1;
                armor.Hero.Health += 10;
                armor.Hero.Intelligence += 3;
            }
            else if (armor.GetType() == typeof(LeatherArmor))
            {
                armor.Hero.Strength += 1;
                armor.Hero.Dexterity += 3;
                armor.Hero.Health += 20;
                armor.Hero.Intelligence += 0;
            }
            else if (armor.GetType() == typeof(PlateArmor))
            {
                armor.Hero.Strength += 3;
                armor.Hero.Dexterity += 1;
                armor.Hero.Health += 30;
                armor.Hero.Intelligence += 0;

            }
            else
            {
                throw new Exception("It's not an armor");
            }

            return armor;
        }

    }
}
