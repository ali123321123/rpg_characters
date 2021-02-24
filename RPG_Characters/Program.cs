using RPG_Characters.Models.Armors;
using RPG_Characters.Models.Heros;
using RPG_Characters.Models.Slots;
using RPG_Characters.Models.Weapons;
using RPG_Characters.Services.IncreaseLevel;
using RPG_Characters.Services.initialize;
using RPG_Characters.Services.initializeService;
using RPG_Characters.Services.WeaponService;
using System;

namespace RPG_Characters
{
    
    class Program
    {
        static void Main(string[] args)
        {

            //An Example with Warrior to show how all feature has been implmented
        
            HeroInit heroInit = new HeroInit();

            Console.WriteLine("*****************************");
            Console.WriteLine("*Start the Game with Warrior*");
            Console.WriteLine("*****************************");

            Console.WriteLine("Warior instance without data");
            Warrior warrior = new Warrior();
            Console.WriteLine(warrior);
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("After starting the game");
            heroInit.initialize(warrior);
            Console.WriteLine(warrior);


            
            NextLevel.LevelUp(warrior, 100);
            Console.WriteLine("");
            Console.WriteLine("Wow! Your Warrior got 100xp");
            Console.WriteLine("The warior will go to the  level 1");
            Console.WriteLine("Here is the new updates");
            Console.WriteLine(warrior);

         
            NextLevel.LevelUp(warrior, 11);
            Console.WriteLine("");
            Console.WriteLine("Wow! Your Warrior got 11xp");
            Console.WriteLine("The warior will go to the  level 2");
            Console.WriteLine("Here is the new updates");
            Console.WriteLine(warrior);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Here is the detalis for weapon");

            RangedWeapon rangedWeapon = new RangedWeapon("Shuriken",3);
            Console.WriteLine("The detalis og the weapon");
            Console.WriteLine(rangedWeapon);
            Console.WriteLine("");
            Console.WriteLine("");
            WeaponServices weaponServices = new WeaponServices(warrior, rangedWeapon);
            Console.WriteLine("");
            Console.WriteLine("");
            weaponServices.CalculateDamage();
            Console.WriteLine("The damage attack to this weapon  :"+ weaponServices.CalculateDamageAttack());

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("The warior will get Armor now :");

            ClothArmor clothArmor = new ClothArmor(3, "type", warrior);

            Slot slot = new Slot(SlotType.Head);

            clothArmor.Slot = slot;


            SlotInit sloInit = new SlotInit();

            sloInit.initialize(clothArmor);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("The Armor detalis");
            Console.WriteLine(clothArmor);

        }
    }
}
