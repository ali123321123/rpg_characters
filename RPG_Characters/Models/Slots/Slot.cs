using RPG_Characters.Models.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Models.Slots
{
    public class Slot
    {
        //Enum SlotType has 3 types Head, Body,Legs


        public SlotType Type { get; set; }
        

        public Slot(SlotType Type)
        {
            this.Type = Type;
        }
      
    }
}
