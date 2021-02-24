using RPG_Characters.Models.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters.Models.Slots
{
    public class Slot
    {
     public SlotType Type { get; set; }
        

        public Slot(SlotType Type)
        {
            this.Type = Type;
        }
      
    }
}
