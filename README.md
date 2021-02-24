**Assignemt 2: RPG Character**
This program is designed to simulate RPG characters. 
This program has many functions as level the character up and give the characters some items(Armor,Weapon). 


**Motivation**:
The program has been designed to show my class design skills, it has been implmented some solid principle which made this project is so easy for further development.

**Language used :**
C#



**Functionality in the program:**
The main method demonstrates how the program workes. All the characters have base-stats based on their class, and when they level up thay get a stat boost.
* The characters can also use 3 types of weapon, and 3 different armor sets (Head, body and leg). All these items gives a boost of some sort.
* By run the program you will see the ouput of all detalis for an example of a Warrior. 


**Installation**:
All you need to clone the porject on your pc, and just run it. ^_^



**Program Structure:**
>Rpg_Charecter 
  >Models
    >Armors
      >ArmorType.cs
      >ClothArmor.cs
      >LeatherArmor.cs
      >PlateArmor.cs
    >Heros
     >Hero.cs
     >HeroType.cs
     >Mage.cs
     >Ranger.cs
     >Warrior.cs
    >Slots
     >Slot.cs
     >Slottype.cs
    >Weapons
     >MagicWeapon.cs
     >MeleeWeapon.cs
     >RangedWeapon.cs
     >Weapon.cs
     >WeaponType.cs
 >Service
  >initializeService
    >ArmorInit.cs
    >HeroInit.cs
    >SlotInit.cs
  >LevelService
   >NextLevel.cs
  >WeaponServices
   >WeaponServices.cs
>program.cs




  


   

