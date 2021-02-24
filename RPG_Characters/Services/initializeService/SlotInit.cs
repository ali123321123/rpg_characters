﻿using RPG_Characters.Models.Armors;
using RPG_Characters.Models.Slots;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Services.initializeService
{
   public  class SlotInit
    {

        public SlotInit()
        {

        }

        public Armor initialize(Armor armor)
        {
            if (armor.Slot.Type == SlotType.Head)
            {
                armor.Hero.Health = (int)(armor.Hero.Health * 0.8);
                armor.Hero.Strength = (int)(armor.Hero.Strength * 0.8);
                armor.Hero.Dexterity = (int)(armor.Hero.Dexterity * 0.8);
                armor.Hero.Intelligence = (int)(armor.Hero.Intelligence * 0.8);
            }
            else if (armor.Slot.Type == SlotType.Legs)
            {
                armor.Hero.Health = (int)(armor.Hero.Health * 0.6);
                armor.Hero.Strength = (int)(armor.Hero.Strength * 0.6);
                armor.Hero.Dexterity = (int)(armor.Hero.Dexterity * 0.6);
                armor.Hero.Intelligence = (int)(armor.Hero.Intelligence * 0.6);
            }
            else if (armor.Slot.Type == SlotType.Body)
            {
                return armor;

            }
            else
            {
                throw new Exception("It is not a slot");
            }

            return armor;
        }

    }
}